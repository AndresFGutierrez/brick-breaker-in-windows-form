using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tumba_Muros.Resources
{
    //peltoa hereda de objetomovil
    internal class Pelota : ObjetoMovil
    {
        private int pelota_x = 4;
        private int pelota_y = 4;

        //constructores
        public Pelota() { }

        public Pelota(string nombre, int x, int y, int w, int h) : base(x, y)
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

        //propiedades
        public int Pelota_x { get => pelota_x; set => pelota_x = value; }
        public int Pelota_y { get => pelota_y; set => pelota_y = value; }

        // Metodo para que la pelota rebote
        public void Rebotar(PictureBox paleta, List<ObjetoGrafico> muros)
        {
            // Accede a las propiedades Left y Top de la imagen de la pelota (ImagenObjeto)
            ImagenObjeto.Left += pelota_x;
            ImagenObjeto.Top += pelota_y;

            // Verifica colisión con la paleta
            if (ImagenObjeto.Bounds.IntersectsWith(paleta.Bounds))
            {
                pelota_y = -pelota_y; // Rebota hacia arriba al colisionar con la paleta
                // Agrega un valor aleatorio a la dirección horizontal para hacer el rebote menos predecible
                pelota_x += new Random().Next(0, 1);
            }

            if (EvaluarColision(muros))
            {
                // Cambia la dirección de la pelota al chocar con un muro
                pelota_x = -pelota_x;
                pelota_y = -pelota_y;
                // Agrega un valor aleatorio a las direcciones para hacer el rebote menos predecible
                pelota_x += new Random().Next(0, 1);
                pelota_y += new Random().Next(0, 1);
            }
        }

        // Metodo para romper ladrillos
        public int RomperLadrillo(List<ObjetoGrafico> ladrillos)
        {
            int id = -1;

            for (int i = 0; i < ladrillos.Count; i++)
            {
                if (this.EvaluarColision(ladrillos[i]))
                {
                    // Guarda el id del ladrillo tocado y finaliza el ciclo
                    id = i;
                    break;
                }
            }
            // Devuelve el ladrillo tocado o -1 si no se toco ningún ladrillo
            return id;
        }
    }
}
