using System;
using System.Collections.Generic;

namespace Tumba_Muros
{
    internal class Ladrillo : ObjetoGrafico
    {
        //Constructores clase Ladrillo, que son los que se rompen, que hereda de ObjetoGrafico
        public Ladrillo() { }
        public Ladrillo(int x, int y, string nombreImagen) : base(nombreImagen, x, y, 50, 25)
        {
        }

        //Metodo para asignar que ladrillos tendran recompensa
        public List<ObjetoGrafico> LadrillosConRecompensa(List<ObjetoGrafico> ladrillos)
        {
            List<ObjetoGrafico> ListaLadrillosPremiados = new List<ObjetoGrafico>();
            HashSet<int> indicesSeleccionados = new HashSet<int>(); //estructura que no permite elementos duplicados
            Random rnd = new Random();
            // Selecciona aleatoriamente 5 ladrillos como premiados y cada uno sera diferente, no habra un ladrillo con premio doble
            while (ListaLadrillosPremiados.Count < 5 && indicesSeleccionados.Count < ladrillos.Count)
            { 
                int indiceAleatorio = rnd.Next(0, ladrillos.Count);
                if (!indicesSeleccionados.Contains(indiceAleatorio))
                {
                    ListaLadrillosPremiados.Add(ladrillos[indiceAleatorio]);
                    indicesSeleccionados.Add(indiceAleatorio);
                }
            }
            //Devuelve la lista con los ladrillos premiados
            return ListaLadrillosPremiados;
        }
    }
}
