using Split_Wise_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Split_Wise_Project.DataAcces
{
    public class DataAccess
    {
        private string connectionString = "Server=localhost;Database=splitwise;User ID=root;";
        public List<Usuario> getUsuarios()
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
                    string query = "SELECT * FROM usuarios_has_gastos";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Gasto varObjeto = new Gasto()
                        {
                            ID = reader.GetInt32("ID_Gasto"),
                            Usuario = reader.GetInt32("Usuarios_idUsuarios"),
                            Grupo = reader.GetInt32("Grupos_idGrupos"),
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

        public List<Usuario> GetAmigos()
        {
            List<Usuario> Amigos = new List<Usuario>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM amigos";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario varObjeto = new Usuario()
                        {
    
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
    }
}