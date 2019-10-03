using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Player
    {
        public Wallet wallet = new Wallet() ;
        public Recipe recipe  = new Recipe();
        public Pitcher pitcher= new Pitcher();
        public double businessProfits;
        public string name;
        public Inventory inventory= new Inventory();
        
            
        public Player()
        {
           GetPlayersName();
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
            int startingCash = 22;
            wallet.money += startingCash;
            Console.WriteLine(wallet.money + " " + "this is how much you have to spend");
        }

        
        

    }



}
   