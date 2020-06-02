using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        // Se establecen los atributos principales.
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=airforcedb;Uid=root;Pwd=admin");

        public static string id_pil;
        public Login()
        {
            InitializeComponent();

        }

        // Método el cual cierra por completo la aplicación
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método el cual te accede a la ventana de Menú si el login es válido.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<string> checkLogin = new List<string>();

            // Se asigna la lista lograda del método a dicha variable.
            checkLogin = comprobarLogin();


            /* 
             * Condición que comprueba si el usuario y contraseña existe.
             * Si se cumple, se procede a pasar de ventana junto a un mensaje de confirmación
             * Si no se cumple, se te vacia los TextBox y te muestra el mensaje de error, normalmente que el usuario o contraseña son incorrectos.
             */
            if (checkLogin.Count == 1)
            {
                id_pil = checkLogin[0];
                MessageBox.Show("Acceso correcto.", "Login");
                txtPass.Text = "";
                txtUsuario.Text = "";
                this.Hide();
                Menu menu = new Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Acceso incorrecto. Revise usuario y/o contraseña", "Login");
                txtPass.Text = "";
                txtUsuario.Text = "";
            }
        }

        // Método que te comprueba si el usuario y contraseña existen. Te devuelve una lista con los resultados.
        private List<string> comprobarLogin()
        {
            // Se asigna el texto recogido por los TextBox
            string usuario = txtUsuario.Text;
            string password = txtPass.Text;

            // Se ejecuta la consulta y el resultado se almacena en un DataReader
            string query = "SELECT p.id_pil FROM Piloto p WHERE p.usuario_pil='" + usuario + "' AND p.contrasena_pil='"+password+"'";
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataReader dr = cmd.ExecuteReader();

            List<string> usuarios = new List<string>();
            
            // Condición que va añadiendo las IDs encontrada con ese enlace de usuario-contraseña
            while (dr.Read()) 
            {

                usuarios.Add(dr["id_pil"] + "");

            }

            dr.Close();
            con.Close();

            return usuarios;
           
        }
        
    }
}
