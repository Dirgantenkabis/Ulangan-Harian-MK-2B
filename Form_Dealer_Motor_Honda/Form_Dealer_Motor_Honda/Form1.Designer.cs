namespace Form_Dealer_Motor_Honda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(345, 58);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 0;
            label1.Text = "Dealer Motor";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 153);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Nama Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 213);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Alamat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 277);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 6;
            label4.Text = "No Hp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 342);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 7;
            label5.Text = "Nama Motor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(311, 334);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 403);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 9;
            label6.Text = "Jumlah";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(311, 396);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(319, 27);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(177, 498);
            button1.Name = "button1";
            button1.Size = new Size(131, 35);
            button1.TabIndex = 11;
            button1.Text = "Cetak Nota";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 498);
            button2.Name = "button2";
            button2.Size = new Size(131, 35);
            button2.TabIndex = 12;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(499, 498);
            button3.Name = "button3";
            button3.Size = new Size(131, 35);
            button3.TabIndex = 13;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(311, 446);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(319, 27);
            textBox4.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(177, 453);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 15;
            label7.Text = "Jumlah Harga";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 562);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Label label7;
    }
}
