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

        public class Empresa
        {
            public string idEmpresa { get; set; }
            public string nomeEmpresa { get; set; }
            public string cnpjCpfEmpresa { get; set; }
            public string razaoSocialEmpresa { get; set; }
            public string emailEmpresa { get; set; }
            public string bannerEmpresa { get; set; }
            public string statusEmpresa { get; set; }
            public string dataCadEmpresa { get; set; }
            public string horarioAtendEmpresa { get; set; }
        }

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

        // botão Adicionar telefone
        private void btnTelefone_Click(object sender, EventArgs e)
        {
            if (!isShowingFone)
            {
                isShowingFone = true;

                btnTelefone.Text = "Remover telefone";

                lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblRazao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblCnpjCpf.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblHorario.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
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
                lblRazao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblCnpjCpf.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblHorario.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
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
        private void btnEnviarPic_Click(object sender, EventArgs e)
        {

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

            lblNome.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblRazao.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblCnpjCpf.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblHorario.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblTelefone.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
            lblOperadora.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);


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
                lblNome.ForeColor = System.Drawing.Color.FromArgb(196,196,196);
                lblRazao.ForeColor = System.Drawing.Color.FromArgb(196,196,196);
                lblEmail.ForeColor = System.Drawing.Color.FromArgb(196,196,196);
                lblCnpjCpf.ForeColor = System.Drawing.Color.FromArgb(196,196,196);
                lblHorario.ForeColor = System.Drawing.Color.FromArgb(196,196,196);
                lblTelefone.ForeColor = System.Drawing.Color.FromArgb(196, 196, 196);
                lblOperadora.ForeColor = System.Drawing.Color.FromArgb(196,196,196);


                if (inNome.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o nome da empresa.";
                    inNome.Focus();
                    lblNome.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (inRazao.Text == "")
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha a razão social da empresa.";
                    inRazao.Focus();
                    lblRazao.ForeColor = System.Drawing.Color.Crimson;
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
                else if (!mkdCnpjCpf.MaskCompleted)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o CNPJ ou CPF da empresa.";
                    mkdCnpjCpf.Focus();
                    lblCnpjCpf.ForeColor = System.Drawing.Color.Crimson;
                    return camposEstaoValidos;
                }
                else if (cmbHorario.SelectedIndex == -1)
                {
                    picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                    lblFeedback.Text = "Por favor, preencha o horário de atendimento da empresa.";
                    cmbHorario.Focus();
                    lblHorario.ForeColor = System.Drawing.Color.Crimson;
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
            
            picFeedback.Image = sys_bdourados.Properties.Resources.info;
            lblFeedback.Text = "Cadastrando empresa...";
            picTab1.Visible = false;
            picTab2.Visible = false;
            picShift.Visible = false;

            if (VerificarCampos())
            {
                Empresa NovaEmpresa = new Empresa()
            {
                idEmpresa = "DEFAULT",
                nomeEmpresa = inNome.Text,
                cnpjCpfEmpresa = mkdCnpjCpf.Text,
                razaoSocialEmpresa = inRazao.Text,
                emailEmpresa = inEmail.Text,
                bannerEmpresa = "DEFAULT",
                statusEmpresa = "ATIVO",
                dataCadEmpresa = DateTime.Now.ToString("yyyy-MM-dd"),
                horarioAtendEmpresa = cmbHorario.Text
            };

                Banco.InserirLinha("empresa", NovaEmpresa);

                picFeedback.Image = sys_bdourados.Properties.Resources.check;
                lblFeedback.Text = "Empresa cadastrada com sucesso!";
            }
        }
    }
}