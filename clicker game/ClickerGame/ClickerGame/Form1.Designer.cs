namespace ClickerGame
{
    partial class Form1
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
            this.MonsterImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MonsterImage
            // 
            this.MonsterImage.Location = new System.Drawing.Point(0, 0);
            this.MonsterImage.Name = "MonsterImage";
            this.MonsterImage.Size = new System.Drawing.Size(434, 607);
            this.MonsterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MonsterImage.TabIndex = 0;
            this.MonsterImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 761);
            this.Controls.Add(this.MonsterImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MonsterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MonsterImage;
    }
}

