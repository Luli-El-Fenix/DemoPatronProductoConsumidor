namespace DemoPatronProductoConsumidor
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoCosina { get; set; }
        public DateTime FechaCreacion { get; set; }
        public object Text1 { get; }
        public string Text2 { get; }

        public Usuario(int id, string nombre, string cosina)
        {
            Id = id;
            Nombre = nombre;
            TipoCosina = cosina;
            FechaCreacion = DateTime.Now;
        }

        public Usuario(object text1, string text2)
        {
            Text1 = text1;
            Text2 = text2;
        }

        public override string ToString()
        {
            return $"Id:{Id},Nombre:{Nombre}, Correo:{TipoCosina},Fecha:{FechaCreacion}";
        }
    }
}
