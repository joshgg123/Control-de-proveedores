using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using GSO.PersistenciaClases.Persistencia;
using GSO.PersistenciaClases;
namespace GSO
{
    public partial class etiqueta : Form
    {
        
        public etiqueta( )
        {
            InitializeComponent();
            
            Conexion.OpenConexion();
        }
        
        private void save(string name)
        {
            string sql = "insert into etiquetas (nombre) values ('" + name + "')";
            SQLiteCommand command = new SQLiteCommand(sql, Conexion.Connection);
            command.ExecuteNonQuery();
        }
        
            private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }
        
        

    private void button1_Click(object sender, EventArgs e)
        {
            save(nombre.Text);
            nombre.Text = "";
        }
    }
}
