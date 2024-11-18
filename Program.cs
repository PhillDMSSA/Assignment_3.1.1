using System;
using System.Text;

namespace Assignment_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EvenNums(100); //must input a int value to call method
        }
        static void EvenNums(int numAmount)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < numAmount; i += 2)
            {
                sb.Append(i);
                sb.Append(" ");
            }
             Console.WriteLine(sb.ToString());
            

        }
    }
}
