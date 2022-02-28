using System;
using poo_rpg.src.entities;

class Program{
    static void Main(string[] args){
        Knight arus = new Knight("Arus", 42, "Knight", 749, 72);
        Wizard jenica = new Wizard("Jenica", 42, "White Wizard", 601, 482);
        Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641);
        Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);

        Console.WriteLine(arus.Attack());
        Console.WriteLine(jenica.Attack(4));
        Console.WriteLine(topapa.Attack());
        Console.WriteLine(wedge.Attack());
    }
}
