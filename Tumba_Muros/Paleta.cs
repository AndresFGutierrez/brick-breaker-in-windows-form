using System.Drawing;
using System.Windows.Forms;

namespace Tumba_Muros.Resources
{
    // Paleta hereda de ObjetoMovil
    internal class Paleta : ObjetoMovil
    {
        //constructores
        public Paleta() { }
        public Paleta(string nombre, int x, int y, int w, int h) : base(x, y)
        {
            nombreRecurso = nombre; 
            ImagenObjeto = new PictureBox();
            ImagenObjeto.Width = w;
            ImagenObjeto.Height = h;
            ImagenObjeto.Location = new System.Drawing.Point(x, y);
            ImagenObjeto.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenObjeto.BackColor = Color.Transparent;
            ImagenObjeto.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreRecurso);
        }
    }
}
