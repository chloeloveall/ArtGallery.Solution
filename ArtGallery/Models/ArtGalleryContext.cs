using Microsoft.EntityFrameworkCore;

namespace ArtGallery.Models
{
  public class ArtGalleryContext : DbContext
  {
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Style> Styles { get; set; }
    public DbSet<Gallery> Gallery { get; set; }
    public ArtGalleryContext(DbContextOptions options) : base(options) { }


    // Add virtual to utilize lazy loading
    // public virtual DbSet<Artist> Artists { get; set; }
    // public virtual DbSet<Style> Styles { get; set; }
    // public virtual DbSet<Gallery> Gallery { get; set; }

    // Adds ability to use lazy loading
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }
  }
}