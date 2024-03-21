namespace StudentAccomodationUI
{
    partial class AmenityUI
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
            this.amenityNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amenityTypeCB = new System.Windows.Forms.ComboBox();
            this.amenityB = new System.Windows.Forms.Button();
            this.amenitiesList = new System.Windows.Forms.ListBox();
            this.upload = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.od = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amenity Name";
            // 
            // amenityNameTB
            // 
            this.amenityNameTB.Location = new System.Drawing.Point(386, 56);
            this.amenityNameTB.Name = "amenityNameTB";
            this.amenityNameTB.Size = new System.Drawing.Size(200, 20);
            this.amenityNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amenity Type";
            // 
            // amenityTypeCB
            // 
            this.amenityTypeCB.FormattingEnabled = true;
            this.amenityTypeCB.Items.AddRange(new object[] {
            "General",
            "Security&Safety",
            "Building ",
            "Utility",
            "Additional"});
            this.amenityTypeCB.Location = new System.Drawing.Point(386, 103);
            this.amenityTypeCB.Name = "amenityTypeCB";
            this.amenityTypeCB.Size = new System.Drawing.Size(200, 21);
            this.amenityTypeCB.TabIndex = 3;
            // 
            // amenityB
            // 
            this.amenityB.Location = new System.Drawing.Point(134, 15);
            this.amenityB.Name = "amenityB";
            this.amenityB.Size = new System.Drawing.Size(112, 23);
            this.amenityB.TabIndex = 6;
            this.amenityB.Text = "Create Amenity";
            this.amenityB.UseVisualStyleBackColor = true;
            this.amenityB.Click += new System.EventHandler(this.amenityB_Click);
            // 
            // amenitiesList
            // 
            this.amenitiesList.FormattingEnabled = true;
            this.amenitiesList.Location = new System.Drawing.Point(37, 44);
            this.amenitiesList.Name = "amenitiesList";
            this.amenitiesList.Size = new System.Drawing.Size(209, 238);
            this.amenitiesList.TabIndex = 7;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(308, 147);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(99, 23);
            this.upload.TabIndex = 8;
            this.upload.Text = "upload photo +";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(308, 191);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(99, 70);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // od
            // 
            this.od.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amenity";
            // 
            // AmenityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.amenitiesList);
            this.Controls.Add(this.amenityB);
            this.Controls.Add(this.amenityTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amenityNameTB);
            this.Controls.Add(this.label1);
            this.Name = "AmenityUI";
            this.Size = new System.Drawing.Size(618, 326);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amenityNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox amenityTypeCB;
        private System.Windows.Forms.Button amenityB;
        private System.Windows.Forms.ListBox amenitiesList;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog od;
        private System.Windows.Forms.Label label3;
    }
}
