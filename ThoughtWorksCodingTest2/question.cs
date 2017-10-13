using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculation
{
    class question
    {

        
         


        public static void quest()
        {
            Char answer = 'Y';

            

            do
            {
                calCost.CalculateCost();
                Console.WriteLine("\n\nWould you like to calculate another room?");
                Console.WriteLine("(Y)es or (N)o\n\n");
                answer = Convert.ToChar(Console.ReadLine());

            }


            while ((answer == 'Y') || (answer == 'y'));


            endProg.EndProgram();
                    
 

        }


    }
}
