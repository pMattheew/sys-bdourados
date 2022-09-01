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
    public partial class frmCadEmpresa : Form
    {
        bool isShowingFone = false;

        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frmEmpresa().Show();
            Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            if (!isShowingFone)
            {
                isShowingFone = true;

                btnTelefone.Text = "Remover telefone";

                lblTelefone.Visible = isShowingFone;
                fndTel.Visible = isShowingFone;
                mkdFone.Visible = isShowingFone;

                lblOperadora.Visible = isShowingFone;
                cmbOperadora.Visible = isShowingFone;

                lblObs.Visible = isShowingFone;
                fndObs.Visible = isShowingFone;
                inObs.Visible = isShowingFone;
            }
            else
            {
                isShowingFone = false;

                btnTelefone.Text = "Adicionar telefone";

                lblTelefone.Visible = isShowingFone;
                fndTel.Visible = isShowingFone;
                mkdFone.Visible = isShowingFone;
                mkdFone.Clear();

                lblOperadora.Visible = isShowingFone;
                cmbOperadora.Visible = isShowingFone;
                cmbOperadora.SelectedIndex = -1;

                lblObs.Visible = isShowingFone;
                fndObs.Visible = isShowingFone;
                inObs.Visible = isShowingFone;
                inObs.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inNome.Clear();
            inRazao.Clear();
            inEmail.Clear();
            mkdCnpjCpf.Clear();
            cmbHorario.SelectedIndex = -1;
            mkdFone.Clear();
            cmbOperadora.SelectedIndex = -1;
            inObs.Clear();
        }
    }
}
