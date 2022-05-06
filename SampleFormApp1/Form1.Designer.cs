
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SocialSecurityNumberTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(20, 22);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(189, 23);
            this.CountryComboBox.TabIndex = 0;
            // 
            // ValidateButton
            // 
            this.ValidateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateButton.Location = new System.Drawing.Point(426, 189);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(75, 29);
            this.ValidateButton.TabIndex = 1;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CountryComboBox);
            this.groupBox1.Location = new System.Drawing.Point(280, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(23, 48);
            this.FirstNameTextBox.MaxLength = 10;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "place first name here";
            this.FirstNameTextBox.Size = new System.Drawing.Size(164, 23);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.Text = "Karen";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(23, 104);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PlaceholderText = "place last name here";
            this.LastNameTextBox.Size = new System.Drawing.Size(164, 23);
            this.LastNameTextBox.TabIndex = 6;
            this.LastNameTextBox.Text = "Payne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pin";
            // 
            // PinTextBox
            // 
            this.PinTextBox.Location = new System.Drawing.Point(280, 21);
            this.PinTextBox.MaxLength = 4;
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(55, 23);
            this.PinTextBox.TabIndex = 8;
            this.PinTextBox.Text = "1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "SSN";
            // 
            // SocialSecurityNumberTextBox
            // 
            this.SocialSecurityNumberTextBox.Location = new System.Drawing.Point(280, 53);
            this.SocialSecurityNumberTextBox.Name = "SocialSecurityNumberTextBox";
            this.SocialSecurityNumberTextBox.PlaceholderText = "000-00-0000";
            this.SocialSecurityNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.SocialSecurityNumberTextBox.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(386, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show/Hide SSN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Postal code";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(23, 164);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.PostalCodeTextBox.TabIndex = 13;
            this.PostalCodeTextBox.Text = "97209";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 238);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SocialSecurityNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ValidateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation code sample";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SocialSecurityNumberTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
    }
}

