using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Player
    {
        public Wallet wallet;
        public Recipe recipe;
      
        public double businessProfits;
        public string name;
        public Inventory inventory;
        
            
        public Player()
        {                       
            GetPlayersName();
           this. inventory = new Inventory();
            this.wallet = new Wallet();
            GetStartingCash();
            
            
            
            
            



    }
            public void GetPlayersName()
            {
                Console.WriteLine("What is your name?");
                name =  Console.ReadLine();
                Console.WriteLine("hello" + " " + name);
                    
            }
        public void GetStartingCash()
        {
            int startingCash = 1;
            wallet.money += startingCash;
            Console.WriteLine(wallet.money + " " + "this is how much you have to spend");
        }

        
        public void CreateARecipe(Inventory inventory)
        {
            recipe = new Recipe(inventory);
        }
        public void EndGame(Game game)
        { 
            game.RunGame(inventory );
        }
        
        
        

       




    }



}
   