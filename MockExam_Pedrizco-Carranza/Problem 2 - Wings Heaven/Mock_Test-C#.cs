using System;

namespace Problem_2___Wings_Heaven
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX = 0.08;
            const double DISCOUNT = 0.18;
            double boneless = 7.99;
            double traditionalWing = 9.99;
            double bothWings = boneless + traditionalWing;

            double[] typeOfSauce = new double[4];
            typeOfSauce[0] = 0.29;
            typeOfSauce[1] = 0.39;
            typeOfSauce[2] = 0.99;
            typeOfSauce[3] = 0.00;

            int[] numberForList = new int[4];
            numberForList[0] = 1;
            numberForList[1] = 2;
            numberForList[2] = 3;
            numberForList[3] = 4;

            int chooseSauces;
            int chooseSides;

            double waffleFries = 3.49;
            double onionRings = 2.49;
            double bothSides = waffleFries + onionRings;
            double subtotal;
            double total;

            Console.Write($"Enter the kind of wings [b - boneless ({boneless:C}), t - traditional " +
                $"({traditionalWing:C}), c - both ({bothWings:C}): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string optionOfWings = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine($"{numberForList[0]}. Buffalo Sauce ({typeOfSauce[0]:C})" +
                $"\n{numberForList[1]}. Mild Sauce ({typeOfSauce[1]:C})" +
                $"\n{numberForList[2]}. BBQ Sauce ({typeOfSauce[2]:C})" +
                $"\n{numberForList[3]}. Plain (no charge)");

            Console.Write("\nSelect one of the preferred sauces: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int.TryParse(Console.ReadLine(), out chooseSauces);
            Console.ResetColor();

            Console.WriteLine($"{numberForList[0]}. Waffle Fries ({waffleFries:C}" +
                $"\n{numberForList[1]}. Onion RIngs ({onionRings:C})" +
                $"\n{numberForList[2]}. Both ({bothSides:C})" +
                $"\n{numberForList[3]}. None");
            Console.Write("Select one of the sides: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int.TryParse(Console.ReadLine(), out chooseSides);

            if (optionOfWings == "boneless")
            {
                if (chooseSauces == numberForList[0])
                {
                    if (chooseSides == numberForList[0])
                    {

                    }
                }
            }
        }
    }
}
