using Proje_OOP.Entity;

namespace Proje_OOP.Ornekler
{

    //sınıfların içindeki öğelere erişim sağlamak için sınıftan bir nesne oluşturulur.
    public class Class1
    {
        //Product p = new Product();
        // nesne nedir? nesne, sınıfın bir örneğidir.
        //dışarıdan erişim sağlayamıyoruz o yüzden metot içinde tanımlıyoruz.
        //metotlar, sınıfın içinde tanımlanır ve sınıfın özelliklerine erişim sağlar.

        //void Metot()
        //{
        //    Product p = new Product();

        //}


        //başlangıça erişim türü belirlenmediyse default olarak private olur.
        //private erişim türü, sadece sınıfın içinde erişilebilir.
        //public erişim türü, sınıfın dışından da erişilebilir.
        //protected erişim türü, sınıfın içinde ve sınıfın miras alan sınıflarında erişilebilir.
        //internal erişim türü, aynı proje içinde erişilebilir.
        //ama bizim başka yerde erişmemiz için public erişim türünü kullanmalıyız.

        public void Topla()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 + sayi2;
        }
        public void Carp()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 * sayi2;
        }

         








    }
}
