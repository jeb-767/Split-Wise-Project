using Split_Wise_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Win32;

namespace Split_Wise_Project.DataAcces
{
    public class DataAccess
    {
        private string connectionString = "Server=localhost;Database=splitwise;User ID=root;";
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> lista_objetos = new List<Usuario>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM usuarios";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario varObjeto = new Usuario()
                        {
                            ID = reader.GetInt32("idUsuarios"),
                            Nombre = reader.GetString("Nombre"),
                            Apellidos = reader.GetString("Apellidos"),
                            Descripcion = reader.GetString("Descripcion"),
                            Correo = reader.GetString("Correo"),
                            Telefono = reader.GetInt32("Telefono"),
                            Foto = reader.GetString("Foto")
                        };
                        lista_objetos.Add(varObjeto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
            return lista_objetos;
        }

        public List<Grupo> GetGrupos()
        {
            List<Grupo> lista_objetos = new List<Grupo>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM grupos";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Grupo varObjeto = new Grupo()
                        {
                            ID = reader.GetInt32("idGrupos"),
                            Nombre = reader.GetString("Nombre"),
                            Descripcion = reader.GetString("Descripcion"),
                            Foto = reader.GetString("Foto"),
                            Estado = reader.GetString("Estado"),
                        };
                        lista_objetos.Add(varObjeto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
            return lista_objetos;
        }

        public List<Gasto> GetGastos()
        {
            List<Gasto> lista_objetos = new List<Gasto>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM splitwise.usuarios_has_gastos";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Gasto varObjeto = new Gasto()
                        {
                            ID = reader.GetInt32("ID_Gasto"),
                            usuario = reader.GetInt32("Usuarios_idUsuarios"),
                            grupo = reader.GetInt32("Grupos_idGrupos"),
                            Cantidad = reader.GetFloat("Cantidad"),
                            Nombre = reader.GetString("Nombre"),
                            Estado = reader.GetString("Estado"),
                        };
                        lista_objetos.Add(varObjeto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
            return lista_objetos;
        }

        public List<Usuario> GetAmigos(int ID)
        {
            List<Usuario> Amigos = new List<Usuario>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM amigos join usuarios on Usuarios_idAmigo = usuarios.idUsuarios where Usuarios_idUsuarios = @id ;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario varObjeto = new Usuario()
                        {
                            ID = reader.GetInt32("idUsuarios"),
                            Nombre = reader.GetString("Nombre"),
                            Apellidos = reader.GetString("Apellidos"),
                            Descripcion = reader.GetString("Descripcion"),
                            Correo = reader.GetString("Correo"),
                            Telefono = reader.GetInt32("Telefono"),
                            Foto = reader.GetString("Foto")
                        };
                        Amigos.Add(varObjeto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
            return Amigos;
        }

        public List<Usuario> GetMiembros(int ID)
        {
            List<Usuario> Miembros = new List<Usuario>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM usuarios_has_grupos join usuarios on Usuarios_idUsuarios = usuarios.idUsuarios WHERE Grupos_idGrupos = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario varObjeto = new Usuario()
                        {
                            ID = reader.GetInt32("idUsuarios"),
                            Nombre = reader.GetString("Nombre"),
                            Apellidos = reader.GetString("Apellidos"),
                            Descripcion = reader.GetString("Descripcion"),
                            Correo = reader.GetString("Correo"),
                            Telefono = reader.GetInt32("Telefono"),
                            Foto = reader.GetString("Foto")
                        };
                        Miembros.Add(varObjeto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
            return Miembros;
        }

        public List<Registro> GetRegistros(int ID)
        {
            List<Registro> Registros = new List<Registro>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM splitwise.registros;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Registro varObjeto = new Registro()
                        {
                            ID = reader.GetInt32("ID_Registro"),
                            Gasto = reader.GetInt32("ID_Gasto"),
                            Accion = reader.GetString("Accion")
                        };
                        Registros.Add(varObjeto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
            return Registros;
        }

        public void AddAmigo(Usuario Original, string Email_Amigo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * FROM splitwise.usuarios WHERE Correo = @correo;";
                    string query_delete = "DELETE FROM splitwise.amigos where Usuarios_idUsuarios = '1' and Usuarios_idAmigo = '2';";
                    MySqlCommand command = new MySqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@correo", Email_Amigo);
                    command.Parameters.AddWithValue("@id", Original.ID);
                    MySqlDataReader reader = command.ExecuteReader();
                    Usuario varObjeto = new Usuario();
                    while (reader.Read())
                    {
                        varObjeto = new Usuario()
                        {
                            ID = reader.GetInt32("idUsuarios"),
                            Nombre = reader.GetString("Nombre"),
                            Apellidos = reader.GetString("Apellidos"),
                            Descripcion = reader.GetString("Descripcion"),
                            Correo = reader.GetString("Correo"),
                            Telefono = reader.GetInt32("Telefono"),
                            Foto = reader.GetString("Foto")
                        };
                    }
                    if (Original.Nombre != null)
                    {
                        reader.Close();
                        command = new MySqlCommand(query_insert, connection);
                        command.Parameters.AddWithValue("@id", Original.ID);
                        command.Parameters.AddWithValue("@id_amigo", varObjeto.ID);
                        reader = command.ExecuteReader();
                        Original.amigos.Add(varObjeto);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
        }

        public void AddMiembroGrupo(Grupo Original, string Email_Usuarios)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * FROM splitwise.usuarios WHERE Correo = @email;";
                    string query_insert = "INSERT INTO `splitwise`.`usuarios_has_grupos` (`Usuarios_idUsuarios`, `Grupos_idGrupos`) VALUES (@id_usuarios, @id_grupo);";
                    MySqlCommand command = new MySqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@email", Email_Usuarios);
                    MySqlDataReader reader = command.ExecuteReader();
                    Usuario varObjeto = new Usuario();
                    while (reader.Read())
                    {
                        varObjeto = new Usuario()
                        {
                            ID = reader.GetInt32("idUsuarios"),
                            Nombre = reader.GetString("Nombre"),
                            Apellidos = reader.GetString("Apellidos"),
                            Descripcion = reader.GetString("Descripcion"),
                            Correo = reader.GetString("Correo"),
                            Telefono = reader.GetInt32("Telefono"),
                            Foto = reader.GetString("Foto")
                        };


                    }
                    if (Original.Nombre != null)
                    {
                        reader.Close();
                        command = new MySqlCommand(query_insert, connection);
                        command.Parameters.AddWithValue("@id_grupo", Original.ID);
                        command.Parameters.AddWithValue("@id_usuarios", varObjeto.ID);
                        reader = command.ExecuteReader();
                        Original.Miembros.Add(varObjeto);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
        }

        public void AddGasto(Grupo Original, string Email_Usuarios, int cantidad, string nombre)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query_find_user = "SELECT * FROM splitwise.usuarios WHERE Correo = @email;";
                    string query_insert = "INSERT INTO `splitwise`.`usuarios_has_gastos` (`Usuarios_idUsuarios`, `Grupos_idGrupos`, `Cantidad`, `Nombre`, `Estado`) VALUES (@id_usuarios, @id_grupos, @Cantidad, @Nombre, 'Pendiente');";
                    MySqlCommand command = new MySqlCommand(query_find_user, connection);
                    command.Parameters.AddWithValue("@email", Email_Usuarios);
                    MySqlDataReader reader = command.ExecuteReader();
                    Usuario varObjeto = new Usuario();
                    while (reader.Read())
                    {
                        varObjeto = new Usuario()
                        {
                            ID = reader.GetInt32("idUsuarios"),
                            Nombre = reader.GetString("Nombre"),
                            Apellidos = reader.GetString("Apellidos"),
                            Descripcion = reader.GetString("Descripcion"),
                            Correo = reader.GetString("Correo"),
                            Telefono = reader.GetInt32("Telefono"),
                            Foto = reader.GetString("Foto")
                        };

                    }
                    if (Email_Usuarios != null)
                    {
                        reader.Close();
                        command = new MySqlCommand(query_insert, connection);
                        command.Parameters.AddWithValue("@id_grupos", Original.ID);
                        command.Parameters.AddWithValue("@id_usuarios", varObjeto.ID);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        reader = command.ExecuteReader();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
        }

        public void AddRegistros(Grupo Original, string Nombre_Gasto, string Accion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * FROM splitwise.usuarios_has_gastos WHERE Nombre = @nombre and Grupos_idGrupos = @Group_id ";
                    string query_insert = "INSERT INTO `splitwise`.`registros` (`Accion`, `ID_Gasto`) VALUES (@accion, @gasto);";
                    MySqlCommand command = new MySqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@nombre", Nombre_Gasto);
                    command.Parameters.AddWithValue("@Group_id", Original.ID);

                    MySqlDataReader reader = command.ExecuteReader();
                    Gasto varObjeto = new Gasto();
                    while (reader.Read())
                    {
                        varObjeto = new Gasto()
                        {
                            ID = reader.GetInt32("ID_Gasto"),
                            usuario = reader.GetInt32("Usuarios_idUsuarios"),
                            grupo = reader.GetInt32("Grupos_idGrupos"),
                            Cantidad = reader.GetFloat("Cantidad"),
                            Nombre = reader.GetString("Nombre"),
                            Estado = reader.GetString("Estado"),
                        };

                    }
                    if (Nombre_Gasto != null)
                    {
                        reader.Close();
                        command = new MySqlCommand(query_insert, connection);
                        command.Parameters.AddWithValue("@accion", Accion);
                        command.Parameters.AddWithValue("@gasto", varObjeto.ID);
                        reader = command.ExecuteReader();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }
            }
        }

        public void CreateGroup(string Nombre_Grupo, string Descripcion_Grupo, Usuario Propietario)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query_insert = "INSERT INTO `splitwise`.`Grupos` (`Nombre`, `Descripcion`, `Foto` , `Estado`) VALUES (@name, @description , 'No' , 'Activado');";
                    MySqlCommand command = new MySqlCommand(query_insert, connection);
                    command.Parameters.AddWithValue("@name", Nombre_Grupo);
                    command.Parameters.AddWithValue("@description", Descripcion_Grupo);
                    command.ExecuteNonQuery();
                    Grupo varObjeto = new Grupo();
                    varObjeto = new Grupo()
                    {
                        ID = 0,
                        Nombre = Nombre_Grupo,
                        Descripcion = Descripcion_Grupo,
                        Foto = "No",
                        Estado = "Activado",
                    };

                    var id = command.LastInsertedId;
                    varObjeto.ID = (int)id;
                    AddMiembroGrupo(varObjeto, Propietario.Correo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }

            }
        }

        public void CreateUser(string Nombre, string Apellidos, string Descripcion, string Correo, int Telefono)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query_insert = "INSERT INTO `splitwise`.`usuarios` (`Nombre`, `Apellidos`, `Descripcion`, `Correo`, `Telefono`, `Foto`) VALUES (@name , @surname ,@description, @email , @phone , 'no');";
                    MySqlCommand command = new MySqlCommand(query_insert, connection);
                    command.Parameters.AddWithValue("@name", Nombre);
                    command.Parameters.AddWithValue("@surname", Apellidos);
                    command.Parameters.AddWithValue("@description", Descripcion);
                    command.Parameters.AddWithValue("@email", Correo);
                    command.Parameters.AddWithValue("@phone", Telefono);
                    command.ExecuteNonQuery();
                    Usuario varObjeto = new Usuario();
                    varObjeto = new Usuario()
                    {
                        ID = 0,
                        Nombre = Nombre,
                        Apellidos = Apellidos,
                        Descripcion = Descripcion,
                        Correo = Correo,
                        Telefono = Telefono,
                        Foto = "No",
                    };

                    var id = command.LastInsertedId;
                    varObjeto.ID = (int)id;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }

            }
        }

