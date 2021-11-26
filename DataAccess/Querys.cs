using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Elementos;
using Elementos.ElementosBiblioteca.Autor;
using Elementos.ElementosBiblioteca.Editorial;
using Elementos.ElementosBiblioteca.Libros;


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

        public FullUser GetLoggData(UserAcces temp)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("LogData", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Correo", temp.Correo);
                    cmd.Parameters.AddWithValue("@Contraseña", temp.Contraseña);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        FullUser retFullUser = new FullUser();

                        foreach (DataRow row in tabla.Rows)
                        {
                            retFullUser.Nombre = row["Nombre"].ToString();
                            retFullUser.Apellidos = row["Apellidos"].ToString();
                            retFullUser.Genero = row["Genero"].ToString();

                            string fec = row["FechaNac"].ToString();

                            if (fec!="")
                                retFullUser.FechaDateTime = DateTime.Parse(row["FechaNac"].ToString());

                            retFullUser.Entidad = row["EntFed"].ToString();
                            retFullUser.Domicilio = row["Domicilio"].ToString();
                            retFullUser.Situacion = row["Situacion"].ToString();
                            retFullUser.ImagenUsuario = row["Pic"].ToString();
                        }

                        return retFullUser;
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

        public bool UpdateDescripcionTema(string codigo, string ndescripcion)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateDescripcionTema", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Code", codigo);
                        cmd.Parameters.AddWithValue("@newDesc", ndescripcion);
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
            string valor;

            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("AddBook", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        //El titulo nunca pueden ir vacios
                        cmd.Parameters.AddWithValue("@Titulo", tempLibro.Titulo);

                        if (tempLibro.codEditorial == ""|tempLibro.codEditorial == null)
                            cmd.Parameters.AddWithValue("@codEditorial", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@codEditorial", tempLibro.codEditorial);

                        if (tempLibro.ISBN == "" | tempLibro.ISBN == null)
                            cmd.Parameters.AddWithValue("@ISBN", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@ISBN", tempLibro.ISBN);

                        if (tempLibro.numEdicion == -1 | tempLibro.numEdicion == null)
                            cmd.Parameters.AddWithValue("@numEdicion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@numEdicion", tempLibro.numEdicion);

                        if (tempLibro.Copias == -1 | tempLibro.Copias == null)
                            cmd.Parameters.AddWithValue("@copias", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@copias", tempLibro.Copias);

                        if (tempLibro.AñoEdicion == 0 | tempLibro.AñoEdicion == null)
                            cmd.Parameters.AddWithValue("@añoEdicion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@añoEdicion", tempLibro.AñoEdicion.ToString());

                        if (tempLibro.Descripcion==null| tempLibro.Descripcion=="")
                            cmd.Parameters.AddWithValue("@descripcion", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@descripcion", tempLibro.Descripcion);

                        if (tempLibro.Imagen == null | tempLibro.Imagen == "")
                            cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@foto", tempLibro.Imagen);

                        cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@codLibro", SqlDbType.Int).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        tempLibro.Codigo = int.Parse(cmd.Parameters["@codLibro"].Value.ToString());

                        if (Convert.ToBoolean(cmd.Parameters["@ret"].Value.ToString()))
                            InsertTemaLibro(tempLibro);
                        else
                            return false;

                        return Convert.ToBoolean(cmd.Parameters["@ret"].Value.ToString());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return false;
                    }
                }

                conexion.Close();
            }
        }

        #endregion

        #endregion

        private void InsertTemaLibro(Libro libro)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                foreach (Tema tem in libro.listaTemas)
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarTemaLibro", conexion))
                    {
                        try
                        {
                            cmd.Connection = conexion;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@codLibro", libro.Codigo);
                            cmd.Parameters.AddWithValue("@codTema", tem.Codigo);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }

                conexion.Close();
            }
        }


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

        public bool UpdateEditorial(FullEditorial oldEditorial, FullEditorial newEditorial)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("UpdatePublishers", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@oldCode", oldEditorial.Codigo);
                        cmd.Parameters.AddWithValue("@newCode", newEditorial.Codigo);

                        cmd.Parameters.AddWithValue("@newName", newEditorial.Nombre);
                        cmd.Parameters.AddWithValue("@newPhone", newEditorial.Telefono);
                        cmd.Parameters.AddWithValue("@newMail", newEditorial.Correo);
                        cmd.Parameters.AddWithValue("@newAddress", newEditorial.Direccion);

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
        
        
        public bool UpdatePublishersWithotCode(string codigo, FullEditorial newEditorial)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("UpdatePublishersWithotCode", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Code", codigo);

                        cmd.Parameters.AddWithValue("@newName", newEditorial.Nombre);
                        cmd.Parameters.AddWithValue("@newPhone", newEditorial.Telefono);
                        cmd.Parameters.AddWithValue("@newMail", newEditorial.Correo);
                        cmd.Parameters.AddWithValue("@newAddress", newEditorial.Direccion);

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

        public bool DeletePublisher(FullEditorial editorial)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("DeletePublisher", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Code", editorial.Codigo);
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

        public bool AddAuthor(FullAutor autor)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("AddAuthor", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", autor.Nombre);

                        //Apellidos
                        if (autor.Apellido == "" | autor.Apellido == null)
                            cmd.Parameters.AddWithValue("@Apellidos", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Apellidos", autor.Apellido);

                        //Pais
                        if (autor.pais == "" | autor.pais == null)
                            cmd.Parameters.AddWithValue("@pais", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@pais", autor.pais);

                        //Ciudad
                        if (autor.ciudad == "" | autor.ciudad == null)
                            cmd.Parameters.AddWithValue("@ciudad", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@ciudad", autor.ciudad);

                        //Comentarios
                        if (autor.comentarios == "" | autor.comentarios == null)
                            cmd.Parameters.AddWithValue("@coment", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@coment", autor.comentarios);


                        //Foto
                        if (autor.foto == "" | autor.foto == null)
                            cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@foto", autor.foto);


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

        public DataTable AutoresTabla()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlDataAdapter adaptador = new SqlDataAdapter("Select * From AutoresTabla", conexion))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        public DataTable TakeExtraDataAutor(string codigo)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("TakeExtraDataAutor", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@code", codigo);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }

        public bool UpdateAutor(FullAutor autor)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateAutor", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@code", autor.Codigo);

                        cmd.Parameters.AddWithValue("@newName", autor.Nombre);
                        cmd.Parameters.AddWithValue("@newSecond", autor.Apellido);
                        cmd.Parameters.AddWithValue("@newCountry", autor.pais);
                        cmd.Parameters.AddWithValue("@newCity", autor.ciudad);
                        cmd.Parameters.AddWithValue("@newComments", autor.comentarios);
                        cmd.Parameters.AddWithValue("@newFoto", autor.foto);


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

        public bool DeleteAutor(string codigo)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("DeleteAutor", conexion))
                {
                    try
                    {
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
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

        public List<Tema> ListarTemas(int start, int end)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("ListarTemas", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@inicio", start);
                    cmd.Parameters.AddWithValue("@final", end);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                List<Tema> listaTemas = new List<Tema>();

                                while (reader.Read())
                                    listaTemas.Add(new Tema(reader["Codigo"].ToString(), reader["Descripcion"].ToString()));

                                return listaTemas;
                            }
                            else
                                return null;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            Console.WriteLine(e);
                        }
                    }
                }
            }

            return null;
        }

        public List<EditorialSencillo> LoadEditoriales()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Select Codigo, Nombre from MostrarEditoriales", conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                List<EditorialSencillo> editoriales = new List<EditorialSencillo>();

                                while (reader.Read())
                                    editoriales.Add(new EditorialSencillo(reader["Codigo"].ToString(), reader["Nombre"].ToString()));

                                return editoriales;
                            }
                            else
                                return null;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }

            return null;
        }

        public List<Tema> LoadTemas()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Select * from ShowAllTopics", conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                List<Tema> topics = new List<Tema>();

                                while (reader.Read())
                                    topics.Add(new Tema(reader["Codigo"].ToString(), reader["Descripcion"].ToString()));

                                return topics;
                            }
                            else
                                return null;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }

            return null;
        }
        
        public List<AutorSimple> LoadAutores()
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("Select Codigo, Nombre, Apellido from AutoresTabla", conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                List<AutorSimple> autores = new List<AutorSimple>();

                                while (reader.Read())
                                    autores.Add(new AutorSimple(reader["Codigo"].ToString(), reader["Nombre"].ToString(), reader["Apellido"].ToString()));

                                return autores;
                            }
                            else
                                return null;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }
            return null;
        }

        public LibroVista GetBookView(int codigo)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("GetBookView", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        LibroVista retBook = new LibroVista(codigo);

                        foreach (DataRow row in tabla.Rows)
                        {
                            retBook.Titulo = row["Titulo"].ToString();
                            retBook.ISBN = row["ISBN"].ToString();
                            retBook.numEdicion = int.Parse(row["numeroEdicion"].ToString());
                            retBook.Editorial = row["Editorial"].ToString();
                            retBook.añoEdicion = int.Parse(row["añoEdicion"].ToString());
                            retBook.imagenLibro = row["Imagen"].ToString();
                            retBook.descripcion = row["Descripcion"].ToString();
                        }

                        return retBook;
                    }
                }
            }
        }

        public List<Tema> GetBookTopics(int codigo)
        {
            using (SqlConnection conexion = getConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("GetBookTopics", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        List<Tema> temas = new List<Tema>();

                        foreach (DataRow row in tabla.Rows)
                            temas.Add(new Tema(row["Codigo"].ToString(), row["Descripcion"].ToString()));

                        return temas;
                    }
                }
            }
        }

        //public bool NewPrestamo()
        //{
        //    string valor;

        //    using (SqlConnection conexion = getConnection())
        //    {
        //        conexion.Open();

        //        using (SqlCommand cmd = new SqlCommand("AddBook", conexion))
        //        {
        //            try
        //            {
        //                cmd.Connection = conexion;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                //El titulo nunca pueden ir vacios
        //                cmd.Parameters.AddWithValue("@Titulo", tempLibro.Titulo);

        //                if (tempLibro.codEditorial == "" | tempLibro.codEditorial == null)
        //                    cmd.Parameters.AddWithValue("@codEditorial", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@codEditorial", tempLibro.codEditorial);

        //                if (tempLibro.ISBN == "" | tempLibro.ISBN == null)
        //                    cmd.Parameters.AddWithValue("@ISBN", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@ISBN", tempLibro.ISBN);

        //                if (tempLibro.numEdicion == -1 | tempLibro.numEdicion == null)
        //                    cmd.Parameters.AddWithValue("@numEdicion", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@numEdicion", tempLibro.numEdicion);

        //                if (tempLibro.Copias == -1 | tempLibro.Copias == null)
        //                    cmd.Parameters.AddWithValue("@copias", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@copias", tempLibro.Copias);

        //                if (tempLibro.AñoEdicion == 0 | tempLibro.AñoEdicion == null)
        //                    cmd.Parameters.AddWithValue("@añoEdicion", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@añoEdicion", tempLibro.AñoEdicion.ToString());

        //                if (tempLibro.Descripcion == null | tempLibro.Descripcion == "")
        //                    cmd.Parameters.AddWithValue("@descripcion", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@descripcion", tempLibro.Descripcion);

        //                if (tempLibro.Imagen == null | tempLibro.Imagen == "")
        //                    cmd.Parameters.AddWithValue("@foto", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@foto", tempLibro.Imagen);

        //                cmd.Parameters.Add("@ret", SqlDbType.Bit).Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@codLibro", SqlDbType.Int).Direction = ParameterDirection.Output;

        //                cmd.ExecuteNonQuery();
        //                tempLibro.Codigo = int.Parse(cmd.Parameters["@codLibro"].Value.ToString());

        //                if (Convert.ToBoolean(cmd.Parameters["@ret"].Value.ToString()))
        //                    InsertTemaLibro(tempLibro);
        //                else
        //                    return false;

        //                return Convert.ToBoolean(cmd.Parameters["@ret"].Value.ToString());
        //            }
        //            catch (Exception e)
        //            {
        //                MessageBox.Show(e.Message);
        //                return false;
        //            }
        //        }

        //        conexion.Close();
        //    }
        //}

    }
}


