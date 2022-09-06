using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_bdourados
{
    class Banco
    {
        static MySqlConnection Conexao = new MySqlConnection("SERVER=localhost;USER=root;DATABASE=id19036169_bdouradosdb");

        // Conexao.Open(); abre o banco de dados
        // Conexao.Close(); fecha o banco de dados

        public static void CarregarDados(string tabela, DataGridView dgv)
        {
            try
            {
                Conexao.Open();

                string query = "SELECT * FROM " + tabela;

                MySqlCommand cmd = new MySqlCommand(query, Conexao);  // gera a query

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);  // adapta os dados da query

                DataTable dt = new DataTable(); // cria uma nova instância de tabela de dados

                da.Fill(dt); // enche a DataTable com os dados adaptados do banco de dados


                dgv.DataSource = dt;
                dgv.ClearSelection();

                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer consulta: \n\n" + ex);
            }
        }
    }
}
