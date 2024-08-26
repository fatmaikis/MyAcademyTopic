using Microsoft.AspNetCore.Mvc;
using Topic.WebUI.Dtos.FaqDtos;

namespace Topic.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class FaqController : Controller
    {
        private readonly HttpClient _client;

        public FaqController(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7063/api/");
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultFaqDto>>("faqs");
            return View(values);
        }

        public async Task<IActionResult> DeleteFaq(int id)
        {
            await _client.DeleteAsync("faqs/"+id);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFaq(CreateFaqDto createFaqDto)
        {
            await _client.PostAsJsonAsync("faqs",createFaqDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFaq(int id)
        {
           var values =  await _client.GetFromJsonAsync<UpdateFaqDto>("faqs/" + id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFaq(UpdateFaqDto updateFaqDto)
        {
            var values = await _client.PutAsJsonAsync("faqs",updateFaqDto);
            return RedirectToAction("Index");
        }


    }
}
