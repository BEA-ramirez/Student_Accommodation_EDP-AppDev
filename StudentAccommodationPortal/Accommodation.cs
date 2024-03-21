using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAccommodationPortal
{
    public class Accommodation
    {
        public string AccommodationName { get; set; }
        public AccommodationType AccommodationType { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double campusProximity { get; set; }
        public User Landlord { get; set; }
        //public List<Application> Applications { get; set; }
        public List<Amenity> Amenities { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Review> Reviews { get; set; }
        public string ImagePath { get; set; }

        public Accommodation(string name, AccommodationType type, string address, string description, double campusProximity, User landlord)
        {
            this.AccommodationName = name;
            this.AccommodationType = type;
            this.Address = address;
            this.Description = description;
            this.campusProximity = campusProximity;
            this.Landlord = landlord;
            //this.Applications = new List<Application>();
            this.Amenities = new List<Amenity>();
            this.Rooms = new List<Room>();
            this.Reviews = new List<Review>();
        }

        public Accommodation()
        {
            //this.Applications = new List<Application>();
            this.Amenities = new List<Amenity>();
            this.Rooms = new List<Room>();
            this.Reviews = new List<Review>();
        }
    }
}
