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
    public partial class Form3 : Form
    {
        bool form3Close = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            form3Close = true;
            this.Close();
        }

        private void button2Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            form3Close = true;
            this.Close();
        }

        private void button2No_MouseEnter(object sender, EventArgs e)
        {
            button2No.Text = "好啊";
        }

        private void button2No_MouseLeave(object sender, EventArgs e)
        {
            button2No.Text = "不要";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!form3Close)
                e.Cancel = true;
        }
    }
}
