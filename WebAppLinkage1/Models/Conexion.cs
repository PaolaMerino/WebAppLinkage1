using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLinkage1.Models
{
    public class Conexion
    {
        private static Conexion Conn = null;

        private Conexion()
        {



        }

        public MySqlConnection CrearConexion()
        {

            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "server=Localhost;user id=root;password=;persistsecurityinfo=False;database=linkage";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Conn == null)
            {
                Conn = new Conexion();
            }
            return Conn;
        }
    }
}