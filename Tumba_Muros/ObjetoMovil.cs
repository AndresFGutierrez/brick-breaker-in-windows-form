using System.Collections.Generic;

namespace Tumba_Muros.Resources
{
    // ObjetoMovil hereda de ObjetoGrafico
    internal class ObjetoMovil : ObjetoGrafico
    {

        // Atributos velocidad y direccion
        int velocidad;
        string direccion;

        // constructores
        public ObjetoMovil()
        {
            velocidad = 100;
            direccion = "left";
        }
        public ObjetoMovil(int x, int y) : base("null", x, y, 18, 18)
        {
            velocidad = 7;
            direccion = "left";
        }

        //Metodo para mover arriba
        public void MoverUp()
        {
            this.Posy -= velocidad;
            direccion = "up";
            SetPos(Posx, Posy);
        }

        //Metodo para mover abajo
        public void MoverDown()
        {
            this.Posy += velocidad;
            direccion = "down";
            SetPos(Posx, Posy);
        }

        //Metodo para mover izquierda
        public void MoverLeft()
        {
            this.Posx -= velocidad;
            direccion = "left";
            SetPos(Posx, Posy);
        }

        //Metodo para mover derecha
        public void MoverRight()
        {
            this.Posx += velocidad;
            direccion = "right";
            SetPos(Posx, Posy);
        }

        // Metodo para evaluar choque con una lista de objetos graficos
        public bool EvaluarColision(List<ObjetoGrafico> objetosGraficos)
        {
            for (int i = 0; i < objetosGraficos.Count; i++)
            {
                if (this.GetRectangulo().IntersectsWith(objetosGraficos[i].GetRectangulo())) //si el rectangulo se intersecta con otro rectangulo retorna true
                                                                                             // osea si una imagen se encuentra con otra diga que se encontro
                {
                    return true;
                }
            }
            return false;
        }

        // Metodo para evaluar choque con un objeto grafico
        public bool EvaluarColision(ObjetoGrafico objetosGraficos)
        {

            if (this.GetRectangulo().IntersectsWith(objetosGraficos.GetRectangulo())) //si el rectangulo se intersecta con otro rectangulo retorna true
                                                                                      // osea si una imagen se encuentra con otra diga que se encontro
            {
                return true;
            }
            return false;
        }

        // Rebote utilizado por la paleta, para que si toca con un borde cambie su direccion
        public void Rebote(int velocidad)
        {
            switch (direccion)
            {
                case "left":
                    this.Posx += velocidad;
                    direccion = "right";
                    break;
                case "right":
                    this.Posx -= velocidad;
                    direccion = "left";
                    break;
                case "up":
                    this.Posy += velocidad;
                    direccion = "down";
                    break;
                case "down":
                    this.Posy -= velocidad;
                    direccion = "up";
                    break;
            }
            SetPos(Posx, Posy);
        }
    }
}
