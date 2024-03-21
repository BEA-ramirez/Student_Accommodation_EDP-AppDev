using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace StudentAccomodationUI
{
    public partial class AmenityUI : UserControl
    {
     
        User user;
        public AmenityUI(User user)
        {
            InitializeComponent();
      
            this.user = user;
        }

        private void amenityB_Click(object sender, EventArgs e)
        {
            /*AmenityType type;
            switch(amenityTypeCB.SelectedItem.ToString())
            {
                case "General":
                    type = AmenityType.General;
                    break;
                case "Security&Safety":
                    type = AmenityType.SecuritySafety;
                    break;
                case "Building":
                    type = AmenityType.Building;
                    break;
                case "Utility":
                    type = AmenityType.Utility;
                    break;
                case "Additional":
                    type = AmenityType.Additional;
                    break;
                default:
                    type = AmenityType.General;
                    break;
            }*/

            
        }

        private void upload_Click(object sender, EventArgs e)
        {
            od.Filter = "Image files(*.jpg, *.jpeg, *.bmp, *.png) | *.jpg; *.jpeg; *.bmp; *.png|All files (*.*)|*.*";
            if(od.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(od.FileName);
            }

        }
    }
}
