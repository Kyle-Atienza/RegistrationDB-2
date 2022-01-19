
namespace RegistrationDB_2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.tbxBirthDate = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.tbxBarangay = new System.Windows.Forms.TextBox();
            this.lblMunicipality = new System.Windows.Forms.Label();
            this.tbxMunicipality = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lbxProvince = new System.Windows.Forms.ListBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.cbxSports = new System.Windows.Forms.CheckBox();
            this.cbxMusic = new System.Windows.Forms.CheckBox();
            this.cbxArts = new System.Windows.Forms.CheckBox();
            this.cbxVirtualGames = new System.Windows.Forms.CheckBox();
            this.cbxMovies = new System.Windows.Forms.CheckBox();
            this.lblOthers = new System.Windows.Forms.Label();
            this.tbxOthers = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(200, 124);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(276, 20);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(104, 127);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(104, 153);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(200, 150);
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(276, 20);
            this.tbxMiddleName.TabIndex = 3;
            this.tbxMiddleName.TextChanged += new System.EventHandler(this.tbxMiddleName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(104, 179);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(200, 176);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(276, 20);
            this.tbxLastName.TabIndex = 5;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(104, 224);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(200, 222);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(48, 17);
            this.rbnMale.TabIndex = 8;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(263, 222);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbnFemale.TabIndex = 9;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(104, 267);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 11;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // tbxBirthDate
            // 
            this.tbxBirthDate.Location = new System.Drawing.Point(200, 264);
            this.tbxBirthDate.Name = "tbxBirthDate";
            this.tbxBirthDate.Size = new System.Drawing.Size(276, 20);
            this.tbxBirthDate.TabIndex = 10;
            this.tbxBirthDate.TextChanged += new System.EventHandler(this.tbxBirthDate_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(104, 295);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.Location = new System.Drawing.Point(119, 321);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(52, 13);
            this.lblBarangay.TabIndex = 15;
            this.lblBarangay.Text = "Barangay";
            // 
            // tbxBarangay
            // 
            this.tbxBarangay.Location = new System.Drawing.Point(200, 321);
            this.tbxBarangay.Name = "tbxBarangay";
            this.tbxBarangay.Size = new System.Drawing.Size(276, 20);
            this.tbxBarangay.TabIndex = 14;
            this.tbxBarangay.TextChanged += new System.EventHandler(this.tbxBarangay_TextChanged);
            // 
            // lblMunicipality
            // 
            this.lblMunicipality.AutoSize = true;
            this.lblMunicipality.Location = new System.Drawing.Point(119, 347);
            this.lblMunicipality.Name = "lblMunicipality";
            this.lblMunicipality.Size = new System.Drawing.Size(62, 13);
            this.lblMunicipality.TabIndex = 17;
            this.lblMunicipality.Text = "Municipality";
            // 
            // tbxMunicipality
            // 
            this.tbxMunicipality.Location = new System.Drawing.Point(200, 347);
            this.tbxMunicipality.Name = "tbxMunicipality";
            this.tbxMunicipality.Size = new System.Drawing.Size(276, 20);
            this.tbxMunicipality.TabIndex = 16;
            this.tbxMunicipality.TextChanged += new System.EventHandler(this.tbxMunicipality_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(211, 573);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 33);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewRecords
            // 
            this.btnViewRecords.Location = new System.Drawing.Point(372, 573);
            this.btnViewRecords.Name = "btnViewRecords";
            this.btnViewRecords.Size = new System.Drawing.Size(142, 33);
            this.btnViewRecords.TabIndex = 19;
            this.btnViewRecords.Text = "View Records";
            this.btnViewRecords.UseVisualStyleBackColor = true;
            this.btnViewRecords.Click += new System.EventHandler(this.btnViewRecords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registration Form";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(119, 392);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(49, 13);
            this.lblProvince.TabIndex = 22;
            this.lblProvince.Text = "Province";
            // 
            // lbxProvince
            // 
            this.lbxProvince.FormattingEnabled = true;
            this.lbxProvince.Items.AddRange(new object[] {
            "Cavite",
            "Laguna",
            "Batangas",
            "Rizal",
            "Quezon"});
            this.lbxProvince.Location = new System.Drawing.Point(200, 392);
            this.lbxProvince.Name = "lbxProvince";
            this.lbxProvince.Size = new System.Drawing.Size(120, 43);
            this.lbxProvince.TabIndex = 23;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(104, 463);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(46, 13);
            this.lblHobbies.TabIndex = 24;
            this.lblHobbies.Text = "Hobbies";
            // 
            // cbxSports
            // 
            this.cbxSports.AutoSize = true;
            this.cbxSports.Location = new System.Drawing.Point(200, 463);
            this.cbxSports.Name = "cbxSports";
            this.cbxSports.Size = new System.Drawing.Size(56, 17);
            this.cbxSports.TabIndex = 25;
            this.cbxSports.Text = "Sports";
            this.cbxSports.UseVisualStyleBackColor = true;
            // 
            // cbxMusic
            // 
            this.cbxMusic.AutoSize = true;
            this.cbxMusic.Location = new System.Drawing.Point(200, 486);
            this.cbxMusic.Name = "cbxMusic";
            this.cbxMusic.Size = new System.Drawing.Size(54, 17);
            this.cbxMusic.TabIndex = 26;
            this.cbxMusic.Text = "Music";
            this.cbxMusic.UseVisualStyleBackColor = true;
            // 
            // cbxArts
            // 
            this.cbxArts.AutoSize = true;
            this.cbxArts.Location = new System.Drawing.Point(200, 509);
            this.cbxArts.Name = "cbxArts";
            this.cbxArts.Size = new System.Drawing.Size(44, 17);
            this.cbxArts.TabIndex = 27;
            this.cbxArts.Text = "Arts";
            this.cbxArts.UseVisualStyleBackColor = true;
            // 
            // cbxVirtualGames
            // 
            this.cbxVirtualGames.AutoSize = true;
            this.cbxVirtualGames.Location = new System.Drawing.Point(310, 486);
            this.cbxVirtualGames.Name = "cbxVirtualGames";
            this.cbxVirtualGames.Size = new System.Drawing.Size(91, 17);
            this.cbxVirtualGames.TabIndex = 29;
            this.cbxVirtualGames.Text = "Virtual Games";
            this.cbxVirtualGames.UseVisualStyleBackColor = true;
            // 
            // cbxMovies
            // 
            this.cbxMovies.AutoSize = true;
            this.cbxMovies.Location = new System.Drawing.Point(310, 463);
            this.cbxMovies.Name = "cbxMovies";
            this.cbxMovies.Size = new System.Drawing.Size(60, 17);
            this.cbxMovies.TabIndex = 28;
            this.cbxMovies.Text = "Movies";
            this.cbxMovies.UseVisualStyleBackColor = true;
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Location = new System.Drawing.Point(307, 510);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(38, 13);
            this.lblOthers.TabIndex = 30;
            this.lblOthers.Text = "Others";
            // 
            // tbxOthers
            // 
            this.tbxOthers.Location = new System.Drawing.Point(351, 507);
            this.tbxOthers.Name = "tbxOthers";
            this.tbxOthers.Size = new System.Drawing.Size(125, 20);
            this.tbxOthers.TabIndex = 31;
            this.tbxOthers.TextChanged += new System.EventHandler(this.tbxOthers_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(50, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 33);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 657);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxOthers);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.cbxVirtualGames);
            this.Controls.Add(this.cbxMovies);
            this.Controls.Add(this.cbxArts);
            this.Controls.Add(this.cbxMusic);
            this.Controls.Add(this.cbxSports);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lbxProvince);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewRecords);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMunicipality);
            this.Controls.Add(this.tbxMunicipality);
            this.Controls.Add(this.lblBarangay);
            this.Controls.Add(this.tbxBarangay);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.tbxBirthDate);
            this.Controls.Add(this.rbnFemale);
            this.Controls.Add(this.rbnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox tbxBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.TextBox tbxBarangay;
        private System.Windows.Forms.Label lblMunicipality;
        private System.Windows.Forms.TextBox tbxMunicipality;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ListBox lbxProvince;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.CheckBox cbxSports;
        private System.Windows.Forms.CheckBox cbxMusic;
        private System.Windows.Forms.CheckBox cbxArts;
        private System.Windows.Forms.CheckBox cbxVirtualGames;
        private System.Windows.Forms.CheckBox cbxMovies;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.TextBox tbxOthers;
        private System.Windows.Forms.Button btnUpdate;
    }
}

