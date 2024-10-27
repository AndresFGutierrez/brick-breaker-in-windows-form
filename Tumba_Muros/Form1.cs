using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tumba_Muros.Resources;

namespace Tumba_Muros
{
    public partial class escenario : Form
    {
        // Atributos de el formulario 
        List<ObjetoGrafico> Muros = new List<ObjetoGrafico>(); // Lista de muros
        List<ObjetoGrafico> Ladrillos = new List<ObjetoGrafico>(); // Lista de ladrillos
        ObjetoGrafico Vida; // Define un objeto grafico vida 
        ObjetoGrafico Recompensa; // Define un objeto grafico Recompensa 
        Paleta paleta; // Define un objeto grafico paleta 
        Pelota pelota; // Define un objeto grafico pelota 
        int segundos = 0; // Variable segundos
        Jugador jugador = new Jugador(); //Crea un nuevo jugador
        bool vidaCreada = false; // Bandera para indicar si la vida ha sido creada
        bool recompensaCreada = false;// Bandera para indicar si la recompensa fue creada
        int aleatorioRecompensa; // variable que almacenara un numero aleatorio del 1 al 3 para darle una recompensa aleatoria
        Audio audio = new Audio(); // Instancia para usar los audios

        public escenario()
        {
            InitializeComponent();
        }

        private void escenario_Load(object sender, EventArgs e)
        {
            paleta = new Paleta("paleta", 260, 410, 60, 25); // Crear una instancia de Paleta
            this.Controls.Add(paleta.ImagenObjeto); // la agrega
            pelota = new Pelota("pelota", 273, 350, 30, 30); // Crear una instancia de pelota
            this.Controls.Add(pelota.ImagenObjeto); // la agrega
            CargarMuros(); // Carga los muros
            CargarLadrillos(); // Carga los ladrillos

            audio.SeleccionarAudio(5); // Audio de que inicio el juego
        }

        // Metodo para cargar los ladrillos
        public void CargarLadrillos()
        {
            var coor = CargarArchivo("ladrillosCoor");
            for (int i = 0; i < coor.GetLength(0); i++)
            {
                Ladrillo ladrillo = new Ladrillo(coor[i, 0], coor[i, 1], "ladrillo");
                Ladrillos.Add(ladrillo);
                this.Controls.Add(ladrillo.ImagenObjeto);
            }
        }

        // Metodo para cargar los muros o barreras
        public void CargarMuros()
        {
            var coor = CargarArchivo("coordenadas");
            for (int i = 0; i < coor.GetLength(0); i++)
            {
                Muro muro = new Muro(coor[i, 0], coor[i, 1], "barrera");
                Muros.Add(muro);
                this.Controls.Add(muro.ImagenObjeto);
            }
        }

        // Metodo que carga el archivo con las coordenadas
        public int[,] CargarArchivo(string nombre)
        {
            string archivo = Properties.Resources.ResourceManager.GetString(nombre); //Leer archivo que le envie
            string[] lineas = archivo.Split('\n'); //separa renglon por renglon, posicion de arreglo 0 cooredenada NN, y asi
            int[,] coordenadas = new int[lineas.Length, 2];
            for (int i = 0; i < lineas.Length; i++)
            {
                lineas[i] = lineas[i].Trim();
                string[] strCoor = lineas[i].Split(';'); // separa cada coordenada X y Y
                coordenadas[i, 0] = int.Parse(strCoor[0]);
                coordenadas[i, 1] = int.Parse(strCoor[1]);
            }

            return coordenadas;
        }

        // Metodo para mover la paleta con las teclas A y D
        private void escenario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            c = char.ToUpper(c);

            switch (c)
            {
                case 'A':
                    if (!paleta.EvaluarColision(Muros))
                        paleta.MoverLeft();
                    else
                        paleta.Rebote(7);
                    break;
                case 'D':
                    if (!paleta.EvaluarColision(Muros))
                        paleta.MoverRight();
                    else
                        paleta.Rebote(7);
                    break;
            }
        }

