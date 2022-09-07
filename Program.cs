using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            //int[] numbers = new int[2] { 1,2};
            //numbers[0] = 1;
            //numbers[1] = 7;


            //Foreach

            string[] carCompanies = { "Tata Motors", "Mahindra", "Volkswagen", "Toyota" };

            foreach (string car in carCompanies)
            {
                Console.WriteLine("{0}", car);
            }
            Console.ReadLine();
            

        }
    }
}
