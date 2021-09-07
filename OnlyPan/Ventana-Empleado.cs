using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPan
{
    public partial class Ventana_Empleado : Form
    {
        public Ventana_Empleado()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            double pali = Convert.ToDouble(txtPali.Text);
            double pnali = Convert.ToDouble(txtPnoali.Text);
            double pesp = Convert.ToDouble(txtPesp.Text);

            double tot = (pali*100) + (pnali*500) + (pesp*2000);

            lblTot.Text = "Total: " + tot.ToString();

            lstGuardar.Items.Add("Nombre: " + txtNcliente.Text);
            lstGuardar.Items.Add("Cédula: " + textCecliente.Text);
            lstGuardar.Items.Add("Fecha: " + dtpFechaComp.Text);
            lstGuardar.Items.Add("Panes Aliñados: " + txtPali.Text);
            lstGuardar.Items.Add("Panes No Aliñados: " + txtPnoali.Text);
            lstGuardar.Items.Add("Panes Especiales: " + txtPesp.Text + "\r\n");
            lstGuardar.Items.Add(lblTot.Text + "\r\n");

        }
    }
}
