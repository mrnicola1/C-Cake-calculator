using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Hvor mange styk kage skal du have?:");
                int Styk = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Du køber nu "+Styk);
                Console.WriteLine("\t\t\t");
                Console.WriteLine("\t\t\t");
                Console.WriteLine("Styk"   +"\t\t\t"     +"Pris");
              
                int pris = 10;
                int i = 0;
                int rebat = 50;
                int rebatpris = 8; 
                
                


                while (i <= Styk)
                {
                   
                    
                    if (Styk>=rebat) {
                        Console.WriteLine(i + "\t\t\t" + i * rebatpris + " Bitcoin");
                        i++;
                    }
                    else {
                        Console.WriteLine(i + "\t\t\t" + i * pris + " Bitcoin");
                        i++;
                    }
                   
                }
                
               
                Console.ReadLine();

            }
        }
    }



}
    

