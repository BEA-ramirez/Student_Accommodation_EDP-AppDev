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

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace StudentAccomodationUI
{
    
    public partial class Form2 : Form
    {
       
        public Form2()
        {
           
            InitializeComponent();
            Login lg = new Login();
            this.Controls.Add(lg);
        }
    }
}
