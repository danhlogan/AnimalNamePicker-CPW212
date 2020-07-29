using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNamePicker_CPW212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Animal Name Picker!");
            Console.WriteLine("Choose an animal type and number of those animals to be named.");

            // Method that gets and returns type of animal
            string animal = AnimalType();

            // Method that gets and returns animal number
            int animalNum = AnimalNum();

            // Method that selects animal name list based on animal type and returns list 
            List<string> animalNames = new List<string>();
            animalNames = AssignNames(animal, animalNum);

            // Method that prints named animal list 
            PrintNames(animalNames, animalNum, animal);

            // Method that asks the user if they would like to go again
            GoAgain();

        }

        private static string AnimalType()
        {
            Console.WriteLine("Please choose an animal type (Cow, Pig, Sheep, or Chicken)");

            string animal = (Console.ReadLine()).ToLower();

            List<string> validAnimals = new List<string>()
            {
            "cow",
            "pig",
            "sheep",
            "chicken",
            };


            if (!validAnimals.Contains(animal))
            {
                Console.WriteLine("Invalid animal selection!");
                AnimalType();
            }

            return animal;
        }

        private static int AnimalNum()
        {
            Console.WriteLine("Please enter a number of animals (up to 5)");

            string input = Console.ReadLine();

            int animalNum;

            if (!int.TryParse(input, out animalNum) || Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 5)
            {
                Console.WriteLine("Invalid number selection!");
                AnimalNum();
            }

            return animalNum;
        }

        // The animals are named after my animals in Stardew Valley! 
        private static List<string> AssignNames(string animal, int animalNum)
        {
            List<string> animalNames = new List<string>();

            if (animal.Equals("cow"))
            {
                animalNames.AddRange(new List<string>()
                {
                    "Moo-Moo","Cheddar","Burrito","Baby-Bell","Strawberry","Cozie","Bessie","Snowflake",
                    "Barley","Beans"
                });
            }
            else if (animal.Equals("pig"))
            {
                animalNames.AddRange(new List<string>()
                {
                    "Popcorn","Sunflower","Dandelion","Mango","Clover","Olive","Peach","Plum","Raindrop",
                        "Charlotte","Petra"
                });
            }
            else if (animal.Equals("sheep"))
            {
                animalNames.AddRange(new List<string>()
                {
                    "Juna", "Pluto","Poppy", "Thea", "Bonnie", "Buttons","Apple", "Juniper", "Pumpkin",
                    "Apricot", "Bo-Peep"
                });
            }
            else if (animal.Equals("chicken"))
            {
                animalNames.AddRange(new List<string>()
                {
                    "Buttercup", "Patchley", "Gumball", "Pebble","Panini", "Sprout", "Blu", "Cadbury",
                        "Frenchie", "Ditalini"
                });
            }


            return animalNames;
        }

        private static void PrintNames(List<string> animalNames, int animalNum, string animal)
        {
            List<string> namedAnimals = new List<string>();


            Console.WriteLine($"Your " + animalNum + " " + animal + "'s will be named: ");

            for (int i = 0; i < animalNum; i++)
            {
                var random = new Random();
                int index = random.Next(animalNames.Count);
                Console.WriteLine(animalNames[index - 1]);
                namedAnimals.Add(animalNames[index]);
                animalNames.RemoveAt(index - 1);
            }
        }

        private static void GoAgain()
        {
            Console.WriteLine("Would you like to go again? (Yes/No)");
            string input = Console.ReadLine();

            if(input.Equals("Yes"))
            {
                Main(null);
            }

            else
            {
                Console.ReadKey();
            }
        }
    }
}

       

