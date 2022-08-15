using System;

namespace PremierLeague
{
    class Program
    {
        static void Main(string[] args)
        {       
            /*
            Club arsenal = new Club("Arsenal", 1980, "kronke", "Arteta", "Emirates");
            Club chelsea = new Club("Chelsea", 1980, "todd", "tuchel", "Bridge"); 
            */           
            
            List <Club> clubList = new List<Club> ();
            
            clubList.Add(new Club("Arsenal", 1980, "kronke", "Arteta", "Emirates"));
            clubList.Add(new Club("Chelsea", 1980, "todd", "tuchel", "Bridge"));

            Console.WriteLine("please enter a club name");
            string inputName = Console.ReadLine();

            Console.WriteLine("please enter the established date");
            int inputDate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter owners name");
            string inputOwner = Console.ReadLine();

            Console.WriteLine("please enter managers name");
            string inputManager = Console.ReadLine();

            Console.WriteLine("please enter home ground");
            string inputGround = Console.ReadLine();

            clubList.Add(new Club(inputName, inputDate, inputOwner, inputManager, inputGround));


            for (int i=0; i<clubList.Count; i++)
            {
                Console.WriteLine("name of club is " + clubList[i].name);
                Console.WriteLine("name of owner is " + clubList[i].owner);

            }
        }
    }
}