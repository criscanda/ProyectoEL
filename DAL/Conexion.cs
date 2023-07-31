﻿using System.Data.SqlClient;

namespace DAL
{
    public static class Conexion
    {
        // Encapsulacion - Accesible solo dentro de la clase
        private static string NombreAplicacion = "SQL Server";
        private static string Servidor = @"DESKTOP-PRNHC0D\SQLEXPRESS";
        private static string Usuario = "canda";
        private static string Password = "canda";
        private static string BaseDatos = "MPOO";

        //cadena de caracteres estatica - SqlAutentication = true, false para Windows
        public static string ConexionString(bool SqlAutentication = false)
        {
            SqlConnectionStringBuilder Constructor = new SqlConnectionStringBuilder()
            {
                ApplicationName = NombreAplicacion,
                IntegratedSecurity = SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos
            };

            if (SqlAutentication)
            {
                Constructor.UserID = Usuario;
                Constructor.Password = Password;
            }
            return Constructor.ConnectionString;
        }




    }
}