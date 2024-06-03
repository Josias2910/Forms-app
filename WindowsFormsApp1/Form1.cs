using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double nLibreta = 0;
        string nombre;
        int documento = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarTB()
        {
            tBNombre.Clear();
            tBDocumento.Clear();
            tBLibreta.Clear();
        }
        private void bAgregar_Click(object sender, EventArgs e)
        {
            nombre = tBNombre.Text;
            nLibreta = Convert.ToDouble(tBLibreta.Text);
            documento = Convert.ToInt32(tBDocumento.Text);
            lBLibreta.Items.Add(nLibreta.ToString());
            lBLibreta.Items.Add(nombre.ToString());
            lBLibreta.Items.Add(documento.ToString());
            LimpiarTB();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            lBLibreta.Items.Remove(nLibreta.ToString());
            lBLibreta.Items.Remove(nombre.ToString());
            lBLibreta.Items.Remove(documento.ToString());
        }
        
        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
