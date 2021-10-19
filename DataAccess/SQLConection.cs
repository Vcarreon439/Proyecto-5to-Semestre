using System.Data.SqlClient;

namespace DataAccess
{
    public class SQLConection
    {
        private readonly string conectionString;

        public SQLConection()
        {
            conectionString = $"Data Source=DESKTOP-185RN13\\SQLEXPRESS;Initial Catalog=LibreriaBD;Integrated Security=True";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(conectionString);
        }
    }
}
