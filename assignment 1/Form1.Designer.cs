namespace assignment_1
{
    partial class Form1
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
            this.series = new System.Windows.Forms.TabControl();
            this.Parrallel = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SR2 = new System.Windows.Forms.TextBox();
            this.SR1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.series.SuspendLayout();
            this.Parrallel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // series
            // 
            this.series.Controls.Add(this.Parrallel);
            this.series.Controls.Add(this.tabPage2);
            this.series.Location = new System.Drawing.Point(2, 12);
            this.series.Name = "series";
            this.series.SelectedIndex = 0;
            this.series.Size = new System.Drawing.Size(797, 437);
            this.series.TabIndex = 0;
            // 
            // Parrallel
            // 
            this.Parrallel.Controls.Add(this.label4);
            this.Parrallel.Controls.Add(this.label3);
            this.Parrallel.Controls.Add(this.button2);
            this.Parrallel.Controls.Add(this.SR2);
            this.Parrallel.Controls.Add(this.SR1);
            this.Parrallel.Location = new System.Drawing.Point(4, 22);
            this.Parrallel.Name = "Parrallel";
            this.Parrallel.Padding = new System.Windows.Forms.Padding(3);
            this.Parrallel.Size = new System.Drawing.Size(789, 411);
            this.Parrallel.TabIndex = 0;
            this.Parrallel.Text = "Series";
            this.Parrallel.UseVisualStyleBackColor = true;
            this.Parrallel.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SR2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SR1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SR2
            // 
            this.SR2.Location = new System.Drawing.Point(52, 95);
            this.SR2.Name = "SR2";
            this.SR2.Size = new System.Drawing.Size(229, 20);
            this.SR2.TabIndex = 1;
            this.SR2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SR1
            // 
            this.SR1.Location = new System.Drawing.Point(53, 44);
            this.SR1.Name = "SR1";
            this.SR1.Size = new System.Drawing.Size(229, 20);
            this.SR1.TabIndex = 0;
            this.SR1.TextChanged += new System.EventHandler(this.SR1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parallel";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "R2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.series);
            this.Name = "Form1";
            this.Text = "Form1";
            this.series.ResumeLayout(false);
            this.Parrallel.ResumeLayout(false);
            this.Parrallel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl series;
        private System.Windows.Forms.TabPage Parrallel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SR2;
        private System.Windows.Forms.TextBox SR1;
        private System.Windows.Forms.Label label2;
    }
}

