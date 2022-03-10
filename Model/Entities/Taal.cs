using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Taal
    {
        // Properties
        public string ISOTaalCode { get; set; }
        public string NaamNL { get; set; }
        public string NaamTaal { get; set; }

        // navigation properties
        public virtual ICollection<Land> Talen { get; set; } = new List<Land>();

    }
}
