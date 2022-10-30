using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // input
           double depositSum = double.Parse(Console.ReadLine());
            int depositInMonths = int.Parse(Console.ReadLine());
            double yearInterestPercentage = double.Parse(Console.ReadLine());
            
            double yearleAccumulatedInterest = depositSum * yearInterestPercentage / 100;
            // calculate
            double totalSum = depositSum + depositInMonths * ((depositSum * yearInterestPercentage / 100 / 12));


            // output
            Console.WriteLine(totalSum);

        }
    }
}
