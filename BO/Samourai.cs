using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Samourai : CommunID
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        public List<ArtMartial> ArtMartiaux { get; set; } = new List<ArtMartial>();
    }
}
