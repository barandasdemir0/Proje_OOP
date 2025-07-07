namespace Proje_OOP.Ornekler
{
    public class Sehirler : Bayrak // Bayrak sınıfından miras alır miras almak derken oradaki öğeler artık sehirler sınıfının bir parçası olur. ve sehirleri çağırdığımız zaman  bayrak sınıfındaki öğeleride kullanabiliriz.
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Nufus { get; set; }
        public string Ulke { get; set; }


    }
}
