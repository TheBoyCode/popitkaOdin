using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    class Restaurant
    {
        public string Name { get; set; }

        // паблік поля з великої букви
        //приватні з _ і з маленької букви

        public string Adress { get; set; }
        //  public List<Human> Owner { get; set; }
        public List<Owner> Owners { get; set; }
        public Kitchen Kitchen { get; set; }

        public List<Hall> Halls { get; set; }
        public Bar Bar { get; set; }
        
        
    }

}
