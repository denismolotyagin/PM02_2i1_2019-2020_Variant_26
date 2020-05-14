using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double minElement(params double[] arr)
        {   double i;
            // Array is empty?
            if (arr.Length == 0)
            {
                Console.WriteLine("Empty array!");                 
                return Double.NegativeInfinity;
            }             
            else
            {   // Only 1 element in array                 
            if (arr.Length == 1)
                {
                    i = arr[0];                     
                    return i;
                }
            }
            i = arr[0];
            // Searcing for i
            for (int j = 1; j < arr.Length; j++)                 
            if (arr[j] < i)                     
            i = arr[j];
            return i;
        }
        static void Main()
        {
            double U = 0;
            double[] R = { 5.5, 7.6, 3.3, -11.7};
            U = minElement(R);
            Console.WriteLine("Min: {0}", U);
            Console.ReadLine();
        }
    }
}