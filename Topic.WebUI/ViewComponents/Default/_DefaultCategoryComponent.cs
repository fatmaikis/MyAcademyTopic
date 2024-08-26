using Microsoft.AspNetCore.Mvc;
using Topic.WebUI.Dtos.CategoryDtos;

namespace Topic.WebUI.ViewComponents.Default
{
    public class _DefaultCategoryComponent :ViewComponent
    {
        private readonly HttpClient _client;

        public _DefaultCategoryComponent(HttpClient client)
        {
            //client.BaseAddress = new Uri("https://localhost:7063/api/");
            _client = client;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCategoryDto>>("https://localhost:7063/api/categories/GetActiveCategories");
            return View(values);
        }
    }
}
