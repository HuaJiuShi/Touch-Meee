namespace Touch_Meee
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.button2No = new System.Windows.Forms.Button();
            this.button2Yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "记得打电话给我哦！";
            // 
            // button2No
            // 
            this.button2No.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2No.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2No.Location = new System.Drawing.Point(159, 65);
            this.button2No.Name = "button2No";
            this.button2No.Size = new System.Drawing.Size(75, 23);
            this.button2No.TabIndex = 6;
            this.button2No.Text = "不要";
            this.button2No.UseVisualStyleBackColor = false;
            this.button2No.Click += new System.EventHandler(this.button2No_Click);
            this.button2No.MouseEnter += new System.EventHandler(this.button2No_MouseEnter);
            this.button2No.MouseLeave += new System.EventHandler(this.button2No_MouseLeave);
            // 
            // button2Yes
            // 
            this.button2Yes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2Yes.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2Yes.Location = new System.Drawing.Point(38, 65);
            this.button2Yes.Name = "button2Yes";
            this.button2Yes.Size = new System.Drawing.Size(75, 23);
            this.button2Yes.TabIndex = 5;
            this.button2Yes.Text = "好啊";
            this.button2Yes.UseVisualStyleBackColor = false;
            this.button2Yes.Click += new System.EventHandler(this.button2Yes_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 102);
            this.Controls.Add(this.button2No);
            this.Controls.Add(this.button2Yes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "谢谢你小姐姐";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2No;
        private System.Windows.Forms.Button button2Yes;
    }
}