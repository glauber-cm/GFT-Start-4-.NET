using AbstracaoRPG.Entities;
using System;

namespace AbstracaoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 20);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 35);
            Wizard wizard = new Wizard("Jennica", 42, "White Wizard", 42);
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard", 50);

            Console.WriteLine(wizard.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackWizard.Attack());
            Console.WriteLine(arus.Attack());
        }
    }
}
