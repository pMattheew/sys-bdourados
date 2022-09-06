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
        int linhaSelecionada = -1;
        string select = "SELECT nomeEmpresa 'Nome da empresa', razaoSocialEmpresa 'Razão social', cnpjCpfEmpresa 'CNPJ/CPF', emailEmpresa 'Email da empresa', GROUP_CONCAT(numeroFoneEmpresa) 'Número da empresa', horarioAtendEmpresa 'Horário de atendimento' FROM empresa LEFT JOIN foneempresa ON foneempresa.idEmpresa = empresa.idEmpresa GROUP BY empresa.idEmpresa";

        public frmEmpresa()
        {
            InitializeComponent();
        }

        // navegação começo
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
        // navegação fim

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Banco.CarregarDados(select, dgvEmpresa);
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaSelecionada = int.Parse(e.RowIndex.ToString()) + 1; // para checar com o banco, necessita +1.
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (linhaSelecionada >= 0)
            {
                Banco.ExcluirLinha("empresa", linhaSelecionada);
                Banco.CarregarDados(select, dgvEmpresa);
            }
        }

    }
}
