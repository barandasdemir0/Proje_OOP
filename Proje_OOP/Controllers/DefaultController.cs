using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
       void islemler()
        {
            Class1 c = new Class1();
            c.Topla();


        }
    }
}
