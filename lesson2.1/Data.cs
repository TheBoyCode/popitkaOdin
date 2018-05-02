using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson2._1
{    
   static class Data
   {
        public static Random randId = new Random();
        public static List<Restaurant> Restaurants { get; set; }
        private static Guid g;
        
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
                Console.WriteLine("\tId: " + Restaurants[i].Id);
                Console.WriteLine("\n\tMenu: ");
                Console.WriteLine("\n\t  Dishes: ");
                for (int j=0;j<Restaurants[i].Menu.Dishes.Count;j++)
                {
                 Console.Write("\t\t"+Restaurants[i].Menu.Dishes[j].Name);
                 Console.Write("\t\tPrice: "+Restaurants[i].Menu.Dishes[j].Price);
                 Console.Write("\t\tWeight: "+Restaurants[i].Menu.Dishes[j].Weight+"\n");
                }
                Console.WriteLine("\n\t  Drinks: ");
                for (int j = 0; j < Restaurants[i].Menu.Drinks.Count; j++)
                {
                    Console.Write("\t\t"+Restaurants[i].Menu.Drinks[j].Name);
                    Console.Write("\t\tPrice: " + Restaurants[i].Menu.Drinks[j].Price);
                    Console.Write("\t\tVolume: " + Restaurants[i].Menu.Drinks[j].Volume+"\n");
                }
                Console.Write("\tOwner: ");
                for (int j=0;j<Restaurants[i].Owners.Count;j++)
                {
                    Console.Write("\n\t   "+Restaurants[i].Owners[j].Name);
                    Console.Write(" (Age: " + Restaurants[i].Owners[j].Age);
                    Console.Write(" Genger: " + Restaurants[i].Owners[j].Sex);
                    Console.Write(" Count of property: " + Restaurants[i].Owners[j].CountOfProperty);
                    Console.Write(" Id: " + Restaurants[i].Owners[j].Id+")");
                }
                Console.WriteLine("\n\tHalls: ");
                for(int j=0; j<Restaurants[i].Halls.Count;j++)
                {
                    Console.WriteLine("\t   Number: " + Restaurants[i].Halls[j].Number);
                    Console.WriteLine("\t   Count of  staff: " + Restaurants[i].Halls[j].Staffs.Count);
                    Console.WriteLine("\t   Staf: ");
                    for(int h=0;h<Restaurants[i].Halls[j].Staffs.Count;h++)
                    {
                        Console.Write("\t\t   " + Restaurants[i].Halls[j].Staffs[h].Name);
                        Console.Write(" (Age: " + Restaurants[i].Halls[j].Staffs[h].Age);
                        Console.Write(" Salary: " + Restaurants[i].Halls[j].Staffs[h].Salary);
                        Console.Write(" Genger: " + Restaurants[i].Halls[j].Staffs[h].Sex);
                        Console.Write(" Id: " + Restaurants[i].Halls[j].Staffs[h].Id + ")\n");
                    }
                    Console.WriteLine("\t   Count of  waiters: " + Restaurants[i].Halls[j].Waiters.Count);
                    Console.WriteLine("\t   Waiters: ");
                    for (int h = 0; h < Restaurants[i].Halls[j].Waiters.Count; h++)
                    {
                        Console.Write("\t\t   " + Restaurants[i].Halls[j].Waiters[h].Name);
                        Console.Write(" (Age: " + Restaurants[i].Halls[j].Waiters[h].Age);
                        Console.Write(" Genger: " + Restaurants[i].Halls[j].Waiters[h].Sex);
                        Console.Write(" \n\t\t   Speed of express: " + Restaurants[i].Halls[j].Waiters[h].speedOfExpress);
                        Console.Write(" Id: " + Restaurants[i].Halls[j].Waiters[h].Id + ")\n");
                    }
                    Console.WriteLine("\t   Count of  Admins: " + Restaurants[i].Halls[j].Administrators.Count);
                    Console.WriteLine("\t   Admins: ");
                    for (int h = 0; h < Restaurants[i].Halls[j].Administrators.Count; h++)
                    {
                        Console.Write("\t\t   " + Restaurants[i].Halls[j].Administrators[h].Name);
                        Console.Write(" Age: " + Restaurants[i].Halls[j].Administrators[h].Age);
                        Console.Write(" Salary: " + Restaurants[i].Halls[j].Administrators[h].Salary);
                        Console.Write(" Experience: " + Restaurants[i].Halls[j].Administrators[h].Experience);
                        Console.Write(" Genger: " + Restaurants[i].Halls[j].Administrators[h].Sex);
                        Console.Write(" Id: " + Restaurants[i].Halls[j].Administrators[h].Id + ")\n");
                    }
                }

                Console.WriteLine("\tKitchen: ");
                Console.WriteLine("\t   Cookers:");
                for(int j=0;j<Restaurants[i].Kitchen.Cookers.Count;j++)
                {
                    Console.Write("\t\t   " + Restaurants[i].Kitchen.Cookers[j].Name);
                    Console.Write(" (Age: " + Restaurants[i].Kitchen.Cookers[j].Age);
                    Console.Write(" Genger: " + Restaurants[i].Kitchen.Cookers[j].Sex);
                    Console.Write(" \n\t\t   Expperience: " + Restaurants[i].Kitchen.Cookers[j].Experience);
                    Console.Write(" Id: " + Restaurants[i].Kitchen.Cookers[j].Id + ")\n");
                }

                Console.WriteLine("\tBar: ");
                Console.WriteLine("\t   Barmens: ");
                for (int j=0;j<Restaurants[i].Bar.Barmens.Count;j++)
                {
                    Console.Write("\t\t   " + Restaurants[i].Bar.Barmens[j].Name);
                    Console.Write(" (Age: " + Restaurants[i].Bar.Barmens[j].Age);
                    Console.Write(" Genger: " + Restaurants[i].Bar.Barmens[j].Sex);
                    Console.Write(" Knowledge about cocktails: " + Restaurants[i].Bar.Barmens[j].KnowledgeCocktails);
                    Console.Write(" Id: " + Restaurants[i].Bar.Barmens[j].Id + ")\n");
                }
                Console.Write("\n\n-------------------------------------------------------------------------" +
                    "-------");
            }
        }
       
        public static  Restaurant RandRestaurant()
        {
            var buffRestaurant = new Restaurant();
            var owners = new List<Owner>();
            var kitchen = new Kitchen();
            var Cooker = new List<Cooker>();
            var hall = new List<Hall>();
            var staff = new List<Human>();
            var admin = new List<Human>();
            buffRestaurant.Halls = new List<Hall>();
            buffRestaurant.Id = Guid.NewGuid().ToString();
            buffRestaurant.Name = RandStr();
            buffRestaurant.Adress = randId.Next(1,200).ToString() +" "+ RandStr();

            var Dishes = new List<Dish>();
            var Drinks = new List<Drink>();
            Menu menu = new Menu();
            for (int i=0;i<randId.Next(1,20);i++)
            {
                Dish dish = new Dish();
                dish.Id = Guid.NewGuid().ToString();
                dish.Name = RandStr();
                dish.Price = randId.Next(1, 200);
                dish.Weight = randId.Next(50, 500);
                Dishes.Add(dish);
            }
            menu.Dishes = Dishes;

            ////////////////////////Dishes//////////////////////
            for (int i = 0; i < randId.Next(1, 20); i++)
            {
                Drink drink = new Drink();
                drink.Id = Guid.NewGuid().ToString();
                drink.Name = RandStr();
                drink.Price = randId.Next(1, 200);
                drink.Volume = randId.Next(50, 500);
                Drinks.Add(drink);
            }
            menu.Drinks = Drinks;
            ///////////////////////Drinks//////////////////////
            buffRestaurant.Menu = menu;

            int n = randId.Next(1, 10);//Count of Owner
            for (int i = 0; i < n; i++)
            {
                var owner = new Owner();
                owner.Age = randId.Next(1, 100);
                owner.CountOfProperty = randId.Next(1, 100);
                owner.Id = randId.Next(100000, 1000000).ToString();
                owner.Name = RandStr();
                owner.Sex = (Gender)randId.Next(0, 2);
                owners.Add(owner);
            }
            buffRestaurant.Owners = owners;
            /////////////////////////Owners//////////////////////////
           
            int k = randId.Next(1, 10);
            for (int i = 0; i < k; i++)
            {
                Cooker cooker = new Cooker();
                cooker.Age = randId.Next(1, 100);
                cooker.Experience = randId.Next(1, 50);
                cooker.Id = randId.Next(100000, 1000000).ToString();
                cooker.Name = RandStr();
                cooker.Sex = (Gender)randId.Next(0, 2);
                Cooker.Add(cooker);
            }
            kitchen.Id = Guid.NewGuid().ToString();
            kitchen.Cookers = Cooker;
            buffRestaurant.Kitchen=kitchen;
            ////////////////////////////Kitchen//////////////////////////
           
            int rnStaff;
            int rnAdmin;
            int h = randId.Next(1, 5);
            for (int i = 0; i < h; i++)
            {
                var hallBuff = new Hall();
                hallBuff.Staffs = new List<Staff>();
                hallBuff.Administrators = new List<Admin>();
                hallBuff.Number = i + 1;
                rnStaff = randId.Next(1,20);
                int countOfWaiters = randId.Next(1, 10);
                var waiters = new List<Waiter>();
                for (int j = 0; j < countOfWaiters; j++)
                {
                    Waiter waiter = new Waiter();
                    waiter.Age = randId.Next(1, 100);
                    waiter.Id = randId.Next(100000, 1000000).ToString();
                    waiter.Name = RandStr();
                    waiter.Sex = (Gender)randId.Next(0, 2);
                    waiter.speedOfExpress = randId.Next(1, 100);
                    waiters.Add(waiter);
                }
                hallBuff.Waiters = waiters;
                ////////////////////////Waiters///////////////////////
                for (int j=0;j< rnStaff;j++)
                {
                    Staff Obj_staff = new Staff();
                    Obj_staff.Age = randId.Next(1, 100);
                    Obj_staff.Id = randId.Next(100000, 1000000).ToString();
                    Obj_staff.Name = RandStr();
                    Obj_staff.Sex = (Gender)randId.Next(0, 2);
                    Obj_staff.Salary = randId.Next(1000, 15000);
                    hallBuff.Staffs.Add(Obj_staff);
                }
                rnAdmin = randId.Next(1,5);
                for (int j = 0; j < rnAdmin; j++)
                {
                    Admin Obj_admin = new Admin();
                    Obj_admin.Age = randId.Next(1, 100);
                    Obj_admin.Id = randId.Next(100000, 1000000).ToString();
                    Obj_admin.Name = RandStr();
                    Obj_admin.Sex = (Gender)randId.Next(0, 2);
                    Obj_admin.Salary = randId.Next(1000, 15000);
                    Obj_admin.Experience = randId.Next();
                    hallBuff.Administrators.Add(Obj_admin);
                }
                hallBuff.Id = Guid.NewGuid().ToString();
                buffRestaurant.Halls.Add(hallBuff);
            }
            ///////////////////////////Hall///////////////////////////////////
            buffRestaurant.Bar = AutoCompBar();
            //////////////////////////Bar////////////////////////////////////
            return buffRestaurant;
        }

        public static Bar AutoCompBar()
        {
            int countOfBarmens = randId.Next(1, 5);
            var bar = new Bar();
            bar.Barmens = new List<Barman>();
            

            for (int i = 0; i < countOfBarmens; i++)
            {
                Barman barman = new Barman();
                barman.Sex = (Gender)randId.Next(0, 2);
                barman.Name = RandStr();
                barman.Age = randId.Next(1, 100);
                g = Guid.NewGuid();
                barman.Id = g.ToString();
                barman.KnowledgeCocktails = randId.Next(1, 100);
                bar.Barmens.Add(barman);
            }
            bar.Id = Guid.NewGuid().ToString();
            return bar;
        }
        public static string RandStr()
        {
            return Path.GetRandomFileName();
        }  
        public static Human AutoCompleteHuman()
        {
            Human hum = new Human();
            hum.Sex = (Gender)randId.Next(0, 2);
            hum.Name = RandStr();
            hum.Age = randId.Next(1, 100);
            g= Guid.NewGuid();
            hum.Id = g.ToString();
                
            return hum;
        }
    }
   
}
