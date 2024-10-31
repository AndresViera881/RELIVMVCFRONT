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
    public class CategoriaController : Controller
    {
        Uri baseAdrees = new Uri("https://localhost:7186/api");
        private readonly HttpClient _client;

        public CategoriaController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAdrees;
        }

        public IActionResult Index()
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

        [HttpPost()]
        public IActionResult Create([FromBody] CategoriaViewModel categoriaViewModel)
        {
            if (categoriaViewModel == null || string.IsNullOrWhiteSpace(categoriaViewModel.Descripcion))
            {
                return Json(new { success = false, errorMessage = "Datos inválidos." });
            }

            HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/Categoria/PostCategoria", categoriaViewModel).Result;

            if (response.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            string errorContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine("Error de la API: " + errorContent);
            return Json(new { success = false, errorMessage = "La categoría no pudo ser creado." });
        }

        [HttpPut()]
        public IActionResult Put(int id, [FromBody] CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(categoria), Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync($"{_client.BaseAddress}/Categoria/PutCategoria/{id}", jsonContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    return Json(new { success = true });
                }
                else
                {
                    ModelState.AddModelError("", "Error al actualizar el estado");
                }
            }
            return View(categoria);
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/Categoria/DeleteCategoria/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }
            else
            {
                ModelState.AddModelError("", "Error al eliminar la categoria");
                return RedirectToAction("Index");
            }
        }

    }
}
