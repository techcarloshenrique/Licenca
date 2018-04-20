namespace Licenca_Prime
{
    partial class frm_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mn_main = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_main = new System.Windows.Forms.TabControl();
            this.tbc_main_encode = new System.Windows.Forms.TabPage();
            this.frm_main_btn_copiar = new System.Windows.Forms.Button();
            this.frm_main_btn_gerar = new System.Windows.Forms.Button();
            this.frm_main_btn_sair = new System.Windows.Forms.Button();
            this.frm_main_pnl_licenca = new System.Windows.Forms.Panel();
            this.frm_main_tb_licenca = new System.Windows.Forms.TextBox();
            this.frm_main_lbl_licenca = new System.Windows.Forms.Label();
            this.frm_main_tb_contrato = new System.Windows.Forms.TextBox();
            this.frm_main_tb_validade = new System.Windows.Forms.TextBox();
            this.frm_main_tb_site = new System.Windows.Forms.TextBox();
            this.frm_main_tb_qtd_user = new System.Windows.Forms.TextBox();
            this.frm_main_tb_sys = new System.Windows.Forms.TextBox();
            this.frm_main_lbl_contrato = new System.Windows.Forms.Label();
            this.frm_main_lbl_qtd_user = new System.Windows.Forms.Label();
            this.frm_main_lbl_validade = new System.Windows.Forms.Label();
            this.frm_main_lbl_site = new System.Windows.Forms.Label();
            this.frm_main_lbl_sys = new System.Windows.Forms.Label();
            this.tbc_main_decode = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frm_main_tb_ler_licenca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frm_main_btn_ler = new System.Windows.Forms.Button();
            this.frm_main_tb_ler_contrato = new System.Windows.Forms.TextBox();
            this.frm_main_tb_ler_validade = new System.Windows.Forms.TextBox();
            this.frm_main_tb_ler_site = new System.Windows.Forms.TextBox();
            this.frm_main_tb_ler_qtd_user = new System.Windows.Forms.TextBox();
            this.frm_main_tb_ler_sys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mn_main.SuspendLayout();
            this.tbc_main.SuspendLayout();
            this.tbc_main_encode.SuspendLayout();
            this.frm_main_pnl_licenca.SuspendLayout();
            this.tbc_main_decode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn_main
            // 
            this.mn_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.mn_main.Location = new System.Drawing.Point(0, 0);
            this.mn_main.Name = "mn_main";
            this.mn_main.Size = new System.Drawing.Size(484, 24);
            this.mn_main.TabIndex = 0;
            this.mn_main.Text = "Menu";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // tbc_main
            // 
            this.tbc_main.Controls.Add(this.tbc_main_encode);
            this.tbc_main.Controls.Add(this.tbc_main_decode);
            this.tbc_main.Location = new System.Drawing.Point(12, 27);
            this.tbc_main.Name = "tbc_main";
            this.tbc_main.SelectedIndex = 0;
            this.tbc_main.Size = new System.Drawing.Size(460, 253);
            this.tbc_main.TabIndex = 1;
            // 
            // tbc_main_encode
            // 
            this.tbc_main_encode.Controls.Add(this.frm_main_btn_copiar);
            this.tbc_main_encode.Controls.Add(this.frm_main_btn_gerar);
            this.tbc_main_encode.Controls.Add(this.frm_main_btn_sair);
            this.tbc_main_encode.Controls.Add(this.frm_main_pnl_licenca);
            this.tbc_main_encode.Controls.Add(this.frm_main_tb_contrato);
            this.tbc_main_encode.Controls.Add(this.frm_main_tb_validade);
            this.tbc_main_encode.Controls.Add(this.frm_main_tb_site);
            this.tbc_main_encode.Controls.Add(this.frm_main_tb_qtd_user);
            this.tbc_main_encode.Controls.Add(this.frm_main_tb_sys);
            this.tbc_main_encode.Controls.Add(this.frm_main_lbl_contrato);
            this.tbc_main_encode.Controls.Add(this.frm_main_lbl_qtd_user);
            this.tbc_main_encode.Controls.Add(this.frm_main_lbl_validade);
            this.tbc_main_encode.Controls.Add(this.frm_main_lbl_site);
            this.tbc_main_encode.Controls.Add(this.frm_main_lbl_sys);
            this.tbc_main_encode.Location = new System.Drawing.Point(4, 22);
            this.tbc_main_encode.Name = "tbc_main_encode";
            this.tbc_main_encode.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_main_encode.Size = new System.Drawing.Size(452, 227);
            this.tbc_main_encode.TabIndex = 0;
            this.tbc_main_encode.Text = "Gerar Licença";
            this.tbc_main_encode.UseVisualStyleBackColor = true;
            // 
            // frm_main_btn_copiar
            // 
            this.frm_main_btn_copiar.Enabled = false;
            this.frm_main_btn_copiar.Location = new System.Drawing.Point(196, 198);
            this.frm_main_btn_copiar.Name = "frm_main_btn_copiar";
            this.frm_main_btn_copiar.Size = new System.Drawing.Size(75, 23);
            this.frm_main_btn_copiar.TabIndex = 9;
            this.frm_main_btn_copiar.Text = "Copiar";
            this.frm_main_btn_copiar.UseVisualStyleBackColor = true;
            this.frm_main_btn_copiar.Click += new System.EventHandler(this.frm_main_btn_copiar_Click);
            // 
            // frm_main_btn_gerar
            // 
            this.frm_main_btn_gerar.Location = new System.Drawing.Point(277, 198);
            this.frm_main_btn_gerar.Name = "frm_main_btn_gerar";
            this.frm_main_btn_gerar.Size = new System.Drawing.Size(75, 23);
            this.frm_main_btn_gerar.TabIndex = 10;
            this.frm_main_btn_gerar.Text = "Gerar";
            this.frm_main_btn_gerar.UseVisualStyleBackColor = true;
            this.frm_main_btn_gerar.Click += new System.EventHandler(this.frm_main_btn_gerar_Click);
            // 
            // frm_main_btn_sair
            // 
            this.frm_main_btn_sair.Location = new System.Drawing.Point(358, 198);
            this.frm_main_btn_sair.Name = "frm_main_btn_sair";
            this.frm_main_btn_sair.Size = new System.Drawing.Size(75, 23);
            this.frm_main_btn_sair.TabIndex = 11;
            this.frm_main_btn_sair.Text = "Sair";
            this.frm_main_btn_sair.UseVisualStyleBackColor = true;
            this.frm_main_btn_sair.Click += new System.EventHandler(this.frm_main_btn_sair_Click);
            // 
            // frm_main_pnl_licenca
            // 
            this.frm_main_pnl_licenca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.frm_main_pnl_licenca.Controls.Add(this.frm_main_tb_licenca);
            this.frm_main_pnl_licenca.Controls.Add(this.frm_main_lbl_licenca);
            this.frm_main_pnl_licenca.Location = new System.Drawing.Point(18, 137);
            this.frm_main_pnl_licenca.Name = "frm_main_pnl_licenca";
            this.frm_main_pnl_licenca.Size = new System.Drawing.Size(415, 55);
            this.frm_main_pnl_licenca.TabIndex = 6;
            this.frm_main_pnl_licenca.Tag = "";
            // 
            // frm_main_tb_licenca
            // 
            this.frm_main_tb_licenca.BackColor = System.Drawing.SystemColors.Window;
            this.frm_main_tb_licenca.Enabled = false;
            this.frm_main_tb_licenca.Location = new System.Drawing.Point(17, 22);
            this.frm_main_tb_licenca.Name = "frm_main_tb_licenca";
            this.frm_main_tb_licenca.ReadOnly = true;
            this.frm_main_tb_licenca.Size = new System.Drawing.Size(381, 20);
            this.frm_main_tb_licenca.TabIndex = 8;
            this.frm_main_tb_licenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_main_lbl_licenca
            // 
            this.frm_main_lbl_licenca.AutoSize = true;
            this.frm_main_lbl_licenca.Location = new System.Drawing.Point(185, 3);
            this.frm_main_lbl_licenca.Name = "frm_main_lbl_licenca";
            this.frm_main_lbl_licenca.Size = new System.Drawing.Size(45, 13);
            this.frm_main_lbl_licenca.TabIndex = 8;
            this.frm_main_lbl_licenca.Text = "Licença";
            // 
            // frm_main_tb_contrato
            // 
            this.frm_main_tb_contrato.Location = new System.Drawing.Point(95, 111);
            this.frm_main_tb_contrato.Name = "frm_main_tb_contrato";
            this.frm_main_tb_contrato.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_contrato.TabIndex = 5;
            // 
            // frm_main_tb_validade
            // 
            this.frm_main_tb_validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frm_main_tb_validade.Location = new System.Drawing.Point(95, 61);
            this.frm_main_tb_validade.Name = "frm_main_tb_validade";
            this.frm_main_tb_validade.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_validade.TabIndex = 3;
            // 
            // frm_main_tb_site
            // 
            this.frm_main_tb_site.Location = new System.Drawing.Point(95, 36);
            this.frm_main_tb_site.Name = "frm_main_tb_site";
            this.frm_main_tb_site.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_site.TabIndex = 2;
            // 
            // frm_main_tb_qtd_user
            // 
            this.frm_main_tb_qtd_user.Location = new System.Drawing.Point(95, 86);
            this.frm_main_tb_qtd_user.Name = "frm_main_tb_qtd_user";
            this.frm_main_tb_qtd_user.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_qtd_user.TabIndex = 4;
            // 
            // frm_main_tb_sys
            // 
            this.frm_main_tb_sys.Enabled = false;
            this.frm_main_tb_sys.Location = new System.Drawing.Point(95, 12);
            this.frm_main_tb_sys.Name = "frm_main_tb_sys";
            this.frm_main_tb_sys.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_sys.TabIndex = 1;
            this.frm_main_tb_sys.Text = "LUX";
            // 
            // frm_main_lbl_contrato
            // 
            this.frm_main_lbl_contrato.AutoSize = true;
            this.frm_main_lbl_contrato.Location = new System.Drawing.Point(15, 114);
            this.frm_main_lbl_contrato.Name = "frm_main_lbl_contrato";
            this.frm_main_lbl_contrato.Size = new System.Drawing.Size(50, 13);
            this.frm_main_lbl_contrato.TabIndex = 4;
            this.frm_main_lbl_contrato.Text = "Contrato:";
            // 
            // frm_main_lbl_qtd_user
            // 
            this.frm_main_lbl_qtd_user.AutoSize = true;
            this.frm_main_lbl_qtd_user.Location = new System.Drawing.Point(15, 89);
            this.frm_main_lbl_qtd_user.Name = "frm_main_lbl_qtd_user";
            this.frm_main_lbl_qtd_user.Size = new System.Drawing.Size(74, 13);
            this.frm_main_lbl_qtd_user.TabIndex = 3;
            this.frm_main_lbl_qtd_user.Text = "Qtd. Usuários:";
            // 
            // frm_main_lbl_validade
            // 
            this.frm_main_lbl_validade.AutoSize = true;
            this.frm_main_lbl_validade.Location = new System.Drawing.Point(15, 64);
            this.frm_main_lbl_validade.Name = "frm_main_lbl_validade";
            this.frm_main_lbl_validade.Size = new System.Drawing.Size(51, 13);
            this.frm_main_lbl_validade.TabIndex = 2;
            this.frm_main_lbl_validade.Text = "Validade:";
            // 
            // frm_main_lbl_site
            // 
            this.frm_main_lbl_site.AutoSize = true;
            this.frm_main_lbl_site.Location = new System.Drawing.Point(15, 39);
            this.frm_main_lbl_site.Name = "frm_main_lbl_site";
            this.frm_main_lbl_site.Size = new System.Drawing.Size(28, 13);
            this.frm_main_lbl_site.TabIndex = 1;
            this.frm_main_lbl_site.Text = "Site:";
            // 
            // frm_main_lbl_sys
            // 
            this.frm_main_lbl_sys.AutoSize = true;
            this.frm_main_lbl_sys.Location = new System.Drawing.Point(15, 15);
            this.frm_main_lbl_sys.Name = "frm_main_lbl_sys";
            this.frm_main_lbl_sys.Size = new System.Drawing.Size(47, 13);
            this.frm_main_lbl_sys.TabIndex = 0;
            this.frm_main_lbl_sys.Text = "Sistema:";
            // 
            // tbc_main_decode
            // 
            this.tbc_main_decode.Controls.Add(this.frm_main_tb_ler_contrato);
            this.tbc_main_decode.Controls.Add(this.frm_main_tb_ler_validade);
            this.tbc_main_decode.Controls.Add(this.frm_main_tb_ler_site);
            this.tbc_main_decode.Controls.Add(this.frm_main_tb_ler_qtd_user);
            this.tbc_main_decode.Controls.Add(this.frm_main_tb_ler_sys);
            this.tbc_main_decode.Controls.Add(this.label2);
            this.tbc_main_decode.Controls.Add(this.label3);
            this.tbc_main_decode.Controls.Add(this.label4);
            this.tbc_main_decode.Controls.Add(this.label5);
            this.tbc_main_decode.Controls.Add(this.label6);
            this.tbc_main_decode.Controls.Add(this.frm_main_btn_ler);
            this.tbc_main_decode.Controls.Add(this.panel1);
            this.tbc_main_decode.Location = new System.Drawing.Point(4, 22);
            this.tbc_main_decode.Name = "tbc_main_decode";
            this.tbc_main_decode.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_main_decode.Size = new System.Drawing.Size(452, 227);
            this.tbc_main_decode.TabIndex = 1;
            this.tbc_main_decode.Text = "Ler Licença";
            this.tbc_main_decode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.frm_main_tb_ler_licenca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 55);
            this.panel1.TabIndex = 7;
            this.panel1.Tag = "";
            // 
            // frm_main_tb_ler_licenca
            // 
            this.frm_main_tb_ler_licenca.BackColor = System.Drawing.SystemColors.Window;
            this.frm_main_tb_ler_licenca.Location = new System.Drawing.Point(17, 22);
            this.frm_main_tb_ler_licenca.Name = "frm_main_tb_ler_licenca";
            this.frm_main_tb_ler_licenca.Size = new System.Drawing.Size(381, 20);
            this.frm_main_tb_ler_licenca.TabIndex = 8;
            this.frm_main_tb_ler_licenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Licença";
            // 
            // frm_main_btn_ler
            // 
            this.frm_main_btn_ler.Location = new System.Drawing.Point(358, 198);
            this.frm_main_btn_ler.Name = "frm_main_btn_ler";
            this.frm_main_btn_ler.Size = new System.Drawing.Size(75, 23);
            this.frm_main_btn_ler.TabIndex = 12;
            this.frm_main_btn_ler.Text = "Ler";
            this.frm_main_btn_ler.UseVisualStyleBackColor = true;
            this.frm_main_btn_ler.Click += new System.EventHandler(this.frm_main_btn_ler_Click);
            // 
            // frm_main_tb_ler_contrato
            // 
            this.frm_main_tb_ler_contrato.Enabled = false;
            this.frm_main_tb_ler_contrato.Location = new System.Drawing.Point(95, 173);
            this.frm_main_tb_ler_contrato.Name = "frm_main_tb_ler_contrato";
            this.frm_main_tb_ler_contrato.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_ler_contrato.TabIndex = 22;
            // 
            // frm_main_tb_ler_validade
            // 
            this.frm_main_tb_ler_validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frm_main_tb_ler_validade.Enabled = false;
            this.frm_main_tb_ler_validade.Location = new System.Drawing.Point(95, 123);
            this.frm_main_tb_ler_validade.Name = "frm_main_tb_ler_validade";
            this.frm_main_tb_ler_validade.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_ler_validade.TabIndex = 18;
            // 
            // frm_main_tb_ler_site
            // 
            this.frm_main_tb_ler_site.Location = new System.Drawing.Point(95, 98);
            this.frm_main_tb_ler_site.Name = "frm_main_tb_ler_site";
            this.frm_main_tb_ler_site.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_ler_site.TabIndex = 16;
            // 
            // frm_main_tb_ler_qtd_user
            // 
            this.frm_main_tb_ler_qtd_user.Enabled = false;
            this.frm_main_tb_ler_qtd_user.Location = new System.Drawing.Point(95, 148);
            this.frm_main_tb_ler_qtd_user.Name = "frm_main_tb_ler_qtd_user";
            this.frm_main_tb_ler_qtd_user.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_ler_qtd_user.TabIndex = 20;
            // 
            // frm_main_tb_ler_sys
            // 
            this.frm_main_tb_ler_sys.Enabled = false;
            this.frm_main_tb_ler_sys.Location = new System.Drawing.Point(95, 74);
            this.frm_main_tb_ler_sys.Name = "frm_main_tb_ler_sys";
            this.frm_main_tb_ler_sys.Size = new System.Drawing.Size(100, 20);
            this.frm_main_tb_ler_sys.TabIndex = 14;
            this.frm_main_tb_ler_sys.Text = "LUX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contrato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Qtd. Usuários:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Validade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Site:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sistema:";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.Controls.Add(this.tbc_main);
            this.Controls.Add(this.mn_main);
            this.MainMenuStrip = this.mn_main;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licença Prime";
            this.mn_main.ResumeLayout(false);
            this.mn_main.PerformLayout();
            this.tbc_main.ResumeLayout(false);
            this.tbc_main_encode.ResumeLayout(false);
            this.tbc_main_encode.PerformLayout();
            this.frm_main_pnl_licenca.ResumeLayout(false);
            this.frm_main_pnl_licenca.PerformLayout();
            this.tbc_main_decode.ResumeLayout(false);
            this.tbc_main_decode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn_main;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TabControl tbc_main;
        private System.Windows.Forms.TabPage tbc_main_encode;
        private System.Windows.Forms.Label frm_main_lbl_contrato;
        private System.Windows.Forms.Label frm_main_lbl_qtd_user;
        private System.Windows.Forms.Label frm_main_lbl_validade;
        private System.Windows.Forms.Label frm_main_lbl_site;
        private System.Windows.Forms.Label frm_main_lbl_sys;
        private System.Windows.Forms.TabPage tbc_main_decode;
        private System.Windows.Forms.TextBox frm_main_tb_contrato;
        private System.Windows.Forms.TextBox frm_main_tb_validade;
        private System.Windows.Forms.TextBox frm_main_tb_site;
        private System.Windows.Forms.TextBox frm_main_tb_qtd_user;
        private System.Windows.Forms.TextBox frm_main_tb_sys;
        private System.Windows.Forms.Button frm_main_btn_sair;
        private System.Windows.Forms.Panel frm_main_pnl_licenca;
        private System.Windows.Forms.Label frm_main_lbl_licenca;
        private System.Windows.Forms.TextBox frm_main_tb_licenca;
        private System.Windows.Forms.Button frm_main_btn_copiar;
        private System.Windows.Forms.Button frm_main_btn_gerar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox frm_main_tb_ler_licenca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frm_main_tb_ler_contrato;
        private System.Windows.Forms.TextBox frm_main_tb_ler_validade;
        private System.Windows.Forms.TextBox frm_main_tb_ler_site;
        private System.Windows.Forms.TextBox frm_main_tb_ler_qtd_user;
        private System.Windows.Forms.TextBox frm_main_tb_ler_sys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button frm_main_btn_ler;
    }
}

