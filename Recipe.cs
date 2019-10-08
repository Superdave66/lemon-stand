using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfCupsOfSugar;
        public int iceCubesPerCup;
        public double pricePerCup;
        public int numberOfCupsLeftInBatch = 0;
        public Recipe(Inventory inventory )
        {
            TheRecipe(); 
            HowMuchPerCup();
            MakeABathch(inventory);
        }
        public void TheRecipe()
        {
          HowManyLemonsPerPitcher();
          HowManyIceCubesPerCup();
          HowManyCupsOfSugar();
          

            
        }
        public void HowManyLemonsPerPitcher()
        {
            Console.WriteLine("How many lemons do you want in your recipe");
            amountOfLemons= int.Parse(Console.ReadLine());
            
        }
        public void HowManyIceCubesPerCup()
        {
            Console.WriteLine("How many ice cubes do you want in each cup?");            
            iceCubesPerCup = int.Parse (Console.ReadLine());
        }   
        public void HowManyCupsOfSugar()
        {
            Console.WriteLine("How many cups of sugar per cup?");
            amountOfCupsOfSugar= int.Parse( Console.ReadLine());
        }
        public void HowMuchPerCup()
        {
            Console.WriteLine("How much would you like to charge per cup");
            pricePerCup =double.Parse(Console.ReadLine());
        }
        public void MakeABathch(Inventory inventory)
        {
            if ( numberOfCupsLeftInBatch == 0)

            {

                inventory.lemons.amount -= amountOfLemons;
                inventory.cupsOfSugar.amount -= amountOfCupsOfSugar;
                numberOfCupsLeftInBatch = 20;


            }
        }
    }

}
