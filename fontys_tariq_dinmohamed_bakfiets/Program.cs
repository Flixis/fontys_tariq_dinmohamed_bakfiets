﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using static fontys_tariq_dinmohamed_bakfiets.Calculations;
using static fontys_tariq_dinmohamed_bakfiets.EnumTypes;

namespace fontys_tariq_dinmohamed_bakfiets
{
    //Who thought it was a good idea to inhert class from filename... I want my file to be named main...
    internal class Program
    {
        static void Main(string[] args)
        {
            int billingAmount = 0;
            List<object> receipt = new List<object>();

            //I decided to switch it up, bakfietsen alone are boring.
            Console.WriteLine("Hallo, Welkom bij V.D Brinckes Fietsen");
            Console.WriteLine("Maak een keuze uit te volgende typen fietsen\n");
            //Printout the different BikeTypes types from enum
            EnumTypes.BikeTypes BikeType = new EnumTypes.BikeTypes();
            EnumTypes.PrintTypes("BikeTypes", BikeType);
            //Calculate bike costs
            billingAmount = CalculateBillingAmount(billingAmount, ref receipt,BikeType, "Fietsen");
            Console.WriteLine($"De totaal prijs is: {billingAmount}");

            //Formatting on prompt is nicer with this
            Console.WriteLine();
            //Printout the different accessoryType types from enum
            EnumTypes.AccesoryTypes accessoryType = new EnumTypes.AccesoryTypes();
            EnumTypes.PrintTypes("Accesories", accessoryType);
            //Calculate accessory costs
            billingAmount = CalculateBillingAmount(billingAmount, ref receipt,accessoryType, "Accesories");

            Console.WriteLine("Totaal bon:");
            Console.WriteLine("------------------------------------");
            foreach (var item in receipt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"De totaal prijs is: {billingAmount}");

            Console.WriteLine("Druk op enter om te beindigen");
            Console.ReadLine();
        }
    }

}
