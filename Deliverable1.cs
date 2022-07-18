using System;

class Program
{
    public static void Main(string[] args)
    {
        
        bool yes = true;
        bool no = true;
        bool y = true;

        while (yes & y)
        {

            Console.WriteLine("How many people are we making PB & J sandwiches for?");


            int num1 = int.Parse(Console.ReadLine());






            int slices = 2;
            int tablespoons = 2;
            int teaspoons = 4;


            double total = num1 * slices;
            double total1 = num1 * tablespoons;
            double total2 = num1 * teaspoons;

            Console.WriteLine("You need \n");

            Console.WriteLine(total + " slices of bread");
            Console.WriteLine(total1 + " tablespoons of peanut butter");
            Console.WriteLine(total2 + " teaspoons of jelly\n");

            //loaves and jars
            int slicesPerLoaf = 28;
            int totalSlicesNeeded = 2;
            int totalTablespoonsNeeded = 2;
            int tableSpoonsperJar = 32;
            int totalTeaspoonsNeeded = 4;
            int teaSpoonsperJar = 48;

            double totalLoavesNeeded = (num1 * totalSlicesNeeded) / (double)slicesPerLoaf;
            double totalPeanutbNeeded = (num1 * totalTablespoonsNeeded) / (double)tableSpoonsperJar;
            double totalJellyNeeded = (num1 * totalTeaspoonsNeeded) / (double)teaSpoonsperJar;

            Console.WriteLine("Which Is...\n");

            Console.WriteLine(Math.Ceiling(totalLoavesNeeded) + " loaves of bread");
            Console.WriteLine(Math.Ceiling(totalPeanutbNeeded) + " jars of peanut butter");
            Console.WriteLine(Math.Ceiling(totalJellyNeeded) + " jars of jelly\n");

           



            Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit");
            string response = (Console.ReadLine());

           
            
                
            

                if (response == "no")
            {

                Console.WriteLine("Goodbye!");

                break; ;
            }

            
              

            
                else if (response == "yes" || response == "y")
            {
                
            }

            
            {

            }
        }

    }
}

        


    

    



        
        






            


          
        
    
