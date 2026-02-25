using Microsoft.EntityFrameworkCore;

namespace TaxiAPI.Data;


public class AppDbContext : DbContext
{
    // Конструктор, который принимает настройки
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Наборы данных для таблиц
    public DbSet<Product> Products { get; set; }


    
}