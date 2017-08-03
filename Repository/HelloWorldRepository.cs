using System.Data.SqlClient;
using System.Linq;
using Repository.Models;
using Dapper;
using IRepository;

namespace Repository
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        public string GetUserName(string id)
        {
            string connectString = "Data Source=.;Initial Catalog=DapperDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                var sql = "select * from [User] where Id=@id";
                var user = conn.Query<User>(sql, new { id = id }).First();

                return user.Name;
            }

        }
    }
}