using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_bdourados
{
    public static class Feedback
    {
        public static void at(Label lbl, PictureBox pic, string caso, string mensagem = "")
        {
            lbl.Text = mensagem;

            if (mensagem == "")
            {
                mensagem = "Fique ligado, aqui você receberá dicas de como usar o sistema com eficiência ;)";
            }

            switch (caso)
            {
                case "info":
                    pic.Image = sys_bdourados.Properties.Resources.info;
                    break;

                case "check":
                    pic.Image = sys_bdourados.Properties.Resources.check;
                    break;

                case "aviso":
                    pic.Image = sys_bdourados.Properties.Resources.exclamation;
                    break;

                case "erro":
                    pic.Image = sys_bdourados.Properties.Resources.error;
                    break;
            }
        }
        public static void tab(Label lbl, PictureBox picFeedback, PictureBox tab1, PictureBox tab2, PictureBox shift, bool on = true)
        {
            if (on == true)
            {
                lbl.Text = "Para alternar ao próximo campo, pressione Tab       em seu teclado; e para o campo anterior, pressione Tab       + Shift";
                picFeedback.Image = sys_bdourados.Properties.Resources.info;

                tab1.Visible = true;
                tab2.Visible = true;
                shift.Visible = true;
            }
            else
            {
                tab1.Visible = false;
                tab2.Visible = false;
                shift.Visible = false;
            }
        }
    }
}
