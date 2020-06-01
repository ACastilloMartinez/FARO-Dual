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
    public partial class Formulario : Form
    {

       // Se establecen los atributos principales.
        
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=airforcedb;Uid=root;Pwd=admin");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        

        public Formulario()
        {

            // Se procede a inicializarse todos los componentes del formulario y la carga de los ComboBox

            InitializeComponent();
            LoadComboPiloto();
            LoadComboVehiculo();
            LoadComboHora();
            LoadComboTerreno();
            LoadComboTiempo();




        }

        // Método el cual hace una llamada a la clase ConectorDB para que ejecute su método 'InsertarFormulario'
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ConectorDB conectordb = new ConectorDB();

           
            int id_valido;
            int puntuacion = sacarPuntos();
            // Condición que asigna un valor dependiendo del resultado de puntos.
            if (puntuacion >= 100)
            {
                id_valido = 1;
            }
            else
            {
                id_valido = 0;
            }

            // Llamada al método que inserta el formulario en la base de datos.
            conectordb.InsertarFormulario(int.Parse(cbNombre.SelectedValue.ToString()), int.Parse(cbVehiculo.SelectedValue.ToString()), int.Parse(cbHora.SelectedValue.ToString()),
                int.Parse(cbTerreno.SelectedValue.ToString()), int.Parse(cbTiempo.SelectedValue.ToString()), id_valido);

            string valido;
            if (id_valido == 0)
            {
                valido = "Rechazada";
            }
            else
            {
                valido = "Aceptada";
            }
            MessageBox.Show("Puntuacion: " + puntuacion+ " ¿Autorización para volar?: "+valido, "Resultado informe");
        }

        // Método el cual te cierra la ventana Formulario y te abre la ventana Menú
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        /* 
         * Métodos el cual te carga todos los datos de la base de datos en el ComboBox.
         */

        /*
         * Se produce la conexión con base de datos y se ejecuta la consulta pertinente, siendo los resultados asignados al DataAdapter
         */

        /*
         * Los resultados del DataAdapter se traspasan al DataSource del ComboBox. 
         * Estableciendose asi la Key o ID de la opción del ComboBox junto a la ID en base de datos y el Value de la opción con la descripción asignada a la ID de la tabla.
         */

        private void LoadComboPiloto()
        {
            // Se recoge la ID del piloto previamente asignada al loguear.
            int id_pil = int.Parse(Login.id_pil);

            DataTable dt;

            
            String sql = "SELECT id_pil, nombre_pil from piloto where id_pil='"+id_pil+"'";

            try
            {
                
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                
                cbNombre.DataSource = dt;
                cbNombre.DisplayMember = "nombre_pil";
                cbNombre.ValueMember = "id_pil";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
        }


        private void LoadComboVehiculo()
        {

            DataTable dt;
            String sql = "SELECT id_veh, nombre_veh from vehiculo";
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbVehiculo.DataSource = dt;
                cbVehiculo.DisplayMember = "nombre_veh";
                cbVehiculo.ValueMember = "id_veh";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
        }

        private void LoadComboHora()
        {

            DataTable dt;
            String sql = "SELECT id_hora, descripcion_h from hora";
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbHora.DataSource = dt;
                cbHora.DisplayMember = "descripcion_h";
                cbHora.ValueMember = "id_hora";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
        }

        private void LoadComboTerreno()
        {

            DataTable dt;
            String sql = "SELECT id_terreno, descripcion_ter from terreno";
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbTerreno.DataSource = dt;
                cbTerreno.DisplayMember = "descripcion_ter";
                cbTerreno.ValueMember = "id_terreno";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
        }


        private void LoadComboTiempo()
        {

            DataTable dt;
            String sql = "SELECT id_tiempo, descripcion_ti from tiempo";
            try
            {
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                cbTiempo.DataSource = dt;
                cbTiempo.DisplayMember = "descripcion_ti";
                cbTiempo.ValueMember = "id_tiempo";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
        }

        // Metodo que realiza la totalidad de puntos dependiendo de las opciones marcadas de los ComboBox
        public int sacarPuntos()
        {

            // Se inicializa los puntos a 200
            int puntos = 200;

            // Se coge la ID del vehiculo escogido en el Combobox
            int id_veh = int.Parse(cbVehiculo.SelectedValue.ToString());


            // Se consigue el tipo de vehiculo a través de la ID del vehiculo
            string sql_veh = "SELECT tipo_veh FROM vehiculo WHERE id_veh ='" + id_veh + "'";

            // Lista para almacenar el resultado de la consulta.
            List<string> tipo_vehiculo = new List<string>();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql_veh;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                tipo_vehiculo.Add(dr["tipo_veh"] + "");

            }

            dr.Close();
            con.Close();

            // Variable que recoge el tipo de vehiculo de la aeronave seleccionada.
            int tipo_veh = int.Parse(tipo_vehiculo[0]);

            // Se coge la ID de la hora escogida en el Combobox
            int hora = int.Parse(cbHora.SelectedValue.ToString());

            // Se coge la ID del terreno escogido en el Combobox
            int terreno = int.Parse(cbTerreno.SelectedValue.ToString());

            // Se coge la ID del tiempo escogido en el Combobox
            int tiempo = int.Parse(cbTiempo.SelectedValue.ToString());

            // Se coge la ID del vehiculo escogido en el Combobox
            int id_pil = int.Parse(cbNombre.SelectedValue.ToString());

            // Se consigue el nivel del piloto a través de la ID del piloto
            string sql_nivel = "SELECT id_nivel FROM piloto WHERE id_pil ='" + id_pil + "'";

            // Lista para almacenar el resultado de la consulta.
            List<string> nivel_piloto = new List<string>();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql_nivel;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                nivel_piloto.Add(dr["id_nivel"] + "");

            }

            dr.Close();
            con.Close();



            // Variable que recoge el nivel del piloto logueado.
            int nivel = int.Parse(nivel_piloto[0]);

            // Switch que recoge el % de reduccion en los puntos.
            double reduccion = 0.0;

            switch (nivel)
            {
                case 1:
                    reduccion = 0.6;
                    break;
                case 2:
                    reduccion = 0.5;
                    break;
                case 3:
                    reduccion = 0.4;
                    break;
                case 4:
                    reduccion = 0.3;
                    break;
                case 5:
                    reduccion = 0.2;
                    break;
                case 6:
                    reduccion = 0.1;
                    break;


            }


            /* 
             * Switchs e Ifs que recogen las diferentes ids y realizan el recuento de puntos
             */

            switch (tipo_veh)
            {
                case 1:
                    // Caza
                    puntos = (int) (puntos - (50 * reduccion));
                    break;
                case 2:
                    // Avion de carga
                    puntos = (int)(puntos - (40 * reduccion));
                    break;
                case 3:
                    // Avioneta
                    puntos = (int)(puntos - (35 * reduccion));
                    break;
                case 4:
                    // Avion de personal
                    puntos = (int)(puntos - (45 * reduccion));
                    break;
                case 5:
                    // Helicoptero
                    puntos = (int)(puntos - (30 * reduccion));
                    break;

                   
            }

            if ((hora >= 7 && hora <= 12) || (hora >= 19 && hora <= 21) )
            {
                // 06:00 a 11:00 o 18:00 a 20:00
                puntos = (int)(puntos - (5 * reduccion));
            }
            else if (hora >= 13 && hora <= 18)
            {
                // 12:00 a 17:00
                puntos = (int)(puntos - (20 * reduccion));
            }
            else if ((hora >= 22 && hora <= 24) || (hora >= 1 && hora <= 6))
            {
                // 21:00 a 05:00
                puntos = (int)(puntos - (25 * reduccion));
            }

            switch (terreno)
            {
                case 1:
                    // Montañoso
                    puntos = (int) (puntos - (50 * reduccion));
                    break;
                case 2:
                    // Urbano
                    puntos = (int)(puntos - (20 * reduccion));
                    break;
                case 3:
                    // Bosque
                    puntos = (int)(puntos - (35 * reduccion));
                    break;
                case 4:
                    // Desertico
                    puntos = (int)(puntos - (10 * reduccion));
                    break;
                case 5:
                    // Llanura
                    puntos = (int)(puntos - (5 * reduccion));
                    break;
                case 6:
                    // Maritimo
                    puntos = (int)(puntos - (5 * reduccion));
                    break;
                   
            }

            switch (tiempo)
            {
                case 1:
                    // Soleado
                    puntos = (int)(puntos - (20 * reduccion));
                    break;
                case 2:
                    // Nubloso
                    puntos = (int)(puntos - (30 * reduccion));
                    break;
                case 3:
                    // Lluvia
                    puntos = (int)(puntos - (35 * reduccion));
                    break;
                case 4:
                    // Nieve
                    puntos = (int)(puntos - (45 * reduccion));
                    break;
                case 5:
                    // Ventoso
                    puntos = (int)(puntos - (25 * reduccion));
                    break;
                case 6:
                    // Niebla
                    puntos = (int)(puntos - (30 * reduccion));
                    break;
                case 7:
                    // Tormenta de arena
                    puntos = (int)(puntos - (50 * reduccion));
                    break;

            }

            return puntos;
        }
    }

}
