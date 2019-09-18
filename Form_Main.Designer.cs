namespace ImageGrayWF
{
    partial class Form_Main
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
            this.button_OpenForm_Ex1 = new System.Windows.Forms.Button();
            this.button_OpenForm_Ex2 = new System.Windows.Forms.Button();
            this.button_OpenForm_Ex3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OpenForm_Ex1
            // 
            this.button_OpenForm_Ex1.Location = new System.Drawing.Point(12, 46);
            this.button_OpenForm_Ex1.Name = "button_OpenForm_Ex1";
            this.button_OpenForm_Ex1.Size = new System.Drawing.Size(184, 51);
            this.button_OpenForm_Ex1.TabIndex = 0;
            this.button_OpenForm_Ex1.Text = "button1";
            this.button_OpenForm_Ex1.UseVisualStyleBackColor = true;
            this.button_OpenForm_Ex1.Click += new System.EventHandler(this.Button_OpenForm_Ex1_Click);
            // 
            // button_OpenForm_Ex2
            // 
            this.button_OpenForm_Ex2.Location = new System.Drawing.Point(12, 109);
            this.button_OpenForm_Ex2.Name = "button_OpenForm_Ex2";
            this.button_OpenForm_Ex2.Size = new System.Drawing.Size(184, 49);
            this.button_OpenForm_Ex2.TabIndex = 1;
            this.button_OpenForm_Ex2.Text = "button2";
            this.button_OpenForm_Ex2.UseVisualStyleBackColor = true;
            this.button_OpenForm_Ex2.Click += new System.EventHandler(this.Button_OpenForm_Ex2_Click);
            // 
            // button_OpenForm_Ex3
            // 
            this.button_OpenForm_Ex3.Location = new System.Drawing.Point(12, 170);
            this.button_OpenForm_Ex3.Name = "button_OpenForm_Ex3";
            this.button_OpenForm_Ex3.Size = new System.Drawing.Size(184, 48);
            this.button_OpenForm_Ex3.TabIndex = 2;
            this.button_OpenForm_Ex3.Text = "button3";
            this.button_OpenForm_Ex3.UseVisualStyleBackColor = true;
            this.button_OpenForm_Ex3.Click += new System.EventHandler(this.Button_OpenForm_Ex3_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 250);
            this.Controls.Add(this.button_OpenForm_Ex3);
            this.Controls.Add(this.button_OpenForm_Ex2);
            this.Controls.Add(this.button_OpenForm_Ex1);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenForm_Ex1;
        private System.Windows.Forms.Button button_OpenForm_Ex2;
        private System.Windows.Forms.Button button_OpenForm_Ex3;
    }
}