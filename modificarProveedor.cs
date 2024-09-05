using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSO.PersistenciaClases;
using GSO.PersistenciaClases.Persistencia;

namespace GSO
{
    public partial class modificarProveedor : Form
    {
        public modificarProveedor(int idProveedor)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            proveedor proveedorcito = pProveedor.GetById(idProveedor);
            metroTextBox1.Text = proveedorcito.Nombre;
            metroTextBox2.Text = proveedorcito.Direccion;
            metroTextBox3.Text = proveedorcito.Telefono;
            metroTextBox4.Text = proveedorcito.Mail;
            id = idProveedor;

        }
        int id;
        public void altaProveedor()
        {
            proveedor p = new proveedor();
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "" && metroTextBox1.Text != "Nombre" && metroTextBox2.Text != "Direccion")
            {
                long telefono;
                if (long.TryParse(metroTextBox3.Text, out telefono))
                {
                    //comprobar el arroba en el mailProvedor y el punto en el dominio del mail  del proveedor 
                    if (metroTextBox4.Text.Contains("@") && metroTextBox4.Text.Contains("."))
                    {
                        p.Nombre = metroTextBox1.Text;
                        p.Direccion = metroTextBox2.Text;
                        p.Telefono = telefono.ToString();
                        p.Mail = metroTextBox4.Text;
                        pProveedor.Update(p,id);
                        MessageBox.Show("Proveedor modificado correctamente");
                        
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
        
        private void modificarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            altaProveedor();
            this.Close();
        }
    }
}
