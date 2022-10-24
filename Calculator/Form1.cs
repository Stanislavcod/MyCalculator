namespace Calculator
{
    public partial class Calculator : Form
    {
        string operandA = string.Empty;
        string operandB = string.Empty;
        string operation = string.Empty;
        string sign = string.Empty;
        Calculations calculations = new();
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Calculator_Load(object sender, EventArgs e)
        {
            labelSign.Text = String.Empty;
            MaximizeBox = false;
        }
        private void OperandChange(string statement)
        {
            if(operation == string.Empty && operandA.Length < 9)
            {
                operandA += statement;
                Display.Text = operandA;
            }
            else if(operandA != string.Empty && operation != string.Empty && operandB.Length < 9)
            {
                operandB += statement;
                Display.Text = operandB;
                labelSign.Text = string.Empty;
            }
        }
        private void OperationCnange(string statement)
        {
            if(operandA != string.Empty && operandB != string.Empty)
            {
                operandA = calculations.ProcessStatement(sign,operandA + operation + operandB);
                if (operandA[0] == '-')
                {
                    labelSign.Text = sign = "-";
                    operandA = operandA.Substring(1);
                }
                else
                {
                    labelSign.Text = sign = string.Empty;
                }
                Display.Text = operandA;
                operation = statement;
                operandB = String.Empty;
            }
            else
            {
                operation = statement;
            }
        }
        private void SignChange()
        {
            if (operation == string.Empty)
            {
                if (sign != "-")
                {
                    labelSign.Text = sign = "-";
                }
                else
                {
                    labelSign.Text = sign = string.Empty;
                }
            }
        }
        private void ClearDisplay()
        {
            operandA = string.Empty;
            operandB = string.Empty;
            operation = string.Empty;
            labelSign.Text = sign = string.Empty;
            Display.Clear();
        }
        private void Equally()
        {
            operandA = calculations.ProcessStatement(sign, operandA + operation + operandB);
            if (operandA[0] == '-')
            {
                labelSign.Text = sign = "-";
                operandA = operandA.Substring(1);
            }
            else
            {
                labelSign.Text = sign = string.Empty;
            }
            Display.Text = operandA;
            operandB = string.Empty;
            operation = string.Empty;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            OperandChange("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            OperandChange("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            OperandChange("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            OperandChange("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            OperandChange("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            OperandChange("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            OperandChange("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            OperandChange("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            OperandChange("9");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            OperandChange("0");
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            OperationCnange("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            OperationCnange("-");
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            OperationCnange("*");
        }


        private void buttonDel_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            OperationCnange("/");
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            Equally();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            SignChange();
        }
    }
}