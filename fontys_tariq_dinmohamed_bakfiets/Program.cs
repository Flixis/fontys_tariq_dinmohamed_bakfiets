using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static fontys_tariq_dinmohamed_bakfiets.BikeType;

namespace fontys_tariq_dinmohamed_bakfiets
{
    //Who thought it was a good idea to inhert namespace from filename... I want my file to be named main...
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

}
