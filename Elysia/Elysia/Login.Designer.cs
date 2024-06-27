namespace Elysia
{
    partial class Login
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
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_forgetPW = new System.Windows.Forms.Label();
            this.lb_resetPW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lb_login.Location = new System.Drawing.Point(242, 87);
            this.lb_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(83, 29);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.MistyRose;
            this.tb_username.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_username.Location = new System.Drawing.Point(159, 198);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(300, 26);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.MistyRose;
            this.tb_password.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_password.Location = new System.Drawing.Point(159, 250);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(300, 26);
            this.tb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Plum;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_login.Location = new System.Drawing.Point(247, 294);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 29);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login Now";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_forgetPW
            // 
            this.lb_forgetPW.AutoSize = true;
            this.lb_forgetPW.Font = new System.Drawing.Font("Arial", 9F);
            this.lb_forgetPW.ForeColor = System.Drawing.Color.Purple;
            this.lb_forgetPW.Location = new System.Drawing.Point(156, 342);
            this.lb_forgetPW.Name = "lb_forgetPW";
            this.lb_forgetPW.Size = new System.Drawing.Size(107, 15);
            this.lb_forgetPW.TabIndex = 5;
            this.lb_forgetPW.Text = "Forget password?";
            this.lb_forgetPW.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // lb_resetPW
            // 
            this.lb_resetPW.AutoSize = true;
            this.lb_resetPW.Font = new System.Drawing.Font("Arial", 9F);
            this.lb_resetPW.ForeColor = System.Drawing.Color.Purple;
            this.lb_resetPW.Location = new System.Drawing.Point(365, 342);
            this.lb_resetPW.Name = "lb_resetPW";
            this.lb_resetPW.Size = new System.Drawing.Size(98, 15);
            this.lb_resetPW.TabIndex = 6;
            this.lb_resetPW.Text = "Reset password";
            this.lb_resetPW.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(67, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(70, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password: ";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_resetPW);
            this.Controls.Add(this.lb_forgetPW);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_login);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_forgetPW;
        private System.Windows.Forms.Label lb_resetPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}