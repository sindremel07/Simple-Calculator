namespace Simple_Calculator
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button18 = new Button();
            button19 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(25, 86);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(417, 48);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 150);
            button1.Name = "button1";
            button1.Size = new Size(69, 65);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(109, 150);
            button2.Name = "button2";
            button2.Size = new Size(69, 65);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(195, 150);
            button3.Name = "button3";
            button3.Size = new Size(69, 65);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(373, 150);
            button4.Name = "button4";
            button4.Size = new Size(69, 65);
            button4.TabIndex = 4;
            button4.Text = "CE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(283, 150);
            button5.Name = "button5";
            button5.Size = new Size(69, 65);
            button5.TabIndex = 5;
            button5.Text = "/";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(283, 221);
            button6.Name = "button6";
            button6.Size = new Size(69, 65);
            button6.TabIndex = 10;
            button6.Text = "*";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(373, 221);
            button7.Name = "button7";
            button7.Size = new Size(69, 65);
            button7.TabIndex = 9;
            button7.Text = "C";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(195, 221);
            button8.Name = "button8";
            button8.Size = new Size(69, 65);
            button8.TabIndex = 8;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(109, 221);
            button9.Name = "button9";
            button9.Size = new Size(69, 65);
            button9.TabIndex = 7;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(25, 221);
            button10.Name = "button10";
            button10.Size = new Size(69, 65);
            button10.TabIndex = 6;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(283, 292);
            button11.Name = "button11";
            button11.Size = new Size(69, 65);
            button11.TabIndex = 15;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(373, 292);
            button12.Name = "button12";
            button12.Size = new Size(69, 136);
            button12.TabIndex = 14;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(195, 292);
            button13.Name = "button13";
            button13.Size = new Size(69, 65);
            button13.TabIndex = 13;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(109, 292);
            button14.Name = "button14";
            button14.Size = new Size(69, 65);
            button14.TabIndex = 12;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(25, 292);
            button15.Name = "button15";
            button15.Size = new Size(69, 65);
            button15.TabIndex = 11;
            button15.Text = "1";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(283, 363);
            button16.Name = "button16";
            button16.Size = new Size(69, 65);
            button16.TabIndex = 19;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(195, 363);
            button18.Name = "button18";
            button18.Size = new Size(69, 65);
            button18.TabIndex = 17;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(25, 363);
            button19.Name = "button19";
            button19.Size = new Size(153, 65);
            button19.TabIndex = 16;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(0, 15);
            label1.TabIndex = 20;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(label1);
            Controls.Add(button16);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button19;
        private Label label1;
    }
}