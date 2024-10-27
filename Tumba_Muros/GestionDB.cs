using System.Data;
using System.Data.SQLite;

namespace Tumba_Muros
{
    internal class GestionDB
    {
        // Definicion de los atributos
        SQLiteConnection conn; //Conectar BD
        SQLiteCommand cmd; //Comandos
        SQLiteDataReader reader; //Leer de resultados de comandos
        string nombreDB = "TumbaMurosDB.db"; //Nombre BD
        string mensaje = string.Empty; // Mensaje definido como vacio

        public string Mensaje { get => mensaje; }

        //Metoodo para conectar la bd 
        void Conectar()
        {
            try
            {
                conn = new SQLiteConnection(string.Format("Data source={0}; version=3", nombreDB));
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                mensaje = "No fue posible establecer conexión por: " + ex.Message;
            }
        }

        // Metodo Agrega puntaje, y el codigo de el jugador va automaticamente
        public int AgregarPuntaje(Jugador jugador)
        {
            int respuesta = 0;
            try
            {
                Conectar();
                string query = "INSERT INTO jugador (puntaje) VALUES (@puntaje)";
                cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@puntaje", jugador.Puntaje1);
                respuesta = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                mensaje = "Error al agregar puntaje: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return respuesta;
        }

        // Metodo para mostrar puntajes
        // Devuelve un DataTable para usarlo en el DataGridView
        public DataTable MostrarPuntajes()
        {
            DataTable dt = new DataTable();

            try
            {
                Conectar();
                string query = "SELECT codigo, puntaje FROM jugador";
                cmd = new SQLiteCommand(query, conn);
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch (SQLiteException ex)
            {
                mensaje = "Error al buscar puntajes: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
