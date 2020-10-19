using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Test.Class;

namespace Test.Model
{
    public class bd_cliente
    {
        private cls_Cliente cls_cliente;
        private List<cls_Cliente> lst_cliente;
        private Boolean respuesta = false;

        //conexión
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;

        private string cadenaConexion = "";
        private string query = "";

        public SqlCommand openCadenaConexion(string query)
        {
            try
            {
                cadenaConexion = @"Server=SRVSIACDESA\SIAC;Database=SIAC;User Id=appcrecob;Password=crecob;";                
                conn = new SqlConnection(cadenaConexion);
                conn.Open();
                cmd = new SqlCommand(query, conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en conexión. Error: " + ex.Message);
            }
            return cmd;
        }
        public int obtenerId()
        {
            int numero = 0;
            try
            {
                query = "select ISNULL(max(id) + 1, 1) as id from pruebaCliente; ";
                cmd = openCadenaConexion(query);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    numero = reader.GetInt32(0);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtenerId. Error:" + ex.Message);
            }
            return numero;
        }
        public int consultarExiste(int id)
        {
            int numero = 0;
            try
            {
                query = "select count(*) as retorna from pruebaCliente where id = "+ id;
                cmd = openCadenaConexion(query);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    numero = reader.GetInt32(0);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtenerId. Error:" + ex.Message);
            }
            return numero;
        }
        public Boolean distribuye(cls_Cliente cls) {

            try
            {
                if (consultarExiste(cls.ID) > 0)
                {
                    respuesta = actualizarCliente(cls);
                }else
                {
                    respuesta = ingresarCliente(cls);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al distribuir la información. Error:" + ex.Message);
            }

            return respuesta;
        }
        public Boolean ingresarCliente(cls_Cliente cls)
        {
            int numero = 0;
            try
            {
                numero = obtenerId();
                query = "insert into pruebaCliente (id,cedula,nombres,apellido,genero,edad,estado) values (" + numero + ",'" +
                                                                                                                cls.CEDULA + "','" +
                                                                                                                cls.NOMBRES + "','" +
                                                                                                                cls.APELLIDOS + "','" +
                                                                                                                cls.GENERO + "'," +
                                                                                                                cls.EDAD + ",'" +
                                                                                                                cls.ESTADO + "');";
                cmd = openCadenaConexion(query);
                cmd.ExecuteNonQuery();
                conn.Close();
                respuesta = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar la información. Error:" + ex.Message);
            }

            return respuesta;
        }
        public Boolean actualizarCliente(cls_Cliente cls)
        {
            try
            {
                query = "update pruebaCliente set id = " + cls.ID +
                                                  ",cedula = '" + cls.CEDULA +
                                                  "',nombres = '" + cls.NOMBRES +
                                                  "',apellido = '" + cls.APELLIDOS +
                                                  "',genero = '" + cls.GENERO +
                                                  "',edad = " + cls.EDAD +
                                                  ",estado = '" + cls.ESTADO +
                                                  "'";
                cmd = openCadenaConexion(query);
                cmd.ExecuteNonQuery();
                conn.Close();
                respuesta = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar la información. Error:" + ex.Message);
            }

            return respuesta;
        }
    }
}