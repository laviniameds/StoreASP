using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.DAL
{
    public class FornecedorDAL
    {
        string connectionString = "";

        public FornecedorDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StoreAppConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Fornecedor> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Fornecedor c;
            // Cria Lista Vazia
            List<Modelo.Fornecedor> aListFornecedor = new List<Modelo.Fornecedor>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Fornecedor";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    c = new Modelo.Fornecedor(
                        Convert.ToInt32(dr["Id"]),
                        dr["Descricao"].ToString(),
                        dr["Telefone"].ToString(),
                        dr["Cidade"].ToString(),
                        dr["Estado"].ToString(),
                        dr["Endereco"].ToString(),
                        dr["CpfCnpj"].ToString(),
                        Convert.ToBoolean(dr["Pessoa"]),
                        dr["Email"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    aListFornecedor.Add(c);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListFornecedor;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Fornecedor> Select(string Id)
        {
            // Variavel para armazenar um livro
            Modelo.Fornecedor c;
            // Cria Lista Vazia
            List<Modelo.Fornecedor> aListFornecedor = new List<Modelo.Fornecedor>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Fornecedor where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    c = new Modelo.Fornecedor(
                        Convert.ToInt32(dr["Id"]),
                        dr["Descricao"].ToString(),
                        dr["Telefone"].ToString(),
                        dr["Cidade"].ToString(),
                        dr["Estado"].ToString(),
                        dr["Endereco"].ToString(),
                        dr["CpfCnpj"].ToString(),
                        Convert.ToBoolean(dr["Pessoa"]),
                        dr["Email"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    aListFornecedor.Add(c);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListFornecedor;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Fornecedor obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedor WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);

            // Executa Comando
            //cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Fornecedor obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedor (Id, Descricao, Telefone, Cidade, Estado, Endereco, CpfCnpj, Pessoa, Email) VALUES (@Id, @Descricao, @Telefone, @Cidade, @Estado, @Endereco, @CpfCnpj, @Pessoa, @Email)", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);
            cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
            cmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);
            cmd.Parameters.AddWithValue("@CpfCnpj", obj.CpfCnpj);
            cmd.Parameters.AddWithValue("@Pessoa", obj.Pessoa);
            cmd.Parameters.AddWithValue("@Email", obj.Email);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Fornecedor obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Fornecedor SET Descricao = @Descricao, Telefone = @Telefone, Cidade = @Cidade, Estado = @Estado, Endereco = @Endereco, CpfCnpj = @CpfCnpj, Pessoa = @Pessoa, Email = @Email  WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);
            cmd.Parameters.AddWithValue("@Telefone", obj.Telefone);
            cmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);
            cmd.Parameters.AddWithValue("@CpfCnpj", obj.CpfCnpj);
            cmd.Parameters.AddWithValue("@Pessoa", obj.Pessoa);
            cmd.Parameters.AddWithValue("@Email", obj.Email);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}