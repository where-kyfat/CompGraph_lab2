namespace ImageGrayWF
{
	partial class Form_Ex1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ex1));
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RGBToGrey1Button = new System.Windows.Forms.Button();
            this.RGBToGrey2Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_Gist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gist)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Image.Image")));
            this.pictureBox_Image.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(668, 620);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image.TabIndex = 0;
            this.pictureBox_Image.TabStop = false;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1273, 28);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 27);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RGBToGrey1Button
            // 
            this.RGBToGrey1Button.Location = new System.Drawing.Point(1273, 244);
            this.RGBToGrey1Button.Name = "RGBToGrey1Button";
            this.RGBToGrey1Button.Size = new System.Drawing.Size(86, 23);
            this.RGBToGrey1Button.TabIndex = 2;
            this.RGBToGrey1Button.Text = "RGB to Grey1";
            this.RGBToGrey1Button.UseVisualStyleBackColor = true;
            this.RGBToGrey1Button.Click += new System.EventHandler(this.RGBToGrey1Button_Click);
            // 
            // RGBToGrey2Button
            // 
            this.RGBToGrey2Button.Location = new System.Drawing.Point(1273, 292);
            this.RGBToGrey2Button.Name = "RGBToGrey2Button";
            this.RGBToGrey2Button.Size = new System.Drawing.Size(86, 23);
            this.RGBToGrey2Button.TabIndex = 3;
            this.RGBToGrey2Button.Text = "RGB to Grey 2";
            this.RGBToGrey2Button.UseVisualStyleBackColor = true;
            this.RGBToGrey2Button.Click += new System.EventHandler(this.RGBToGrey2Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1273, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Difference);
            // 
            // pictureBox_Gist
            // 
            this.pictureBox_Gist.Location = new System.Drawing.Point(741, 12);
            this.pictureBox_Gist.Name = "pictureBox_Gist";
            this.pictureBox_Gist.Size = new System.Drawing.Size(512, 620);
            this.pictureBox_Gist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gist.TabIndex = 5;
            this.pictureBox_Gist.TabStop = false;
            // 
            // Form_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 644);
            this.Controls.Add(this.pictureBox_Gist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RGBToGrey2Button);
            this.Controls.Add(this.RGBToGrey1Button);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.pictureBox_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Ex1";
            this.Text = "RGB&HSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ex1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gist)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_Image;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button RGBToGrey1Button;
		private System.Windows.Forms.Button RGBToGrey2Button;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_Gist;
    }
}

