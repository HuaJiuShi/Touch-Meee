namespace Touch_Meee
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button2Yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2Yes
            // 
            this.button2Yes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2Yes.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2Yes.Location = new System.Drawing.Point(69, 131);
            this.button2Yes.Name = "button2Yes";
            this.button2Yes.Size = new System.Drawing.Size(75, 23);
            this.button2Yes.TabIndex = 2;
            this.button2Yes.Text = "好啊";
            this.button2Yes.UseVisualStyleBackColor = false;
            this.button2Yes.Click += new System.EventHandler(this.button2Yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(123, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "求求你了，以后你最大";
            // 
            // button2No
            // 
            this.button2No.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2No.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2No.Location = new System.Drawing.Point(205, 131);
            this.button2No.Name = "button2No";
            this.button2No.Size = new System.Drawing.Size(75, 23);
            this.button2No.TabIndex = 4;
            this.button2No.Text = "不要";
            this.button2No.UseVisualStyleBackColor = false;
            this.button2No.Click += new System.EventHandler(this.button2No_Click);
            this.button2No.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2No_MouseDown);
            this.button2No.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2No_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(368, 183);
            this.Controls.Add(this.button2No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2Yes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2No;
    }
}