using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionArticle.Models;


namespace Services;


public class ArticleService
{

    public static int AddArticle(Article f)
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.ConnectionString = @"Data Source=FAUCON;Initial Catalog=GestionArticles;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "InsertArticle";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Name", f.Name);
                command.Parameters.AddWithValue("Price", f.Price);
                command.Parameters.AddWithValue("Ean", f.EAN13);
                command.Parameters.AddWithValue("Description", f.Description);
                connection.Open();
                int Id = (int)command.ExecuteScalar();
                return Id;
            }
        }
    }

    public static void EditArticle(Article f)
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.ConnectionString = @"Data Source=FAUCON;Initial Catalog=GestionArticles;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "EditArticle";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Name", f.Name);
                command.Parameters.AddWithValue("Price", f.Price);
                command.Parameters.AddWithValue("Ean", f.EAN13);
                command.Parameters.AddWithValue("Description", f.Description);
                connection.Open();
                int Id = (int)command.ExecuteScalar();
            }
        }
    }
    public static IEnumerable<Article> AllArticles()
    {
        using (SqlConnection connection = new SqlConnection())
        {
            connection.ConnectionString = @"Data Source=FAUCON;Initial Catalog=GestionArticles;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

            using (SqlCommand command = connection.CreateCommand())
            {

                connection.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article article = new Article();

                        article.Name = reader["Name"].ToString();
                        article.Id = (int)reader["Id"];
                        article.Description = reader["Description"].ToString();
                        article.Price = (double)reader["Price"];
                        article.EAN13 = reader["EAN13"].ToString();

                        yield return article;
                    }
                }      
            }
        }
    }
}

