using System.Threading.Tasks;
using CarvedRock.Web.Clients;
using CarvedRock.Web.HttpClients;
using CarvedRock.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarvedRock.Web.Controllers
{
    public class HomeController: Controller
    {
        private readonly ProductHttpClient _httpClient;
        private readonly ProductGraphClient _productGraphClient;

        public HomeController(ProductHttpClient httpClient, 
            ProductGraphClient productGraphClient)
        {
            _httpClient = httpClient;
            _productGraphClient = productGraphClient;
        }


        public async Task<IActionResult> Index()
        {
            var responseModel = await _httpClient.GetProducts();
            responseModel.ThrowErrors();
            return View(responseModel.Data.Products);
        }

        public async Task<IActionResult> ProductDetail(int productId)
        {
            var product = await _productGraphClient.GetProduct(productId);
            return View(product);
        }

        public IActionResult AddReview(int productId)
        {
            return View(new ProductReviewModel {ProductId = productId});
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(ProductReviewInputModel reviewModel)
        {
            await _productGraphClient.AddReview(reviewModel);
            return RedirectToAction("ProductDetail", new {productId = reviewModel.ProductId});
        }
    }
}
