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
    public partial class frmCadFuncionario : Form
    {
        bool isShowingFone = false;
        private string funcao, id;
        private string selectEmpresas = "SELECT idEmpresa, nomeEmpresa FROM empresa ORDER BY nomeEmpresa";

        public class Funcionario
        {
            public string idFuncionario { get; set; }
            public string nomeFuncionario { get; set; }
            public string emailFuncionario { get; set; }
            public string senhaFuncionario { get; set; }
            public string nivelFuncionario { get; set; }
            public string statusFuncionario { get; set; }
            public string dataCadFuncionario { get; set; }
            public string horarioTrabalhoFuncionario { get; set; }
            public string fotoFuncionario { get; set; }
            public string descFuncionario { get; set; }
            public string repFuncionario { get; set; }
            public string idEmpresa { get; set; }
        }

        public frmCadFuncionario(string funcionalidade, int idSelecionado = -1)
        {
            id = idSelecionado.ToString();
            funcao = funcionalidade;
            InitializeComponent();
        }

        Funcionario AtualizarFuncionario = new Funcionario();
        Funcionario NovoFuncionario = new Funcionario();

        // navegação
        private void voltar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
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
        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            if (funcao == "ATUALIZAR")
            {
                void AutoPreencherCampos()
                {
                    inNome.Text = AtualizarFuncionario.nomeFuncionario;
                    inEmail.Text = AtualizarFuncionario.emailFuncionario;
                    inSenha.Text = AtualizarFuncionario.senhaFuncionario;
                    Banco.CarregarDados(selectEmpresas, null, cmbEmpresa, "empresa");
                    cmbNivel.Text = AtualizarFuncionario.nivelFuncionario;
                    cmbHoras.Text = AtualizarFuncionario.horarioTrabalhoFuncionario;
                    inDescricao.Text = AtualizarFuncionario.descFuncionario;
                }

                lblTitulo.Text = "Gerenciar funcionários | atualizar dados do funcionário";
                btnCadastrar.Text = "Atualizar funcionário";

                AtualizarFuncionario.idFuncionario = id;

                Banco.CarregarDadosObjeto("funcionario", AtualizarFuncionario);

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
            inEmail.Clear();
            inSenha.Clear();
            cmbEmpresa.SelectedIndex = -1;
            cmbNivel.SelectedIndex = -1;
            cmbHoras.SelectedIndex = -1;
            inDescricao.Clear();
            mkdFone.Clear();
            cmbOperadora.SelectedIndex = -1;
            inObs.Clear();

            lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblSenha.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblNivel.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblHoras.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblDescricao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblTelefone.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblOperadora.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);

            Feedback.tab(lblFeedback,picFeedback,picTab1,picTab2,picShift);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool VerificarCampos()
            {
                bool camposEstaoValidos = false;

                // titulos voltam para as cores normais
                lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblSenha.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblNivel.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblHoras.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblDescricao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblTelefone.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblOperadora.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);

                Feedback.at(lblFeedback, picFeedback, "info","Cadastrando funcionário...");

                Feedback.tab(lblFeedback,picFeedback,picTab1,picTab2,picShift,false);

                if (inNome.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o nome do funcionário.";
                    inNome.Focus();
                    lblNome.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (inEmail.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o email da empresa.";
                    inEmail.Focus();
                    lblEmail.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (inSenha.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha a senha do funcionário.";
                    inSenha.Focus();
                    lblSenha.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (cmbEmpresa.SelectedIndex == -1)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha a empresa em que o funcionário trabalha.";
                    cmbEmpresa.Focus();
                    lblEmpresa.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (cmbNivel.SelectedIndex == -1)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o nível hierárquico do funcionário.";
                    cmbNivel.Focus();
                    lblNivel.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (cmbHoras.SelectedIndex == -1)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha as horas trabalhadas pelo funcionário.";
                    cmbHoras.Focus();
                    lblHoras.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (isShowingFone) // somente se cadastrar telefone for true
                {
                    if (!mkdFone.MaskCompleted)
                    {
                        picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                        lblFeedback.Text = "Por favor, preencha o telefone da empresa.";
                        mkdFone.Focus();
                        lblTelefone.ForeColor = System.Drawing.Color.Crimson;
                        return camposEstaoValidos;
                    }
                    else if (cmbOperadora.SelectedIndex == -1)
                    {
                        picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                        lblFeedback.Text = "Por favor, preencha a operadora do número da empresa.";
                        cmbOperadora.Focus();
                        lblOperadora.ForeColor = System.Drawing.Color.Crimson;
                        return camposEstaoValidos;
                    }
                    else
                    {
                        camposEstaoValidos = true;
                        return camposEstaoValidos;
                    }
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
                    NovoFuncionario.idFuncionario = "DEFAULT";
                    NovoFuncionario.nomeFuncionario = inNome.Text;
                    NovoFuncionario.emailFuncionario = inEmail.Text;
                    NovoFuncionario.senhaFuncionario = inSenha.Text;
                    NovoFuncionario.nivelFuncionario = cmbNivel.Text;
                    NovoFuncionario.statusFuncionario = "ATIVO";
                    NovoFuncionario.dataCadFuncionario = DateTime.Now.ToString("yyyy-MM-dd");
                    NovoFuncionario.horarioTrabalhoFuncionario = cmbHoras.Text;
                    NovoFuncionario.fotoFuncionario = "DEFAULT";
                    NovoFuncionario.descFuncionario = inDescricao.Text;
                    NovoFuncionario.repFuncionario = "DEFAULT";
                    NovoFuncionario.idEmpresa = Convert.ToString(cmbEmpresa.SelectedValue);
                }
                else if (funcao == "ATUALIZAR")
                {
                    AtualizarFuncionario.nomeFuncionario = inNome.Text;
                    AtualizarFuncionario.emailFuncionario = inEmail.Text;
                    AtualizarFuncionario.senhaFuncionario = inSenha.Text;
                    AtualizarFuncionario.nivelFuncionario = cmbNivel.Text;
                    AtualizarFuncionario.horarioTrabalhoFuncionario = cmbHoras.Text;
                    AtualizarFuncionario.descFuncionario = inDescricao.Text;
                    AtualizarFuncionario.idEmpresa = Convert.ToString(cmbEmpresa.SelectedValue);
                }
            }

            Feedback.tab(lblFeedback, picFeedback, picTab1, picTab2, picShift, false);

            DeclararCampos();

            if (funcao == "CADASTRAR" && VerificarCampos())
            {
                Banco.InserirLinha("funcionario", NovoFuncionario);

                Feedback.at(lblFeedback, picFeedback, "check", "Funcionário cadastrado com sucesso!");
            }
            else if (funcao == "ATUALIZAR" && VerificarCampos())
            {
                Banco.AtualizarDadosObjeto("funcionario", AtualizarFuncionario);

                Feedback.at(lblFeedback, picFeedback, "check", "Dados do funcionário atualizados com sucesso!");
            }
        }
        private void btnTelefone_Click(object sender, EventArgs e)
        {
            if (!isShowingFone)
            {
                isShowingFone = true;

                btnTelefone.Text = "Remover telefone";

                lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblSenha.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblNivel.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblHoras.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblDescricao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblTelefone.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblOperadora.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);

                picFeedback.Image = sys_bdourados.Properties.Resources.info;
                lblFeedback.Text = "Se desejar adicionar mais telefones à mesma empresa, é possível através do painel Gerenciar empresas.";
                picTab1.Visible = false;
                picTab2.Visible = false;
                picShift.Visible = false;


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

                lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblSenha.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblNivel.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblHoras.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblDescricao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblTelefone.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblOperadora.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);

                picFeedback.Image = sys_bdourados.Properties.Resources.info;
                lblFeedback.Text = "Para alternar ao próximo campo, pressione Tab       em seu teclado; e para o campo anterior, pressione Tab       + Shift";
                picTab1.Visible = true;
                picTab2.Visible = true;
                picShift.Visible = true;

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

    }
}
