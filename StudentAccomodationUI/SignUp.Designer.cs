namespace StudentAccomodationUI
{
    partial class SignUp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.landlordRB = new System.Windows.Forms.RadioButton();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.userPanel = new System.Windows.Forms.Panel();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contactNoTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sexCB = new System.Windows.Forms.ComboBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordSTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cPasswordSTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.signupStudentB = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.degreePrgTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.collegeTB = new System.Windows.Forms.TextBox();
            this.landlordPanel = new System.Windows.Forms.Panel();
            this.signupLandlordB = new System.Windows.Forms.Button();
            this.cPasswordLTB = new System.Windows.Forms.TextBox();
            this.passwordLTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.userPanel.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.landlordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // landlordRB
            // 
            this.landlordRB.AutoSize = true;
            this.landlordRB.Location = new System.Drawing.Point(240, 154);
            this.landlordRB.Name = "landlordRB";
            this.landlordRB.Size = new System.Drawing.Size(66, 17);
            this.landlordRB.TabIndex = 10;
            this.landlordRB.TabStop = true;
            this.landlordRB.Text = "Landlord";
            this.landlordRB.UseVisualStyleBackColor = true;
            this.landlordRB.CheckedChanged += new System.EventHandler(this.landlordRB_CheckedChanged);
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Location = new System.Drawing.Point(98, 154);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(62, 17);
            this.studentRB.TabIndex = 9;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Student";
            this.studentRB.UseVisualStyleBackColor = true;
            this.studentRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.ageTB);
            this.userPanel.Controls.Add(this.label8);
            this.userPanel.Controls.Add(this.contactNoTB);
            this.userPanel.Controls.Add(this.label7);
            this.userPanel.Controls.Add(this.emailTB);
            this.userPanel.Controls.Add(this.label6);
            this.userPanel.Controls.Add(this.sexCB);
            this.userPanel.Controls.Add(this.addressTB);
            this.userPanel.Controls.Add(this.label5);
            this.userPanel.Controls.Add(this.label4);
            this.userPanel.Controls.Add(this.lNameTB);
            this.userPanel.Controls.Add(this.label3);
            this.userPanel.Controls.Add(this.fNameTB);
            this.userPanel.Controls.Add(this.usernameTB);
            this.userPanel.Controls.Add(this.label2);
            this.userPanel.Controls.Add(this.label1);
            this.userPanel.Location = new System.Drawing.Point(63, 192);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(294, 256);
            this.userPanel.TabIndex = 11;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(175, 125);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(92, 20);
            this.ageTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Age";
            // 
            // contactNoTB
            // 
            this.contactNoTB.Location = new System.Drawing.Point(109, 231);
            this.contactNoTB.Name = "contactNoTB";
            this.contactNoTB.Size = new System.Drawing.Size(159, 20);
            this.contactNoTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact No.";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(109, 195);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(159, 20);
            this.emailTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // sexCB
            // 
            this.sexCB.FormattingEnabled = true;
            this.sexCB.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.sexCB.Location = new System.Drawing.Point(46, 125);
            this.sexCB.Name = "sexCB";
            this.sexCB.Size = new System.Drawing.Size(81, 21);
            this.sexCB.TabIndex = 10;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(108, 159);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(159, 20);
            this.addressTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sex";
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(109, 88);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(159, 20);
            this.lNameTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(108, 52);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(159, 20);
            this.fNameTB.TabIndex = 3;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(109, 17);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(158, 20);
            this.usernameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // passwordSTB
            // 
            this.passwordSTB.Location = new System.Drawing.Point(108, 94);
            this.passwordSTB.Name = "passwordSTB";
            this.passwordSTB.PasswordChar = '\"';
            this.passwordSTB.Size = new System.Drawing.Size(159, 20);
            this.passwordSTB.TabIndex = 17;
            this.passwordSTB.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Password";
            // 
            // cPasswordSTB
            // 
            this.cPasswordSTB.Location = new System.Drawing.Point(108, 131);
            this.cPasswordSTB.Name = "cPasswordSTB";
            this.cPasswordSTB.Size = new System.Drawing.Size(159, 20);
            this.cPasswordSTB.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Confirm password";
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.signupStudentB);
            this.studentPanel.Controls.Add(this.label12);
            this.studentPanel.Controls.Add(this.degreePrgTB);
            this.studentPanel.Controls.Add(this.label11);
            this.studentPanel.Controls.Add(this.collegeTB);
            this.studentPanel.Controls.Add(this.cPasswordSTB);
            this.studentPanel.Controls.Add(this.label10);
            this.studentPanel.Controls.Add(this.label9);
            this.studentPanel.Controls.Add(this.passwordSTB);
            this.studentPanel.Location = new System.Drawing.Point(64, 450);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(294, 195);
            this.studentPanel.TabIndex = 12;
            this.studentPanel.Visible = false;
            // 
            // signupStudentB
            // 
            this.signupStudentB.Location = new System.Drawing.Point(104, 168);
            this.signupStudentB.Name = "signupStudentB";
            this.signupStudentB.Size = new System.Drawing.Size(75, 23);
            this.signupStudentB.TabIndex = 14;
            this.signupStudentB.Text = "Sign up";
            this.signupStudentB.UseVisualStyleBackColor = true;
            this.signupStudentB.Click += new System.EventHandler(this.signupStudentB_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Degree Program";
            // 
            // degreePrgTB
            // 
            this.degreePrgTB.Location = new System.Drawing.Point(108, 53);
            this.degreePrgTB.Name = "degreePrgTB";
            this.degreePrgTB.Size = new System.Drawing.Size(159, 20);
            this.degreePrgTB.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "College";
            // 
            // collegeTB
            // 
            this.collegeTB.Location = new System.Drawing.Point(108, 15);
            this.collegeTB.Name = "collegeTB";
            this.collegeTB.Size = new System.Drawing.Size(159, 20);
            this.collegeTB.TabIndex = 21;
            // 
            // landlordPanel
            // 
            this.landlordPanel.Controls.Add(this.signupLandlordB);
            this.landlordPanel.Controls.Add(this.cPasswordLTB);
            this.landlordPanel.Controls.Add(this.passwordLTB);
            this.landlordPanel.Controls.Add(this.label13);
            this.landlordPanel.Controls.Add(this.label14);
            this.landlordPanel.Location = new System.Drawing.Point(61, 453);
            this.landlordPanel.Name = "landlordPanel";
            this.landlordPanel.Size = new System.Drawing.Size(294, 113);
            this.landlordPanel.TabIndex = 13;
            // 
            // signupLandlordB
            // 
            this.signupLandlordB.Location = new System.Drawing.Point(104, 78);
            this.signupLandlordB.Name = "signupLandlordB";
            this.signupLandlordB.Size = new System.Drawing.Size(75, 23);
            this.signupLandlordB.TabIndex = 24;
            this.signupLandlordB.Text = "Sign up";
            this.signupLandlordB.UseVisualStyleBackColor = true;
            this.signupLandlordB.Click += new System.EventHandler(this.signupLandlordB_Click);
            // 
            // cPasswordLTB
            // 
            this.cPasswordLTB.Location = new System.Drawing.Point(108, 41);
            this.cPasswordLTB.Name = "cPasswordLTB";
            this.cPasswordLTB.Size = new System.Drawing.Size(159, 20);
            this.cPasswordLTB.TabIndex = 28;
            // 
            // passwordLTB
            // 
            this.passwordLTB.Location = new System.Drawing.Point(108, 4);
            this.passwordLTB.Name = "passwordLTB";
            this.passwordLTB.PasswordChar = '\"';
            this.passwordLTB.Size = new System.Drawing.Size(159, 20);
            this.passwordLTB.TabIndex = 26;
            this.passwordLTB.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Confirm password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Password";
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.landlordPanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.landlordRB);
            this.Controls.Add(this.studentRB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(446, 655);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.landlordPanel.ResumeLayout(false);
            this.landlordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton landlordRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.ComboBox sexCB;
        private System.Windows.Forms.TextBox contactNoTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cPasswordSTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passwordSTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox degreePrgTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox collegeTB;
        private System.Windows.Forms.Button signupStudentB;
        private System.Windows.Forms.Panel landlordPanel;
        private System.Windows.Forms.Button signupLandlordB;
        private System.Windows.Forms.TextBox cPasswordLTB;
        private System.Windows.Forms.TextBox passwordLTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
