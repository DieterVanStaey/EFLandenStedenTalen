using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Stad
    {
        // Properties

        public int StadId { get; set; }
        public string Naam { get; set; }
        public string ISOLandCode { get; set; } 

        // Navigation properties

        public virtual Land Land { get; set; }
    }
}
