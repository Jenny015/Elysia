﻿namespace Elysia
{
    partial class DangerLevel
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDangerLevel = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangerLevel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDangerLevel
            // 
            this.dgvDangerLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangerLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangerLevel.Location = new System.Drawing.Point(41, 132);
            this.dgvDangerLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDangerLevel.Name = "dgvDangerLevel";
            this.dgvDangerLevel.RowHeadersWidth = 62;
            this.dgvDangerLevel.RowTemplate.Height = 31;
            this.dgvDangerLevel.Size = new System.Drawing.Size(1420, 887);
            this.dgvDangerLevel.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 90);
            this.panel2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Danger Level";
            // 
            // DangerLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDangerLevel);
            this.Name = "DangerLevel";
            this.Size = new System.Drawing.Size(1503, 1055);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangerLevel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDangerLevel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
