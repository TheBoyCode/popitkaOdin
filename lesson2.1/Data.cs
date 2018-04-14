using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
   static class Data
    {
        public static Random randId = new Random();
        public static List<Restaurant> Restaurants { get; set; }
       
        //static void randomFilling(List<Restaurant> restaurants)
        //{
        //    Restaurant restaurantBuff = new Restaurant();

        //}
        public static  Restaurant RandRestaurant()
        {
            
            Restaurant buffRestaurant = new Restaurant();
            buffRestaurant.Name = RandStr();
            buffRestaurant.Adress = randId.Next(1,200).ToString() +" "+ RandStr();
           
          
            List<Human> Ow = new List<Human>();
            int n = randId.Next(1, 10);//Count of Owner
            for (int i = 0; i < n; i++)
            {
               Human human = new Human();
               
               human = AutoCompleteHuman();
               Ow.Add(human);
               buffRestaurant.Owner = Ow;
            }//LIST of Human Owner

            ///////////////////////////////////////////////////
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(buffRestaurant.Owner[i].Age);
                Console.WriteLine(buffRestaurant.Owner[i].Sex);
                Console.WriteLine(buffRestaurant.Owner[i].Name);
                Console.WriteLine(buffRestaurant.Owner[i].Id);
            }
            ////////////////////////////////////////////////////
            Console.WriteLine("//////////////////////////////////////////");

            Kitchen kitchen = new Kitchen();
            Random ranCircl_Kitchen = new Random();
            List<Human> Cooker = new List<Human>();

            int k = ranCircl_Kitchen.Next(1, 10);
            for (int i = 0; i < k; i++)
            {
                Human humanK = new Human();
                
                humanK = AutoCompleteHuman();

                Cooker.Add(humanK);
                kitchen.Cookers = Cooker;
                buffRestaurant.Kitchen = kitchen;
                //Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Sex);
                //Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Age);
                //Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Name);
                //Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Id);

                
            }  //kitchen

            ////////////////////////////////////////////////////
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Age);
                Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Id);
                Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Name);
                Console.WriteLine(buffRestaurant.Kitchen.Cookers[i].Sex);
            }
            //////////////////////////////////////////////////
            List<Hall> hall = new List<Hall>();

          
            List<Human> staff = new List<Human>();
            List<Human> admin = new List<Human>();
            int rnStaff;
            
            int rnAdmin;
            
            buffRestaurant.Halls = new List<Hall>();
           
            int h = randId.Next(1, 5);//count of halls
            for (int i = 0; i < h; i++)
            {
               Hall hallBuff = new Hall();
                hallBuff.Staff = new List<Human>();
                hallBuff.Administrators = new List<Human>();

                hallBuff.Number = i + 1;
                //count of staff
                rnStaff = randId.Next(1,10);

               
                
                for (int j=0;j< rnStaff;j++)
                {
                    
                    Human StaffHuman = new Human();
                    StaffHuman = AutoCompleteHuman();
                    hallBuff.Staff.Add(StaffHuman);
             
                }

                //count of staff
               
                rnAdmin = randId.Next(1,10);
                for (int j = 0; j < rnAdmin; j++)
                {
                    
                    Human AdminHuman = new Human();
                    AdminHuman = AutoCompleteHuman();
                    hallBuff.Administrators.Add(AdminHuman);

                }
                //hallBuff.Administrators = admin;
                //hallBuff.Staff = staff;
              //  hall.Add(hallBuff);
                buffRestaurant.Halls.Add(hallBuff);
                
               
            } 
            //buffRestaurant.Halls = hall;
            //////////////////////////////////////////
            Console.WriteLine("///////////////////////////////");
            for (int y = 0; y < h; y++)
            {
                Console.WriteLine(buffRestaurant.Halls[y].Number);
                for (int p = 0, f = 0; p < buffRestaurant.Halls[y].Staff.Count + buffRestaurant.Halls[y].Administrators.Count; f++, p++)
                {

                    if (p < buffRestaurant.Halls[y].Staff.Count)
                        Console.WriteLine(buffRestaurant.Halls[y].Staff[p].Name);



                    //if (f < buffRestaurant.Halls[y].Administrators.Count)
                    //    Console.WriteLine(buffRestaurant.Halls[y].Administrators[f].Name);
                }
            }


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
                Random randLetter = new Random(countOfLetter*i+i+rand);
                int buff = randLetter.Next(0, 25);
                letter = abc[buff];//рандомна буква
                str += letter;
            }
            ///////////
            // Console.WriteLine(str);
            /////////////
            return str;
        } //Random NUMBER
        
        public static Human AutoCompleteHuman()
        {
            Human hum = new Human();
           
            hum.Sex = (Gender)randId.Next(0, 2);
            hum.Name = RandStr(randId.Next());
            hum.Id = randId.Next(100000, 1000000).ToString();
            hum.Age = randId.Next(1, 100);

            return hum;
        }
    }
   
}
