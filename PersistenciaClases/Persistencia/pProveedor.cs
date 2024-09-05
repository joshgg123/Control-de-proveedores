using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace GSO.PersistenciaClases.Persistencia
{
    internal class pProveedor
    {
        public static void Save(proveedor p)
        {

            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Proveedores (nombre, telefono, mail, direccion) VALUES (@nombre, @telefono, @mail, @direccion)", Conexion.Connection);
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@telefono", p.Telefono));
            cmd.Parameters.Add(new SQLiteParameter("@mail", p.Mail));
            cmd.Parameters.Add(new SQLiteParameter("@direccion", p.Direccion));
                        
            //asigno conexion
            
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static void Update(proveedor p, int id)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Proveedores SET nombre = @nombre, telefono = @telefono, mail = @mail, direccion = @direccion WHERE id = @id", Conexion.Connection);
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@telefono", p.Telefono));
            cmd.Parameters.Add(new SQLiteParameter("@mail", p.Mail));
            cmd.Parameters.Add(new SQLiteParameter("@direccion", p.Direccion));
            
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static void Delete(int id)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Proveedores SET avaible=@avaible WHERE id = @id");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@avaible", 0));
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static proveedor GetById(int id)
        {
            
            proveedor p = new proveedor();
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Proveedores WHERE id = @id");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            if (obdr != null)
            {
                while (obdr.Read())
                {
                    p.Id = obdr.GetInt32(0);
                    p.Nombre = obdr.GetString(1);
                    p.Telefono = (obdr.GetValue(2)).ToString();
                    p.Mail = obdr.GetString(3);
                    p.Direccion = obdr.GetString(4);
                   
                }
            }
            return p;
        }
        public static List<proveedor> GetAll()
        {
            List<proveedor> ls = new List<proveedor>();
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Proveedores WHERE avaible = 1");
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            if (obdr != null)
            {
                while (obdr.Read())
                {
                    proveedor p = new proveedor();
                    p.Id = obdr.GetInt32(0);
                    p.Nombre = obdr.GetString(1);
                    p.Telefono = (obdr.GetValue(2)).ToString();
                    p.Mail = obdr.GetString(3);
                    p.Direccion = obdr.GetString(4);
                    ls.Add(p);
                }
            }
            return ls;
        }
        //quiuero una funcion publica que me traiga el id del ultimo proveedor agregado a la base de datos
        public static int GetLastId()
        {
            int id = 0;
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("SELECT MAX(id) FROM Proveedores");
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            if (obdr != null)
            {
                while (obdr.Read())
                {
                    id = obdr.GetInt32(0);
                }
            }
            return id;
        }
        public static void SaveEtiquetaProveedor(int p, string e)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO EtiProveedor (idProveedor, etiqueta) VALUES (@idProveedor, @etiqueta)", Conexion.Connection);
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@idProveedor", p));
            cmd.Parameters.Add(new SQLiteParameter("@etiqueta", e));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
