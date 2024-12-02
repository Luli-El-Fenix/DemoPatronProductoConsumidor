namespace DemoPatronProductoConsumidor
{
    public class Productor
    {
        private Cola<Usuario> _cola;
        public Productor(Cola<Usuario> cola)
        {
            _cola = cola;
        }
        public void Producir(Usuario item)
        {
            _cola.Agregaar(item);
            Thread.Sleep(2000);
        }
    }
}
