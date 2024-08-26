using Microsoft.AspNetCore.Mvc;
using Topic.WebUI.Dtos.FaqDtos;
namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultFaqComponent:ViewComponent
    {

        private readonly HttpClient _client;

        public _DefaultFaqComponent(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7063/api/");
            _client = client;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

    
            var values = await _client.GetFromJsonAsync<List<ResultFaqDto>>("faqs");
            return View(values);  
        }


    }
}
