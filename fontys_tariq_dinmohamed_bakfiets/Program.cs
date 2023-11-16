using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static fontys_tariq_dinmohamed_bakfiets.BikeType;

namespace fontys_tariq_dinmohamed_bakfiets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int billingAmount = 0;
            //I decided to switch it up, bakfietsen alone are boring.
            Console.WriteLine("Hallo, Welkom bij V.D Brinckes Fietsen");
            Console.WriteLine("Maak een keuze uit te volgende typen fietsen\n");
            //Printout the different bike types from enum
            BikeType.PrintBikeTypes();
            billingAmount = BikeType.CalculateBillingAmountBikeType(billingAmount);
            Console.WriteLine($"Totaal prijs: {billingAmount}");    
        }
    }


    internal class BikeType
    {
        public enum BikeTypes
        {
            Stadfiets = 10,
            Sprintfiets = 20,
            Bakfiets = 30,
            Mountainbike = 40
        }

        public static void PrintBikeTypes()
        {
            /**
             * Here, we iterate through the BikeTypes enum, one type at a time, 
             * and for each type, we retrieve its value (integer representation).
             * We then assign both the type's name and its associated value to 'bikeType'.
             */

            Console.WriteLine("Beschikbare fietstypes en kosten:");
            foreach (BikeTypes bikeType in Enum.GetValues(typeof(BikeTypes)))
            {
                Console.WriteLine($"{bikeType} - Cost: {(int)bikeType}");
            }
            Console.WriteLine();
        }

        public static int CalculateBillingAmountBikeType(int billingAmount)
        {
            BikeTypes selectedBikeType;

            do
            {
                Console.Write("Voer het type fiets in dat je wilt huren (of voer \"volgende\" in om verder te gaan): ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput) || userInput.ToLower() == "volgende")
                {
                    break;
                }

                //https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse?view=net-7.0
                /*
                 * Learned something new here!
                 * Enum tryparse.
                 * 
                 * In essence, It tries to match the userinput to something in the enum.
                 * If it fails, it will "ignore" that case and print the text below.
                 * If it matches it continues, and saves the userinput that it matched in selectedbiketype.
                 * Then we add it to the billingamount.
                 * 
                 * Pretty cool stuff imo, I guess enum parsing is popular enough that MSF made their own function for it.
                 
                 */
                if (!Enum.TryParse<BikeTypes>(userInput, true, out selectedBikeType))
                {
                    Console.WriteLine("Ongeldige fietsselectie. Maak een keuze uit de vermelde opties.");
                    continue;
                }

                billingAmount += (int)selectedBikeType;
            } while (true);

            return billingAmount;
        }
    }




}
