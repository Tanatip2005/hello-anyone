namespace WinFormsApp1
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
            label2 = new Label();
            label3 = new Label();
            Num1 = new TextBox();
            B1 = new Button();
            Num2 = new TextBox();
            result = new TextBox();
            B2 = new Button();
            result2 = new Button();
            B4 = new Button();
            button4 = new Button();
            B3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Num1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 56);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Num2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 90);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Result";
            label3.Click += label3_Click;
            // 
            // Num1
            // 
            Num1.Location = new Point(105, 18);
            Num1.Name = "Num1";
            Num1.Size = new Size(100, 23);
            Num1.TabIndex = 3;
            Num1.TextChanged += textBox1_TextChanged;
            // 
            // B1
            // 
            B1.Location = new Point(225, 20);
            B1.Name = "B1";
            B1.Size = new Size(75, 23);
            B1.TabIndex = 4;
            B1.Text = "+";
            B1.UseVisualStyleBackColor = true;
            B1.Click += result_Click;
            // 
            // Num2
            // 
            Num2.Location = new Point(105, 53);
            Num2.Name = "Num2";
            Num2.Size = new Size(100, 23);
            Num2.TabIndex = 5;
            // 
            // result
            // 
            result.Location = new Point(105, 82);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 6;
            // 
            // B2
            // 
            B2.Location = new Point(306, 20);
            B2.Name = "B2";
            B2.Size = new Size(75, 23);
            B2.TabIndex = 7;
            B2.Text = "-";
            B2.UseVisualStyleBackColor = true;
            B2.Click += button1_Click;
            // 
            // result2
            // 
            result2.Location = new Point(306, 53);
            result2.Name = "result2";
            result2.Size = new Size(75, 23);
            result2.TabIndex = 8;
            result2.Text = "x";
            result2.UseVisualStyleBackColor = true;
            result2.Click += result2_Click;
            // 
            // B4
            // 
            B4.Location = new Point(306, 53);
            B4.Name = "B4";
            B4.Size = new Size(75, 23);
            B4.TabIndex = 9;
            B4.Text = "%";
            B4.UseVisualStyleBackColor = true;
            B4.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(225, 86);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            B3.Location = new Point(225, 53);
            B3.Name = "B3";
            B3.Size = new Size(75, 23);
            B3.TabIndex = 11;
            B3.Text = "x";
            B3.UseVisualStyleBackColor = true;
            B3.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 493);
            Controls.Add(B3);
            Controls.Add(button4);
            Controls.Add(B4);
            Controls.Add(result2);
            Controls.Add(B2);
            Controls.Add(result);
            Controls.Add(Num2);
            Controls.Add(B1);
            Controls.Add(Num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Num1;
        private Button B1;
        private TextBox Num2;
        private TextBox result;
        private Button B2;
        private Button result2;
        private Button B4;
        private Button button4;
        private Button B3;
    }
}
