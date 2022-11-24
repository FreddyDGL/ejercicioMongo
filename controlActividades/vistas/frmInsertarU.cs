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
    public partial class frmInsertarU : Form
    {
        public frmInsertarU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxNombre.Text != "" && textBoxApPaterno.Text != "" && textBoxApMaterno.Text !="" && textBoxEdad.Text != "")
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

        private void textBoxApPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
