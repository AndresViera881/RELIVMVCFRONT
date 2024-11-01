﻿using System;
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
        public CategoriaViewModel CategoriaViewModel { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public EstadoViewModel EstadoViewModel { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
    }
}
