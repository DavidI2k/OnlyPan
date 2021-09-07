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

        }
    }
}
