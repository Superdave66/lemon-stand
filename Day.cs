using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand1
{
    class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public Customer customer;
        //public Day(Recipe recipe)
        //{
        //    recipe.TheReciepe();
        //}
        public void CreateCustomers(Weather weather)
        {
            int x = 100;
            customers = new List<Customer>();
            for (int i = 0; i < x; i++) ;
            {
                Customer customer = new Customer(weather);
                customers.Add(customer);
            }
            foreach (Customer customer in customers) ;


        }

    }
}