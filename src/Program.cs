using System;

namespace tic_tac_toe_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Game();
            Console.ReadKey();
        }
    }
}
