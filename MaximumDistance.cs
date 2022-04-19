using System;
using System.Threading;

namespace TorstaiA
{
    class MaximumDistance
    {
        static void Main(string[] args)
        {
            //Try to use descriptive names
            double concumptionCity = 9.3;
            double concumptionMotorway = 6.7;
            int totCapacity = 57;
            double kilometresCity = (totCapacity / concumptionCity) * 100;
            double kilometresMotorway = (totCapacity / concumptionMotorway) * 100;

            Console.WriteLine($"In city environment {kilometresCity:F0} kilometres.");
            Console.WriteLine($"Using motorways {kilometresMotorway:F0} kilometres.");            
        }
    }
} 
