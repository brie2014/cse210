using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largestNumber = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) break;
            numbers.Add(number);
        } while (number != 0);

        foreach (int num in numbers)
        {
            // add num to sum
            sum += num;
            // set num to largest if it is bigger
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}