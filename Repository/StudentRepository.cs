using System.Data.SqlClient;
using System.Linq;
using Dapper;
using IRepository;
using Repository.Models;

namespace Repository
{
    class StudentRepository : IStudentRepository
    {
        public string GetName(int id)
        {
            string connectString = "Data Source=.;Initial Catalog=DapperDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                var sql = "select * from [Student] where Id=@id";
                var user = conn.Query<Student>(sql, new { id = id }).First();

                return user.Name;
            }

        }
    }
}
