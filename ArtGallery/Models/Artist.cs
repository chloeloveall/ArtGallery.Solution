using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtGallery.Models
{
  public class Artist
  {
    public Artist()
    {
      this.JoinEntities = new HashSet<Gallery>();
    }

    public int ArtistId { get; set;}
    [Required]
    [Display(Name="Name")]
    public string ArtistName { get; set; }
    [Required]
    public string Birthplace { get; set; }
    [Required]
    [Range(0,120)]
    public int Age { get; set; }
    [Required]
    public string Bio { get; set; }
    public virtual ICollection<Gallery> JoinEntities { get; set; }
  }
}