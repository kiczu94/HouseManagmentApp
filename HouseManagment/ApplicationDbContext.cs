using HouseManagment.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HouseManagment;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Activity> Activities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {

        modelBuilder.Entity<Activity>(entity =>
        {

            entity.ToTable("Activity");
            entity.HasKey(p => p.Id).HasName("PK_User");
            entity.Property(p => p.Id).HasColumnName("id").ValueGeneratedNever();
            entity.Property(p => p.Name).HasColumnName("name");
            entity.Property(p => p.ResponsiblePersonId).HasColumnName("responsiblePersonId");
            entity.Property(p => p.DateOfExecution).HasColumnName("dateOfExecution");
            entity.Property(p => p.Description).HasColumnName("description");
            entity.Property(p => p.IsFinished).HasColumnName("isFinished");
        });

    }
}

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connection = Environment.GetEnvironmentVariable("DefaultConnection");
        optionsBuilder.UseSqlServer(connection);
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
