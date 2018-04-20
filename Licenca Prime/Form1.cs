using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Licenca_Prime
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Sair() {
            Environment.Exit(0);
        }

        internal enum CryptProvider
        {
            Rijndael,
            RC2,
            DES,
            TripleDES
        }
        internal sealed class Crypt
        {
            private string _key = string.Empty;

            private CryptProvider _cryptProvider;

            private SymmetricAlgorithm _algorithm;

            public Crypt()
            {
                _algorithm = new RijndaelManaged();
                _algorithm.Mode = CipherMode.CBC;
                _cryptProvider = CryptProvider.Rijndael;
            }

            public Crypt(CryptProvider cryptProvider, string key)
            {
                switch (cryptProvider)
                {
                    case CryptProvider.Rijndael:
                        _algorithm = new RijndaelManaged();
                        _cryptProvider = CryptProvider.Rijndael;
                        break;
                    case CryptProvider.RC2:
                        _algorithm = new RC2CryptoServiceProvider();
                        _cryptProvider = CryptProvider.RC2;
                        break;
                    case CryptProvider.DES:
                        _algorithm = new DESCryptoServiceProvider();
                        _cryptProvider = CryptProvider.DES;
                        break;
                    case CryptProvider.TripleDES:
                        _algorithm = new TripleDESCryptoServiceProvider();
                        _cryptProvider = CryptProvider.TripleDES;
                        break;
                }
                _algorithm.Mode = CipherMode.CBC;
                _key = key;
            }

            private void SetIV()
            {
                if (_cryptProvider == CryptProvider.Rijndael)
                {
                    _algorithm.IV = new byte[16]
                    {
                15,
                111,
                19,
                46,
                53,
                194,
                205,
                249,
                5,
                70,
                156,
                234,
                168,
                75,
                115,
                204
                    };
                }
                else
                {
                    _algorithm.IV = new byte[8]
                    {
                15,
                111,
                19,
                46,
                53,
                194,
                205,
                249
                    };
                }
            }

            public byte[] GetKey()
            {
                string empty = string.Empty;
                if (_algorithm.LegalKeySizes.Length != 0)
                {
                    int num = _key.Length * 8;
                    int minSize = _algorithm.LegalKeySizes[0].MinSize;
                    int maxSize = _algorithm.LegalKeySizes[0].MaxSize;
                    int skipSize = _algorithm.LegalKeySizes[0].SkipSize;
                    if (num > maxSize)
                    {
                        _key = _key.Substring(0, maxSize / 8);
                    }
                    else if (num < maxSize)
                    {
                        int num2 = (num <= minSize) ? minSize : (num - num % skipSize + skipSize);
                        if (num < num2)
                        {
                            _key = _key.PadRight(num2 / 8, '*');
                        }
                    }
                }
                return new PasswordDeriveBytes(_key, Encoding.ASCII.GetBytes(empty)).GetBytes(_key.Length);
            }

            public string Encrypt(string plainText)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(plainText);
                byte[] key = GetKey();
                _algorithm.Key = key;
                SetIV();
                ICryptoTransform transform = _algorithm.CreateEncryptor();
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                cryptoStream.Write(bytes, 0, bytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] array = memoryStream.ToArray();
                return Convert.ToBase64String(array, 0, array.GetLength(0));
            }

            public string Decrypt(string cryptoText)
            {
                byte[] array = Convert.FromBase64String(cryptoText);
                byte[] key = GetKey();
                _algorithm.Key = key;
                SetIV();
                ICryptoTransform transform = _algorithm.CreateDecryptor();
                try
                {
                    return new System.IO.StreamReader(new CryptoStream(new System.IO.MemoryStream(array, 0, array.Length), transform, CryptoStreamMode.Read)).ReadToEnd();
                }
                catch
                {
                    return null;
                }
            }

        }
            private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void frm_main_btn_sair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void frm_main_btn_gerar_Click(object sender, EventArgs e)
        {
            if (frm_main_tb_site.Text.Equals("")
                || frm_main_tb_validade.Text.Equals("")
                || frm_main_tb_qtd_user.Text.Equals("") 
                || frm_main_tb_contrato.Text.Equals(""))
            {

                MessageBox.Show("Todos os campos devem ser preenchidos!", "Atenção...");

            }
            else {

                //DateTime dataValidade;
                StringBuilder stringBuilder = new StringBuilder(frm_main_tb_sys.Text);
                stringBuilder.Append(frm_main_tb_site.Text);
                stringBuilder.Append(frm_main_tb_validade.Text);
                stringBuilder.Append(frm_main_tb_qtd_user.Text.PadLeft(5,'0'));
                stringBuilder.Append(frm_main_tb_contrato.Text.PadLeft(10,'0'));
                //stringBuilder.Append(frm_main_tb_validade.Text.ToString("ddMMyyyy"));
                string chave = frm_main_tb_sys.Text+frm_main_tb_site.Text;

                Crypt crypt = new Crypt(CryptProvider.RC2, chave);

                frm_main_tb_licenca.Text = stringBuilder.ToString();

                try
                {
                    frm_main_tb_licenca.Text = crypt.Encrypt(stringBuilder.ToString());
                    frm_main_btn_copiar.Enabled = true;
                    //frm_main_btn_gerar.Enabled = false;
                    frm_main_tb_licenca.Enabled = true;
                    frm_main_tb_licenca.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void frm_main_btn_copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(frm_main_tb_licenca.Text);
            frm_main_btn_copiar.Enabled = false;
            //frm_main_tb_licenca.Text
            frm_main_tb_licenca.Text = "Copiado!";
            frm_main_tb_licenca.Enabled = false;

        }

        private void frm_main_btn_ler_Click(object sender, EventArgs e)
        {
            if (frm_main_tb_ler_site.Text.Equals(""))

            {
                MessageBox.Show("O campos licença e site devem ser preenchidos!", "Atenção...");
            }
            else {

                string chave = frm_main_tb_ler_sys.Text + frm_main_tb_ler_site.Text;
                Crypt crypt = new Crypt(CryptProvider.RC2, chave);
                string text = crypt.Decrypt(frm_main_tb_ler_licenca.Text);
                frm_main_tb_ler_site.Text = text.Substring(3, 7);
                frm_main_tb_ler_validade.Text = text.Substring(10, 8);
                frm_main_tb_ler_qtd_user.Text = text.Substring(18, 5);
                frm_main_tb_ler_contrato.Text = text.Substring(23, 10);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
