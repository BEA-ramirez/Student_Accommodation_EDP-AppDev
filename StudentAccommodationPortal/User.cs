using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentAccommodationPortal
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string FirstName { get; set; }
        [FirestoreProperty]
        public string LastName { get; private set; }
        [FirestoreProperty]
        public string Username { get; private set; }
        [FirestoreProperty]
        public string Sex { get; private set; }
        [FirestoreProperty]
        public string Address { get; private set; }
        [FirestoreProperty]
        public string Email { get; private set; }
        [FirestoreProperty]
        public string ContactNumber { get; set; }
        [FirestoreProperty]
        public string Password { get; private set; }

        [FirestoreProperty]
        public bool isLandlord { get; set; } = false;

        [FirestoreProperty]
        public string College { get; set; } = "";

        [FirestoreProperty]
        public string DegreeProgram { get; set; } = "";

        [FirestoreProperty]
        public List<Accommodation> Accommodations { get; set; } 

        public User(string fName, string lName, string uName, string sex, string address, string email, string contactNo, string password)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Username = uName;
            this.Sex = sex;
            this.Address = address;
            this.Email = email;
            this.ContactNumber = contactNo;
            this.Password = password;
            this.Accommodations = new List<Accommodation>();
            this.isLandlord = true;
        }

        public User(string fName, string lName, string uName, string sex, string address, string email, string contactNo, string password, string degreeProgram, string college)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Username = uName;
            this.Sex = sex;
            this.Address = address;
            this.Email = email;
            this.ContactNumber = contactNo;
            this.Password = password;
            this.isLandlord = false;
            this.DegreeProgram = degreeProgram;
            this.College = college;
        }

        public User()
        {

        }
    }

    
    
}
