using System;

namespace Repetition{
    class Program{
        static void Main(string[] args) {
            
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();

            int counter = 0;

            while(counter < 10) {
                int counter2 = counter;
                
                while (counter2 < 5) {
                    Console.Write(name);
                    counter2++;
                }

                Console.WriteLine();
                counter++;
            }
            Console.WriteLine("Goodbye " + name);
            
        }
    }
}
