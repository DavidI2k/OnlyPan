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
    public partial class Ventana_Administrador : Form
    {
        public Ventana_Administrador()
        {
            InitializeComponent();
            
             
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbEmpleados.AppendText("David" + "\r\n");
            rtbEmpleados.AppendText("Administrador: Emilia" + "\r\n");
        }
    }
}
