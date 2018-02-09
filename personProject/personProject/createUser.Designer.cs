namespace personProject
{
    partial class createUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.createEmailText = new System.Windows.Forms.TextBox();
            this.createStateText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createFirstNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createLastNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createAddressText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.createCityText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.createZipText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createPersonButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create User";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // createEmailText
            // 
            this.createEmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createEmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createEmailText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmailText.ForeColor = System.Drawing.Color.DarkGray;
            this.createEmailText.Location = new System.Drawing.Point(145, 88);
            this.createEmailText.Name = "createEmailText";
            this.createEmailText.Size = new System.Drawing.Size(239, 26);
            this.createEmailText.TabIndex = 8;
            this.createEmailText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.createFirstNameText_KeyPress);
            // 
            // createStateText
            // 
            this.createStateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createStateText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createStateText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createStateText.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.createStateText.ForeColor = System.Drawing.Color.DarkGray;
            this.createStateText.FormattingEnabled = true;
            this.createStateText.Items.AddRange(new object[] {
            "",
            "AK",
            "AL",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.createStateText.Location = new System.Drawing.Point(145, 296);
            this.createStateText.Name = "createStateText";
            this.createStateText.Size = new System.Drawing.Size(49, 33);
            this.createStateText.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createFirstNameText
            // 
            this.createFirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createFirstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createFirstNameText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFirstNameText.ForeColor = System.Drawing.Color.DarkGray;
            this.createFirstNameText.Location = new System.Drawing.Point(145, 131);
            this.createFirstNameText.Name = "createFirstNameText";
            this.createFirstNameText.Size = new System.Drawing.Size(239, 26);
            this.createFirstNameText.TabIndex = 9;
            this.createFirstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.createFirstNameText_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createLastNameText
            // 
            this.createLastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createLastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createLastNameText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLastNameText.ForeColor = System.Drawing.Color.DarkGray;
            this.createLastNameText.Location = new System.Drawing.Point(145, 174);
            this.createLastNameText.Name = "createLastNameText";
            this.createLastNameText.Size = new System.Drawing.Size(239, 26);
            this.createLastNameText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(7, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createAddressText
            // 
            this.createAddressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createAddressText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAddressText.ForeColor = System.Drawing.Color.DarkGray;
            this.createAddressText.Location = new System.Drawing.Point(145, 217);
            this.createAddressText.Name = "createAddressText";
            this.createAddressText.Size = new System.Drawing.Size(239, 26);
            this.createAddressText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(7, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "City:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createCityText
            // 
            this.createCityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createCityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createCityText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCityText.ForeColor = System.Drawing.Color.DarkGray;
            this.createCityText.Location = new System.Drawing.Point(145, 259);
            this.createCityText.Name = "createCityText";
            this.createCityText.Size = new System.Drawing.Size(239, 26);
            this.createCityText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(7, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zip:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createZipText
            // 
            this.createZipText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.createZipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createZipText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createZipText.ForeColor = System.Drawing.Color.DarkGray;
            this.createZipText.Location = new System.Drawing.Point(145, 339);
            this.createZipText.MaxLength = 5;
            this.createZipText.Name = "createZipText";
            this.createZipText.Size = new System.Drawing.Size(107, 26);
            this.createZipText.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(7, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "State:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createPersonButton
            // 
            this.createPersonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.createPersonButton.FlatAppearance.BorderSize = 0;
            this.createPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPersonButton.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.createPersonButton.ForeColor = System.Drawing.Color.White;
            this.createPersonButton.Location = new System.Drawing.Point(129, 469);
            this.createPersonButton.Name = "createPersonButton";
            this.createPersonButton.Size = new System.Drawing.Size(153, 43);
            this.createPersonButton.TabIndex = 15;
            this.createPersonButton.Text = "Create";
            this.createPersonButton.UseVisualStyleBackColor = false;
            this.createPersonButton.Click += new System.EventHandler(this.createPersonButton_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(7, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(145, 380);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(239, 26);
            this.passwordTextBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(7, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Confirm:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(145, 421);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(239, 26);
            this.confirmPasswordTextBox.TabIndex = 21;
            // 
            // createUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 530);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.createZipText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createCityText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createAddressText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createLastNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createFirstNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createStateText);
            this.Controls.Add(this.createEmailText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPersonButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "createUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.label1_Click_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createEmailText;
        private System.Windows.Forms.ComboBox createStateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createFirstNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox createLastNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox createAddressText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox createCityText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox createZipText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createPersonButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
    }
}