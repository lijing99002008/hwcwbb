namespace hwcwbb
{
    partial class hwcw_exceltosql
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
            this.TextBox43 = new System.Windows.Forms.TextBox();
            this.Button34 = new System.Windows.Forms.Button();
            this.Button35 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox43
            // 
            this.TextBox43.Location = new System.Drawing.Point(93, 23);
            this.TextBox43.Name = "TextBox43";
            this.TextBox43.Size = new System.Drawing.Size(497, 25);
            this.TextBox43.TabIndex = 23;
            // 
            // Button34
            // 
            this.Button34.Location = new System.Drawing.Point(596, 25);
            this.Button34.Name = "Button34";
            this.Button34.Size = new System.Drawing.Size(75, 23);
            this.Button34.TabIndex = 22;
            this.Button34.Text = "路径";
            this.Button34.UseVisualStyleBackColor = true;
            this.Button34.Click += new System.EventHandler(this.Button34_Click);
            // 
            // Button35
            // 
            this.Button35.Location = new System.Drawing.Point(12, 23);
            this.Button35.Name = "Button35";
            this.Button35.Size = new System.Drawing.Size(75, 23);
            this.Button35.TabIndex = 21;
            this.Button35.Text = "导入DGV1";
            this.Button35.UseVisualStyleBackColor = true;
            this.Button35.Click += new System.EventHandler(this.Button35_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 25;
            // 
            // hwcw_exceltosql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 142);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox43);
            this.Controls.Add(this.Button34);
            this.Controls.Add(this.Button35);
            this.Name = "hwcw_exceltosql";
            this.Text = "导入表格";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox43;
        internal System.Windows.Forms.Button Button34;
        internal System.Windows.Forms.Button Button35;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}