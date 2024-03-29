﻿using System;
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
        int idSelecionado = -1;
        string select = "SELECT empresa.idEmpresa 'ID', nomeEmpresa 'Nome da empresa', razaoSocialEmpresa 'Razão social', cnpjCpfEmpresa 'CNPJ/CPF', emailEmpresa 'Email da empresa', GROUP_CONCAT(numeroFoneEmpresa) 'Número da empresa', horarioAtendEmpresa 'Horário de atendimento' FROM empresa LEFT JOIN foneempresa ON foneempresa.idEmpresa = empresa.idEmpresa GROUP BY empresa.idEmpresa";

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
        // navegação fim

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Banco.CarregarDados(select, dgvEmpresa);
        }

        private void dgvEmpresa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEmpresa.Columns["ID"].Visible = false;
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idSelecionado = Convert.ToInt32(dgvEmpresa[0, e.RowIndex].Value);
            }catch{}
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadEmpresa("CADASTRAR").Show();
            Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                new frmCadEmpresa("ATUALIZAR", idSelecionado).Show();
                Hide();
            }
            else
            {
                picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                lblFeedback.Text = "Para atualizar os dados de uma empresa selecione uma linha.";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado >= 0)
            {
                Banco.ExcluirLinha("empresa", idSelecionado);
                Banco.CarregarDados(select, dgvEmpresa);

                idSelecionado = -1;

                picFeedback.Image = sys_bdourados.Properties.Resources.check;
                lblFeedback.Text = "Empresa excluída com sucesso!";
            }
            else
            {
                picFeedback.Image = sys_bdourados.Properties.Resources.exclamation;
                lblFeedback.Text = "Para excluir selecione uma linha.";
            }
        }
    }
}
