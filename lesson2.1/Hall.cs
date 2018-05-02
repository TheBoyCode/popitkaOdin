using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    class Hall
    {
        public List<Staff> Staffs { get; set; } 
        public List<Waiter> Waiters { get; set; }
        public List<Admin> Administrators { get; set; }
        public int Number { get; set; }
        public string Id { get; set; }
    }
}
