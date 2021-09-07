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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btninicioS_Click(object sender, EventArgs e)
        {
            string empl1 = "David";
            string empl1c = "d3v1d";
            string adm1 = "admin";
            string adm1c = "admin1";

            if (txtUsuario.Text == empl1 && txtContra.Text == empl1c)
            {
                Ventana_Empleado ventana_Empleado = new Ventana_Empleado();
                Ventana_Empleado VeEm = ventana_Empleado;
                VeEm.Show();
            }

            if (txtUsuario.Text == adm1 && txtContra.Text == adm1c)
            {
                Ventana_Administrador ventana_Administrador = new Ventana_Administrador();
                Ventana_Administrador VeAdm = ventana_Administrador;
                VeAdm.Show();
            }
        }
    }
}
