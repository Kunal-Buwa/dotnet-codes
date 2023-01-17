using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;
        public class CollectionContext:DbContext{
        public DbSet<Car> Cars {get;set;}
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       string conString=@"server=localhost;port=3306;user=root; password=kunal@8998;database=cartab";       
        optionsBuilder.UseMySQL(conString);

}
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>(entity => 
            {
            entity.HasKey(e => e.CarID);
            entity.Property(e => e.CarName).IsRequired();
            entity.Property(e => e.Company).IsRequired();
             entity.Property(e => e.Type).IsRequired();
            });
            modelBuilder.Entity<Car>().ToTable("cartable");
}
}