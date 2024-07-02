using System;


namespace calc
{
    public partial class Form1 : Form
    {
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;

        private string operation = string.Empty;
        private double result = 0.0;


        private bool operatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!operatorClicked)
            {
                operand1 += (sender as Button).Text;
                textBoxOutput.Text = operand1;

                button4.Enabled = true;
                button8.Enabled = true;
                button13.Enabled = true;
                button17.Enabled = true;
            }
            else
            {
                operand2 += (sender as Button).Text;
                textBoxOutput.Text = operand2;
            }
        }

        private void handle_read_only(object sender, EventArgs e)
        {
            all_calc_RO.Text = operand1;

            if (operation != string.Empty)
            {
                all_calc_RO.Text += " " + operation + " " + operand2;
            }

            if (result != 0.0)
            {
                all_calc_RO.Text += " = " + result;
                operand1 = result.ToString();
                result = 0.0;
                operand2 = string.Empty;
                operation = string.Empty;
                operatorClicked = false;
            }
        }

        private void handle_operation(object sender, EventArgs e)
        {

            operation += (sender as Button).Text;
            operatorClicked = true;

            textBoxOutput.Text = string.Empty;

        }

        private void clear_calc(object sender, EventArgs e)
        {
            operand1 = string.Empty;
            operand2 = string.Empty;
            operation = string.Empty;
            result = 0.0;
            operatorClicked = false;
            textBoxOutput.Text = "0";
            all_calc_RO.Text = string.Empty;

            button4.Enabled = false;
            button8.Enabled = false;
            button13.Enabled = false;
            button17.Enabled = false;

        }

        private void fix_line(object sender, EventArgs e)
        {

        }

        private void handle_result(object sender, EventArgs e)
        {

            if (operand1.Length == 0 || operation.Length == 0 || operand2.Length == 0)
            {
                return;
            }
            double num1 = double.Parse(operand1);
            double num2 = double.Parse(operand2);


            if (operation == "+")
            {
                result = num1 + num2;
            }

            if (operation == "-")
            {
                result = num1 - num2;
            }

            if (operation == "X")
            {
                result = num1 * num2;
            }

            if (operation == "/")
            {
                result = num1 / num2;
            }

            textBoxOutput.Text = result.ToString();
        }
    }
}
