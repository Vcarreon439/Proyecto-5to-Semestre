using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Elementos;

namespace DataAccess
{
    public class Querys : SQLConection
    {
        #region StoredProcedures

        public bool RegisterNew(UsuarioTemp temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("RegistroNormal", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@nombre", temp.Nombre);
                        cmd.Parameters.AddWithValue("@apellidos", temp.Apellidos);
                        cmd.Parameters.AddWithValue("@correo", temp.Correo);
                        cmd.Parameters.AddWithValue("@contraseña", temp.Contraseña);

                        return(cmd.ExecuteNonQuery() > 0);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        throw;
                    }

                }
            }
        }

        public FullUser LoginUser(UsuarioTemp temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("IniciarSesion", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@correo", temp.Correo);
                        cmd.Parameters.AddWithValue("@contraseña", temp.Contraseña);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FullUser retorno = new FullUser();
                                retorno.Nombre = reader["Nombre"].ToString();
                                retorno.Apellidos = reader["Apellidos"].ToString();
                                retorno.Correo = reader["Correo"].ToString();
                                retorno.Entidad = reader["EntidadFederativa"].ToString();
                                retorno.Genero = reader["Genero"].ToString();
                                return retorno;
                            }
                            else
                                return null;
                            
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }
            }
        }

        #endregion

        #region Views



        #endregion

    }
}
