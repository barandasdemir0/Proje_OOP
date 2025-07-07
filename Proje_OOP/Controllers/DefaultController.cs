using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        // {
        //     Class1 c = new Class1();
        //     c.Topla();


        // }


        #region geriye değer döndürmeyen metotlar
        void mesajlar()
        {
            ViewBag.m1 = "merhaba bu bir core projesi"; // ViewBag, controller ile view arasında veri taşımak için kullanılır.
            ViewBag.m2 = "merhaba bu proje harika";
            ViewBag.m3 = "merhaba bu proje çok güzel";
        }

        public IActionResult Urunler()
        {
            mesajlar(); // mesajlar metodunu çağırıyoruz, böylece ViewBag içindeki veriler view'a taşınacak.
            ViewBag.t = topla(); // topla metodunu çağırıyoruz ve sonucu ViewBag.t'ye atıyoruz.
            ViewBag.c = Cevre(); // cevre metodunu çağırıyoruz ve sonucu ViewBag.c'ye atıyoruz.
            ViewBag.f = faktöriyel();
            kullanıcı("deneme");
            return View();
        }


        public IActionResult Musteriler()
        {
            ViewBag.c = cümle();
            kullanıcı("baran");
            return View(); 
        }


        public IActionResult Index()
        {
            mesajlar(); // mesajlar metodunu çağırıyoruz, böylece ViewBag içindeki veriler view'a taşınacak.
            MesajListesi("merhabayın arkadaşlar");
            kullanıcı("admin"); // kullanıcı metodunu çağırıyoruz ve kullaniciadi değerini ViewBag.k'ye atıyoruz.
            ViewBag.t = topla(4, 5);
            ViewBag.faktör = faktör(5);
            return View();
        }


        #endregion

        #region geriye değer döndüren metotlar

        int topla()
        {
            int s1 = 10;
            int s2 = 20;
            int sonuc = s1 + s2; 
            return sonuc; ; // bu metot iki sayıyı toplar ve sonucu döndürür.
        }




        int Cevre()
        {
            int kisakenar = 10;
            int uzunkenar = 20;
            int cevre = 2 * (kisakenar+uzunkenar);
            return cevre; // bu metot dikdörtgenin çevresini hesaplar ve sonucu döndürür.
        }


        int faktöriyel()
        {
            int sayi = 5;
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        #endregion


        string cümle()
        {
            string c = "ankaraa";
            return c;
        }


        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void kullanıcı(string kullaniciadi)
        {
            ViewBag.k = kullaniciadi; // son verisi olarak kullaniciadi değerini ViewBag.k'ye atıyoruz.
        }

        int topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc; // bu metot iki sayıyı toplar ve sonucu döndürür.
        }

        int faktör(int sayi)
        {
            int faktörBaslangic = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktörBaslangic = faktörBaslangic * i;
            }
            return faktörBaslangic;
        }



    }
}
