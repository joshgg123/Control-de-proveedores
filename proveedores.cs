using System;
using System.Windows.Forms;
using GSO.PersistenciaClases.Persistencia;
using GSO.PersistenciaClases;
using System.Data.SQLite;
using System.Drawing;
using GSO;

using System.Collections.Generic;


namespace GSO
{
    public partial class proveedores : Form
    {
        public proveedores()
        {
            InitializeComponent();
            Conexion.OpenConexion();
            CargarProveedores();
            dataGridViewE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Habilitar el ajuste automático del texto dentro de las celdas.
            dataGridViewE.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Establecer el ancho deseado para la columna que contiene el texto largo.
            int desiredColumnWidth = 200; // Ajusta el valor según tus necesidades.

            // Obtener la referencia a la columna que contiene el texto largo (reemplaza "yourLongTextColumnIndex" con el índice correcto).


            // Establecer el ancho deseado para la columna que contiene el texto largo.
            dataGridViewE.Columns[3].Width = desiredColumnWidth;
        }
        public List<string> getEtiquetas()
        {
            List<string> etiquetas = new List<string>();
            string sql = "select * from etiquetas";
            SQLiteCommand command = new SQLiteCommand(sql, Conexion.Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                etiquetas.Add(reader["nombre"].ToString());
            }
            return etiquetas;
        }
        public void CargarProveedores()
        {

            dataGridViewE.DataSource = pProveedor.GetAll();
            listBox1.DataSource = getEtiquetas();

        }
        private void proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        public void altaProveedor()
        {
            proveedor p = new proveedor();
            if (nomProveedor.Text != "" && direProveedor.Text != "" && nomProveedor.Text != "Nombre" && direProveedor.Text != "Direccion" )
            {
                long telefono;
                if (long.TryParse(telProveedor.Text, out telefono))
                {
                    //comprobar el arroba en el mailProvedor y el punto en el dominio del mail  del proveedor 
                    if (mailProveedor.Text.Contains("@") && mailProveedor.Text.Contains("."))
                    {
                        p.Nombre = nomProveedor.Text;
                        p.Direccion = direProveedor.Text;
                        p.Telefono = telefono.ToString();
                        p.Mail = mailProveedor.Text;
                        
                        pProveedor.Save(p);
                        int id_proveedor = pProveedor.GetLastId();
                        foreach (String ep in listBox1.SelectedItems)
                        {
                            pProveedor.SaveEtiquetaProveedor(id_proveedor, ep);
                        }
                        MessageBox.Show("Proveedor agregado correctamente");
                        CargarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("El mail ingresado no es valido");
                    }
                }
                else
                {
                    MessageBox.Show("El Teléfono debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void nomProveedor_Enter(object sender, EventArgs e)
        {
            if (nomProveedor.Text == "Nombre")
            {
                nomProveedor.Text = "";
                nomProveedor.ForeColor = Color.Silver;
            }
        }

        private void nomProveedor_Leave(object sender, EventArgs e)
        {
            if (nomProveedor.Text == "")
            {
                nomProveedor.Text = "Nombre";
                nomProveedor.ForeColor = Color.Silver;
            }
        }
        private void direProveedor_Enter(object sender, EventArgs e)
        {
            if (direProveedor.Text == "Direccion")
            {
                direProveedor.Text = "";
                direProveedor.ForeColor = Color.Silver;
            }
        }

        private void direProveedor_Leave(object sender, EventArgs e)
        {
            if (direProveedor.Text == "")
            {
                direProveedor.Text = "Direccion";
                direProveedor.ForeColor = Color.Silver;
            }
        }
        private void telProveedor_Enter(object sender, EventArgs e)
        {


            if (telProveedor.Text == "Telefono")
            {
                telProveedor.Text = "";
                telProveedor.ForeColor = Color.Silver;
            }
        }

        private void telProveedor_Leave(object sender, EventArgs e)
        {
            if (telProveedor.Text == "")
            {
                telProveedor.Text = "Telefono";
                telProveedor.ForeColor = Color.Silver;
            }
        }
        private void mailProveedor_Enter(object sender, EventArgs e)
        {
            if (mailProveedor.Text == "Email")
            {
                mailProveedor.Text = "";
                mailProveedor.ForeColor = Color.Silver;
            }
        }

        private void mailProveedor_Leave(object sender, EventArgs e)
        {
            if (mailProveedor.Text == "")
            {
                mailProveedor.Text = "Email";
                mailProveedor.ForeColor = Color.Silver;
            }
        }

        private void dataGridViewE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LimpiarTextBox()
        {
            nomProveedor.Text = "Nombre";
            nomProveedor.ForeColor = Color.Silver;
            direProveedor.Text = "Direccion";
            direProveedor.ForeColor = Color.Silver;
            telProveedor.Text = "Telefono";
            telProveedor.ForeColor = Color.Silver;
            mailProveedor.Text = "Email";
            mailProveedor.ForeColor = Color.Silver;
            listBox1.SelectedIndices.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaProveedor();
            CargarProveedores();
            LimpiarTextBox();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                // Obtener el valor de la columna deseada (por ejemplo, la columna 0)
                string valorColumnaSeleccionada = dataGridViewE.SelectedRows[0].Cells[0].Value.ToString();
                
                // Abrir el otro formulario y pasar el valor a través de un constructor o una propiedad
                new modificarProveedor(int.Parse(valorColumnaSeleccionada)).ShowDialog(); // Suponiendo que el constructor del formulario acepta el valor como parámetro
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en la grilla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewE.SelectedRows.Count > 0)
            {
                // Obtener el valor de la columna deseada (por ejemplo, la columna 0)
                string valorColumnaSeleccionada = dataGridViewE.SelectedRows[0].Cells[0].Value.ToString();
                pProveedor.Delete(int.Parse(valorColumnaSeleccionada));
                CargarProveedores();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new busqueda().ShowDialog(); // Suponiendo que el constructor del formulario acepta el valor como parámetro
            CargarProveedores();

        }
    }
}
