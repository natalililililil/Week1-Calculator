using Week1_Calculator;

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("=====Консольный калькулятор=====");

    try
    {
        Console.Write("Введите первое число: ");
        double firstNum = InputValidator.ReadNumber(Console.ReadLine());

        Console.Write("Введите арифметическую операцию: `+`, `-`, `*`, `/`: ");
        var operation = InputValidator.ReadOperation(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double secondNum = InputValidator.ReadNumber(Console.ReadLine());

        var calculator = new Calculator();

        var result = calculator.Calculate(operation, firstNum, secondNum);
        Console.WriteLine($"Результат операции: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine("Нажмите ENTER, чтобы выполнить новую операцию, или ESC для выхода");
    var choice = Console.ReadKey(intercept: true);

    if (choice.Key == ConsoleKey.Escape)
    {
        isRunning = false;
    }

    Console.Clear();
}

