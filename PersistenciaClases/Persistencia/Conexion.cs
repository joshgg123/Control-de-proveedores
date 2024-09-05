﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace GSO.PersistenciaClases.Persistencia
{
    internal class Conexion
    {
        
            public static string cadena = @"Data Source=GSO.db;";
            private static SQLiteConnection connection = new SQLiteConnection(Conexion.cadena);

            public static void OpenConexion()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }

            public static void CloseConexion()
            {
                connection.Close();
            }

            public static SQLiteConnection Connection
            {
                set { connection = value; }
                get { return connection; }
            }
        }

    
}
