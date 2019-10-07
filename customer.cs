using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Customer
    {
        private List<Customer> typeOfCustomer;

        private Day day;
        public Customer customer1;
      
        public Customer (Weather weather)
        {

        }

        public bool CreateCustomer1(Weather weather ,Player player)
        {
            customer1 = new Customer( weather );
            if (weather.condition == sunny && weather.temperature >= 70)
            {
                if (player.recipe.pricePerCup < .50)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

           else  if (weather.condition == rainy && weather.temperature >= 70)
            {
                if (player.recipe.pricePerCup < .20)
                    return true;
                else
                {
                    return false;
                }
            } 
        
        else
            {
                return true;
            }


        }



                                    

    }
}

