using System.Media;

namespace Tumba_Muros
{
    internal class Audio
    {
        SoundPlayer player;
        public Audio()
        { }

        // Metodo para seleccionar segun la entrada que audio sonara
        public void SeleccionarAudio(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    player = new SoundPlayer(Properties.Resources.agarro);
                    break;
                case 2:
                    player = new SoundPlayer(Properties.Resources.perdiste1);
                    break;
                case 3:
                    player = new SoundPlayer(Properties.Resources.rebote);
                    break;
                case 4:
                    player = new SoundPlayer(Properties.Resources.vidamenos);
                    break;
                case 5:
                    player = new SoundPlayer(Properties.Resources.inicio);
                    break;
                case 6:
                    player = new SoundPlayer(Properties.Resources.ganaste1);
                    break;
            }
            // Reproduce el sonido seleccionado
            player.Play();
        }
    }
}
