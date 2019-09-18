using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGrayWF
{
    public partial class Form_Main : Form
    {
        Form_Ex1 FormEx1;
        Form_Ex2 FormEx2;
        Form_Ex3 FormEx3;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Button_OpenForm_Ex1_Click(object sender, EventArgs e)
        {   
            FormEx1 = new Form_Ex1(this);
            FormEx1.Show();
            Hide();
        }

        private void Button_OpenForm_Ex2_Click(object sender, EventArgs e)
        {
            FormEx2 = new Form_Ex2(this);
            FormEx2.Show();
            Hide();
        }

        private void Button_OpenForm_Ex3_Click(object sender, EventArgs e)
        {
            FormEx3 = new Form_Ex3(this);
            FormEx3.Show();
            Hide();
        }
    }
}
