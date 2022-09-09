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
    public partial class frmServico : Form
    {
        int idSelecionado = -1;
        string select = "SELECT idServico 'ID', nomeServico 'Nome do serviço', descricaoServico 'Descrição do serviço', valorServico 'Valor', tempoExecServico 'Tempo de execução', nomeEmpresa 'Empresa prestadora' FROM servico INNER JOIN empresa ON empresa.idEmpresa = servico.idEmpresa";

        public frmServico()
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

        private void frmServico_Load(object sender, EventArgs e)
        {
            Banco.CarregarDados(select, dgvServico);
        }

        private void dgvServico_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvServico.Columns["ID"].Visible = false;
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSelecionado = Convert.ToInt32(dgvServico[0, e.RowIndex].Value);
            }
            catch { }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadServico("CADASTRAR").Show();
            Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                new frmCadServico("ATUALIZAR", idSelecionado).Show();
                Hide();
            }
            else
            {
                Feedback.at(lblFeedback, picFeedback, "aviso", "Para atualizar os dados de um serviço selecione uma linha.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                Banco.ExcluirLinha("servico", idSelecionado);
                Banco.CarregarDados(select, dgvServico);

                idSelecionado = -1;

                Feedback.at(lblFeedback, picFeedback, "check","Serviço excluído com sucesso!");
            }
            else
            {
                Feedback.at(lblFeedback, picFeedback,"aviso","Para excluir selecione uma linha.");
            }
        }
    }
}
