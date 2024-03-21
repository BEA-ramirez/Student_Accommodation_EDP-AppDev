using StudentAccommodationPortal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp.Extensions;
using Google.Cloud.Firestore;
using Google.Type;


namespace StudentAccomodationUI
{
    public partial class Login : UserControl
    {
        public User user;

        public Login()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Controls.Clear();
            this.Controls.Add(signup);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameTB.Text) || string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Please fill in the required fields");
                return;
            }

            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("User").Document(username);
            User data = docRef.GetSnapshotAsync().Result.ConvertTo<User>();

            if (data != null)
            {
                if (password == Security.Decrypt(data.Password))
                {
                    this.user = data;
                    AccommodationUI accom = new AccommodationUI(this.user);
                    this.Controls.Clear();
                    this.Controls.Add(accom);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }
    }
}
