﻿namespace sys_bdourados
{
    partial class frmCadEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voltar = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.fundo = new System.Windows.Forms.Label();
            this.inNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.inRazao = new System.Windows.Forms.TextBox();
            this.inEmail = new System.Windows.Forms.TextBox();
            this.radCnpj = new System.Windows.Forms.RadioButton();
            this.radCpf = new System.Windows.Forms.RadioButton();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.mkdFone = new System.Windows.Forms.MaskedTextBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.voltar.Image = global::sys_bdourados.Properties.Resources.voltar;
            this.voltar.Location = new System.Drawing.Point(1080, 0);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(40, 40);
            this.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltar.TabIndex = 16;
            this.voltar.TabStop = false;
            this.voltar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.minimize.Image = global::sys_bdourados.Properties.Resources.minimizar;
            this.minimize.Location = new System.Drawing.Point(1120, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(40, 40);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 17;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.close.Image = global::sys_bdourados.Properties.Resources.fechar;
            this.close.Location = new System.Drawing.Point(1160, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 18;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(0, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 50);
            this.label1.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 13F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblTitulo.Location = new System.Drawing.Point(7, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(439, 31);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Gerenciar empresas | cadastrar nova empresa";
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.fundo.Location = new System.Drawing.Point(0, 40);
            this.fundo.Margin = new System.Windows.Forms.Padding(0);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(1200, 610);
            this.fundo.TabIndex = 19;
            // 
            // inNome
            // 
            this.inNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.inNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inNome.Font = new System.Drawing.Font("Montserrat", 12F);
            this.inNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inNome.Location = new System.Drawing.Point(47, 101);
            this.inNome.Name = "inNome";
            this.inNome.Size = new System.Drawing.Size(508, 20);
            this.inNome.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(36, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 35);
            this.label3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(36, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 35);
            this.label2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(36, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 35);
            this.label4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(36, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 35);
            this.label5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(36, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 35);
            this.label6.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblNome.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblNome.Location = new System.Drawing.Point(36, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(152, 21);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome da empresa:";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblRazao.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblRazao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblRazao.Location = new System.Drawing.Point(36, 148);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(197, 21);
            this.lblRazao.TabIndex = 22;
            this.lblRazao.Text = "Razão social da empresa:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblEmail.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblEmail.Location = new System.Drawing.Point(36, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(149, 21);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email da empresa:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblTelefone.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblTelefone.Location = new System.Drawing.Point(36, 418);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(76, 21);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblHorario.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblHorario.Location = new System.Drawing.Point(336, 339);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(192, 21);
            this.lblHorario.TabIndex = 22;
            this.lblHorario.Text = "Horário de atendimento:";
            // 
            // inRazao
            // 
            this.inRazao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.inRazao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inRazao.Font = new System.Drawing.Font("Montserrat", 12F);
            this.inRazao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inRazao.Location = new System.Drawing.Point(47, 180);
            this.inRazao.Name = "inRazao";
            this.inRazao.Size = new System.Drawing.Size(508, 20);
            this.inRazao.TabIndex = 20;
            // 
            // inEmail
            // 
            this.inEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.inEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inEmail.Font = new System.Drawing.Font("Montserrat", 12F);
            this.inEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inEmail.Location = new System.Drawing.Point(47, 260);
            this.inEmail.Name = "inEmail";
            this.inEmail.Size = new System.Drawing.Size(508, 20);
            this.inEmail.TabIndex = 20;
            // 
            // radCnpj
            // 
            this.radCnpj.AutoSize = true;
            this.radCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.radCnpj.Font = new System.Drawing.Font("Montserrat", 11F);
            this.radCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.radCnpj.Location = new System.Drawing.Point(40, 335);
            this.radCnpj.Name = "radCnpj";
            this.radCnpj.Size = new System.Drawing.Size(69, 25);
            this.radCnpj.TabIndex = 23;
            this.radCnpj.TabStop = true;
            this.radCnpj.Text = "CNPJ";
            this.radCnpj.UseVisualStyleBackColor = false;
            // 
            // radCpf
            // 
            this.radCpf.AutoSize = true;
            this.radCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.radCpf.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.radCpf.FlatAppearance.BorderSize = 0;
            this.radCpf.Font = new System.Drawing.Font("Montserrat", 11F);
            this.radCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.radCpf.Location = new System.Drawing.Point(115, 335);
            this.radCpf.Name = "radCpf";
            this.radCpf.Size = new System.Drawing.Size(59, 25);
            this.radCpf.TabIndex = 23;
            this.radCpf.TabStop = true;
            this.radCpf.Text = "CPF";
            this.radCpf.UseVisualStyleBackColor = false;
            // 
            // lblCnpjCpf
            // 
            this.lblCnpjCpf.AutoSize = true;
            this.lblCnpjCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblCnpjCpf.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblCnpjCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblCnpjCpf.Location = new System.Drawing.Point(35, 311);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(205, 21);
            this.lblCnpjCpf.TabIndex = 22;
            this.lblCnpjCpf.Text = "CNPJ ou CPF da empresa:";
            // 
            // mkdFone
            // 
            this.mkdFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.mkdFone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkdFone.Font = new System.Drawing.Font("Montserrat", 12F);
            this.mkdFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mkdFone.Location = new System.Drawing.Point(46, 450);
            this.mkdFone.Mask = "(00)00000-0000";
            this.mkdFone.Name = "mkdFone";
            this.mkdFone.Size = new System.Drawing.Size(209, 20);
            this.mkdFone.TabIndex = 24;
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHorario.Font = new System.Drawing.Font("Montserrat", 15F);
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.IntegralHeight = false;
            this.cmbHorario.ItemHeight = 27;
            this.cmbHorario.Items.AddRange(new object[] {
            "06:00",
            "08:00",
            "10:00",
            "12:00",
            "14:00",
            "16:00"});
            this.cmbHorario.Location = new System.Drawing.Point(337, 364);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(228, 35);
            this.cmbHorario.TabIndex = 25;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(30, 614);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(240, 35);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar empresa";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(330, 614);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(240, 35);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnTelefone
            // 
            this.btnTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnTelefone.FlatAppearance.BorderSize = 0;
            this.btnTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelefone.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnTelefone.ForeColor = System.Drawing.Color.White;
            this.btnTelefone.Location = new System.Drawing.Point(630, 614);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(240, 35);
            this.btnTelefone.TabIndex = 26;
            this.btnTelefone.Text = "Adicionar telefone";
            this.btnTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelefone.UseVisualStyleBackColor = false;
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.lblOperadora.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblOperadora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblOperadora.Location = new System.Drawing.Point(337, 418);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(92, 21);
            this.lblOperadora.TabIndex = 22;
            this.lblOperadora.Text = "Operadora:";
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOperadora.Font = new System.Drawing.Font("Montserrat", 15F);
            this.cmbOperadora.FormattingEnabled = true;
            this.cmbOperadora.IntegralHeight = false;
            this.cmbOperadora.ItemHeight = 27;
            this.cmbOperadora.Items.AddRange(new object[] {
            "TIM",
            "VIVO",
            "CLARO",
            "OI",
            "NEXTEL"});
            this.cmbOperadora.Location = new System.Drawing.Point(338, 443);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(228, 35);
            this.cmbOperadora.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(36, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 35);
            this.label7.TabIndex = 21;
            // 
            // inObs
            // 
            this.inObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.inObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inObs.Font = new System.Drawing.Font("Montserrat", 12F);
            this.inObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inObs.Location = new System.Drawing.Point(47, 531);
            this.inObs.Name = "inObs";
            this.inObs.Size = new System.Drawing.Size(508, 20);
            this.inObs.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label8.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label8.Location = new System.Drawing.Point(36, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descrição do telefone:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(46, 370);
            this.maskedTextBox1.Mask = "00,000,000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(209, 20);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // frmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbOperadora);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.mkdFone);
            this.Controls.Add(this.radCpf);
            this.Controls.Add(this.lblOperadora);
            this.Controls.Add(this.radCnpj);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCnpjCpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRazao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.inObs);
            this.Controls.Add(this.inEmail);
            this.Controls.Add(this.inRazao);
            this.Controls.Add(this.inNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fundo);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DouradosSys | Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox voltar;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label fundo;
        private System.Windows.Forms.TextBox inNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox inRazao;
        private System.Windows.Forms.TextBox inEmail;
        private System.Windows.Forms.RadioButton radCnpj;
        private System.Windows.Forms.RadioButton radCpf;
        private System.Windows.Forms.Label lblCnpjCpf;
        private System.Windows.Forms.MaskedTextBox mkdFone;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTelefone;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}