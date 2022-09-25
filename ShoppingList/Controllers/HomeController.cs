using Microsoft.AspNetCore.Mvc;
using ShoppingList.Models;
using System.Diagnostics;

namespace ShoppingList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Models.AppContext db;


        public HomeController(Models.AppContext context, ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //db.shops.Add(new Shop { Name = "Пятерочка" });
            //db.categories.Add(new Category { Name = "Продукты" });
            //db.purchases.Add(new Purchase { ProductList = new List<Product>{ new Product { CategoryID = 1, Name = "Булка", Price = 156, PurchaseId = 1 } }, ShopID = 1, Time = DateTime.Now });
            //db.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}