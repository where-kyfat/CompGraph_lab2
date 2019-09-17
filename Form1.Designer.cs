namespace ImageGrayWF
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.ResetButton = new System.Windows.Forms.Button();
			this.RGBToGrey1Button = new System.Windows.Forms.Button();
			this.RGBToGrey2Button = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(631, 426);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(685, 43);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(80, 27);
			this.ResetButton.TabIndex = 1;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// RGBToGrey1Button
			// 
			this.RGBToGrey1Button.Location = new System.Drawing.Point(679, 272);
			this.RGBToGrey1Button.Name = "RGBToGrey1Button";
			this.RGBToGrey1Button.Size = new System.Drawing.Size(86, 23);
			this.RGBToGrey1Button.TabIndex = 2;
			this.RGBToGrey1Button.Text = "RGB to Grey1";
			this.RGBToGrey1Button.UseVisualStyleBackColor = true;
			this.RGBToGrey1Button.Click += new System.EventHandler(this.RGBToGrey1Button_Click);
			// 
			// RGBToGrey2Button
			// 
			this.RGBToGrey2Button.Location = new System.Drawing.Point(679, 311);
			this.RGBToGrey2Button.Name = "RGBToGrey2Button";
			this.RGBToGrey2Button.Size = new System.Drawing.Size(86, 23);
			this.RGBToGrey2Button.TabIndex = 3;
			this.RGBToGrey2Button.Text = "RGB to Grey 2";
			this.RGBToGrey2Button.UseVisualStyleBackColor = true;
			this.RGBToGrey2Button.Click += new System.EventHandler(this.RGBToGrey2Button_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(679, 350);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.RGBToGrey2Button);
			this.Controls.Add(this.RGBToGrey1Button);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.pictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "RGB&HSV";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button RGBToGrey1Button;
		private System.Windows.Forms.Button RGBToGrey2Button;
		private System.Windows.Forms.Button button1;
	}
}

