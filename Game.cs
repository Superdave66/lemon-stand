using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Game
    {
       public Player player; 
        public string createdPlayer;
       public List<Day> days;
        public Store store;
        
        public Game ()
        {
            CreateAPlayer();
            CreateAStore();
            CreateNumberOfDays();





        }

        public void CreateAPlayer( )
        {
            Console.WriteLine("type 1 to create your player");
           createdPlayer= Console.ReadLine();    
            if (createdPlayer == "1")
            { this.player = new Player(); 
                
                
            } 
            else
            {
                Console.WriteLine("you did not type 1 please type 1 to create your player");
                CreateAPlayer();
                
            }

         }
         public void CreateAStore( )
        {
              store = new Store( this. player);
        }
        public void CreateNumberOfDays()
        {
            Console.WriteLine("how many days would you like to play?");
            int x = int.Parse(Console.ReadLine());
            days = new List<Day>();
            for (int i =0; i <x; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
            foreach (Day day in days)
            {
                
            }
            
            
        }
        public void CreateWeather()
        {
            //if()
        }
        public void RunGame(Inventory inventory)
        {
            CreateNumberOfDays();
            player.CreateARecipe(inventory);


           

        }
    }  
}
       