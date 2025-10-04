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
                "/" => firstNum / secondNum,
            };

            return result;
        }
    }
}
