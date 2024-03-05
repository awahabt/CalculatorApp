using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {    
        double _num1 = 0;
        double _num2 = 0;
        string _operator;

        
        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyboardPress);
        }

        private double? Calculate()
        {
            double? result = 0;
            switch(_operator)
            {
                case "+":
                    result = _num1 + _num2;
                    break;
                case "-":
                    result = _num1 - _num2;
                    break;
                case "/":
                    result = _num1 / _num2;
                    break;
                case "*":
                    result = _num1 * _num2;
                    break;
                default:
                    break;
            }
            return result;
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            calText.Text = string.Empty;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            int txtLength = txtDisplay.Text.Length;

            if (txtLength > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtLength - 1);
            }
        }
        private void PI_Click(object sender, EventArgs e)
        {
            var pi = Math.PI;
            var maxPi = pi.ToString().Length;

            txtDisplay.Text = pi.ToString().Remove(maxPi - 8);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                FinalCal.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_KeyboardPress(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.NumPad0: button0.PerformClick(); break;
                    
                case Keys.NumPad1: button1.PerformClick(); break;

                case Keys.NumPad2: button2.PerformClick(); break;   

                case Keys.NumPad3: button3.PerformClick(); break;

                case Keys.NumPad4: button4.PerformClick(); break;

                case Keys.NumPad5: button5.PerformClick(); break;

                case Keys.NumPad6: button6.PerformClick(); break;

                case Keys.NumPad7: button7.PerformClick(); break;

                case Keys.NumPad8: button8.PerformClick(); break;

                case Keys.NumPad9: button9.PerformClick(); break;

                case Keys.Back: Backspace.PerformClick(); break;

                case Keys.Add: buttonPlus.PerformClick(); break;

                case Keys.Subtract: buttonMinus.PerformClick(); break;

                case Keys.Divide: buttonDivided.PerformClick(); break;

                case Keys.Multiply: buttonTimes.PerformClick(); break;
            }
        }


        #region MouseButtonClick
        private void button0_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }

        private void point_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtDisplay.Text += text;
            this.ActiveControl = null;
        }
        #endregion

        // Operators
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _operator = "+";
            double.TryParse(txtDisplay.Text, out double temp);
            _num1 = temp;
            txtDisplay.Clear();
            calText.Text = $"{_num1} {_operator}";
            this.ActiveControl = null;
        }

        private void buttonDivided_Click(object sender, EventArgs e)
        {
            _operator = "/";
            double.TryParse(txtDisplay.Text, out double temp);
            _num1 = temp;
            txtDisplay.Clear();
            calText.Text = $"{_num1} {_operator}";
            this.ActiveControl = null;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            _operator = "*";
            double.TryParse(txtDisplay.Text, out double temp);
            _num1 = temp;
            txtDisplay.Clear();
            calText.Text = $"{_num1} {_operator}";
            this.ActiveControl = null;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _operator = "-";
            double.TryParse(txtDisplay.Text, out double temp);
            _num1 = temp;
            txtDisplay.Clear();
            calText.Text = $"{_num1} {_operator}";
            this.ActiveControl = null;
        }

        private void FinalCal_Click(object sender, EventArgs e)
        {
            var text = "=";
            double.TryParse(txtDisplay.Text, out double temp);
            _num2 = temp;
            txtDisplay.Text = Calculate().ToString();
            calText.Text = $"{_num1} {_operator} {_num2} {text} {txtDisplay.Text}";
        }

    }
}