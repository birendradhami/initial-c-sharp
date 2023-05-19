using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
     internal class Program
    {
        static void Main()
        {
            // Hello World 
            /*Console.WriteLine("Birendra Dhami");
            Console.ReadLine();*/

            //User input
            /*Console.WriteLine("Enter Your name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);*/


            //jarray 2D
            /*string[][,] name = new string[2][,] {
                new string[,] {{ "Ram" , "Hari"} , { "Me", "You" } },
                new string[,] {{ "Sita" , "Gita"} , {"Me" , "You"} }
            };

            for(int i=0; i< name.Length;  i++)
            {
                for(int j=0; j< name[i].GetLength(0); j++)
                    {
                    for(int k=i; k< name[i].GetLength(1); k++)
                    {
                        Console.WriteLine(name[i][j,k]);
                    }
                }
            }*/


            //Creating object
            /*  Console.WriteLine("Enter Name of the Shop:");

              Shop s1 = new Shop();
              s1.name = Console.ReadLine();
              Console.WriteLine(s1.name);*/


            //Accessing fields and methods
            /* Console.WriteLine("Enter Name of the Shop:");

             Shop s1 = new Shop();
             s1.getName();
             s1.printName();*/

            //Constructor 
            //Shop s1 = new Shop();


            //Inheritance
            /* Info i1 = new Info();
             i1.printName();*/

            Console.WriteLine("Enter Shop's name: ");
            Shop s1 = new Shop();
            s1.Name = Console.ReadLine();
            Console.WriteLine(s1.Name);


            Console.ReadLine();



        }
    }
}
