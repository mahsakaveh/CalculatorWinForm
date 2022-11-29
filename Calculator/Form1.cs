using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRnd_Click(object sender, EventArgs e)
        {
            double data = double.Parse(lblInput.Text);
            double rund = Math.Round(data, 1, MidpointRounding.ToNegativeInfinity);
            lblInput.Text = rund.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblInput.Text += ((Button)sender).Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(lblInput.Text);
            double result = 0;
            switch (op)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                default:
                    break;
            }
            lblShow.Text = firstNumber.ToString() + op + secondNumber.ToString() + "=" + result;
            lblInput.Text = result.ToString();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(lblInput.Text);
            lblInput.Text = "";
            op = ((Button)sender).Text; //+ - * /
            lblShow.Text = firstNumber.ToString() + op;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "";
        }

        private void btnEinzeln_Click(object sender, EventArgs e)
        {
            if (lblInput.Text == "") return; //nicht weitermachen
            string temp = lblInput.Text;
            if (temp.Length > 0)
            {
                lblInput.Text = temp.Remove(temp.Length - 1, 1);
            }
        }

        private void btnOneDivideX_Click(object sender, EventArgs e)
        {
            if (lblInput.Text == "") return; //nicht weitermachen
            double num = double.Parse(lblInput.Text);
            double numResult = 1 / num;
            lblShow.Text = "1/(" + lblInput.Text + ")= " + numResult.ToString();
            lblInput.Text = numResult.ToString();

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (lblInput.Text == "") return;
            double num = double.Parse(lblInput.Text);
            double numResult = Math.Pow(num, 2);
            lblShow.Text = "(" + lblInput.Text + ")²= " + numResult.ToString();
            lblInput.Text = numResult.ToString();

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (lblInput.Text == "") return;
            double num = double.Parse(lblInput.Text);
            double numResult = Math.Sqrt(num);
            lblShow.Text = "²√(" + lblInput.Text + ")= " + numResult.ToString();
            lblInput.Text = numResult.ToString();

        }


        private void btnLogTwo_Click(object sender, EventArgs e)
        {
            if (lblInput.Text == "") return;
            double num = double.Parse(lblInput.Text);
            double numResult = Math.Log2(num);
            lblShow.Text = "Log2(" + lblInput.Text + ")= " + numResult.ToString();
            lblInput.Text = numResult.ToString();


        }

        private void btnLogX_Click(object sender, EventArgs e)
        {
            if (lblInput.Text == "") return;
            double num = double.Parse(lblInput.Text);
            double numResult = Math.Log10(num);
            lblShow.Text = "Log10(" + lblInput.Text + ")= " + numResult.ToString();
            lblInput.Text = numResult.ToString();
        }
    }
}