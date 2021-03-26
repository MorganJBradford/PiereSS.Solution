using System.Collections.Generic;

namespace PierreSS.Models
{
  public class Flavor
  {
    public Flavor()
    {
      JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; }
  }
}