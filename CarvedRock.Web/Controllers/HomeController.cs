using System.Threading.Tasks;
using CarvedRock.Web.HttpClients;
using Microsoft.AspNetCore.Mvc;

namespace CarvedRock.Web.Controllers
{
    public class HomeController: Controller
    {
        private readonly ProductHttpClient _httpClient;

        public HomeController(ProductHttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IActionResult> Index()
        {
            var responseModel = await _httpClient.GetProducts();
            responseModel.HandleErrors();
            return View(responseModel.Data.Products);
        }

        public async Task<IActionResult> ProductDetail(int productId)
        {
            var responseModel = await _httpClient.GetProduct(productId);
            responseModel.HandleErrors();
            return View(responseModel.Data.Product);
        }
    }
}
