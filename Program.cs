namespace lesson_5;

internal class Program
{
    private static void Main()
    {
        var calc = new Calc();
        var opMatrix = new[] { 42, 43, 45, 47 };
        Console.Write("Текущий результат ");
        Console.WriteLine(calc.Result);
        calc.MyEventHandler += Calc_MyEventHandler;
        while (true)
        {
            /*
             *Esc - 27
             *Enter - 13
             * "*" - 42
             * "+" - 43
             * "-" - 45
             * "/" - 47
             */
            var op = Convert.ToInt16(Console.ReadKey().KeyChar);
            if (op == 27 || op == 13)
            {
                Console.WriteLine("Выход");
                Console.ReadKey();
                break;
            }

            if (!opMatrix.Contains(op))
            {
                Console.WriteLine(" - Недопустимая операция, разрешены только *-+/");
                Console.ReadKey();
                continue;
            }

                int num = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 42:
                        calc.Multy(num);
                        break;
                    case 43:
                        calc.Sum(num);
                        break;
                    case 45:
                        calc.Sub(num);
                        break;
                    case 47:
                        calc.Divide(num);
                        break;
                }
        }
    }

    private static void Calc_MyEventHandler(object? sender, EventArgs e)
    {
        if (sender is Calc calc)
            Console.WriteLine(calc.Result);
    }
}