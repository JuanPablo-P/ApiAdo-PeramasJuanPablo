using IntegrandoAA.Model;
using System.Data.SqlClient;

namespace IntegrandoAA.Repository
{

    public static class VentaHandler
    {
        public const string ConnectionString = "Server=DESKTOP-8O5C5B1;" +
            "Database=SistemaGestion;" +
            "Trusted_Connection=True";
        

        public static List<Venta> GetVentas()
        {
            List<Venta> resultados = new List<Venta>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))

            {
                var queryInstert = "INSERT into venta (Id, Comentarios) values (7,'algo'); select @@IDENTITY";
                sqlConnection.Open();

                double IdNuevo = 0;

                using (SqlCommand comandoInsert = new SqlCommand(queryInstert, connection))
                {
                    IdNuevo =Convert.ToInt64(comandoInsert.ExecuteScalar());
                }
                connection.Close();
                

            }
            return resultados;
        }
    }
}
