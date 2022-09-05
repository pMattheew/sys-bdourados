namespace sys_bdourados
{
    partial class frmEmpresa
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFone = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.lblFundoDinamico = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.picShift = new System.Windows.Forms.PictureBox();
            this.picTab2 = new System.Windows.Forms.PictureBox();
            this.picTab1 = new System.Windows.Forms.PictureBox();
            this.picFeedback = new System.Windows.Forms.PictureBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 13F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblTitulo.Location = new System.Drawing.Point(7, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 31);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gerenciar empresas";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(0, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 50);
            this.label1.TabIndex = 11;
            // 
            // btnAddFone
            // 
            this.btnAddFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnAddFone.FlatAppearance.BorderSize = 0;
            this.btnAddFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFone.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAddFone.ForeColor = System.Drawing.Color.White;
            this.btnAddFone.Location = new System.Drawing.Point(17, 216);
            this.btnAddFone.Name = "btnAddFone";
            this.btnAddFone.Size = new System.Drawing.Size(226, 32);
            this.btnAddFone.TabIndex = 16;
            this.btnAddFone.Text = "Adicionar telefone";
            this.btnAddFone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFone.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(17, 172);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(226, 32);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir empresa";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(17, 128);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(226, 32);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar dados da empresa";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(17, 85);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(226, 32);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar nova empresa";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 610);
            this.label3.TabIndex = 15;
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(260, 40);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(940, 610);
            this.dgvEmpresa.TabIndex = 20;
            // 
            // lblFundoDinamico
            // 
            this.lblFundoDinamico.AutoSize = true;
            this.lblFundoDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblFundoDinamico.Location = new System.Drawing.Point(14, 667);
            this.lblFundoDinamico.Name = "lblFundoDinamico";
            this.lblFundoDinamico.Size = new System.Drawing.Size(0, 13);
            this.lblFundoDinamico.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pictureBox1.Image = global::sys_bdourados.Properties.Resources.voltar;
            this.pictureBox1.Location = new System.Drawing.Point(1080, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.minimize.TabIndex = 12;
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
            this.close.TabIndex = 13;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // picShift
            // 
            this.picShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.picShift.Image = global::sys_bdourados.Properties.Resources.shift;
            this.picShift.Location = new System.Drawing.Point(925, 665);
            this.picShift.Name = "picShift";
            this.picShift.Size = new System.Drawing.Size(20, 20);
            this.picShift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShift.TabIndex = 31;
            this.picShift.TabStop = false;
            // 
            // picTab2
            // 
            this.picTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.picTab2.Image = global::sys_bdourados.Properties.Resources.tab;
            this.picTab2.Location = new System.Drawing.Point(850, 665);
            this.picTab2.Name = "picTab2";
            this.picTab2.Size = new System.Drawing.Size(20, 20);
            this.picTab2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTab2.TabIndex = 32;
            this.picTab2.TabStop = false;
            // 
            // picTab1
            // 
            this.picTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.picTab1.Image = global::sys_bdourados.Properties.Resources.tab;
            this.picTab1.Location = new System.Drawing.Point(412, 665);
            this.picTab1.Name = "picTab1";
            this.picTab1.Size = new System.Drawing.Size(20, 20);
            this.picTab1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTab1.TabIndex = 33;
            this.picTab1.TabStop = false;
            // 
            // picFeedback
            // 
            this.picFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.picFeedback.Image = global::sys_bdourados.Properties.Resources.info;
            this.picFeedback.Location = new System.Drawing.Point(30, 665);
            this.picFeedback.Name = "picFeedback";
            this.picFeedback.Size = new System.Drawing.Size(20, 20);
            this.picFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFeedback.TabIndex = 34;
            this.picFeedback.TabStop = false;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblFeedback.Font = new System.Drawing.Font("Montserrat", 11F);
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.lblFeedback.Location = new System.Drawing.Point(53, 665);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(873, 21);
            this.lblFeedback.TabIndex = 30;
            this.lblFeedback.Text = "Para alternar ao próximo campo, pressione Tab       em seu teclado; e para o camp" +
    "o anterior, pressione Tab       + Shift";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.picShift);
            this.Controls.Add(this.picTab2);
            this.Controls.Add(this.picTab1);
            this.Controls.Add(this.picFeedback);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblFundoDinamico);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.btnAddFone);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DouradosSys | Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFone;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFundoDinamico;
        private System.Windows.Forms.PictureBox picShift;
        private System.Windows.Forms.PictureBox picTab2;
        private System.Windows.Forms.PictureBox picTab1;
        private System.Windows.Forms.PictureBox picFeedback;
        private System.Windows.Forms.Label lblFeedback;
    }
}