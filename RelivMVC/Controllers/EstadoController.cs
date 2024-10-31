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
    public class EstadoController : Controller
    {
        Uri baseAdrees = new Uri("https://localhost:7186/api");
        private readonly HttpClient _client;

        public EstadoController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAdrees;
        }

        public IActionResult Index()
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
        public IActionResult Create([FromBody] EstadoViewModel estadoViewModel)
        {
            if (estadoViewModel != null && !string.IsNullOrWhiteSpace(estadoViewModel.Descripcion))
            {
                // Aquí se implementaría la lógica para enviar el POST a la API o guardar en la base de datos
                HttpResponseMessage response = _client.PostAsJsonAsync(_client.BaseAddress + "/Estado/PostEstados", estadoViewModel).Result;

                if (response.IsSuccessStatusCode)
                {
                    return Json(new { success = true });
                }
            }

            return Json(new { success = false, errorMessage = "El estado no pudo ser creado." });
        }

        [HttpPut]
        public IActionResult Put(int id, EstadoViewModel estado)
        {
            if (ModelState.IsValid)
            {
                var jsonContent = new StringContent(JsonConvert.SerializeObject(estado), Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PutAsync($"{_client.BaseAddress}/Estado/PutEstado/{id}", jsonContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Error al actualizar el estado");
                }
            }
            return View(estado);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = _client.DeleteAsync($"{_client.BaseAddress}/Estado/DeleteEstado/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Error al eliminar el estado");
                return RedirectToAction("Index");
            }
        }

    }
}
