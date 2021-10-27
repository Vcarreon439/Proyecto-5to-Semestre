using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Elementos;
using Elementos.ElementosBiblioteca.Editorial;


namespace DataAccess
{
    public class Querys : SQLConection
    {
        #region StoredProcedures

        #region IniciarSesion

        public TipoUsuario.NivelAutorizacion LoginUser(UserAcces temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Loggeo", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Correo", temp.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", temp.Contraseña);
                        cmd.Parameters.Add("@level", SqlDbType.VarChar, Int32.MaxValue).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        return TipoUsuario.ConvertirNivelAutorizacion(cmd.Parameters["@level"].Value.ToString());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return TipoUsuario.NivelAutorizacion.Invitado;
                    }
                }
            }
        }

        #endregion

        #region Editorial

        #endregion

        #region Inserts

        #region NewUser

        public bool NewUser(UsuarioTemp temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("NewUser", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", temp.Nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", temp.Apellidos);
                        cmd.Parameters.AddWithValue("@Correo", temp.Correo);
                        cmd.Parameters.AddWithValue("@Contraseña", temp.Contraseña);
                        cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();

                        return Convert.ToBoolean(int.Parse(cmd.Parameters["@ret"].Value.ToString()));
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

        #endregion

        #region Tema

        #region AddTema

        public bool AddTema(Tema temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("AddTema", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", temp.Codigo);
                        cmd.Parameters.AddWithValue("@Descripcion", temp.Descripcion);
                        cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        return Convert.ToBoolean(int.Parse(cmd.Parameters["@ret"].Value.ToString())); ;
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

        #region UpdateTema

        public bool UpdateTema(Tema topic, string newCode, string newDesc)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateTema", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@oldCode", topic.Codigo);
                        cmd.Parameters.AddWithValue("@oldDesc", topic.Descripcion);
                        cmd.Parameters.AddWithValue("@newCode", newCode);
                        cmd.Parameters.AddWithValue("@newDesc", newDesc);
                        cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();

                        return Convert.ToBoolean(int.Parse(cmd.Parameters["@ret"].Value.ToString()));
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

        #region DeleteTema

        public bool DeleteTema(Tema temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("DeleteTema", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", temp.Codigo);
                        cmd.Parameters.AddWithValue("@Descripcion", temp.Descripcion);
                        cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        return Convert.ToBoolean(int.Parse(cmd.Parameters["@ret"].Value.ToString())); ;
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


        #endregion

        #region Book

        public bool AddBook(Libro tempLibro)
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
                        cmd.Parameters.AddWithValue("@titulo", tempLibro.Titulo);
                        cmd.Parameters.AddWithValue("@numEdicion", tempLibro.numEdicion);
                        cmd.Parameters.AddWithValue("@copias", tempLibro.Copias);

                        //Parametros opcionales

                        //ISBN
                        if (tempLibro.ISBN == "" | tempLibro.ISBN == null)
                            cmd.Parameters.AddWithValue("@isbn", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@isbn", tempLibro.ISBN);

                        //Descripcion
                        if (tempLibro.Descripcion == "" | tempLibro.Descripcion == null)
                            cmd.Parameters.AddWithValue("@descripcion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@descripcion", tempLibro.Descripcion);


                        //codEditorial
                        if (tempLibro.codEditorial == "" | tempLibro.codEditorial == null)
                            cmd.Parameters.AddWithValue("@codEditorial", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@codEditorial", tempLibro.codEditorial);

                        //numEdicion
                        if (tempLibro.AñoEdicion == "")
                            cmd.Parameters.AddWithValue("@añoEdicion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@añoEdicion", tempLibro.AñoEdicion);

                        if (tempLibro.Imagen == null)
                            cmd.Parameters.AddWithValue("@imagen", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@imagen", tempLibro.Imagen);


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

        #endregion

        #region Views

        public DataTable ShowAllTopics()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("Select * From ShowAllTopics", conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public List<LibroSencillo> LibrosPopulares_4()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Select * From LibrosPopulares_4", conexion))
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
                                    edit.Nombre = reader["Descripcion"].ToString();
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

        public bool AddEditorial(FullEditorial publisher)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("AddEditorial", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Codigo", publisher.Codigo);
                        cmd.Parameters.AddWithValue("@Nombre", publisher.Nombre);
                        cmd.Parameters.AddWithValue("@Telefono", publisher.Telefono);
                        cmd.Parameters.AddWithValue("@Correo", publisher.Correo);
                        cmd.Parameters.AddWithValue("@Direccion", publisher.Direccion);

                        cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();
                        return Convert.ToBoolean(int.Parse(cmd.Parameters["@ret"].Value.ToString())); ;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return false;
                    }

                }
            }
        }

        public DataTable MostrarEditoriales()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("Select * From MostrarEditoriales", conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }
    }
}

