namespace ArtGallery.Models
{
  public class Gallery
  {
    public int GalleryId { get; set; }
    public int ArtistId { get; set; }
    public int StyleId { get; set; }
    public virtual Artist Artist { get; set; }
    public virtual Style Style { get; set; }
  }
}