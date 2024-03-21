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
    public partial class RoomUI : UserControl
    {
        public RoomUI()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            od.Filter = "Image files(*.jpg, *.jpeg, *.bmp, *.png) | *.jpg; *.jpeg; *.bmp; *.png|All files (*.*)|*.*";   
            if(od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(od.FileName);
            }
        }

        
    }
}
