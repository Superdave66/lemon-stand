﻿using System;
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
        public Pitcher pitcher;
        public double businessProfits;
        public string name;
        public inventory inventory;

        public Player() { }
            public void GetPlayersName()
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            }
            public void GetStartingCash()
        {

        }
        

    }



}
   