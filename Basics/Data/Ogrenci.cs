namespace Basics.Data{
    public class Ogrenci{
        //biz bir klas tanımlasak bile bu veri tabanında bir tabloya dönüşecektir. OgrenciId=>Primary key.
        //klas isminde id kelimesi bulunmuyorsa bunun bir key olduğunu algılamaz o nedenle klasın üstündeki satıra [Key] yazmanız gerekir.
        public int OgrenciId { get; set; }
        public string OgrenciAd{ get; set; }
        public string OgrenciSoyad{ get; set; }
        public string Eposta{ get; set; }
    }
}