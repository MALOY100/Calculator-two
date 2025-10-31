using System;
using Calculator;

ICalculator _calculator = new ICalculator();
UpCalculator upcalculator = new UpCalculator();
while (true)
{
    Console.WriteLine("Введите первое число");
    string FirstInput = Console.ReadLine();
    int Value1 = int.Parse(FirstInput);
    Console.WriteLine("Введите второе число");
    string SecondInput = Console.ReadLine();
    int Value2 = int.Parse(SecondInput);
    Console.WriteLine("Введите операцию (+,-,*,/)");
    string Symbol = Console.ReadLine();
    if (Symbol == "+")
    {
        Console.WriteLine(_calculator.Add(Value1, Value2));
    }
    else if (Symbol == "-")
    {
        Console.WriteLine(_calculator.Div(Value1, Value2));
    }
    else if (Symbol == "*")
    {
        Console.WriteLine(_calculator.Math(Value1, Value2));
    }
    else if (Symbol == "/")
    {
        Console.WriteLine(_calculator.Sub(Value1, Value2));
    }

    Console.WriteLine("Завершить работу?");
    string choose = Console.ReadLine();
    if (choose == "да")
    {
        Console.WriteLine("Хотите ли вы попробовать другой калькулятор?");
        string chose = Console.ReadLine();
        if (chose == "да")
        {
            Console.WriteLine("Введите число:");
            string Input = Console.ReadLine();
            int Value3 = int.Parse(Input);
            Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц, 7 - выход");
            string Math = Console.ReadLine();
            if (Math == "1")
            {
                Console.WriteLine(upcalculator.Exponentiation2(Value3));
            }
            else if (Math == "2")
            {
                Console.WriteLine(upcalculator.Exponentiation3(Value3));
            }
            else if (Math == "3")
            {
                Console.WriteLine(upcalculator.Root(Value3));
            }
            else if (Math == "4")
            {
                Console.WriteLine(upcalculator.Cos(Value3));
            }
            else if (Math == "5")
            {
                Console.WriteLine(upcalculator.Sin(Value3));
            }
            else if (Math == "6")
            {
                Console.WriteLine(upcalculator.Tan(Value3));
            }
            else if (Math == "7")
            {
                break;
            }
        }
        else
        {
            break;
        }
    }
    else
    {
        continue;
    }
}