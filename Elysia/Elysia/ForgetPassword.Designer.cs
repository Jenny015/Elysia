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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_reset = new System.Windows.Forms.Label();
            this.btn_forget = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(485, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "EmployeeID: ";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.MistyRose;
            this.tb_username.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_username.Location = new System.Drawing.Point(648, 191);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(285, 35);
            this.tb_username.TabIndex = 14;
            // 
            // lb_reset
            // 
            this.lb_reset.AutoSize = true;
            this.lb_reset.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lb_reset.Location = new System.Drawing.Point(538, 69);
            this.lb_reset.Name = "lb_reset";
            this.lb_reset.Size = new System.Drawing.Size(328, 41);
            this.lb_reset.TabIndex = 13;
            this.lb_reset.Text = "Forget Password";
            // 
            // btn_forget
            // 
            this.btn_forget.BackColor = System.Drawing.Color.Plum;
            this.btn_forget.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_forget.Location = new System.Drawing.Point(623, 297);
            this.btn_forget.Margin = new System.Windows.Forms.Padding(4);
            this.btn_forget.Name = "btn_forget";
            this.btn_forget.Size = new System.Drawing.Size(150, 40);
            this.btn_forget.TabIndex = 17;
            this.btn_forget.Text = "Done";
            this.btn_forget.UseVisualStyleBackColor = false;
            this.btn_forget.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_forget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_reset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_reset;
        private System.Windows.Forms.Button btn_forget;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}