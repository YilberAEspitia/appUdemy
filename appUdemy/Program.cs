using System;
using Newtonsoft.Json;

namespace appUdemy
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto
            {
                Nombre = "Camisa Volcom",
                Precio = 800,
                Descripcion = "Tela de algodón",
                Estado = true
            };
            string json = JsonConvert.SerializeObject(producto, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
