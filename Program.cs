using System;
using System.Text;
using System.Threading.Tasks;

namespace PokerCalculator
{
    public class PokerCalculator
    {
        static void Main(string[] args)
        {
            int numPlayers = 0;
            decimal totalPot = 0.00m;
            decimal firstPlace = 0.00m;
            decimal secondPlace = 0.00m;
            decimal thirdPlace = 0.00m;
            bool moreThanSix = false;

            Console.Write("Enter number of players: ");
            numPlayers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total amount of American dollars (do not include comma if amount is at least in the thousands): $");
            totalPot = Convert.ToDecimal(Console.ReadLine());

            // For a game of 6 or less players
            if (numPlayers <= 6)
            {
                firstPlace = totalPot * .60m; // First place takes 60% of the pot
                secondPlace = totalPot * .40m; // Second place takes 40% of the pot
            }

            // For a game of 7 or more players
            else
            {
                moreThanSix = true;
                firstPlace = totalPot * .50m; // First place takes 50% of the pot
                secondPlace = totalPot * .30m; // Second place takes 30% of the pot
                thirdPlace = totalPot * .20m; // Third place takes 20% of the pot
            }

            firstPlace = decimal.Round(firstPlace, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("First place would take home $" + firstPlace);
            secondPlace = decimal.Round(secondPlace, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine("Second place would take home $" + secondPlace);
            if (moreThanSix)
            {
                thirdPlace = decimal.Round(thirdPlace, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("Third place would take home $" + thirdPlace);
            }
        }
    }
}