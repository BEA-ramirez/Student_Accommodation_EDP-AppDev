using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAccommodationPortal
{
    public class Room
    {
        public Accommodation Accommodation { get; set; }
        public RoomType RoomType { get; set; }
        public Boolean IsAvailable { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Review> Reviews { get; set; }
        public Boolean Bathroom { get; set; }
        public string ImagePath { get; set; }

        public Room(int roomId, int accommodationId, RoomType roomType, Boolean isAvailable, string description, double price, Boolean bathroom)
        {
            this.RoomType = roomType;
            this.IsAvailable = isAvailable;
            this.Description = description;
            this.Price = price;
            this.Bathroom = bathroom;
            this.Reviews = new List<Review>();
        }
        
        public void AddImage(string imagePath)
        {
            this.ImagePath = imagePath;
        }

        public Room()
        {
            this.IsAvailable = true;
            this.Reviews = new List<Review>();
            this.Bathroom = false;
        }
    }
}