        public void DeleteGasto(Grupo Original, string Nombre_Gasto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * FROM splitwise.usuarios_has_gastos WHERE Nombre = @name and Grupos_idGrupos = @id_grupo ;";
                    string query_delete = "UPDATE splitwise.usuarios_has_gastos SET Estado = \"Anulado\" where  ID_Gasto = @id";
                    MySqlCommand command = new MySqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@name", Nombre_Gasto);
                    command.Parameters.AddWithValue("@id_grupo", Original.ID);                    
                    MySqlDataReader reader = command.ExecuteReader();
                    Gasto varObjeto = new Gasto();
                    while (reader.Read())
                    {
                        varObjeto = new Gasto()
                        {
                            ID = reader.GetInt32("ID_Gasto"),
                            usuario = reader.GetInt32("Usuarios_idUsuarios"),
                            grupo = reader.GetInt32("Grupos_idGrupos"),
                            Cantidad = reader.GetFloat("Cantidad"),
                            Nombre = reader.GetString("Nombre"),
                            Estado = reader.GetString("Estado"),
                        };
                    }
                    reader.Close();
                    varObjeto.Estado = "Anulado";
                    command = new MySqlCommand(query_delete, connection);
                    command.Parameters.AddWithValue("@id", varObjeto.ID);
                    command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }

            }
        }

        public void DeleteGrupo(string Nombre_Grupo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * FROM splitwise.grupos WHERE Nombre = @name;";
                    string query_delete = "UPDATE splitwise.grupos SET Estado = \"Anular\" where Nombre = @name";
                    MySqlCommand command = new MySqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@name", Nombre_Grupo);
                    MySqlDataReader reader = command.ExecuteReader();
                    Grupo varObjeto = new Grupo();
                    while (reader.Read())
                    {
                        varObjeto = new Grupo()
                        {
                            ID = reader.GetInt32("idGrupos"),
                            Nombre = reader.GetString("Nombre"),
                            Descripcion = reader.GetString("Descripcion"),
                            Foto = reader.GetString("Foto"),
                            Estado = reader.GetString("Estado"),
                        };
                    }
                    reader.Close();
                    varObjeto.Estado = "Anular";
                    command = new MySqlCommand(query_delete, connection);
                    command.Parameters.AddWithValue("@name", Nombre_Grupo);
                    command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }

            }
        }
        public void DeleteFriend(string Correo_Amigo , Usuario Original)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query1 = "SELECT * FROM splitwise.grupos WHERE Nombre = @name;";
                    string query_delete = "UPDATE splitwise.grupos SET Estado = \"Anular\" where Nombre = @name";
                    MySqlCommand command = new MySqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@name", Nombre_Grupo);
                    MySqlDataReader reader = command.ExecuteReader();
                    Grupo varObjeto = new Grupo();
                    while (reader.Read())
                    {
                        varObjeto = new Grupo()
                        {
                            ID = reader.GetInt32("idGrupos"),
                            Nombre = reader.GetString("Nombre"),
                            Descripcion = reader.GetString("Descripcion"),
                            Foto = reader.GetString("Foto"),
                            Estado = reader.GetString("Estado"),
                        };
                    }
                    reader.Close();
                    varObjeto.Estado = "Anular";
                    command = new MySqlCommand(query_delete, connection);
                    command.Parameters.AddWithValue("@name", Nombre_Grupo);
                    command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching objects: " + ex.Message);
                }

            }
        }
    }
}