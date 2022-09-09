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
    public partial class frmCadServico : Form
    {
        private string funcao, id;
        private string selectEmpresas = "SELECT idEmpresa, nomeEmpresa FROM empresa ORDER BY nomeEmpresa";

        public class Servico
        {
            public string idServico { get; set; }
            public string nomeServico { get; set; }
            public string descricaoServico { get; set; }
            public string valorServico { get; set; }
            public string statusServico { get; set; }
            public string dataCadServico { get; set; }
            public string tempoExecServico { get; set; }
            public string idEmpresa { get; set; }
        }
        public frmCadServico(string funcionalidade, int idSelecionado = -1)
        {
            id = idSelecionado.ToString();
            funcao = funcionalidade;
            InitializeComponent();
        }

        Servico AtualizarServico = new Servico();
        Servico NovoServico = new Servico();

        // navegação começo
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
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
        // navegação fim

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            if (funcao == "ATUALIZAR")
            {
                void AutoPreencherCampos()
                {
                    inNome.Text = AtualizarServico.nomeServico;
                    inDescricao.Text = AtualizarServico.descricaoServico;
                    inValor.Text = AtualizarServico.valorServico;
                    cmbTempoExec.Text = AtualizarServico.tempoExecServico;
                    Banco.CarregarDados(selectEmpresas, null, cmbEmpresa, "empresa");
                }

                lblTitulo.Text = "Gerenciar serviços | atualizar dados do serviço";
                btnCadastrar.Text = "Atualizar serviço";

                AtualizarServico.idServico = id;

                Banco.CarregarDadosObjeto("servico", AtualizarServico);

                AutoPreencherCampos();
            }
            else if (funcao == "CADASTRAR")
            {
                Banco.CarregarDados(selectEmpresas, null, cmbEmpresa, "empresa");
            }

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            inNome.Clear();
            inDescricao.Clear();
            inValor.Clear();
            cmbTempoExec.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;

            lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblDescricao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblValor.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblTempoExec.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);

            picFeedback.Image = sys_bdourados.Properties.Resources.info;
            lblFeedback.Text = "Para alternar ao próximo campo, pressione Tab       em seu teclado; e para o campo anterior, pressione Tab       + Shift";
            picTab1.Visible = true;
            picTab2.Visible = true;
            picShift.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool VerificarCampos()
            {
                bool camposEstaoValidos = false;

                // titulos voltam para as cores normais
                lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblDescricao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblValor.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblTempoExec.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);

                picFeedback.Image = sys_bdourados.Properties.Resources.info;
                lblFeedback.Text = "Cadastrando serviço...";
                picTab1.Visible = false;
                picTab2.Visible = false;
                picShift.Visible = false;


                if (inNome.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o nome do serviço.";
                    inNome.Focus();
                    lblNome.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (inDescricao.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha a descrição do serviço.";
                    inDescricao.Focus();
                    lblDescricao.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (inValor.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o valor do serviço.";
                    inValor.Focus();
                    lblValor.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (cmbTempoExec.SelectedIndex == -1)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, escolha o tempo de execução do serviço.";
                    cmbTempoExec.Focus();
                    lblTempoExec.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (cmbEmpresa.SelectedIndex == -1)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, escolha a empresa prestadora do serviço.";
                    cmbEmpresa.Focus();
                    lblEmpresa.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else
                {
                    camposEstaoValidos = true;
                    return camposEstaoValidos;
                }

            }

            void DeclararCampos()
            {
                if (funcao == "CADASTRAR")
                {
                    NovoServico.idServico = "DEFAULT";
                    NovoServico.nomeServico = inNome.Text;
                    NovoServico.descricaoServico = inDescricao.Text;
                    NovoServico.valorServico = inValor.Text;
                    NovoServico.tempoExecServico = cmbTempoExec.Text;
                    NovoServico.idEmpresa = Convert.ToString(cmbEmpresa.SelectedValue);
                    NovoServico.dataCadServico = DateTime.Now.ToString("yyyy-MM-dd");
                    NovoServico.statusServico = "ATIVO";
                }
                else if (funcao == "ATUALIZAR")
                {
                    AtualizarServico.nomeServico = inNome.Text;
                    AtualizarServico.descricaoServico = inDescricao.Text;
                    AtualizarServico.valorServico= inValor.Text;
                    AtualizarServico.tempoExecServico= cmbTempoExec.Text;
                    AtualizarServico.idEmpresa = Convert.ToString(cmbEmpresa.SelectedValue);
                }
            }

            Feedback.tab(lblFeedback, picFeedback, picTab1, picTab2, picShift, false);

            DeclararCampos();

            if (funcao == "CADASTRAR" && VerificarCampos())
            {
                Banco.InserirLinha("servico", NovoServico);

                Feedback.at(lblFeedback, picFeedback, "check", "Serviço cadastrado com sucesso!");
            }
            else if (funcao == "ATUALIZAR" && VerificarCampos())
            {
                Banco.AtualizarDadosObjeto("servico", AtualizarServico);

                Feedback.at(lblFeedback, picFeedback, "check", "Dados do serviço atualizados com sucesso!");
            }

        }
    }
}
