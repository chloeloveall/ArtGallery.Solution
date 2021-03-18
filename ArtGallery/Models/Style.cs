using System.Collections.Generic;
using System.ComponentModel;

namespace ArtGallery.Models
{
  public class Style
  {
    public Style()
    {
      this.JoinEntities = new HashSet<Gallery>();
    }

    public int StyleId { get; set; }
    public Period Period { get; set; } 
    public Medium Medium { get; set; }

    public virtual ICollection<Gallery> JoinEntities { get; }
  }

  public enum Period
  {
    [Description("Ancient Classical Period")]
    AncientClassicalPeriod,
    [Description("Medieval Period")]
    Medieval,
    [Description("Renaissance Period")]
    RenaissancePeriod,
    [Description("Neoclassicism Period")]
    NeoclassicismPeriod,
    [Description("Romanticism Period")]
    RomanticismPeriod,
    [Description("Modern Period")]
    ModernPeriod,
    [Description("Contemporary Period")]
    ContemporaryPeriod
  }

  public enum Medium {
    [Description("Painting")]
    Painting,
    [Description("Drawing")]
    Drawing,
    [Description("Printing")]
    Printing,
    [Description("Textiles")]
    Textiles,
    [Description("Photography/Film/Technology")]
    PhotographyFilmTechnology,
    [Description("Sculpture")]
    Sculpture

  }
}