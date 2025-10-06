using System;

namespace Week1_Calculator
{
    internal class Calculator
    {
        public double Calculate(string operation, double firstNum, double secondNum)
        {
            var result = operation switch
            {
                "+" => firstNum + secondNum,
                "-" => firstNum - secondNum,
                "*" => firstNum * secondNum,
                "/" => secondNum == 0 ? throw new DivideByZeroException("Деление на ноль запрещено") : firstNum / secondNum
            };

            return result;
        }
    }
}
