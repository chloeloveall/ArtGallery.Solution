using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ArtGallery.Models
{
  public class ArtGalleryContextFactory : IDesignTimeDbContextFactory<ArtGalleryContext>
  {

    ArtGalleryContext IDesignTimeDbContextFactory<ArtGalleryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<ArtGalleryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new ArtGalleryContext(builder.Options);
    }
  }
}