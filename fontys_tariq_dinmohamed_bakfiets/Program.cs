using System;
using System.Runtime.InteropServices;

namespace fontys_tariq_dinmohamed_bakfiets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I decided to switch it up, bakfietsen alone are boring.
            Console.WriteLine("Hallo, Welkom bij V.D Brinckes Fietsen");
            Console.WriteLine("Maak een keuze uit te volgende typen fietsen\n");
            //Printout the different bike types from enum
            Selector.PrintBikeTypes();
            string read_user_input = Console.ReadLine();
/*            if (type_of_bike == null || type_of_bike == "")
            {
                Console.WriteLine("Whoops! daar ging iets fout! Kies een nummer");
            }
            else
            {
                Console.WriteLine(type_of_bike);
            }*/
        }
    }


    internal class Selector
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
            //Enumarate over enum biketypes and print each , including pricing.
            foreach (BikeTypes bikeType in Enum.GetValues(typeof(BikeTypes)))
            {
                /**
                 * Here, we iterate through the BikeTypes enum, one type at a time, 
                 * and for each type, we retrieve its value (integer representation).
                 * We then assign both the type's name and its associated value to 'bikeType'.
                 * 
                 * So the first call on biketype prints the enum name.
                 * The second call on biketype prints the associated int(price).
                 */

                Console.WriteLine($"{bikeType}, Kosten: {(int)bikeType}");
            }
        }
    }


}
