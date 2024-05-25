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
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lb_login.Location = new System.Drawing.Point(890, 304);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(125, 41);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.MistyRose;
            this.tb_username.Location = new System.Drawing.Point(721, 456);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(448, 29);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "Username";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.MistyRose;
            this.tb_password.Location = new System.Drawing.Point(721, 528);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(448, 29);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Plum;
            this.btn_login.Location = new System.Drawing.Point(903, 591);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 32);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login Now";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_forgetPW
            // 
            this.lb_forgetPW.AutoSize = true;
            this.lb_forgetPW.Location = new System.Drawing.Point(717, 658);
            this.lb_forgetPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_forgetPW.Name = "lb_forgetPW";
            this.lb_forgetPW.Size = new System.Drawing.Size(129, 18);
            this.lb_forgetPW.TabIndex = 5;
            this.lb_forgetPW.Text = "Forget password?";
            // 
            // lb_resetPW
            // 
            this.lb_resetPW.AutoSize = true;
            this.lb_resetPW.Location = new System.Drawing.Point(1045, 658);
            this.lb_resetPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_resetPW.Name = "lb_resetPW";
            this.lb_resetPW.Size = new System.Drawing.Size(116, 18);
            this.lb_resetPW.TabIndex = 6;
            this.lb_resetPW.Text = "Reset password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
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
    }
}