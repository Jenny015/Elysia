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
            this.lb_login.Location = new System.Drawing.Point(363, 120);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(125, 41);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.MistyRose;
            this.tb_username.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_username.Location = new System.Drawing.Point(238, 274);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(448, 35);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.MistyRose;
            this.tb_password.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_password.Location = new System.Drawing.Point(238, 346);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(448, 35);
            this.tb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Plum;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_login.Location = new System.Drawing.Point(370, 407);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(150, 40);
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
            this.lb_forgetPW.Location = new System.Drawing.Point(106, 513);
            this.lb_forgetPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_forgetPW.Name = "lb_forgetPW";
            this.lb_forgetPW.Size = new System.Drawing.Size(154, 21);
            this.lb_forgetPW.TabIndex = 5;
            this.lb_forgetPW.Text = "Forget password?";
            this.lb_forgetPW.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // lb_resetPW
            // 
            this.lb_resetPW.AutoSize = true;
            this.lb_resetPW.Font = new System.Drawing.Font("Arial", 9F);
            this.lb_resetPW.ForeColor = System.Drawing.Color.Purple;
            this.lb_resetPW.Location = new System.Drawing.Point(547, 513);
            this.lb_resetPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_resetPW.Name = "lb_resetPW";
            this.lb_resetPW.Size = new System.Drawing.Size(139, 21);
            this.lb_resetPW.TabIndex = 6;
            this.lb_resetPW.Text = "Reset password";
            this.lb_resetPW.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(100, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(105, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password: ";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_resetPW);
            this.Controls.Add(this.lb_forgetPW);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_login);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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