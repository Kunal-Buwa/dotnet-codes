using  Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;

public class CollectionContext:DbContext
{
    public DbSet<Employee> Emp {get;set;}
    protected override void OnConfiguring(DbContextOptionBuilder)
} {
       string conString=@"server=localhost;port=3306;user=root; password=kunal@8998;database=cartab";       
        optionsBuilder.UseMySQL(conString);

}
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity => 
            {
            entity.HasKey(e => e.Empid);
            entity.Property(e => e.Ename).IsRequired();
            entity.Property(e => e.Department).IsRequired();
           
            });
            modelBuilder.Entity<Employee>().ToTable("employee");
}
}