using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelivMVC.Models.ViewModels
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public int EstadoId { get; set; }
    }
}
