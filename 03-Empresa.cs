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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frmPainel().Show();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadEmpresa().Show();
            Hide();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            string query = "SELECT nomeEmpresa 'Nome da empresa', razaoSocialEmpresa 'Razão social', cnpjCpfEmpresa 'CNPJ/CPF', emailEmpresa 'Email da empresa', GROUP_CONCAT(numeroFoneEmpresa) 'Número da empresa', horarioAtendEmpresa 'Horário de atendimento' FROM empresa LEFT JOIN foneempresa ON foneempresa.idEmpresa = empresa.idEmpresa GROUP BY empresa.idEmpresa";
            Banco.CarregarDados(query, dgvEmpresa);
        }
    }
}
