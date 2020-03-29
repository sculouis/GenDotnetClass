<%namespace file="UsingTemplate.mako" import="*"/>
${using()}
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
        % for tableName in TableNames:
            ${dbset(tableName)}
        % endfor
    }
}

    <%def name="dbset(tableName)">
        public DbSet<${tableName}> ${tableName} { get; set; }
    </%def>