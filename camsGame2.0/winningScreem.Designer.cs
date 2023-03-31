namespace camsGame2._0
{
    partial class winningScreem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.labeal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Image = global::camsGame2._0.Properties.Resources.happMan;
            this.imageBox.Location = new System.Drawing.Point(165, -17);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(429, 465);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 21;
            this.imageBox.TabStop = false;
            // 
            // labeal
            // 
            this.labeal.Font = new System.Drawing.Font("Playbill", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeal.Location = new System.Drawing.Point(534, 0);
            this.labeal.Name = "labeal";
            this.labeal.Size = new System.Drawing.Size(176, 121);
            this.labeal.TabIndex = 22;
            this.labeal.Text = "YOU WIN!!!!!!!!!!!!!!";
            this.labeal.Click += new System.EventHandler(this.labeal_Click);
            // 
            // winningScreem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.labeal);
            this.Controls.Add(this.imageBox);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "winningScreem";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label labeal;
    }
}
