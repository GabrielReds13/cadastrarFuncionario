using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarFuncionario.Classes
{
    public static class Banco
    {
        // - Metodos -
        public static void Inserir(Funcionario f)
        {

            try
            {
                Conexao sql = new Conexao();
                var insert = sql.Comando("insert into Funcionario (" +
                    // Atributos
                    "id_fun, " +
                    "nome_fun, " +
                    "data_nasc_fun, " +
                    "sexo_fun, " +
                    "cpf_fun, " +
                    "rg_fun, " +
                    "estado_civil_fun, " +
                    "telefone_fun, " +
                    "email_fun, " +
                    "funcao_fun) " +
                    
                    // Valores
                    "values (" +
                    "@id, " +
                    "@nome, " +
                    "@data_nasc, " +
                    "@sexo, " +
                    "@cpf, " +
                    "@rg, " +
                    "@estado_civil, " +
                    "@telefone, " +
                    "@email, " +
                    "@funcao);");

                // Definir valores
                insert.Parameters.AddWithValue("@id", f.Id);
                insert.Parameters.AddWithValue("@nome", f.Nome);
                insert.Parameters.AddWithValue("@data_nasc", f.DataNasc);
                insert.Parameters.AddWithValue("@sexo", f.Sexo);
                insert.Parameters.AddWithValue("@cpf", f.Cpf);
                insert.Parameters.AddWithValue("@rg", f.Rg);
                insert.Parameters.AddWithValue("@estado_civil", f.EstadoCivil);
                insert.Parameters.AddWithValue("@telefone", f.Telefone);
                insert.Parameters.AddWithValue("@email", f.Email);
                insert.Parameters.AddWithValue("@funcao", f.Funcao);

                // Adicionar no banco
                var resultado = insert.ExecuteNonQuery();

                if (resultado > 0) MessageBox.Show("Funcinário cadastrado com êxito.");
                else MessageBox.Show("Erro ao cadastrar funcionário.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string[] Consultar()
        {
            try
            {
                Conexao sql = new Conexao();
                var select = sql.Comando("select * from Funcionario");
                var leitor = select.ExecuteReader();

                List<string> lista = new List<string>();

                while(leitor.Read()) lista.Add($"NOME: {leitor.GetString("nome_fun")}; SEXO: {leitor.GetString("sexo_fun")}; DATA NASC: {leitor.GetDateTime("data_nasc_fun").Date}; FUNÇÃO: {leitor.GetString("funcao_fun")};");

                return lista.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
