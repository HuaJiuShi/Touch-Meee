using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Touch_Meee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2No_MouseDown(object sender, MouseEventArgs e)
        {
            button2No.Text = "好啊";
        }

        private void button2No_MouseUp(object sender, MouseEventArgs e)
        {
            button2No.Text = "不要";
        }
    }
}
