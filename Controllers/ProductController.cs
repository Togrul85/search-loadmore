using FrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {



        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IActionResult Index()
        {
           

            var products = _appDbContext.Products.Include(p=>p.ProductImages).ToList();
            return View();
        }
    }
}
