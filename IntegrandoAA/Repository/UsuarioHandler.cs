using IntegrandoAA.Model;
using System.Data.SqlClient;

namespace IntegrandoAA.Repository
{
    public static class UsuarioHandler
    {
        public const string ConnectionString = "Server=DESKTOP-8O5C5B1;" +
            "Database=SistemaGestion;" +
            "Trusted_Connection=True";
        public static List<Usuario> GetUsuarios()
        {
            List<Usuario> resultados = new List<Usuario>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))

            { using (SqlCommand sqlCommand = new SqlCommand("UPDATE usuario" +
                "SET Nombre = Tobias" +
                " Apellido= Casazza " +
                "NombreUsuario = tcasazza22 " +
                "Contraseña= SoyTobiasCasazza " +
                "Mail = tobias.casazza@gmail.com " +
                "WHERE Id = 1",
                sqlConnection))

                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        if (dataReader.HasRows)
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();

                                resultados.Add(usuario);
                            }
                }

            }
           return resultados;
        }
        

    }
}
