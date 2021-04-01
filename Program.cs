using System;

namespace Repetition{
    class Program{
        static void Main(string[] args){
            
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();

            int counter = 0;

            while( counter < 10){
                int counter2 = counter;

                while (counter2 < 5){
                    Console.WriteLine(name);
                    counter2++;
                    Console.WriteLine(counter2);
                }
                counter++;
            }
            Console.WriteLine("Goodbye " + name);
            
        }
    }
}
