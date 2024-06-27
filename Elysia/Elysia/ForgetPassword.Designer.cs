namespace Elysia
{
    partial class ForgetPassword
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_reset = new System.Windows.Forms.Label();
            this.btn_forget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(169, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username: ";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.MistyRose;
            this.tb_username.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_username.Location = new System.Drawing.Point(261, 167);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(300, 26);
            this.tb_username.TabIndex = 14;
            // 
            // lb_reset
            // 
            this.lb_reset.AutoSize = true;
            this.lb_reset.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lb_reset.Location = new System.Drawing.Point(287, 102);
            this.lb_reset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_reset.Name = "lb_reset";
            this.lb_reset.Size = new System.Drawing.Size(219, 29);
            this.lb_reset.TabIndex = 13;
            this.lb_reset.Text = "Forget Password";
            // 
            // btn_forget
            // 
            this.btn_forget.BackColor = System.Drawing.Color.Plum;
            this.btn_forget.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_forget.Location = new System.Drawing.Point(344, 223);
            this.btn_forget.Name = "btn_forget";
            this.btn_forget.Size = new System.Drawing.Size(100, 29);
            this.btn_forget.TabIndex = 17;
            this.btn_forget.Text = "Done";
            this.btn_forget.UseVisualStyleBackColor = false;
            this.btn_forget.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_forget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_reset);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_reset;
        private System.Windows.Forms.Button btn_forget;
    }
}