        // Timer de la pelota
        private void timerPelota_Tick(object sender, EventArgs e)
        {
            // Rebote de la pelota
            pelota.Rebotar(paleta.ImagenObjeto, Muros);
            // Aqui se revisa si un ladrillo a sido roto, lo elimina, y si el ladrillo tiene recompensa aleaatoria la suelta
            // Ademas agrega el puntaje por romper cada ladrillo que es 35 puntos
            int id = pelota.RomperLadrillo(Ladrillos);
            if (id != -1 && id < Ladrillos.Count)
            {
                List<ObjetoGrafico> ladrillosConPremio = new Ladrillo().LadrillosConRecompensa(Ladrillos);
                foreach (ObjetoGrafico ladrillo in ladrillosConPremio)
                {
                    if (Ladrillos[id] == ladrillo)
                    {
                        // llama al metodo que asigna la recompensa aleatoria que sera un puntaje diferente aleatoriamente
                        RecompensaAleatoria();
                        break; // Terminar el bucle una vez que se haya encontrado el ladrillo premiado
                    }
                }
                jugador.Puntaje1 += 35;
                // Audio cuando rompe ladrillo
                audio.SeleccionarAudio(3);
                lblpuntaje.Text = "Puntaje: " + jugador.Puntaje1;
                this.Controls.Remove(Ladrillos[id].ImagenObjeto);
                Ladrillos.RemoveAt(id);
                // Rebote de la pelota
                pelota.Rebotar(paleta.ImagenObjeto, Ladrillos);
            }

            // Revisa si se perdio una vida, si se perdio resta una vida y suena
            bool perder = jugador.PerderVida(pelota, paleta);
            if (perder)
            {
                audio.SeleccionarAudio(4);
                lblvidas.Text = "Vidas: " + jugador.Vidas1;
            }
            // Si las vidas son 0 suena que perdio, muestra el mensaje de que perdio, deshabilita todos los timer
            // Muestra ek form de los puntajes
            if (jugador.Vidas1 == 0)
            {
                // Sonido perdio
                audio.SeleccionarAudio(2);

                // Mostrar mensaje de que perdio
                Mensaje mensaje = new Mensaje();
                mensaje.Estado = 0;
                mensaje.Show();
                // Desactivar timers
                timerPelota.Enabled = false;
                timerRecompensa.Enabled = false;
                timertiempo.Enabled = false;
                timervida.Enabled = false;

                // Mostrar formulario de puntajes
                Puntajes puntajes = new Puntajes();
                puntajes.Show();
            }
        }

        // Timer para el contador de los segundos
        private void timertiempo_Tick(object sender, EventArgs e)
        {
            segundos++;
            lbltiempo.Text = "Tiempo: " + segundos.ToString();
        }

        // Metodo para asignar la recompensa aleatoria que se dara al romper el ladrillo premiado
        public void RecompensaAleatoria()
        {
            if (!recompensaCreada)
            {
                aleatorioRecompensa = new Random().Next(1, 4); //un numero aleatorio del 1 al 3 para darle una recompensa aleatoria
                int posX = new Random().Next(70, 400); //posicion de salida de la recompensa aleatoria

                Recompensa = new ObjetoGrafico("puntos_" + aleatorioRecompensa, posX, 55, 65, 25); // Crear la recompensa segun el numero dado, y la posicion dada
                this.Controls.Add(Recompensa.ImagenObjeto); // la agrega 
                recompensaCreada = true; // Marca que la recompensa fue creada
            }
        }

        // Instancia la nueva vida, la agrega y marca que la vida fue creada
        private void InstanciaYControl(int posX, int seg)
        {
            if (!vidaCreada && segundos == seg)
            {
                Vida = new ObjetoGrafico("vida", posX, 55, 30, 30); // Crear la vida en la posición inicial
                this.Controls.Add(Vida.ImagenObjeto);
                vidaCreada = true; // Marcar que la vida ha sido creada
            }
        }

