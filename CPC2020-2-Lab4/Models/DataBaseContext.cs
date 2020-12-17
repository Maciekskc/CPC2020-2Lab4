using CPC2020_2_Lab4.Models.Entities;
using System.Data.Entity;

namespace CPC2020_2_Lab4.Models
{
    /// <summary>
    /// Klasa kontekstu bazy danyh przechowująca informacje o tablach i połączeniu z bazą danych
    /// </summary>
    public class DataBaseContext : DbContext
    {
        //Konstruktor wywołujący bazowy konstruktor klasy DContext przekazując nazwe connection stringa z pliku App.config
        public DataBaseContext():base("ConnectionString")
        {
        }

        //Tabele bazy danych
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
