namespace Cronometer
{
    partial class RemainingTime
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
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.lblSeparator2 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.AutoSize = true;
            this.lblSeparator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator1.Location = new System.Drawing.Point(59, 2);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(31, 46);
            this.lblSeparator1.TabIndex = 1;
            this.lblSeparator1.Text = ":";
            this.lblSeparator1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSeparator1_MouseDown);
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.AutoSize = true;
            this.lblSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator2.Location = new System.Drawing.Point(132, 2);
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(31, 46);
            this.lblSeparator2.TabIndex = 4;
            this.lblSeparator2.Text = ":";
            this.lblSeparator2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSeparator2_MouseDown);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(150, 5);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(64, 46);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "00";
            this.lblSeconds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSeconds_MouseDown);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(77, 5);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(64, 46);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "00";
            this.lblMinutes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMinutes_MouseDown);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(5, 5);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(64, 46);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "00";
            this.lblHours.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHours_MouseDown);
            // 
            // RemainingTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 56);
            this.ControlBox = false;
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblSeparator2);
            this.Controls.Add(this.lblSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemainingTime";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cronometro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemainingTime_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSeparator1;
        private System.Windows.Forms.Label lblSeparator2;
        public System.Windows.Forms.Label lblHours;
        public System.Windows.Forms.Label lblMinutes;
        public System.Windows.Forms.Label lblSeconds;
    }
}