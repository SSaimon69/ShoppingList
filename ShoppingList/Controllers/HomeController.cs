using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //db.Shops.Add(new Shop { Name = "Пятерочка" });
            //db.Categories.Add(new Category { Name = "Зависимость" });
            //db.Products.AddRange(new List<Product>()
            //    {
            //        new Product { CategoryID = 1, Name = "Булка", Price = 156, PurchaseId = 1 },
            //        new Product {CategoryID = 1, Name = "Колбаса", Price = 352.7m, PurchaseId = 1},
            //        new Product {CategoryID = 1, Name = "Сметана", Price = 241.64m, PurchaseId = 1},
            //        new Product {CategoryID = 1, Name = "Нагетсы", Price = 352.21m, PurchaseId = 1},
            //        new Product {CategoryID = 2, Name = "Сигареты", Price = 130.25m, PurchaseId = 1}
            //    });
            //db.SaveChanges();

            //db.purchases.First().ProductList = db.products.Join(db.purchases,
            //    a => a.PurchaseId,
            //    b => b.Id,
            //    (a, b) => new Product 
            //    {
            //        Name = a.Name, 
            //        Price = a.Price, 
            //        PurchaseId = b.Id 
            //    }).ToList(); 

            var a = db.Purchases.Where(u => u.Id == 1).Include(x => x.ProductList).FirstOrDefault();
            return View(a);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}