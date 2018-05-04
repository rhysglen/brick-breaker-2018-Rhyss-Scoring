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
            this.titleBox = new System.Windows.Forms.PictureBox();
            this.playerscoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Image = global::BrickBreaker.Properties.Resources.HighScores3;
            this.titleBox.Location = new System.Drawing.Point(187, 34);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(401, 110);
            this.titleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.titleBox.TabIndex = 1;
            this.titleBox.TabStop = false;
            // 
            // playerscoreLabel
            // 
            this.playerscoreLabel.Location = new System.Drawing.Point(188, 162);
            this.playerscoreLabel.Name = "playerscoreLabel";
            this.playerscoreLabel.Size = new System.Drawing.Size(399, 359);
            this.playerscoreLabel.TabIndex = 2;
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
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
