using System;

namespace Week1_Calculator
{
    internal static class InputValidator
    {
        public static double ReadNumber(string? inputNum)
        {
            inputNum = inputNum.Replace('.', ',');

            if (double.TryParse(inputNum, out var outputNum))
                return outputNum;
            else
                throw new ArgumentException("Введено не число");
        }

        public static string ReadOperation(string? operation)
        {
            if (operation is "+" or "-" or "*" or "/")
                return operation;
            else
                throw new InvalidOperationException("Неизвестная операция");
        }
    }
}
