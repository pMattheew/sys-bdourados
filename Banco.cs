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
        public static MySqlConnection Conexao = new MySqlConnection("SERVER=localhost;USER=root;DATABASE=id19036169_bdouradosdb");

        // Conexao.Open(); abre o banco de dados
        // Conexao.Close(); fecha o banco de dados

        public static void CarregarDados(string query, DataGridView dgv)
        {
            try
            {
                Conexao.Open();

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

        public static void ExcluirLinha(string tabela, int linha)
        {
            try
            {
                Conexao.Open();

                // concatena a inicial maiúscula com o resto da string (E + mpresa = dgvEmpresa) #
                string coluna = char.ToUpper(tabela[0]) + tabela.Substring(1); //#

                //  empresa............idEmpresa........codEmpresa
                string query = "DELETE FROM " + tabela + " WHERE id" + coluna + "=@" + linha.ToString();

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.AddWithValue("@" + linha.ToString(), linha); // declara a variável do SQL com o valor armazenado no objeto Variaveis do sistema (codEmpresa).

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                DataGridView dataGridView = new DataGridView(); //#

                dataGridView.Name = "dgv" + coluna;

                dataGridView.DataSource = dt;
                dataGridView.ClearSelection();

                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir campo: \n\n" + ex.Message);
            }
        }
    }
}
