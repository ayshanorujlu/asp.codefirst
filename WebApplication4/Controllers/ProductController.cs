using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task< IActionResult> Index()
        {
           var result=await _productService.GetAllByKey();
            return Ok(result);
        }
    }
}
