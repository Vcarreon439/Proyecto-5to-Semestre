using System.Data.SqlClient;

namespace DataAccess
{
    public class SQLConection
    {
        private readonly string conectionString;

        public SQLConection()
        {
            conectionString = $"Data Source=.\\SQLEXPRESS;Initial Catalog=Pruebas11_11;Integrated Security=True";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(conectionString);
        }
    }
}
