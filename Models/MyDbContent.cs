using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options): base(options){

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MyProject;Persist Security Info = True;User ID=SA;Password=<YourStrong@Passw0rd>");
        }
            
        public DbSet<EXPMaster> EXPMaster { get; set; }
    
            
        public DbSet<ENPMaster> ENPMaster { get; set; }
    
            
        public DbSet<FormMaster> FormMaster { get; set; }
    
            
        public DbSet<ENPDetail> ENPDetail { get; set; }
    
    }
}

    