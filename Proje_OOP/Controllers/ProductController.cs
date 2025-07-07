using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList(); // product tablosundaki her veriyi listele bu değerleri valuese at 
            return View(values); // values değerini view'e gönder yanş kullanıcı valuesle product tablosundaki verileri görecek
        }

        [HttpGet] // HTTP GET isteği ile çalışacak yani bu metot sadece verileri görüntülemek için kullanılacak
        public IActionResult AddProduct()
        {
            return View(); // AddProduct view'ini döndür
        }

        [HttpPost] // HTTP POST isteği ile çalışacak yani bu metot verileri eklemek için kullanılacak
        public IActionResult AddProduct(Product p) // product sınıfından p nesnesi ürettik bunun sebebi 
        {
            context.Add(p); // context'e p nesnesini ekle yani veritabanına ekle product tablosuna ekle
            context.SaveChanges(); // değişiklikleri kaydet
            return RedirectToAction("Index"); // işlemi tamamladıktan sonra Index metoduna yönlendir 
        }


        public IActionResult DeleteProduct(int id) //id parametresi ile silinecek ürünün idsini bulacağız
        {
            var deleteProduct = context.Products.Find(id); // context üzerinden Products tablosunda id'si verilen ürünü bul
            context.Remove(deleteProduct); // bulduğumuz ürünü context üzerinden sil
            context.SaveChanges(); // değişiklikleri kaydet
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var updateProduct = context.Products.Find(id);
            return View(updateProduct); // id'si verilen ürünü bul ve bu ürünü UpdateProduct view'ine gönder
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)//bunun amacı güncelleme işlemi için product sınıfından prodcut nesnesi almak
        {
            var updateProduct = context.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            updateProduct.Name = product.Name;
            updateProduct.Price = product.Price;
            updateProduct.Stock = product.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
