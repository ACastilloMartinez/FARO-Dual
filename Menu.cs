using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FARO_Dual
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Método el cual te cierra la ventana actual y te abre la referente al Formulario.
        private void btnFormulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario formulario = new Formulario();
            formulario.Show();
        }
        // Método el cual te cierra la ventana actual y te abre la referente a la Información del piloto.
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informacion informacion = new Informacion();
            informacion.Show();
        }
        // Método el cual te cierra la ventana actual y te devuelve a la ventana de Login.
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
