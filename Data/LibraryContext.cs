using Microsoft.EntityFrameworkCore;

namespace MyLibrary.Data
{
  public class LibraryContext : DbContext
  {
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Database=mylibrary;Username=library_user;Password=Library2*19");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Author>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.FirstName).IsRequired();
        entity.Property(e => e.LastName).IsRequired();
        entity.Property(e => e.BirthDate);
      });

      modelBuilder.Entity<Category>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Description).IsRequired();
      });

      modelBuilder.Entity<Book>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Title).IsRequired();
        entity.Property(e => e.Description).IsRequired();
      });
    }
  }
}