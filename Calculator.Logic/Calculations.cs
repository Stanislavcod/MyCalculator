namespace Calculator
{
    public class Calculations
    {

        public string ProcessStatement(string sign,string statement)
        {
            try
            {
                string result = CalulateStatement(GetOperantA(sign, statement), GetOperantB(statement), GetOperation(statement));
                if(statement.Length > 9)
                {
                    return "EXCEEDED";
                }
                else
                {
                    return result;
                }
            }
            catch(Exception)
            {
                return "0";
            }
        }
        string GetOperantA(string sign, string statement)
        {

            string[] a = statement.Split('+', '-', '/', '*');
            return sign + a[0];

        }
        string GetOperantB(string statament)
        {
            string[] b = statament.Split('+', '-', '/', '*');
            return b[1];
        }

        string GetOperation(string statament)
        {
            string[] a = statament.Split('+', '-', '/', '*');
            string b = statament.Substring(a[0].Length, 1);
            return b;
        }
        string CalulateStatement(string operandOne, string operandTwo, string operation)
        {
            switch (operation)
            {
                //тут будет выполнено сложение
                case "+":
                    return Sum(operandOne, operandTwo);
                //тут будет выполнено вычитание
                case "-":
                    return Subtraction(operandOne, operandTwo);
                //тут будет выполнено умножение
                case "*":
                    return Multiply(operandOne, operandTwo);
                //тут будет выполнено деление
                case "/":
                    return Divide(operandOne, operandTwo);
                default:
                    return "Такой операции не существует";
            }
        }
        string Sum(string operandOne, string operandTwo)
        {
            return (int.Parse(operandOne) + int.Parse(operandTwo)).ToString();
        }
        string Multiply(string operandOne, string operandTwo)
        {
            return (int.Parse(operandOne) * int.Parse(operandTwo)).ToString();
        }
        string Subtraction(string operandOne, string operandTwo)
        {
            return (int.Parse(operandOne) - int.Parse(operandTwo)).ToString();
        }
        string Divide(string operandOne, string operandTwo)
        {
            if (operandOne == "0" || operandTwo == "0")
            {
                return "NOT ÷ 0";
            }
            else
            {
                return (int.Parse(operandOne) / int.Parse(operandTwo)).ToString();
            }
        }
    }
}
