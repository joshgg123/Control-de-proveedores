using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSO.PersistenciaClases
{
    internal class proveedor
    {
        int id;
        string nombre;
        string telefono;
        string mail;
        string direccion;
        
        public proveedor()
        { 
        
        }

        public proveedor(int id, string nombre, string telefono, string mail, string direccion )
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.mail = mail;
            this.direccion = direccion;
            
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        

        public override string ToString()
        {
            return this.nombre + " " ;
        }
    }
}
