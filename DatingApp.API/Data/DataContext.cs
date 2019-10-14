using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base (options) {

        }
        
        public DbSet<WeatherForecast> Weathers { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //     base.OnConfiguring(optionsBuilder);
        //     optionsBuilder.UseSqlServer("");
        // }
        
    }

}