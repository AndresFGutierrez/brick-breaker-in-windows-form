namespace Tumba_Muros
{
    internal class Muro : ObjetoGrafico
    {
        //Constructores clase muro, que es la barrera del juego, que hereda de ObjetoGrafico
        public Muro() { }
        public Muro(int x, int y, string nombreImagen) : base(nombreImagen, x, y, 18, 18)
        {

        }
    }
}
