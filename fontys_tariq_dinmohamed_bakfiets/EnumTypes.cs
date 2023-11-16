using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fontys_tariq_dinmohamed_bakfiets
{
    internal class EnumTypes
    {
        public enum AccesoryTypes
        {
            Helm = 10,
            Regenpak = 20,
            licht = 30,
            Lunch = 40,
        }
        public enum BikeTypes
        {
            Stadfiets = 10,
            Sprintfiets = 20,
            Bakfiets = 30,
            Mountainbike = 40
        }

        public static void PrintTypes(string displayName, Enum type)
        {
            Console.WriteLine($"Available {displayName} and costs:");

            // Create a variable of the corresponding Enum type
            var valuesArray = Enum.GetValues(type.GetType());

            foreach (var item in valuesArray)
            {
                Console.WriteLine($"{item} - Cost: {(int)item}");
            }

            Console.WriteLine();
        }

    }
}
