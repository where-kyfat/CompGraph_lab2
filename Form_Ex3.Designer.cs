namespace ImageGrayWF
{
    partial class Form_Ex3
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
            this.HueTrackBar = new System.Windows.Forms.TrackBar();
            this.SaturationTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.RGBtoHSVButton = new System.Windows.Forms.Button();
            this.SaveImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HueTrackBar
            // 
            this.HueTrackBar.Location = new System.Drawing.Point(600, 100);
            this.HueTrackBar.Maximum = 360;
            this.HueTrackBar.Name = "HueTrackBar";
            this.HueTrackBar.Size = new System.Drawing.Size(104, 45);
            this.HueTrackBar.TabIndex = 0;
            // 
            // SaturationTrackBar
            // 
            this.SaturationTrackBar.Location = new System.Drawing.Point(600, 167);
            this.SaturationTrackBar.Maximum = 1000;
            this.SaturationTrackBar.Name = "SaturationTrackBar";
            this.SaturationTrackBar.Size = new System.Drawing.Size(104, 45);
            this.SaturationTrackBar.TabIndex = 1;
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(600, 237);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(104, 45);
            this.BrightnessTrackBar.TabIndex = 2;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Image = global::ImageGrayWF.Properties.Resources.ФРУКТЫ;
            this.ImagePictureBox.Location = new System.Drawing.Point(54, 56);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(401, 274);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePictureBox.TabIndex = 3;
            this.ImagePictureBox.TabStop = false;
            // 
            // RGBtoHSVButton
            // 
            this.RGBtoHSVButton.Location = new System.Drawing.Point(610, 307);
            this.RGBtoHSVButton.Name = "RGBtoHSVButton";
            this.RGBtoHSVButton.Size = new System.Drawing.Size(75, 23);
            this.RGBtoHSVButton.TabIndex = 4;
            this.RGBtoHSVButton.Text = "button1";
            this.RGBtoHSVButton.UseVisualStyleBackColor = true;
            this.RGBtoHSVButton.Click += new System.EventHandler(this.RGBtoHSVbutton_Click_Click);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Location = new System.Drawing.Point(212, 358);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(75, 23);
            this.SaveImageButton.TabIndex = 5;
            this.SaveImageButton.Text = "button1";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // Form_Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveImageButton);
            this.Controls.Add(this.RGBtoHSVButton);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.BrightnessTrackBar);
            this.Controls.Add(this.SaturationTrackBar);
            this.Controls.Add(this.HueTrackBar);
            this.Name = "Form_Ex3";
            this.Text = "Ex3_RGB->HSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ex3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar HueTrackBar;
        private System.Windows.Forms.TrackBar SaturationTrackBar;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Button RGBtoHSVButton;
        private System.Windows.Forms.Button SaveImageButton;
    }
}