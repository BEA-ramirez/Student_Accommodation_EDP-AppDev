using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using StudentAccommodationPortal;



namespace StudentAccomodationUI
{
    public partial class SignUp : UserControl
    {

        public SignUp()
        {
            InitializeComponent();

            userPanel.Visible = false;
            landlordPanel.Visible = false;
            studentPanel.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (studentRB.Checked == true)
            {
                userPanel.Visible = true;
                landlordPanel.Visible = false;
                studentPanel.Visible = true;
            }
            else
            {
                studentPanel.Visible = false;
                userPanel.Visible = false;
            }

        }

        private void landlordRB_CheckedChanged(object sender, EventArgs e)
        {
            if (landlordRB.Checked == true)
            {
                userPanel.Visible = true;
                studentPanel.Visible = false;
                landlordPanel.Visible = true;
            }
            else
            {
                landlordPanel.Visible = false;
                userPanel.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Controls.Clear();
            this.Controls.Add(login);
        }

        private void signupLandlordB_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;

            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("User already exist");
                return;
            }

            var data = getWriteData();
            DocumentReference docRef = db.Collection("User").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("Success");

            this.Controls.Clear();
            Login lg = new Login();
            this.Controls.Add(lg);

        }

        private User getWriteData()
        {
            
            string fname = fNameTB.Text.Trim();
            string lname = lNameTB.Text.Trim();
            string username = usernameTB.Text.Trim();
            string sex = sexCB.Text.Trim();
            string address = addressTB.Text.Trim();
            string email = emailTB.Text.Trim();
            string contactNo = contactNoTB.Text.Trim();
            string password = Security.Encrypt(passwordLTB.Text);

            if (studentRB.Checked == true)
            {
                password = Security.Encrypt(passwordSTB.Text);
                string college = collegeTB.Text.Trim();
                string degreeProg = degreePrgTB.Text.Trim();
                return new User(fname, lname, username, sex, address, email, contactNo, password, degreeProg, college);
            }
            return new User(fname, lname, username, sex, address, email, contactNo, password);
        }

        private bool CheckIfUserAlreadyExist()
        {
            string username = usernameTB.Text.Trim();

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("User").Document(username);
            User data = docRef.GetSnapshotAsync().Result.ConvertTo<User>();

            if (data != null)
            {
                return true;
            }
            return false;
        }

        private void signupStudentB_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;

            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("User already exist");
                return;
            }

            var data = getWriteData();
            DocumentReference docRef = db.Collection("User").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("Success");

            this.Controls.Clear();
            Login lg = new Login();
            this.Controls.Add(lg);
        }
    }
}
