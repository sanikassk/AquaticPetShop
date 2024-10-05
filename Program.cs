namespace AquaticPetShop
{
    using System;


    //defining properties in Fish class
    public class Fish
    {
        public string Species { get; set; }
        public double PricePerFish { get; set; }
    }

    //Extending class Fish
    public class FishUtility : Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;
        }

        public bool BuyFish()
        {
            return Species == "Clownfish" || Species == "Goldfish";
        }

        public double CalculatePrice(int numberOfFishes)
        {
            double additionalCharges = Species == "Clownfish" ? 100 : 1.50;
            return numberOfFishes * PricePerFish + additionalCharges;
        }
    }

    public class Program
    {
        public static void Main()
        {
            FishUtility fishUtility = new FishUtility();

            Console.Write("Enter the species to buy: ");
            string species = Console.ReadLine();

            Console.Write("Enter the price per fish: ");
            double pricePerFish = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of fishes you need to buy: ");
            int numberOfFishes = Convert.ToInt32(Console.ReadLine());

            fishUtility.AddFish(species, pricePerFish);

            if (!fishUtility.BuyFish())
            {
                Console.WriteLine($"{species} species not found");
            }
            else
            {
                double totalPrice = fishUtility.CalculatePrice(numberOfFishes);
                Console.WriteLine($"Total price: ${totalPrice:F2}");
            }
        }
    }
}
