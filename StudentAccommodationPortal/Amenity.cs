using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace StudentAccommodationPortal
{
    public class Amenity
    {
        public string AmenityName { get; set; }
        public AmenityType AmenityType { get; set; }
        public string ImagePath { get; set; }

        public Amenity(string name, AmenityType type)
        {
            this.AmenityName = name;
            this.AmenityType = type;
        }

        public Amenity()
        {

        }
    }
}
