using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FARO_Dual { 
   class ConectorDB {

    // Se establecen los atributos principales.
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public ConectorDB()
    {
            Inicializar();
    }

    //Inicialización de los valores
    public void Inicializar()
    {
        server = "localhost";
        database = "airforcedb";
        uid = "root";
        password = "admin";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

        //Se abre la conexión a la base de datos
        private bool OpenConnection() {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                
                //0: No se puede conectar al servidor
                //1045: Usuario y/o contraseña inválido
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("ERROR. No se puede conectar a la base de datos.");
                        break;

                    case 1045:
                        MessageBox.Show("ERROR. No se puede acceder a la base de datos, revise usuario y contraseña");
                        break;
                }
                return false;
            }
        }

        //Se cierra la conexión
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Se mostrará en una ventana emergente el mensaje con el error
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        // TO-DO

        //Método de inserción de Formulario en la Base de Datos mediante los parametros recogidos en los ComboBox de Formulario
        public void InsertarFormulario(int id_pil, int id_veh, int id_h, int id_ter, int id_ti, int id_val)
        {

            // Consulta que realiza la inserción pertinente basandose en los parametros del método
            string query = "INSERT INTO formulario (id_piloto, id_vehiculo, id_hora, id_terreno, id_tiempo, id_val) VALUES('"+id_pil+"', '"+id_veh+"','"+id_h+"','"+id_ter+"','"+id_ti+"','"+id_val+"')";

            // Se abre la conexión
            if (this.OpenConnection() == true)
            {
                // Se realiza la Query en la Conexión establecida
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Se ejecuta la consulta
                cmd.ExecuteNonQuery();

                // Se cierra la consulta
                this.CloseConnection();
            }
        }



    }
}

