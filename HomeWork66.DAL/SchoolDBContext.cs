using HomeWork66.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWork66.DAL;

public class SchoolDBContext:DbContext
{
    public SchoolDBContext()
    {
        
    }

    public SchoolDBContext(DbContextOptions<SchoolDBContext> dbContextOptions) : base(dbContextOptions)
    {

    }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
        optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = SchoolDB");
	}

    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Property> Properties { get; set; }
}
