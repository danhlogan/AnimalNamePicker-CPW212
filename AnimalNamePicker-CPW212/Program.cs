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

            // Create Method that gets and returns animal number
            int animalNum = AnimalNum();

            // Create Method that selects animal names and returns list 
            AssignNames(animal, animalNum);

            // Create Method that prints list 


            Console.ReadKey();
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
            "horse"
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

            if(!int.TryParse(input, out animalNum) || Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 5)
            {
                Console.WriteLine("Invalid number selection!");
                AnimalNum();
            }

             return animalNum;         
        }

        private static List<string> AssignNames(string animal, int animalNum)
        {
            List<string> namedAnimals = new List<string>();

            List<string> cowNames = new List<string>()
            { 
                "Moo-Moo","Cheddar","Burrito","Baby-Bell","Strawberry","Cozie","Bessie","Snowflake",
                "Barley","Beans"
            };

            List<string> pigNames = new List<string>()
            {
                "Popcorn","Sunflower","Dandelion","Mango","Clover","Olive","Peach","Plum","Raindrop", 
                    "Charlotte","Petra"
            };

            List<string> sheepNames = new List<string>()
            {
                "Juna", "Pluto","Poppy", "Thea", "Bonnie", "Buttons","Apple", "Juniper", "Pumpkin",
                "Apricot", "Bo-Peep"
            };

            List<string> chickenNames = new List<string>()
            {
                "Buttercup", "Patchley", "Gumball", "Pebble","Panini", "Sprout", "Blu", "Cadbury",
                    "Frenchie", "Ditalini"
            };




            return namedAnimals;
        }
    }
}
