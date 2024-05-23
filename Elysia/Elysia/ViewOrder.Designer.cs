namespace Elysia
{
    partial class ViewOrder
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblDept = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(126)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.btnSave.Location = new System.Drawing.Point(1458, 799);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(418, -57);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(41, 15);
            this.lblOrderID.TabIndex = 23;
            this.lblOrderID.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(609, -57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "label1";
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(171)))));
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton5.Location = new System.Drawing.Point(4, 824);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(363, 50);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Logout";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(171)))));
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.Location = new System.Drawing.Point(4, 413);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(363, 62);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "View Order";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(171)))));
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton3.Location = new System.Drawing.Point(4, 351);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(363, 62);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "New Order";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(171)))));
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Location = new System.Drawing.Point(4, 289);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(363, 62);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View Dealer";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(171)))));
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(4, 227);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(363, 62);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New Dealer";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // lblDept
            // 
            this.lblDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.lblDept.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDept.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(4, 165);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(363, 62);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "label1";
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDept.Click += new System.EventHandler(this.lblDept_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Size = new System.Drawing.Size(373, 879);
            this.panel1.TabIndex = 14;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Location = new System.Drawing.Point(4, 3);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(363, 162);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 54);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1710, 879);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label label1;
    }
}