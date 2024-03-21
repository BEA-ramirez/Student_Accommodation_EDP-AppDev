namespace StudentAccomodationUI
{
    partial class AccommodationUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campusProxTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.od = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(163, 55);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(121, 20);
            this.nameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Apartment",
            "Studio",
            "Dormitory",
            "House"});
            this.typeCB.Location = new System.Drawing.Point(163, 97);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(121, 21);
            this.typeCB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location";
            // 
            // locationTB
            // 
            this.locationTB.Location = new System.Drawing.Point(163, 137);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(121, 20);
            this.locationTB.TabIndex = 6;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(101, 245);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(201, 153);
            this.descriptionTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // campusProxTB
            // 
            this.campusProxTB.Location = new System.Drawing.Point(193, 176);
            this.campusProxTB.Name = "campusProxTB";
            this.campusProxTB.Size = new System.Drawing.Size(91, 20);
            this.campusProxTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Campus Proximity";
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(392, 58);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(94, 23);
            this.upload.TabIndex = 13;
            this.upload.Text = "upload photo";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(392, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // od
            // 
            this.od.FileName = "openFileDialog1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(392, 245);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 23);
            this.save.TabIndex = 15;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(225, 33);
            this.label.TabIndex = 16;
            this.label.Text = "Accommodation";
            // 
            // AccommodationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.campusProxTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locationTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "AccommodationUI";
            this.Size = new System.Drawing.Size(645, 414);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTB;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campusProxTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog od;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label;
    }
}
