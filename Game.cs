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
            
        }

        public void CreateAPlayer()
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
         public void CreateAStore()
        {
              store = new Store();
        }

        public void RunGame()
        {
            CreateAStore();
            store.BuyCups( player);


        }
    }  
}
       