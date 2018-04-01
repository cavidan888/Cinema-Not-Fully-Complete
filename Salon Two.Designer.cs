namespace letsCinema
{
    partial class Salon_Two
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
            this.SalonName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalonName2
            // 
            this.SalonName2.AutoSize = true;
            this.SalonName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName2.Location = new System.Drawing.Point(312, 23);
            this.SalonName2.Name = "SalonName2";
            this.SalonName2.Size = new System.Drawing.Size(69, 24);
            this.SalonName2.TabIndex = 0;
            this.SalonName2.Text = "Salon:";
            // 
            // Salon_Two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalonName2);
            this.Name = "Salon_Two";
            this.Text = "Salon_Two";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName2;
    }
}