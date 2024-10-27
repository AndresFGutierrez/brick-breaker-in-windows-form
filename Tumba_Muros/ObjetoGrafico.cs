using System.Drawing;
using System.Windows.Forms;

namespace Tumba_Muros
{
    internal class ObjetoGrafico
    {
        // atributos
        protected int Posx, Posy;
        PictureBox imagenObjeto; // PictureBox utilizado para mostrar la imagen del objeto
        protected string nombreRecurso; // Nombre de la imagen

        // propiedades
        protected int Posx1 { get => Posx; }
        protected int Posy1 { get => Posy; }
        public PictureBox ImagenObjeto { get => imagenObjeto; set => imagenObjeto = value; }

        // constructores
        public ObjetoGrafico() { }
        public ObjetoGrafico(string nombre, int x, int y, int w, int h)
        {
            nombreRecurso = nombre;
            Posx = x;
            Posy = y;
            ImagenObjeto = new PictureBox();
            imagenObjeto.Width = w;
            imagenObjeto.Height = h;
            imagenObjeto.Location = new System.Drawing.Point(x, y); // crear la imagen en la localizacion
            imagenObjeto.SizeMode = PictureBoxSizeMode.StretchImage; //estrechar la imagen
            imagenObjeto.BackColor = Color.Transparent;
            imagenObjeto.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreRecurso); //traer la imagen de la carpeta propieties/ressources de acuerdo con el nombre del recurso que le de
        }

        // Metodo para la posicion de el objeto grafico, X y Y
        public void SetPos(int x, int y)
        {
            Posx = x;
            Posy = y;
            imagenObjeto.Location = new System.Drawing.Point(x, y); // crear la imagen en la localizacion
        }

        // Metodo virtual para obtener el rectangulo que rodea al objeto
        public virtual Rectangle GetRectangulo()
        {
            return imagenObjeto.Bounds;
        }
    }
}
