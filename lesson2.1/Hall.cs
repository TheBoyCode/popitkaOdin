using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    class Hall
    {
        public List<Human> Staff { get; set; } 
        public List<Waiter> Waiters { get; set; }
        public List<Human> Administrators { get; set; }
        public int Number { get; set; }

    }
}
