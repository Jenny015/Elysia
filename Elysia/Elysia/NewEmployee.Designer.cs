﻿namespace Elysia
{
    partial class NewEmployee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbPostion = new System.Windows.Forms.TextBox();
            this.lbDeliveryAddress = new System.Windows.Forms.Label();
            this.lbCompanyAddress = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.lbDealerName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.RadioButton();
            this.f = new System.Windows.Forms.RadioButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deptn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 65);
            this.panel2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Employee";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(166, 676);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Plum;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(32, 676);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbPostion
            // 
            this.tbPostion.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbPostion.Location = new System.Drawing.Point(32, 534);
            this.tbPostion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPostion.Name = "tbPostion";
            this.tbPostion.Size = new System.Drawing.Size(611, 29);
            this.tbPostion.TabIndex = 7;
            // 
            // lbDeliveryAddress
            // 
            this.lbDeliveryAddress.AutoSize = true;
            this.lbDeliveryAddress.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbDeliveryAddress.Location = new System.Drawing.Point(28, 509);
            this.lbDeliveryAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDeliveryAddress.Name = "lbDeliveryAddress";
            this.lbDeliveryAddress.Size = new System.Drawing.Size(71, 22);
            this.lbDeliveryAddress.TabIndex = 65;
            this.lbDeliveryAddress.Text = "Postion";
            // 
            // lbCompanyAddress
            // 
            this.lbCompanyAddress.AutoSize = true;
            this.lbCompanyAddress.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbCompanyAddress.Location = new System.Drawing.Point(28, 452);
            this.lbCompanyAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCompanyAddress.Name = "lbCompanyAddress";
            this.lbCompanyAddress.Size = new System.Drawing.Size(107, 22);
            this.lbCompanyAddress.TabIndex = 63;
            this.lbCompanyAddress.Text = "Department";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbEmail.Location = new System.Drawing.Point(32, 391);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(611, 29);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Leave += new System.EventHandler(this.phoneValidate);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(28, 366);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 22);
            this.lbEmail.TabIndex = 61;
            this.lbEmail.Text = "Email";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(32, 315);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhoneNumber.MaxLength = 8;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(611, 29);
            this.tbPhoneNumber.TabIndex = 4;
            this.tbPhoneNumber.Leave += new System.EventHandler(this.phoneValidate);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbPhoneNumber.Location = new System.Drawing.Point(28, 290);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.lbPhoneNumber.TabIndex = 59;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // tbEmpName
            // 
            this.tbEmpName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbEmpName.Location = new System.Drawing.Point(32, 179);
            this.tbEmpName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.Size = new System.Drawing.Size(611, 29);
            this.tbEmpName.TabIndex = 1;
            // 
            // lbDealerName
            // 
            this.lbDealerName.AutoSize = true;
            this.lbDealerName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbDealerName.Location = new System.Drawing.Point(28, 154);
            this.lbDealerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDealerName.Name = "lbDealerName";
            this.lbDealerName.Size = new System.Drawing.Size(58, 22);
            this.lbDealerName.TabIndex = 55;
            this.lbDealerName.Text = "Name";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblEmpID.Location = new System.Drawing.Point(150, 103);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(103, 21);
            this.lblEmpID.TabIndex = 70;
            this.lblEmpID.Text = "EmployeeID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "EmployeeID: ";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.m.Location = new System.Drawing.Point(114, 234);
            this.m.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(64, 25);
            this.m.TabIndex = 2;
            this.m.TabStop = true;
            this.m.Text = "Male";
            this.m.UseVisualStyleBackColor = true;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.f.Location = new System.Drawing.Point(199, 234);
            this.f.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(81, 25);
            this.f.TabIndex = 3;
            this.f.TabStop = true;
            this.f.Text = "Female";
            this.f.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tbPassword.Location = new System.Drawing.Point(32, 608);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(611, 29);
            this.tbPassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 583);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Password";
            // 
            // deptn
            // 
            this.deptn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptn.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.deptn.FormattingEnabled = true;
            this.deptn.Location = new System.Drawing.Point(139, 450);
            this.deptn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deptn.Name = "deptn";
            this.deptn.Size = new System.Drawing.Size(280, 29);
            this.deptn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "Gender: ";
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deptn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f);
            this.Controls.Add(this.m);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbPostion);
            this.Controls.Add(this.lbDeliveryAddress);
            this.Controls.Add(this.lbCompanyAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.tbEmpName);
            this.Controls.Add(this.lbDealerName);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewEmployee";
            this.Size = new System.Drawing.Size(1002, 762);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbPostion;
        private System.Windows.Forms.Label lbDeliveryAddress;
        private System.Windows.Forms.Label lbCompanyAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.Label lbDealerName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton m;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deptn;
        private System.Windows.Forms.Label label3;
    }
}