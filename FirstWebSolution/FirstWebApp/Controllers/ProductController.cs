using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product(101,"Pencil",5,2,""),
            new Product(102,"Eraser",10,1,"")
        };
        public IActionResult Index()
        {
            var sortedProducts = products.Where(p=>p.Price>1).OrderBy(p => p.Price);
            return View(sortedProducts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            products.Add(product);
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = null;
            for (int i = 0;i<products.Count;i++)
            {
                if (products[i].Id ==id)
                {
                    product = products[i];
                    break;
                }
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id,Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products[i] = product;
                    break;
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Product product = null;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    product = products[i];
                    break;
                }
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
