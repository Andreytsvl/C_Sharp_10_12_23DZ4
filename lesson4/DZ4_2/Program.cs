class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int size = 10;

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(99, 1000);
        }

        Console.WriteLine("массив:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество четных чисел: " + count);

      
    }
}
