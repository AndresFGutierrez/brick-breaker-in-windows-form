using System;
using System.Data;
using System.Windows.Forms;

namespace Tumba_Muros
{
    public partial class Puntajes : Form
    {
        GestionDB GestionDB = new GestionDB();

        public Puntajes()
        {
            InitializeComponent();
        }

        private void Puntajes_Load(object sender, EventArgs e)
        {
            CargarPuntajes();
        }

        private void CargarPuntajes()
        {
            DataTable dt = GestionDB.MostrarPuntajes();
            dataGridView1.DataSource = dt;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
