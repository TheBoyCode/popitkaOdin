﻿using System;
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

        public static void randomFilling()
        {
            int countOfRest = randId.Next(1,5);
            Restaurants = new List<Restaurant>();
            for(int i=0;i<countOfRest;i++)
            {
                Restaurants.Add(RandRestaurant());
            }
        }

        public static void ShowListOfRestaurant()
        {
            for(int i=0;i<Restaurants.Count;i++)
            {
                
                Console.WriteLine("\n\tName: "+Restaurants[i].Name);
                Console.WriteLine("\tAdress: " + Restaurants[i].Adress);
                Console.Write("\tOwner: ");
                for (int j=0;j<Restaurants[i].Owner.Count;j++)
                {
                    Console.Write("\n\t   "+Restaurants[i].Owner[j].Name);
                    Console.Write(" (Age: " + Restaurants[i].Owner[j].Age);
                    Console.Write(" Genger: " + Restaurants[i].Owner[j].Sex);
                    Console.Write(" Id: " + Restaurants[i].Owner[j].Id+")");
                }
                Console.WriteLine("\n\tHalls: ");
                for(int j=0; j<Restaurants[i].Halls.Count;j++)
                {
                    Console.WriteLine("\t   Number: " + Restaurants[i].Halls[j].Number);
                    Console.WriteLine("\t   Count of  staff: " + Restaurants[i].Halls[j].Staff.Count);
                    Console.WriteLine("\t   Staf: ");
                    for(int h=0;h<Restaurants[i].Halls[j].Staff.Count;h++)
                    {
                        Console.Write("\t\t   " + Restaurants[i].Halls[j].Staff[h].Name);
                        Console.Write(" (Age: " + Restaurants[i].Halls[j].Staff[h].Age);
                        Console.Write(" Genger: " + Restaurants[i].Halls[j].Staff[h].Sex);
                        Console.Write(" Id: " + Restaurants[i].Halls[j].Staff[h].Id + ")\n");
                    }
                    Console.WriteLine("\t   Count of  Admins: " + Restaurants[i].Halls[j].Administrators.Count);
                    Console.WriteLine("\t   Admins: ");
                    for (int h = 0; h < Restaurants[i].Halls[j].Administrators.Count; h++)
                    {
                        Console.Write("\t\t   " + Restaurants[i].Halls[j].Administrators[h].Name);
                        Console.Write(" (Age: " + Restaurants[i].Halls[j].Administrators[h].Age);
                        Console.Write(" Genger: " + Restaurants[i].Halls[j].Administrators[h].Sex);
                        Console.Write(" Id: " + Restaurants[i].Halls[j].Administrators[h].Id + ")\n");
                    }
                }

                Console.WriteLine("\tKitchen: ");
                Console.WriteLine("\t   Cook:");
                for(int j=0;j<Restaurants[i].Kitchen.Cook.Count;j++)
                {
                    Console.Write("\t\t   " + Restaurants[i].Kitchen.Cook[j].Name);
                    Console.Write(" (Age: " + Restaurants[i].Kitchen.Cook[j].Age);
                    Console.Write(" Genger: " + Restaurants[i].Kitchen.Cook[j].Sex);
                    Console.Write(" Id: " + Restaurants[i].Kitchen.Cook[j].Id + ")\n");
                }

                Console.WriteLine("\tBar: ");
                Console.WriteLine("\t   Barmens: ");
                for (int j=0;j<Restaurants[i].Bar.Barmens.Count;j++)
                {
                    Console.Write("\t\t   " + Restaurants[i].Bar.Barmens[j].Name);
                    Console.Write(" (Age: " + Restaurants[i].Bar.Barmens[j].Age);
                    Console.Write(" Genger: " + Restaurants[i].Bar.Barmens[j].Sex);
                    Console.Write(" Id: " + Restaurants[i].Bar.Barmens[j].Id + ")\n");
                }
                Console.Write("\n\n-------------------------------------------------------------------------" +
                    "-------");
            }
        }

        public static  Restaurant RandRestaurant()
        {
            
            Restaurant buffRestaurant = new Restaurant();
            buffRestaurant.Name = RandStr();
            buffRestaurant.Adress = randId.Next(1,200).ToString() +" "+ RandStr(8);
           
          
            List<Human> Ow = new List<Human>();
            int n = randId.Next(1, 10);//Count of Owner
            for (int i = 0; i < n; i++)
            {
               Human human = new Human();
               
               human = AutoCompleteHuman();
               Ow.Add(human);
               buffRestaurant.Owner = Ow;
            }//LIST of Human Owner

          

            Kitchen kitchen = new Kitchen();
            Random ranCircl_Kitchen = new Random();
            List<Human> Cooker = new List<Human>();

            int k = ranCircl_Kitchen.Next(1, 10);
            for (int i = 0; i < k; i++)
            {
                Human humanK = new Human();
                
                humanK = AutoCompleteHuman();

                Cooker.Add(humanK);
                kitchen.Cook = Cooker;
                buffRestaurant.Kitchen = kitchen;
                

            }  //kitchen

            
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
                rnStaff = randId.Next(1,20);

               
                
                for (int j=0;j< rnStaff;j++)
                {
                    
                    Human StaffHuman = new Human();
                    StaffHuman = AutoCompleteHuman();
                    hallBuff.Staff.Add(StaffHuman);
             
                }

                //count of staff
               
                rnAdmin = randId.Next(1,5);
                for (int j = 0; j < rnAdmin; j++)
                {
                    
                    Human AdminHuman = new Human();
                    AdminHuman = AutoCompleteHuman();
                    hallBuff.Administrators.Add(AdminHuman);

                }
                
                buffRestaurant.Halls.Add(hallBuff);
                
               
            }
            
            buffRestaurant.Bar = AutoCompBar();

            return buffRestaurant;
        }

        public static Bar AutoCompBar()
        {
            Bar bar = new Bar();
            bar.Barmens = new List<Human>();
            int countOfBarmens = randId.Next(1, 5);
            for(int i=0;i<countOfBarmens;i++)
            {
                bar.Barmens.Add(AutoCompleteHuman());
                //Console.WriteLine(bar.Barmens[i].Id);

            }
            return bar;
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
