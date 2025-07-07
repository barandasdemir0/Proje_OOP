using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if (customer.Name.Length>=6 && customer.City != "" && customer.City.Length >= 3)
            {
                context.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Veriler Eklenemedi";
                return View();
            }
         
        }

        public IActionResult DeleteCustomer(int id)
        {
            var deletedValues = context.Customers.Find(id);
            context.Remove(deletedValues);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var updatedValues = context.Customers.Find(id);
            return View(updatedValues); // bunu koymamızın sebebi içerideki veriler dolsun istiyoruz
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            if (customer.Name.Length >= 6 && customer.City != "" && customer.City.Length >= 3)
            {
                var updatedValues = context.Customers.Find(customer.Id);
                updatedValues.Name = customer.Name;
                updatedValues.City = customer.City;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Veriler Eklenemedi";
                return View();
            }
        }

    }
}
