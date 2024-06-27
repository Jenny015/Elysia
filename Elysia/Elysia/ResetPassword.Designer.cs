namespace Elysia
{
    partial class ResetPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_reset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_npassword = new System.Windows.Forms.TextBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(169, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(166, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username: ";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.MistyRose;
            this.tb_password.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_password.Location = new System.Drawing.Point(258, 183);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(300, 26);
            this.tb_password.TabIndex = 11;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.MistyRose;
            this.tb_username.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_username.Location = new System.Drawing.Point(258, 131);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(300, 26);
            this.tb_username.TabIndex = 10;
            // 
            // lb_reset
            // 
            this.lb_reset.AutoSize = true;
            this.lb_reset.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lb_reset.Location = new System.Drawing.Point(284, 66);
            this.lb_reset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_reset.Name = "lb_reset";
            this.lb_reset.Size = new System.Drawing.Size(207, 29);
            this.lb_reset.TabIndex = 9;
            this.lb_reset.Text = "Reset Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(130, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = " New Password: ";
            // 
            // tb_npassword
            // 
            this.tb_npassword.BackColor = System.Drawing.Color.MistyRose;
            this.tb_npassword.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_npassword.Location = new System.Drawing.Point(258, 230);
            this.tb_npassword.Name = "tb_npassword";
            this.tb_npassword.PasswordChar = '*';
            this.tb_npassword.Size = new System.Drawing.Size(300, 26);
            this.tb_npassword.TabIndex = 14;
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.Plum;
            this.btn_Change.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_Change.Location = new System.Drawing.Point(340, 301);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(100, 29);
            this.btn_Change.TabIndex = 16;
            this.btn_Change.Text = "Reset";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_npassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_reset);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_npassword;
        private System.Windows.Forms.Button btn_Change;
    }
}