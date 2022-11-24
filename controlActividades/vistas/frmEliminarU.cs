using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlActividades.modelos;



namespace controlActividades.vistas
{
    public partial class frmEliminarU : Form
    {
        public frmEliminarU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxApPaterno.Text != "" && textBoxApMaterno.Text != "" && textBoxEdad.Text != "")
            {
                clsUsuario clsUsuario = new clsUsuario
                {
                    nombre = textBoxNombre.Text,
                    apellidoPaterno = textBoxApPaterno.Text,
                    apellidoMaterno = textBoxApMaterno.Text,
                    edad = textBoxEdad.Text
                };
                MessageBox.Show("Operacion Exitosa");

            }
        }
    }
}
