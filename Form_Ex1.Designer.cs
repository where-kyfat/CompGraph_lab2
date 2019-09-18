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
            this.pictureBox_Gray1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gray1Gist = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gray2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gray2Gist = new System.Windows.Forms.PictureBox();
            this.pictureBox_Difference = new System.Windows.Forms.PictureBox();
            this.pictureBox_OriginImage = new System.Windows.Forms.PictureBox();
            this.label_OriginImage = new System.Windows.Forms.Label();
            this.label_Gray1 = new System.Windows.Forms.Label();
            this.label_Gray1Gist = new System.Windows.Forms.Label();
            this.label_Gray2 = new System.Windows.Forms.Label();
            this.label_GrayGist = new System.Windows.Forms.Label();
            this.label_Difference = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray1Gist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray2Gist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Gray1
            // 
            this.pictureBox_Gray1.Location = new System.Drawing.Point(382, 42);
            this.pictureBox_Gray1.Name = "pictureBox_Gray1";
            this.pictureBox_Gray1.Size = new System.Drawing.Size(336, 255);
            this.pictureBox_Gray1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gray1.TabIndex = 0;
            this.pictureBox_Gray1.TabStop = false;
            // 
            // pictureBox_Gray1Gist
            // 
            this.pictureBox_Gray1Gist.Location = new System.Drawing.Point(827, 42);
            this.pictureBox_Gray1Gist.Name = "pictureBox_Gray1Gist";
            this.pictureBox_Gray1Gist.Size = new System.Drawing.Size(336, 255);
            this.pictureBox_Gray1Gist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gray1Gist.TabIndex = 5;
            this.pictureBox_Gray1Gist.TabStop = false;
            // 
            // pictureBox_Gray2
            // 
            this.pictureBox_Gray2.Location = new System.Drawing.Point(382, 324);
            this.pictureBox_Gray2.Name = "pictureBox_Gray2";
            this.pictureBox_Gray2.Size = new System.Drawing.Size(336, 255);
            this.pictureBox_Gray2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gray2.TabIndex = 6;
            this.pictureBox_Gray2.TabStop = false;
            // 
            // pictureBox_Gray2Gist
            // 
            this.pictureBox_Gray2Gist.Location = new System.Drawing.Point(827, 324);
            this.pictureBox_Gray2Gist.Name = "pictureBox_Gray2Gist";
            this.pictureBox_Gray2Gist.Size = new System.Drawing.Size(336, 255);
            this.pictureBox_Gray2Gist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gray2Gist.TabIndex = 7;
            this.pictureBox_Gray2Gist.TabStop = false;
            // 
            // pictureBox_Difference
            // 
            this.pictureBox_Difference.Location = new System.Drawing.Point(600, 629);
            this.pictureBox_Difference.Name = "pictureBox_Difference";
            this.pictureBox_Difference.Size = new System.Drawing.Size(336, 255);
            this.pictureBox_Difference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Difference.TabIndex = 8;
            this.pictureBox_Difference.TabStop = false;
            // 
            // pictureBox_OriginImage
            // 
            this.pictureBox_OriginImage.Image = global::ImageGrayWF.Properties.Resources.ФРУКТЫ;
            this.pictureBox_OriginImage.Location = new System.Drawing.Point(12, 249);
            this.pictureBox_OriginImage.Name = "pictureBox_OriginImage";
            this.pictureBox_OriginImage.Size = new System.Drawing.Size(336, 255);
            this.pictureBox_OriginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OriginImage.TabIndex = 9;
            this.pictureBox_OriginImage.TabStop = false;
            // 
            // label_OriginImage
            // 
            this.label_OriginImage.AutoSize = true;
            this.label_OriginImage.Location = new System.Drawing.Point(111, 233);
            this.label_OriginImage.Name = "label_OriginImage";
            this.label_OriginImage.Size = new System.Drawing.Size(130, 13);
            this.label_OriginImage.TabIndex = 10;
            this.label_OriginImage.Text = "Оригинальная картинка";
            // 
            // label_Gray1
            // 
            this.label_Gray1.AutoSize = true;
            this.label_Gray1.Location = new System.Drawing.Point(407, 26);
            this.label_Gray1.Name = "label_Gray1";
            this.label_Gray1.Size = new System.Drawing.Size(298, 13);
            this.label_Gray1.TabIndex = 11;
            this.label_Gray1.Text = "После преобразования в черно-белый первым способом";
            // 
            // label_Gray1Gist
            // 
            this.label_Gray1Gist.AutoSize = true;
            this.label_Gray1Gist.Location = new System.Drawing.Point(854, 26);
            this.label_Gray1Gist.Name = "label_Gray1Gist";
            this.label_Gray1Gist.Size = new System.Drawing.Size(283, 13);
            this.label_Gray1Gist.TabIndex = 12;
            this.label_Gray1Gist.Text = "Гистограмма преобразованной картинки, способом 1";
            // 
            // label_Gray2
            // 
            this.label_Gray2.AutoSize = true;
            this.label_Gray2.Location = new System.Drawing.Point(407, 308);
            this.label_Gray2.Name = "label_Gray2";
            this.label_Gray2.Size = new System.Drawing.Size(297, 13);
            this.label_Gray2.TabIndex = 13;
            this.label_Gray2.Text = "После преобразования в черно-белый вторым способом";
            // 
            // label_GrayGist
            // 
            this.label_GrayGist.AutoSize = true;
            this.label_GrayGist.Location = new System.Drawing.Point(854, 308);
            this.label_GrayGist.Name = "label_GrayGist";
            this.label_GrayGist.Size = new System.Drawing.Size(283, 13);
            this.label_GrayGist.TabIndex = 14;
            this.label_GrayGist.Text = "Гистограмма преобразованной картинки, способом 2";
            // 
            // label_Difference
            // 
            this.label_Difference.AutoSize = true;
            this.label_Difference.Location = new System.Drawing.Point(663, 613);
            this.label_Difference.Name = "label_Difference";
            this.label_Difference.Size = new System.Drawing.Size(199, 13);
            this.label_Difference.TabIndex = 15;
            this.label_Difference.Text = "Разность преобразованных картинок";
            // 
            // Form_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 925);
            this.Controls.Add(this.label_Difference);
            this.Controls.Add(this.label_GrayGist);
            this.Controls.Add(this.label_Gray2);
            this.Controls.Add(this.label_Gray1Gist);
            this.Controls.Add(this.label_Gray1);
            this.Controls.Add(this.label_OriginImage);
            this.Controls.Add(this.pictureBox_OriginImage);
            this.Controls.Add(this.pictureBox_Difference);
            this.Controls.Add(this.pictureBox_Gray2Gist);
            this.Controls.Add(this.pictureBox_Gray2);
            this.Controls.Add(this.pictureBox_Gray1Gist);
            this.Controls.Add(this.pictureBox_Gray1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_Ex1";
            this.Text = "RGB&HSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ex1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray1Gist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gray2Gist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_Gray1;
        private System.Windows.Forms.PictureBox pictureBox_Gray1Gist;
        private System.Windows.Forms.PictureBox pictureBox_Gray2;
        private System.Windows.Forms.PictureBox pictureBox_Gray2Gist;
        private System.Windows.Forms.PictureBox pictureBox_Difference;
        private System.Windows.Forms.PictureBox pictureBox_OriginImage;
        private System.Windows.Forms.Label label_OriginImage;
        private System.Windows.Forms.Label label_Gray1;
        private System.Windows.Forms.Label label_Gray1Gist;
        private System.Windows.Forms.Label label_Gray2;
        private System.Windows.Forms.Label label_GrayGist;
        private System.Windows.Forms.Label label_Difference;
    }
}

