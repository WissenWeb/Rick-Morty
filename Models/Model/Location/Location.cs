using Models.Model.Base;
using Rick_Morty.Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model.Location
{
    public class LocationResult : BaseMain
    {
        public List<Location> results { get; set; }
    }
    public class Location:BaseMovie
    {
        public string Type { get; set; }
        public string Dimension { get; set; }
        public List<string> Residents { get; set; }
    }
    
    
}
