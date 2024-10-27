using System;
using System.Windows.Forms;

namespace Tumba_Muros
{
    public partial class Mensaje : Form
    {
        int estado;
        public int Estado { get => estado; set => estado = value; }

        public Mensaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            if (estado == 0)
            {

                pictureBox1.Image = Properties.Resources.PERDISTE;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.GANASTE;
            }
        }
    }
}
