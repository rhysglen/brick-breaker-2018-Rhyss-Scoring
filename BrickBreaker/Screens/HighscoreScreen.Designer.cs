namespace BrickBreaker.Screens
{
    partial class HighscoreScreen
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
            this.playerscoreLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerscoreLabel
            // 
            this.playerscoreLabel.Location = new System.Drawing.Point(189, 147);
            this.playerscoreLabel.Name = "playerscoreLabel";
            this.playerscoreLabel.Size = new System.Drawing.Size(399, 343);
            this.playerscoreLabel.TabIndex = 2;
            // 
            // titleBox
            // 
            this.titleBox.Image = global::BrickBreaker.Properties.Resources.HighScores3;
            this.titleBox.Location = new System.Drawing.Point(192, 13);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(401, 110);
            this.titleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.titleBox.TabIndex = 1;
            this.titleBox.TabStop = false;
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.back;
            this.Controls.Add(this.playerscoreLabel);
            this.Controls.Add(this.titleBox);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox titleBox;
        private System.Windows.Forms.Label playerscoreLabel;
    }
}
