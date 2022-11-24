using controlActividades.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlActividades.vistas
{
    public partial class frmEliminarA : Form
    {
        public frmEliminarA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDNombreA.Text != "" && textBoxDUsuarioA.Text != "")
            {
                clsActividad oActividad = new clsActividad()
                {
                    nombreActividad = textBoxDNombreA.Text,
                    usuario = textBoxDUsuarioA.Text
                };
            }
            MessageBox.Show("Operacion Exitosa");
        }
    }
}
