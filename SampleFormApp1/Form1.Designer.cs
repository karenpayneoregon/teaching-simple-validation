
namespace SampleFormApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MakeCountryNullCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SocialSecurityNumberTextBox = new System.Windows.Forms.TextBox();
            this.ShowHidePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.ValidNoteCountCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CreditCardTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentDateTimePicker1 = new WindowsFormsLibrary.Controls.NullableDateTimePicker();
            this.BirthDatePicker = new WindowsFormsLibrary.Controls.NullableDateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownHeight = 150;
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.IntegralHeight = false;
            this.CountryComboBox.ItemHeight = 15;
            this.CountryComboBox.Location = new System.Drawing.Point(20, 22);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(189, 23);
            this.CountryComboBox.TabIndex = 0;
            // 
            // ValidateButton
            // 
            this.ValidateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateButton.Image = global::SampleFormApp1.Properties.Resources.ValidationRule_16x;
            this.ValidateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValidateButton.Location = new System.Drawing.Point(428, 349);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(73, 36);
            this.ValidateButton.TabIndex = 1;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MakeCountryNullCheckBox);
            this.groupBox1.Controls.Add(this.CountryComboBox);
            this.groupBox1.Location = new System.Drawing.Point(269, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C&ountry";
            // 
            // MakeCountryNullCheckBox
            // 
            this.MakeCountryNullCheckBox.AutoSize = true;
            this.MakeCountryNullCheckBox.Location = new System.Drawing.Point(20, 51);
            this.MakeCountryNullCheckBox.Name = "MakeCountryNullCheckBox";
            this.MakeCountryNullCheckBox.Size = new System.Drawing.Size(122, 19);
            this.MakeCountryNullCheckBox.TabIndex = 1;
            this.MakeCountryNullCheckBox.Text = "Make country null";
            this.MakeCountryNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(16, 13);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(62, 15);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "&First name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(20, 37);
            this.FirstNameTextBox.MaxLength = 10;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "place first name here";
            this.FirstNameTextBox.Size = new System.Drawing.Size(164, 23);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.Text = "Karen";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(20, 93);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PlaceholderText = "place last name here";
            this.LastNameTextBox.Size = new System.Drawing.Size(164, 23);
            this.LastNameTextBox.TabIndex = 6;
            this.LastNameTextBox.Text = "Payne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pi&n";
            // 
            // PinTextBox
            // 
            this.PinTextBox.Location = new System.Drawing.Point(280, 13);
            this.PinTextBox.MaxLength = 4;
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(55, 23);
            this.PinTextBox.TabIndex = 8;
            this.PinTextBox.Text = "1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "&SSN";
            // 
            // SocialSecurityNumberTextBox
            // 
            this.SocialSecurityNumberTextBox.Location = new System.Drawing.Point(280, 45);
            this.SocialSecurityNumberTextBox.Name = "SocialSecurityNumberTextBox";
            this.SocialSecurityNumberTextBox.PlaceholderText = "000-00-0000";
            this.SocialSecurityNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.SocialSecurityNumberTextBox.TabIndex = 10;
            // 
            // ShowHidePasswordCheckBox
            // 
            this.ShowHidePasswordCheckBox.AutoSize = true;
            this.ShowHidePasswordCheckBox.Location = new System.Drawing.Point(386, 45);
            this.ShowHidePasswordCheckBox.Name = "ShowHidePasswordCheckBox";
            this.ShowHidePasswordCheckBox.Size = new System.Drawing.Size(109, 19);
            this.ShowHidePasswordCheckBox.TabIndex = 11;
            this.ShowHidePasswordCheckBox.Text = "Show/Hide SSN";
            this.ShowHidePasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowHidePasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowHidePasswordCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "&Postal code";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(20, 201);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.PostalCodeTextBox.TabIndex = 13;
            this.PostalCodeTextBox.Text = "97209";
            // 
            // ValidNoteCountCheckBox
            // 
            this.ValidNoteCountCheckBox.AutoSize = true;
            this.ValidNoteCountCheckBox.Checked = true;
            this.ValidNoteCountCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ValidNoteCountCheckBox.Location = new System.Drawing.Point(289, 170);
            this.ValidNoteCountCheckBox.Name = "ValidNoteCountCheckBox";
            this.ValidNoteCountCheckBox.Size = new System.Drawing.Size(112, 19);
            this.ValidNoteCountCheckBox.TabIndex = 15;
            this.ValidNoteCountCheckBox.Text = "Valid note count";
            this.ValidNoteCountCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Birth &date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "&Credit card number";
            // 
            // CreditCardTextBox
            // 
            this.CreditCardTextBox.Location = new System.Drawing.Point(20, 257);
            this.CreditCardTextBox.Name = "CreditCardTextBox";
            this.CreditCardTextBox.Size = new System.Drawing.Size(171, 23);
            this.CreditCardTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Appintment date";
            // 
            // AppointmentDateTimePicker1
            // 
            this.AppointmentDateTimePicker1.CustomFormat = "";
            this.AppointmentDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppointmentDateTimePicker1.Location = new System.Drawing.Point(20, 322);
            this.AppointmentDateTimePicker1.Name = "AppointmentDateTimePicker1";
            this.AppointmentDateTimePicker1.ShowUpDown = true;
            this.AppointmentDateTimePicker1.Size = new System.Drawing.Size(164, 23);
            this.AppointmentDateTimePicker1.TabIndex = 21;
            this.AppointmentDateTimePicker1.Value = new System.DateTime(2022, 5, 7, 8, 54, 53, 185);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.CustomFormat = "";
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatePicker.Location = new System.Drawing.Point(20, 150);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.ShowUpDown = true;
            this.BirthDatePicker.Size = new System.Drawing.Size(164, 23);
            this.BirthDatePicker.TabIndex = 23;
            this.BirthDatePicker.Value = new System.DateTime(2022, 5, 7, 8, 54, 53, 185);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 392);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.AppointmentDateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreditCardTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ValidNoteCountCheckBox);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowHidePasswordCheckBox);
            this.Controls.Add(this.SocialSecurityNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ValidateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation code sample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SocialSecurityNumberTextBox;
        private System.Windows.Forms.CheckBox ShowHidePasswordCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.CheckBox MakeCountryNullCheckBox;
        private System.Windows.Forms.CheckBox ValidNoteCountCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CreditCardTextBox;
        private System.Windows.Forms.Label label1;
        private WindowsFormsLibrary.Controls.NullableDateTimePicker AppointmentDateTimePicker1;
        private WindowsFormsLibrary.Controls.NullableDateTimePicker BirthDatePicker;
    }
}

