using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            const int STOP = 0;
            double mean = 0;
            int input;

            int count = 0;
            Console.WriteLine("Input number: ,End = 0");
            input = Convert.ToInt32(Console.ReadLine());
            while (input != STOP)
            {
                for (int i = 0; input != STOP; i++)
                {
                    Console.WriteLine("End = 0");
                    input = Convert.ToInt32(Console.ReadLine());
                    count++;
                    var Out = new int[] { input };
                    min = Out.Min();
                    max = Out.Max();
                    mean = Out.Mean();

                    if ((input > min) || (input < max))
                    {
                        min = Out.Min();

                    }
                    if (input > max)
                    {
                        max = Out.Max();
                    }
                }
            }
            Console.WriteLine("Count: {0}", count);
            string Find;
            Find = Console.ReadLine();

            if (Find == "FindMax")
            {
                Console.WriteLine("Max number is {0}", max);
            }
            if (Find == "FindMin")
            {
                Console.WriteLine("Min is {0}", min);
            }
            if (Find == "FindMean")
            {
                Console.WriteLine("Mean is {0}", mean);
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();
        }
    }
}
