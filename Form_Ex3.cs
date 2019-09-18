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
    public partial class Form_Ex3 : Form
    {
        private Form_Main FormMain;
        public Form_Ex3(Form_Main form_Main)
        {
            InitializeComponent();
            FormMain = form_Main;
        }

        private void Form_Ex3_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }
    }
}
