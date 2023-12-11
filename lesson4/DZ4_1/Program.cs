// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа "q" или при вводе числа, сумма цифр которого чётная.




class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                if (GetSumOfDigits(number) % 2 == 0)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
            }
        }

        Console.WriteLine("Программа завершена. Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static int GetSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}