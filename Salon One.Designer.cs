namespace letsCinema
{
    partial class Salon_One
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
            this.SalonName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalonName
            // 
            this.SalonName.AutoSize = true;
            this.SalonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName.Location = new System.Drawing.Point(327, 23);
            this.SalonName.Name = "SalonName";
            this.SalonName.Size = new System.Drawing.Size(75, 24);
            this.SalonName.TabIndex = 0;
            this.SalonName.Text = "Salon: ";
            // 
            // Salon_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalonName);
            this.Name = "Salon_One";
            this.Text = "Salon_One";
            this.Load += new System.EventHandler(this.Salon_One_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName;
    }
}