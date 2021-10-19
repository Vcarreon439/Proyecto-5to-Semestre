using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Elementos;

namespace DataAccess
{
    public class Querys : SQLConection
    {
        #region StoredProcedures

            #region Inserts

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

                            return (cmd.ExecuteNonQuery() > 0);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            throw;
                        }

                    }
                }
            }

            public bool AddTema(Tema temp)
            {
                using (SqlConnection conexion = getConnection())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("Insercion_Genero", conexion))
                    {
                        try
                        {
                            cmd.Connection = conexion;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@cod", temp.Codigo);
                            cmd.Parameters.AddWithValue("@tipo", temp.Nombre);

                            return (cmd.ExecuteNonQuery() > 0);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            return false;
                        }

                    }
                }
            }



        public bool AddBook(Book tempBook)
            {
                using (SqlConnection conexion = getConnection())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("AgregarLibro", conexion))
                    {
                        try
                        {
                            cmd.Connection = conexion;
                            cmd.CommandType = CommandType.StoredProcedure;

                            //El titulo nunca pueden ir vacios
                            cmd.Parameters.AddWithValue("@titulo", tempBook.Titulo);
                            cmd.Parameters.AddWithValue("@numEdicion", tempBook.numEdicion);
                            cmd.Parameters.AddWithValue("@copias", tempBook.Copias);

                            //Parametros opcionales

                            //ISBN
                            if (tempBook.ISBN == "" | tempBook.ISBN == null)
                                cmd.Parameters.AddWithValue("@isbn", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@isbn", tempBook.ISBN);

                            //Descripcion
                            if (tempBook.Descripcion == "" | tempBook.Descripcion == null)
                                cmd.Parameters.AddWithValue("@descripcion", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@descripcion", tempBook.Descripcion);


                        //codEditorial
                        if (tempBook.codEditorial == "" | tempBook.codEditorial == null)
                                cmd.Parameters.AddWithValue("@codEditorial", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@codEditorial", tempBook.codEditorial);

                            //numEdicion
                            if (tempBook.AñoEdicion == "")
                                cmd.Parameters.AddWithValue("@añoEdicion", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@añoEdicion", tempBook.AñoEdicion);

                            if (tempBook.Imagen == null)
                                cmd.Parameters.AddWithValue("@imagen", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@imagen", tempBook.Imagen);


                        return (cmd.ExecuteNonQuery() > 0);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            return false;
                        }
                    }
                }
            }

            #endregion

            #region Logins

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

        #endregion

        #region Views

        public List<LibroSencillo> MostrarPopulares()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Select * From MostrarPopulares", conexion))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                List<LibroSencillo> listaLibros = new List<LibroSencillo>();

                                while (reader.Read())
                                {
                                    LibroSencillo libro = new LibroSencillo();
                                    libro.Codigo = int.Parse(reader["Codigo"].ToString());
                                    libro.Descripcion = reader["Descripcion"].ToString();
                                    libro.Imagen = reader["Imagen"].ToString();
                                    libro.Titulo = reader["Titulo"].ToString();
                                    listaLibros.Add(libro);
                                }

                                return listaLibros;
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

        public List<EditorialSencillo> Editoriales()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Select * From EditorialesOrdenado100", conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                List<EditorialSencillo> listaEditorialesS = new List<EditorialSencillo>();

                                while (reader.Read())
                                {
                                    EditorialSencillo edit = new EditorialSencillo();
                                    edit.Codigo = reader["Codigo"].ToString();
                                    edit.Nombre = reader["Nombre"].ToString();
                                    listaEditorialesS.Add(edit);
                                }

                                return listaEditorialesS;
                            }
                            else
                                return null;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
            }

            return null;
        }

        #endregion


        public DataTable MostrarGeneros50()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("Select * From MostrarTemas", conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }
    }
}
