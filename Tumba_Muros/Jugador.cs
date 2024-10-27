using System.Drawing;
using Tumba_Muros.Resources;

namespace Tumba_Muros
{
    internal class Jugador
    {
        //Se define los atributos y se inicia en 3 vidads
        int Puntaje;
        int Vidas = 3;

        //Constructores
        public Jugador() { }

        public Jugador(int puntaje, int vidas)
        {
            Puntaje = 0;
            Vidas = 3;
        }

        public int Puntaje1 { get => Puntaje; set => Puntaje = value; }
        public int Vidas1 { get => Vidas; set => Vidas = value; }

        // Metodo con el que se identifica que se perdio una vida
        public bool PerderVida(Pelota pelota, Paleta paleta)
        {
            Point pelotaLocation = pelota.ImagenObjeto.Location;

            // Verificar la posición vertical de la pelota esta en la coordenada deseada
            if (pelotaLocation.Y == 410)
            {
                // Restar una vida al jugador
                Vidas--;
                //Se reubica la pelota y la paleta
                pelota.SetPos(273, 350);
                paleta.SetPos(260, 410);
                return true;
            }
            return false;
        }

        // Metodo para verificar Si la paleta toca o la vida o la recompensa de puntaje 
        public bool GanarRecompensa(Paleta paleta, ObjetoGrafico nombre)
        {
            bool intersection = paleta.ImagenObjeto.Bounds.IntersectsWith(nombre.ImagenObjeto.Bounds);
            return intersection;
        }
    }
}
