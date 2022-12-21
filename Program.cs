using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_number_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usern1, usern2, eqaun1, eqaun2,sum;
            Console.WriteLine("Enter the first number : ");
            usern1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            usern2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The perfect numbers in range : ");

            for (eqaun1 = usern1; eqaun1 <= usern2; eqaun1++)
            {

                eqaun2 = 1;
                sum=0;

                while (eqaun2 < eqaun1)
                {
                    if (eqaun1 % eqaun1 == 0)
                    {
                        sum = sum + eqaun2;
                        eqaun2++;

                    }
                    if (sum == eqaun1)
                    {
                        Console.WriteLine(eqaun1);
                    }
                }
            }
           
          
        }
    }
}
