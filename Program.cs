using System;

namespace Repetition{
    class Program{
        static void Main(string[] args){
            

            Console.WriteLine("How many times would you like this to repeat?");
            //int repeat = int.Parse(Console.ReadLine());

            string num = Console.ReadLine();
            int repeat = int.Parse(num);

            int count = 0;
            
            Console.WriteLine("Printing your name " + repeat + " times");

            while(repeat > count){
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
                Console.WriteLine(name);
                count++;
            }
            Console.WriteLine("Goodbye ");
        }
    }
}
