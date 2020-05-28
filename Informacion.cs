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
using System.Windows.Forms.VisualStyles;

namespace FARO_Dual
{
    public partial class Informacion : Form
    {
        // Se establecen los atributos principales
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=airforcedb;Uid=root;Pwd=admin");
        MySqlDataAdapter da;
        int id_pil = int.Parse(Login.id_pil);
      
        public Informacion()
        {
            InitializeComponent();

            // Se oculta el DataGridView una vez inicializada la ventana.
            dgvForms.Hide();

            /*
             * Se realiza y se ejecuta la consulta para sacar la información del piloto mediante la ID conseguida en el logueo.
             * Los resultados se almacenan en una lista
             * Dichos slots de la lista van siendo asignados a los diferentes labels que muestran la información del piloto.
             */
            string query = "SELECT p.usuario_pil, p.nombre_pil, p.rango_pil,n.descripcion_niv FROM Piloto p, Nivel n WHERE p.id_pil='" + id_pil + "' AND p.id_nivel=n.id_nivel";
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataReader dr = cmd.ExecuteReader();
            List<string> usuarios = new List<string>();

            while (dr.Read())
            {

                usuarios.Add(dr["usuario_pil"] + "");
                usuarios.Add(dr["nombre_pil"] + "");
                usuarios.Add(dr["rango_pil"] + "");
                usuarios.Add(dr["descripcion_niv"] + "");

            }

            dr.Close();
            

            lblResUser.Text = usuarios[0];
            lblResNom.Text = usuarios[1];
            lblResRank.Text = usuarios[2];
            lblResNiv.Text = usuarios[3];

            
            /*
             * Se realiza una segunda consulta para sacar la información relevante para el DataGrid de los formularios realizados por el piloto.
             * Una vez ejecutada la consulta, se van asignando a un DataAdapter que rellena el DataSource del DataGridView
             */

            string queryTabla = "SELECT f.id_form, p.nombre_pil,v.nombre_veh, h.descripcion_h, ter.descripcion_ter, ti.descripcion_ti, val.descripcion_val FROM formulario f, piloto p, vehiculo v, hora h, terreno ter, tiempo ti, validez val WHERE f.id_piloto='"+id_pil+"' AND p.id_pil ='"+id_pil+"' AND f.id_vehiculo = v.id_veh AND f.id_hora = h.id_hora AND f.id_terreno = ter.id_terreno AND f.id_tiempo = ti.id_tiempo AND f.id_val = val.id_val";
            cmd = new MySqlCommand(queryTabla, con);
            da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvForms.DataSource = table;

            con.Close();
        }

        // Método el cual vuelve visible el DataGridView
        private void btnForms_Click(object sender, EventArgs e)
        {
            dgvForms.Show();
        }

        // Método el cual te devuelve a la ventana del menú tras cerrar la actual.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        //Método autogenerado referente al rellenado de datos del DataGridView.
        private void Informacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'airforcedbDataSet.nivel' Puede moverla o quitarla según sea necesario.
            this.nivelTableAdapter.Fill(this.airforcedbDataSet.nivel);
            // TODO: esta línea de código carga datos en la tabla 'airforcedbDataSet.formulario' Puede moverla o quitarla según sea necesario.
            this.formularioTableAdapter.Fill(this.airforcedbDataSet.formulario);
            // TODO: esta línea de código carga datos en la tabla 'airforcedbDataSet.formulario' Puede moverla o quitarla según sea necesario.
            this.formularioTableAdapter.Fill(this.airforcedbDataSet.formulario);

        }
    }
}
