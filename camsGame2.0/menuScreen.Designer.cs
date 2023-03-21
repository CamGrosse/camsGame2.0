namespace camsGame2._0
{
    partial class menuScreen
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
            this.gameStartButton = new System.Windows.Forms.Button();
            this.gameExitButton = new System.Windows.Forms.Button();
            this.gameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameStartButton
            // 
            this.gameStartButton.Location = new System.Drawing.Point(323, 147);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(165, 73);
            this.gameStartButton.TabIndex = 0;
            this.gameStartButton.Text = "Enter";
            this.gameStartButton.UseVisualStyleBackColor = true;
            this.gameStartButton.Click += new System.EventHandler(this.gameStartButton_Click);
            // 
            // gameExitButton
            // 
            this.gameExitButton.Location = new System.Drawing.Point(323, 288);
            this.gameExitButton.Name = "gameExitButton";
            this.gameExitButton.Size = new System.Drawing.Size(165, 73);
            this.gameExitButton.TabIndex = 1;
            this.gameExitButton.Text = "Exit";
            this.gameExitButton.UseVisualStyleBackColor = true;
            this.gameExitButton.Click += new System.EventHandler(this.gameExitButton_Click);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(320, 65);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(168, 13);
            this.gameLabel.TabIndex = 2;
            this.gameLabel.Text = "WELCOME TO CAMS GAME 2.0 ";
            // 
            // menuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.gameExitButton);
            this.Controls.Add(this.gameStartButton);
            this.Name = "menuScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.Button gameExitButton;
        private System.Windows.Forms.Label gameLabel;
    }
}