        private void RegalarVida()
        {
            InstanciaYControl(160, 20); //crea la vida y hace el proceso para el aumento de la vida si es que la alcanza a tocar con la paleta
            InstanciaYControl(370, 40);
        }

        // Metodo para mover la vida y la recompensa, animacion caida
        private void Mover(ref ObjetoGrafico objeto, bool esVida)
        {
            if (objeto != null)
            {
                // Obtener la posición actual del PictureBox
                int nuevaPosY = objeto.ImagenObjeto.Top + 5; 
                objeto.ImagenObjeto.Top = nuevaPosY; // Actualizar la posicion del PictureBox

                // Comprueba si el jugador gano la recompensa, que es que la paleta toque la imagen de la recompensa
                if (jugador.GanarRecompensa(paleta, objeto))
                {
                    // Primer camino si es una vida, segundo que es la recompensa de puntaje
                    if (esVida)
                    {
                        // audio de que agarro la recompensa
                        audio.SeleccionarAudio(1);
                        // Aumenta las vidas y actualiza el label
                        jugador.Vidas1++;
                        lblvidas.Text = "Vidas: " + jugador.Vidas1;
                        vidaCreada = false; // Permitir que se cree una nueva vida en el futuro
                    }
                    else
                    {
                        // audio de que agarro la recompensa
                        audio.SeleccionarAudio(1);
                        int puntajeConseguido = 0;
                        // logica para asignar los puntos segun corresponda
                        switch (aleatorioRecompensa)
                        {
                            case 1:
                                puntajeConseguido += aleatorioRecompensa * 100;
                                break;
                            case 2:
                                puntajeConseguido += aleatorioRecompensa * 125;
                                break;
                            case 3:
                                puntajeConseguido += aleatorioRecompensa * 167;
                                break;
                        }
                        jugador.Puntaje1 += puntajeConseguido; //se suman puntos por recompensa
                        lblpuntaje.Text = "Puntaje: " + jugador.Puntaje1;
                        recompensaCreada = false; // Permitir que se cree una nueva recompensa en el futuro
                    }
                    this.Controls.Remove(objeto.ImagenObjeto); // Eliminar el objeto
                    objeto.ImagenObjeto.Dispose(); // Liberar los recursos del PictureBox
                    objeto = null;
                }
                else if (nuevaPosY >= 410) // Si la posicion de la recompensa llega a abajo se elimina
                {
                    this.Controls.Remove(objeto.ImagenObjeto);
                    objeto.ImagenObjeto.Dispose(); // Liberar los recursos del PictureBox
                    objeto = null;
                    if (esVida)
                    {
                        vidaCreada = false; // Permitir que se cree una nueva vida en el futuro
                    }
                    else
                    {
                        recompensaCreada = false; // Permitir que se cree una nueva recompensa en el futuro
                    }
                }
            }
        }

        // Timer vida
        private void timervida_Tick(object sender, EventArgs e)
        {
            RegalarVida(); //crea la vida
            Mover(ref Vida, true);  // mueve la vida y valida si el jugador la agarro o no
        }

        //Timer recompensa
        private void timerRecompensa_Tick(object sender, EventArgs e)
        {
            Mover(ref Recompensa, false);  // mueve la recompensa y valida si el jugador la agarro o no
            // Si el puntaje es de 1000 o mas pasa de nivel
            if (jugador.Puntaje1 >= 1000)
            {
                // Se desactivan los timer
                timerPelota.Enabled = false;
                timerRecompensa.Enabled = false;
                timertiempo.Enabled = false;
                timervida.Enabled = false;
                // Se abre el otro nivel y se oculta este
                escenario2 nivel2 = new escenario2();
                nivel2.Show();
                this.Hide();  // Oculta el formulario actual en lugar de cerrarlo
            }
        }
    }
}
