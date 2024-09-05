using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSO.PersistenciaClases;
using GSO.PersistenciaClases.Persistencia;

namespace GSO
{
    public partial class busqueda : Form
    {
        public busqueda()
        {
            InitializeComponent();
            Conexion.OpenConexion();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Habilitar el ajuste automático del texto dentro de las celdas.
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Asegúrate de que haya datos antes de ajustar el ancho de la columna.
            if (dataGridView1.Rows.Count > 0)
            {
                // Establece el ancho deseado para la columna que contiene el texto largo.
                int desiredColumnWidth = 200; // Ajusta el valor según tus necesidades.
                dataGridView1.Columns[3].Width = desiredColumnWidth;
            }

        }
        
        private List<proveedor> ObtenerProveedorPorNombre(string nombre)
        {
            Conexion.OpenConexion();
            List<proveedor> clientesCoincidentes = new List<proveedor>();
            
            SQLiteCommand cmd = new SQLiteCommand("SELECT id, nombre, telefono, mail, direccion FROM Proveedores WHERE LOWER(nombre) LIKE '%' || @nombre || '%' AND avaible = 1");
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    proveedor cliente = new proveedor();
                    cliente.Id = int.Parse(reader["id"].ToString());
                    cliente.Nombre = reader["nombre"].ToString();
                    cliente.Telefono = reader["telefono"].ToString();
                    cliente.Mail = reader["mail"].ToString();
                    cliente.Direccion = reader["direccion"].ToString();
                    clientesCoincidentes.Add(cliente);
                }
            }
            return clientesCoincidentes;
        }
        private List<proveedor> ObtenerProveedorPorRubro(string rubro)
        {
            Conexion.OpenConexion();
            List<proveedor> clientesCoincidentes = new List<proveedor>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idProveedor FROM etiProveedor et JOIN Proveedores p ON p.id = et.idProveedor WHERE LOWER(etiqueta) LIKE '%' || @etiqueta || '%' AND p.avaible = 1");
            cmd.Parameters.AddWithValue("@etiqueta", rubro);
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    proveedor prove = new proveedor();
                    prove = pProveedor.GetById(int.Parse(reader["idProveedor"].ToString()));
                    clientesCoincidentes.Add(prove);
                }
            }
            return clientesCoincidentes;
        }
        private List<proveedor> ObtenerClientesPorProveedorYrubro1(string nombre, string rubro)
        {
            List<proveedor> intermedia = new List<proveedor>();
            intermedia = ObtenerProveedorPorNombre(nombre);
            if (intermedia.Count > 0)
            {
                List<proveedor> intermedia2 = new List<proveedor>();
                intermedia2 = ObtenerProveedorPorRubro(rubro);
                foreach (proveedor item in intermedia2)
                {
                    intermedia.Add(item);
                }
            }

            return intermedia;


        }
        private List<proveedor> ObtenerClientesPorProveedorYRubro(string nombre, string rubro)
        {
            List<proveedor> proveedoresPorNombre = ObtenerProveedorPorNombre(nombre);
            List<proveedor> proveedoresPorRubro = ObtenerProveedorPorRubro(rubro);

            // Utilizamos LINQ para encontrar la intersección de ambas listas por el campo único 'ID'.
            List<proveedor> resultado = proveedoresPorNombre
                .Where(p => proveedoresPorRubro.Any(pr => pr.Id == p.Id))
                .ToList();

            return resultado;
        }



        private void busqueda_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.ToLower().Trim();
            string rubro = textBox2.Text.ToLower().Trim();

            // Verifica si ambos criterios de búsqueda están vacíos
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(rubro))
            {
                MessageBox.Show("Por favor, ingresa al menos un criterio de búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<proveedor> clientesCoincidentes;

            if (!string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(rubro))
            {
                // Busca por nombre
                clientesCoincidentes = ObtenerProveedorPorNombre(nombre);
            }
            else if (string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(rubro))
            {
                // Busca por apellido
                clientesCoincidentes = ObtenerProveedorPorRubro(rubro);
            }
            else
            {
                // Busca por nombre y apellido
              
                clientesCoincidentes = ObtenerClientesPorProveedorYRubro(nombre, rubro);
            }


            // Asigna los clientes coincidentes a comboBox1 para mostrarlos
            dataGridView1.DataSource = clientesCoincidentes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
