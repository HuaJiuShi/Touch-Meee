using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Touch_Meee
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public extern static bool GetCursorPos(ref Point pot);  //获取鼠标位置
        Point pNow;
        [DllImport("User32.dll")]
        public extern static void SetCursorPos(int x, int y);   //改变鼠标位置

        bool formCloseFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {

        }

        private void buttonNo_MouseEnter(object sender, EventArgs e)
        {
            GetCursorPos(ref pNow);
            SetCursorPos(pNow.X - 200, pNow.Y);
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            formCloseFlag = true;
            this.Hide();

            if (fm3.ShowDialog() == DialogResult.OK)
                this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!formCloseFlag)
            {
                Form2 fm2 = new Form2();
                e.Cancel = true;
                this.Hide();

                if (fm2.ShowDialog() == DialogResult.OK)
                    this.Show();
            }
        }
    }
}
