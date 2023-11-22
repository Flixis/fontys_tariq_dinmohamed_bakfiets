using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;


namespace fontys_tariq_dinmohamed_bakfiets
{
    public class Calculations
    {
        public static int CalculateBillingAmount(int billingAmount, Enum enumType, string DisplayName)
        {
            bool addMore = true;
            while (addMore)
            {
                Console.WriteLine($"Welke van de volgende {DisplayName} zou je willen?:");
                string userInput = Console.ReadLine().Trim().ToLower();

                /*
                 *Learned something new here!
                 *https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse?view=net-7.0
                 * Enum tryparse.
                 *
                 *In essence, It tries to match the userinput to something in the enum.
                 * If it fails, it will "ignore" that case and print the text below.
                 * If it matches it continues, and saves the userinput that it matched in selectedbiketype.
                 * Then we add it to the billingamount.
                 * 
                 * Pretty cool stuff imo, I guess enum parsing is popular enough that MSF made their own function for it.
                */
                if (!Enum.TryParse(enumType.GetType(), userInput, true, out var enumValue))
                {
                    Console.WriteLine("Ongeldige selectie. Maak een keuze uit de vermelde opties.");
                    continue;
                }

                Console.Write($"Hoeveel van deze {DisplayName} wilt u huren?: ");
                //Sanitise the input, with this cool shorthand if parser.
                if (!int.TryParse(Console.ReadLine(), out int quantity))
                {
                    Console.WriteLine("Ongeldige invoer. Voer een getal in.");
                    continue;
                }

                billingAmount += (int)enumValue * quantity;

                // Ask if the user wants to add more items
                Console.Write("Wil je meer items toevoegen? (ja/nee): ");
                userInput = Console.ReadLine().Trim().ToLower();
                if (userInput != "ja")
                {
                    addMore = false;
                    continue;
                }
            }

            // Return the updated billingAmount
            return billingAmount;
        }
    }
}
