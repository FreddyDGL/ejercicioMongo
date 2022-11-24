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
using MongoDB.Bson;
using MongoDB.Driver;

namespace controlActividades.vistas
{
    public partial class frmInsertarA : Form
    {
        public frmInsertarA()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxNombreA.Text != "" && textBoxUsuarioA.Text != "")
            {
                clsActividad oActividad = new clsActividad()
                {
                    nombreActividad = textBoxNombreA.Text,
                    usuario = textBoxUsuarioA.Text
                };
            }
            MessageBox.Show("Operacion Exitosa");
        }
    }
}
