using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;


namespace fontys_tariq_dinmohamed_bakfiets
{
    public class Calculations
    {
        /*public static int CalculateBillingAmountBikeType(int billingAmount)
        {
            BikeTypes selectedBikeType;
            int amountOfBikes;

            do
            {
                Console.Write("Voer het type fiets in dat je wilt huren (of voer \"volgende\" in om verder te gaan): ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput) || userInput.ToLower() == "volgende")
                {
                    break;
                }

                //https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse?view=net-7.0
                *//*
                 * Learned something new here!
                 * Enum tryparse.
                 * 
                 * In essence, It tries to match the userinput to something in the enum.
                 * If it fails, it will "ignore" that case and print the text below.
                 * If it matches it continues, and saves the userinput that it matched in selectedbiketype.
                 * Then we add it to the billingamount.
                 * 
                 * Pretty cool stuff imo, I guess enum parsing is popular enough that MSF made their own function for it.
                 
                 *//*
                if (!Enum.TryParse<BikeTypes>(userInput, true, out selectedBikeType))
                {
                    Console.WriteLine("Ongeldige fietsselectie. Maak een keuze uit de vermelde opties.");
                    continue;
                }

                Console.Write("Hoeveel van deze fietsen wil je huren? ");
                //Sanitise the input, with this cool shorthand if parser.
                if (!int.TryParse(Console.ReadLine(), out amountOfBikes))
                {
                    Console.WriteLine("Ongeldige invoer. Voer een getal in.");
                    continue;
                }

                int amountByBikes = amountOfBikes * (int)selectedBikeType;
                billingAmount += amountByBikes;

                Console.WriteLine($"Totaal prijs: {billingAmount}");
            } while (true);

            return billingAmount;
        }*/

    }
}
