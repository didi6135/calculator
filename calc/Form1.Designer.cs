namespace calc
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
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            textBox1 = new TextBox();
            textBoxOutput = new TextBox();
            all_calc_RO = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Location = new Point(88, 209);
            button1.Name = "button1";
            button1.Size = new Size(208, 153);
            button1.TabIndex = 0;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Location = new Point(302, 209);
            button2.Name = "button2";
            button2.Size = new Size(208, 153);
            button2.TabIndex = 1;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clear_calc;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.Location = new Point(516, 209);
            button3.Name = "button3";
            button3.Size = new Size(208, 153);
            button3.TabIndex = 2;
            button3.Text = "(";
            button3.UseVisualStyleBackColor = false;
            button3.Click += handle_operation;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonShadow;
            button4.Enabled = false;
            button4.Location = new Point(730, 368);
            button4.Name = "button4";
            button4.Size = new Size(208, 153);
            button4.TabIndex = 14;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += handle_operation;
            button4.Click += handle_read_only;

            // 
            // button5
            // 
            button5.Location = new Point(516, 368);
            button5.Name = "button5";
            button5.Size = new Size(208, 153);
            button5.TabIndex = 13;
            button5.Text = "9";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            button5.Click += handle_read_only;

            // 
            // button6
            // 
            button6.Location = new Point(302, 368);
            button6.Name = "button6";
            button6.Size = new Size(208, 153);
            button6.TabIndex = 12;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            button6.Click += handle_read_only;

            // 
            // button7
            // 
            button7.Location = new Point(88, 368);
            button7.Name = "button7";
            button7.Size = new Size(208, 153);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            button7.Click += handle_read_only;

            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonShadow;
            button8.Enabled = false;
            button8.Location = new Point(730, 527);
            button8.Name = "button8";
            button8.Size = new Size(208, 153);
            button8.TabIndex = 18;
            button8.Text = "X";
            button8.UseVisualStyleBackColor = false;
            button8.Click += handle_operation;
            button8.Click += handle_read_only;

            // 
            // button9
            // 
            button9.Location = new Point(516, 527);
            button9.Name = "button9";
            button9.Size = new Size(208, 153);
            button9.TabIndex = 17;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            button9.Click += handle_read_only;

            // 
            // button10
            // 
            button10.Location = new Point(302, 527);
            button10.Name = "button10";
            button10.Size = new Size(208, 153);
            button10.TabIndex = 16;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            button10.Click += handle_read_only;

            // 
            // button12
            // 
            button12.Location = new Point(88, 527);
            button12.Name = "button12";
            button12.Size = new Size(208, 153);
            button12.TabIndex = 15;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            button12.Click += handle_read_only;

            // 
            // button13
            // 
            button13.BackColor = SystemColors.ButtonShadow;
            button13.Enabled = false;
            button13.Location = new Point(730, 686);
            button13.Name = "button13";
            button13.Size = new Size(208, 153);
            button13.TabIndex = 22;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = false;
            button13.Click += handle_operation;
            button13.Click += handle_read_only;

            // 
            // button14
            // 
            button14.Location = new Point(516, 686);
            button14.Name = "button14";
            button14.Size = new Size(208, 153);
            button14.TabIndex = 21;
            button14.Text = "3";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_Click;
            button14.Click += handle_read_only;

            // 
            // button15
            // 
            button15.Location = new Point(302, 686);
            button15.Name = "button15";
            button15.Size = new Size(208, 153);
            button15.TabIndex = 20;
            button15.Text = "2";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_Click;
            button15.Click += handle_read_only;

            // 
            // button16
            // 
            button16.Location = new Point(88, 686);
            button16.Name = "button16";
            button16.Size = new Size(208, 153);
            button16.TabIndex = 19;
            button16.Text = "1";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button_Click;
            button16.Click += handle_read_only;

            // 
            // button17
            // 
            button17.BackColor = SystemColors.ButtonShadow;
            button17.Enabled = false;
            button17.Location = new Point(730, 845);
            button17.Name = "button17";
            button17.Size = new Size(208, 153);
            button17.TabIndex = 26;
            button17.Text = "+";
            button17.UseVisualStyleBackColor = false;
            button17.Click += handle_operation;
            button17.Click += handle_read_only;

            // 
            // button18
            // 
            button18.Location = new Point(516, 845);
            button18.Name = "button18";
            button18.Size = new Size(208, 153);
            button18.TabIndex = 25;
            button18.Text = "=";
            button18.UseVisualStyleBackColor = true;
            button18.Click += handle_result;
            button18.Click += handle_read_only;

            // 
            // button19
            // 
            button19.Location = new Point(302, 845);
            button19.Name = "button19";
            button19.Size = new Size(208, 153);
            button19.TabIndex = 24;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(88, 845);
            button20.Name = "button20";
            button20.Size = new Size(208, 153);
            button20.TabIndex = 23;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            button20.Click += handle_read_only;

            // 
            // button21
            // 
            button21.BackColor = SystemColors.ButtonShadow;
            button21.Location = new Point(730, 209);
            button21.Name = "button21";
            button21.Size = new Size(208, 153);
            button21.TabIndex = 29;
            button21.Text = ")";
            button21.UseVisualStyleBackColor = false;
            button21.Click += handle_operation;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Location = new Point(88, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(850, 140);
            textBox1.TabIndex = 27;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Enabled = false;
            textBoxOutput.Location = new Point(606, 109);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(300, 48);
            textBoxOutput.TabIndex = 28;
            textBoxOutput.Text = "0";
            textBoxOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // all_calc_RO
            // 
            all_calc_RO.BorderStyle = BorderStyle.None;
            all_calc_RO.Enabled = false;
            all_calc_RO.ForeColor = SystemColors.ControlDarkDark;
            all_calc_RO.Location = new Point(606, 69);
            all_calc_RO.Name = "all_calc_RO";
            all_calc_RO.Size = new Size(300, 48);
            all_calc_RO.TabIndex = 30;
            all_calc_RO.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 1091);
            Controls.Add(all_calc_RO);
            Controls.Add(button21);
            Controls.Add(textBoxOutput);
            Controls.Add(textBox1);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button12);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button11;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox textBox1;
        private TextBox textBoxOutput;
        private Button button21;
        private TextBox all_calc_RO;

        public Button Button11 { get => button11; set => button11 = value; }
    }
}
