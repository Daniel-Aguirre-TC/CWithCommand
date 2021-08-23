using ConsoleTips.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    static class ConsoleInput
    {
        
        public static ConsoleKeyInfo GetInput()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            ReadAndClear();
            return input;
        }
        public static void ReadAndClear()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.KeyChar == 'e')
            {
                EndApplication();
            }
            else Clear();
        }

        public static void Clear ()
        {
            Console.Clear();
        }

        public static void Display (string str)
        {
            Console.WriteLine(str);
        }
        public static void Display(List<Command> Commands)
        {
            foreach (Command cmd in Commands)
            {
                Console.WriteLine($"{cmd.name} \n- {cmd.desc}\n");
            }
        }
  
        public static void Display(List<Tip> Tips)
        {
            foreach (Tip tip in Tips)
            {
                Console.WriteLine($"{tip.name} \n- {tip.desc}:\n{tip.example}\n");
            }
        }

        public static void DisplayCommandName (string commandName)
        {
            Console.WriteLine($"{commandName} Commands:\n----------------------\n");
        }

        public static void EndApplication()
        {
            Clear();
            Console.WriteLine("Thank you for using this Console Application!\n\nAny/All Feedback Welcome!\n\nCreated by: Daniel Aguirre\n\nPress any key to end.");
            Console.ReadKey();
            Clear();
            Environment.Exit(0);
        }
    }
}
