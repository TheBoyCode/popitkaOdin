using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
   static class Data
    {
      public static List<Restaurant> restaurants { get; set; }
       
        //static void randomFilling(List<Restaurant> restaurants)
        //{
        //    Restaurant restaurantBuff = new Restaurant();

        //}
        public static string RandStr()
        {
            string str="";
            int countOfLetter;
            char letter;
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            Random randCountOfLetter = new Random();
            
            countOfLetter = randCountOfLetter.Next(3, 10);//число букв в слові
            for(int i=0;i<countOfLetter;i++)
            {
                Random randLetter = new Random(countOfLetter+i);
                int buff = randLetter.Next(0, 25);
                letter = abc[buff];//рандомна буква
                str += letter;
            }
            ///////////
           // Console.WriteLine(str);
            /////////////
            return str;
        }

        
    }
   
}
