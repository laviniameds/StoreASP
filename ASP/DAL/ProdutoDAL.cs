using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.DAL
{
    public class ProdutoDAL
    {
        string connectionString = "";

        public ProdutoDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["StoreAppConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produto> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Produto c;
            // Cria Lista Vazia
            List<Modelo.Produto> aListProduto = new List<Modelo.Produto>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Produto";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    c = new Modelo.Produto(
                        Convert.ToInt32(dr["Id"]),
                        dr["Descricao"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    aListProduto.Add(c);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListProduto;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produto> Select(string Id)
        {
            // Variavel para armazenar um livro
            Modelo.Produto c;
            // Cria Lista Vazia
            List<Modelo.Produto> aListProduto = new List<Modelo.Produto>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Produto where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    c = new Modelo.Produto(
                        Convert.ToInt32(dr["Id"]),
                        dr["Descricao"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    aListProduto.Add(c);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListProduto;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Produto obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Produto WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);

            // Executa Comando
            //cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Produto obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Produto (Id, Descricao) VALUES (@Id, @Descricao)", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Produto obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Produto SET Descricao = @Descricao  WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}