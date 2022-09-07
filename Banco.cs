using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
                Conexao.Close();
            }
        }

        public static object CarregarDadosObjeto(string tabela, object objeto)
        {
            try
            {
                Conexao.Open();

                int i = 0;

                string nome = char.ToUpper(tabela[0]) + tabela.Substring(1);

                // key:value do ID do objeto
                string chave = objeto.GetType().GetProperty("id"+nome).Name;
                object valor = objeto.GetType().GetProperty("id" + nome).GetValue(objeto);

                string query = "SELECT * FROM " + tabela + " WHERE " + chave + "=@" + chave;

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.AddWithValue("@" + chave, valor);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                PropertyInfo[] propriedades = objeto.GetType().GetProperties();


                foreach (var prop in propriedades)
                {
                    // checa se é um horário e remove os segundos
                    if (reader.GetString(i).Contains(":00"))
                    {
                        string hr = reader.GetString(i);
                        prop.SetValue(objeto, hr.Remove(hr.Length - 3));
                        i++;
                    }
                    else
                    {
                        prop.SetValue(objeto, reader.GetString(i));
                        i++;
                    }
                }

                Conexao.Close();

                return objeto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: \n\n" + ex);
                Conexao.Close();
                return objeto;
            }
        }

        public static void AtualizarDadosObjeto(string tabela, object objeto)
        {
            try
            {
                Conexao.Open();

                string nome = char.ToUpper(tabela[0]) + tabela.Substring(1);

                // método que concatena as chaves e valores do update
                string Concatenar()
                {
                    string resultado = "";

                    foreach (var prop in objeto.GetType().GetProperties())
                    {
                        // pular id e data de cadastro
                        if (prop.Name.Remove(2) == "id" || prop.Name.Contains("dataCad"))
                        {}
                        else
                        {
                            resultado += (prop.Name + "=@" + prop.Name + ",");
                        }
                    }

                    resultado = resultado.Remove(resultado.Length - 1);

                    return resultado;
                }

                string update = "UPDATE " + tabela + " SET " + Concatenar() + " WHERE id" + nome + "=@" + "id"+ nome;

                MySqlCommand cmd = new MySqlCommand(update, Conexao);

                // repetição para dar valor aos parâmetros do update
                foreach (var prop in objeto.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(objeto));
                }

                cmd.ExecuteNonQuery();

                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: \n\n" + ex);
                Conexao.Close();
            }

        }

        public static void ExcluirLinha(string tabela, int id)
        {
            try
            {
                Conexao.Open();

                // concatena a inicial maiúscula com o resto da string (E + mpresa = dgvEmpresa) #
                string coluna = char.ToUpper(tabela[0]) + tabela.Substring(1); //#

                //  empresa............idEmpresa........codEmpresa
                string query = "DELETE FROM " + tabela + " WHERE id" + coluna + "=@id" + coluna;

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                cmd.Parameters.AddWithValue("@id" + coluna, id); // declara a variável do SQL com o valor armazenado no objeto Variaveis do sistema (codEmpresa).

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
                Conexao.Close();
            }
        }

        public static void InserirLinha(string tabela, object objeto)
        {
            try
            {

                Conexao.Open();

                string nome = char.ToUpper(tabela[0]) + tabela.Substring(1);

                // método que concatena as chaves e valores do insert
                string Concatenar(bool valor)
                {
                    string resultado = "";
                    string concatenarArroba = valor ? ",@" : ",";
                    int caracterFinal = valor ? 2 : 1;

                    foreach (var prop in objeto.GetType().GetProperties())
                    {
                        resultado += (prop.Name + concatenarArroba);
                    }

                    resultado = resultado.Remove(resultado.Length - caracterFinal);

                    return resultado;
                }

                string insert = "INSERT INTO " + tabela + "(" + Concatenar(false) + ")VALUES(" + Concatenar(true) + ")";

                MySqlCommand cmd = new MySqlCommand(insert, Conexao);

                // repetição para dar valor aos parâmetros do insert
                foreach (var prop in objeto.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(objeto));
                }

                cmd.ExecuteNonQuery();

                Conexao.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar: \n\n" + ex);
                Conexao.Close();
            }
        }
    }
}
