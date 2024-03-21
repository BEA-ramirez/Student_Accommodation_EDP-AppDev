using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAccommodationPortal;


namespace StudentAccomodationUI
{
    public partial class AccommodationUI : UserControl
    {
        
        User user;
        public AccommodationUI( User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            od.Filter = "Image files(*.jpg, *.jpeg, *.bmp, *.png) | *.jpg; *.jpeg; *.bmp; *.png|All files (*.*)|*.*";
            if(od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(od.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameTB.Text) || string.IsNullOrEmpty(typeCB.SelectedItem.ToString()) || string.IsNullOrEmpty(locationTB.Text) || string.IsNullOrEmpty(campusProxTB.Text) || string.IsNullOrEmpty(descriptionTB.Text) || pictureBox1.Image == null)
            {
                MessageBox.Show("Please filled in the required fields.");
                return;
            }

            
        }
        
        
    }
}
