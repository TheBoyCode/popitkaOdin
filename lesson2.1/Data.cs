using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
   static class Data
    {
      public static List<Restaurant> Restaurants { get; set; }
       
        //static void randomFilling(List<Restaurant> restaurants)
        //{
        //    Restaurant restaurantBuff = new Restaurant();

        //}
        public static  Restaurant RandRestaurant()
        {
            Random ranNumber= new Random();
            Restaurant buffRestaurant = new Restaurant();
            buffRestaurant.Name = RandStr();
            buffRestaurant.Adress = ranNumber.Next(1,200).ToString() +" "+ RandStr();
           
            Random ranCircl = new Random();
            List<Human> Ow = new List<Human>();
            int n = ranCircl.Next(1, 10);
            for (int i=0; i< n ; i++)
            {
                Human human = new Human();
                Random randId = new Random(ranCircl.Next());
                human.Sex= (Gender)ranCircl.Next(0, 2);
                human.Name = RandStr(randId.Next());
                human.Id = randId.Next(100000,1000000).ToString();
                human.Age = randId.Next(1,100);
                
                Ow.Add(human);
                buffRestaurant.Owner = Ow;
            }//LIST of Human

           // /////////////////////////////////////////////////////
           //for(int i=0;i<n;i++)
           // {
           //     Console.WriteLine(buffRestaurant.Owner[i].Age);
           //     Console.WriteLine(buffRestaurant.Owner[i].Sex);
           //     Console.WriteLine(buffRestaurant.Owner[i].Name);
           //     Console.WriteLine(buffRestaurant.Owner[i].Id);
           // }
           ////////////////////////////////////////////////////////


            return buffRestaurant;
        }


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
        }   //Random TIME
        public static string RandStr(int rand)
        {
            string str = "";
            int countOfLetter;
            char letter;
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            Random randCountOfLetter = new Random(rand);

            countOfLetter = randCountOfLetter.Next(3, 10);//число букв в слові
            for (int i = 0; i < countOfLetter; i++)
            {
                Random randLetter = new Random(countOfLetter + i);
                int buff = randLetter.Next(0, 25);
                letter = abc[buff];//рандомна буква
                str += letter;
            }
            ///////////
            // Console.WriteLine(str);
            /////////////
            return str;
        } //Random NUMBER


    }
   
}
