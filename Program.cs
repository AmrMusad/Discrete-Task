using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int usern1, usern2, eqan1, eqan2, flag;
            Console.WriteLine("Enter the first number : " );
            usern1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the second number : ");
            
            usern2 =int.Parse(Console.ReadLine());
            Console.WriteLine("The prime numbers in range :");

            for (eqan1 = usern1; eqan1 <= usern2; eqan1++)
            {
                flag = 0;

                for (eqan2 = 2; eqan2 <= eqan1 / 2; eqan2++)
                {


                    if (eqan1 % eqan2 == 0)
                    {
                        flag++;
                        break;
                    }
                }

            if((flag==0)&& (eqan1 !=1))
                {
                    Console.WriteLine(eqan1);
                }
                










            }
          
        }
    }
}
