using System.Collections.Generic;

namespace CakeFactory.Data
{
    public class Postre
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Calorias { get; set; }
        public decimal Precio { get; set; }
        public string PaisDeOrigen { get; set; }
        public List<Fruta> Frutas { get; set; } = new List<Fruta>();
    }
}