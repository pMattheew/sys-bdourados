using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_bdourados
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        string funcao = "VISUALIZAR";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frmPainel().Show();
            Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            funcao = "CADASTRAR";
            lblFundoDinamico.Location = new System.Drawing.Point(0, 40);
            lblFundoDinamico.Width = 1200;
            lblFundoDinamico.Height = 610;
        }
    }
}
