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
    public partial class frmFuncionario : Form
    {
        int idSelecionado = -1;
        string select = "SELECT idFuncionario 'ID', nomeFuncionario 'Nome do funcionário', emailFuncionario 'Email do funcionário', nivelFuncionario 'Nível', descFuncionario 'Descrição do funcionário', nomeEmpresa 'Empresa' FROM funcionario INNER JOIN empresa ON empresa.idEmpresa = funcionario.idEmpresa";

        public frmFuncionario()
        {
            InitializeComponent();
        }

        // navegação
        private void btnVoltar_Click(object sender, EventArgs e)
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
        // fim navegação
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            Banco.CarregarDados(select, dgvFuncionario);
        }

        private void dgvFuncionario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvFuncionario.Columns["ID"].Visible = false;
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSelecionado = Convert.ToInt32(dgvFuncionario[0, e.RowIndex].Value);
            }
            catch { }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadFuncionario("CADASTRAR").Show();
            Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                new frmCadFuncionario("ATUALIZAR", idSelecionado).Show();
                Hide();
            }
            else
            {
                Feedback.at(lblFeedback, picFeedback, "aviso", "Para atualizar os dados de um funcionário selecione uma linha.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                Banco.ExcluirLinha("funcionario", idSelecionado);
                Banco.CarregarDados(select, dgvFuncionario);

                idSelecionado = -1;

                Feedback.at(lblFeedback, picFeedback, "check", "Funcionário excluído com sucesso!");
            }
            else
            {
                Feedback.at(lblFeedback, picFeedback, "aviso", "Para excluir selecione uma linha.");
            }
        }
    }
}
