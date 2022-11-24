using controlActividades.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlActividades
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertarA frmInsertarA = new frmInsertarA();
            frmInsertarA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmActualizarA frmActualizarA = new frmActualizarA();
            frmActualizarA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEliminarA frmEliminarA = new frmEliminarA();
            frmEliminarA.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInsertarU frmInsertarU = new frmInsertarU();
            frmInsertarU.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmActualizarU frmActualizarU = new frmActualizarU();
            frmActualizarU.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEliminarU frmEliminarU = new frmEliminarU();
            frmEliminarU.Show();
        }
    }
}
