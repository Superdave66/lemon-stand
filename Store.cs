using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Store
    {
        //priceOfIceMachine = 8.5;     
        //priceOfLemons = 3;                 //25 lemons  
        // priceOfBulkLemons = 4.5;           //100 lemons 
        // priceOfCups = 2;                   //100 cups
        // priceOfBulkCups = 3.5;             // 400 cups   
        // priceOfCupsOFSugar = 4;               // 25 cups   
        // priceOfBulkCupsOfSugar = 5.5;      // 100 cups 
        Player player;
        public Store(Player player)
        {
            PurchaseIceMachine(player);
            BuySugar(player);
            BuyCups(player);
            BuyLemons(player);


        }
        
        
           

       


        public void PurchaseIceMachine(Player player )
               
        {
            Console.WriteLine("would you like to rent a icemachine for the week. type 1 for yes");
            int iceMachinePurchased = int.Parse(Console.ReadLine());

            if (iceMachinePurchased == 1)
            {                
                player.wallet.money -= 8.5;
                player.inventory.iceMachine.IceCubes = 100000;
                Console.WriteLine("you have succefully rented the icemachine");
            }            
            else
            {
                Console.WriteLine("we are sorry but you can not continue this game with out renting a icemachine");
                PurchaseIceMachine(player);
                
            }
        }
            public void BuySugar(Player player)
        {

            Console.WriteLine("type 1 for 25 cups of sugar sugar or 2 for bulk cups  of sugar");
            int sugarPurchased = int.Parse(Console.ReadLine());
            if (sugarPurchased == 1)
            {
                
                
                
              
                    player.wallet.money -= 4;
                
                player.inventory.cupsOfSugar.amount += 25;
                Console.WriteLine("25 cups of sugar was placed in inventory");
            }
            else if (sugarPurchased == 2)
            {
                player.wallet.money -= 5.5;                
                player.inventory.cupsOfSugar.amount += 100;
                Console.WriteLine("100 cups of sugar was placed in your inventory");
            }

            else
            {
                Console.WriteLine("im sorry but you did not enter a proper response");
                BuySugar(player);

            }        
    }



        public void BuyCups(Player player)
        {
            Console.WriteLine("type 1 for 100 cups or type 2 for bulk amount of cups");
            int cupsPurchased = int.Parse(Console.ReadLine());
            if (cupsPurchased == 1)
            {
                player.inventory.cups.amount += 100;
                Console.WriteLine("100 cups was placed in inventory");
            }
            else if (cupsPurchased == 2)
            {
                player.wallet.money -= 3.5;
                player.inventory.cups.amount += 400;
                Console.WriteLine("400 cups was placed in your inventory");
            }

            else
            {
                Console.WriteLine("im sorry but you did not enter a proper response");
                BuyCups(player);
            }

        }


        public void BuyLemons( Player player )
        {
            Console.WriteLine("type 1 for 25 Lemons or 2 for bulk Lemons");
            int lemonsPurchased = int.Parse(Console.ReadLine());
            if (lemonsPurchased == 1)
            {
                player.wallet.money -= 3;
                player.inventory.lemons.amount += 25;
                Console.WriteLine("25 where placed in inventory");
            }
            else if (lemonsPurchased == 2)
            {
               
                player.wallet.money -= 4.5;
                player.inventory.lemons.amount += 100;
                Console.WriteLine("100 Lemons where placed in your inventory");
            }

            else
            {
                Console.WriteLine("im sorry but you did not enter a proper response");
                BuyLemons(player);



            }
        }




    }
}
    