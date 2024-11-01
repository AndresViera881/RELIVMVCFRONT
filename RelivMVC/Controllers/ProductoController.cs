using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RelivMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace RelivMVC.Controllers
{
    public class ProductoController : Controller
    {
        Uri baseAdrees = new Uri("https://localhost:7186/api");
        private readonly HttpClient _client;

        public ProductoController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAdrees;
        }

        public IActionResult Index()
        {
            List<ProductoViewModel> lista = new List<ProductoViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Producto/GetProductos").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductoViewModel>>>(data);
                lista = apiResponse?.Data ?? new List<ProductoViewModel>();
            }

            return View(lista);
        }

        [HttpGet("GetCategorias")]
        public IActionResult GetCategorias()
        {
            List<CategoriaViewModel> lista = new List<CategoriaViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Categoria/GetCategorias").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<CategoriaViewModel>>>(data);
                lista = apiResponse?.Data ?? new List<CategoriaViewModel>();
            }
            return View(lista); 
        }

        [HttpGet("GetEstados")]
        public IActionResult GetEstados()
        {
            List<EstadoViewModel> lista = new List<EstadoViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Estado/GetEstados").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<EstadoViewModel>>>(data);
                lista = apiResponse?.Data ?? new List<EstadoViewModel>();
            }
            return View(lista);
        }



        [HttpPost]
        public IActionResult Create([FromBody] ProductoViewModel productoViewModel)
        {

            if (productoViewModel == null || string.IsNullOrWhiteSpace(productoViewModel.Nombre) || productoViewModel.Precio <= 0 || productoViewModel.Stock <= 0)
            {
                return Json(new { success = false, errorMessage = "Datos inválidos." });
            }

            HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/Producto/PostProducto", productoViewModel).Result;

            if (response.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            string errorContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine("Error de la API: " + errorContent);
            return Json(new { success = false, errorMessage = "El producto no pudo ser creado." });
        }

        [HttpPut()]
        public IActionResult Put(int id, [FromBody] ProductoViewModel producto)
        {
            if (ModelState.IsValid)
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync($"{_client.BaseAddress}/Producto/PutProducto/{id}", jsonContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    return Json(new { success = true });
                }
                else
                {
                    ModelState.AddModelError("", "Error al actualizar el producto");
                }
            }
            return View(producto);
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/Producto/DeleteProducto/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }
            else
            {
                ModelState.AddModelError("", "Error al eliminar el producto");
                return RedirectToAction("Index");
            }
        }
    }
    }
