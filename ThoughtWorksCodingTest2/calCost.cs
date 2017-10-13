using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculation
{
    class calCost
    {
        public static void CalculateCost()
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            const int INCHES_PER_FOOT = 12;
            const string BEST_CARPET = "Saler One";
            const string ECONOMY_CARPET = "Saler Two";

            int roomLengthFeet = 12,
                roomLengthInches = 2,
                roomWidthFeet = 14,
                roomWidthInches = 7;

            double  roomLength,
                    roomWidth,
                    carpetPrice,
                    numOfSquareFeet,
                    numOfSquareYards,
                    totalCost;




            //Get Room Width
            Console.WriteLine("What is your rooms width?");
            roomWidth = Convert.ToDouble(Console.ReadLine());

            //Get room Length 
            Console.WriteLine("\nWhat is your rooms length?");
            roomLength = Convert.ToDouble(Console.ReadLine());

            //Get square footage
            numOfSquareFeet = roomLength * roomWidth;
            Console.Write("\nYour room square footage is: " + "{0:N0}", +numOfSquareFeet);
            Console.WriteLine(" square feet");

            //Get carpet price

            Console.WriteLine("\nPlease enter the cost of your carpet: ");
            carpetPrice = Convert.ToDouble(Console.ReadLine());


            totalCost = numOfSquareFeet * carpetPrice;
            Console.Write("\nYour total cost for carpet is: " + "{0:c2}", +totalCost);
            Console.WriteLine(" plus tax");




        }
    }
}
