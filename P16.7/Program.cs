using System;

namespace P16._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Find the maximum of two numbers without using comparisons
            //ONLY POSITIVES or ONLY NEGATIVES
            //There's an scenary where you can use negatives but only when
            //The Abs of the negative is less than the positive
            //using maths, (and some magic) 
            var compareOne = -10;
            var compareTwo = 4;
            var biggestValue = (Math.Abs(compareOne-compareTwo)+Math.Abs(compareOne+compareTwo))/2;
            Console.WriteLine($"The biggest value is: {biggestValue}");
        }
    }
}
