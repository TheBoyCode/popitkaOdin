﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Restaurant r = new Restaurant();
            r = Data.RandRestaurant();


            Console.ReadLine();
        }
    }
}
