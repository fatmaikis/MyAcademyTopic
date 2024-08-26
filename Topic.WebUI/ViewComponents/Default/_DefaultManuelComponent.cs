using Microsoft.AspNetCore.Mvc;
using Topic.DTOLayer.DTOs.ManuelDtos;



namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultManuelComponent :ViewComponent
    {
        private readonly HttpClient _client;

        public _DefaultManuelComponent(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7063/api/");

            _client = client;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _client.GetFromJsonAsync<List<ResultManuelDto>>("manuels");
            return View(value);
        }
    }
}
