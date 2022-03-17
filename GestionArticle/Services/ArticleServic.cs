using GestionArticle.Models;
using System.Data.SqlClient;
using System.Data;


namespace GestionArticle.Services
{
    


    public class ArticleServic
    {

        public static int AddArticle(Article f)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=FAUCON;Initial Catalog=GestionArticles;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            
                using(SqlCommand command = connection.CreateCommand())
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

    }
}
