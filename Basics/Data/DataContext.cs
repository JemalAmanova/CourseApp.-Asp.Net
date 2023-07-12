using Microsoft.EntityFrameworkCore;

namespace Basics.Data
{
    //code-first yöntemini kullandık: Entity sınıflarını ve DbContext'i tanımlayıp, clasları kullanarak db yi ilgili sql server altında (ben sqlite kullanacağım) kuracağız
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }
        public DbSet<Kurs> Kurslar { get; set; } = null!;
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<KursKayit> Kayit => Set<KursKayit>();
    }
}