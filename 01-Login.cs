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
    public partial class frmLogin : Form
    {
        bool email = true;
        public class Login
        {
            public string email { get; set; }
            public string senha { get; set; }
        }

        Login login = new Login();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
           if(input.Text == "")
            {
                lblAviso.Text = "Insira um email válido";
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (email)
            {
                login.email = input.Text;

                input.Clear();

                lblInput.Text = "Senha:";
                input.PasswordChar = '*';
                btnAvancar.Text = "Acessar";

                email = false;
            }
            else if (!email)
            {
                Banco.FazerLogin(login, frmLogin);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new frmPainel().Show();
            Hide();
        }
    }
}
