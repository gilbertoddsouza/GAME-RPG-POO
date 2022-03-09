using POO_jogo_rpg.src.Enums;
using POO_jogo_rpg.src.Entities;

namespace poo_jogo_rpg_dotnet;

public class Program {
    static void Main(string[] args) {
        var hero =  new Warrior("Arus");
        var hero2 =  new Wizzard("Jenica");
        var hero3 =  new BlackWizzard("Topapa");
        var hero4 =  new Ninja("Wedge");

        Console.WriteLine(hero.ToString());
        Console.WriteLine(hero2.ToString());
        Console.WriteLine(hero3.ToString());
        Console.WriteLine(hero4.ToString());

        Console.WriteLine();

        Console.WriteLine(hero.Attack());
        Console.WriteLine(hero2.Attack());
        Console.WriteLine(hero3.Attack());
        Console.WriteLine(hero4.Attack());

        Console.WriteLine();

        Console.WriteLine(hero2.Attack(7));
        Console.WriteLine(hero2.Attack(1));
        
        Console.WriteLine();

        Console.WriteLine(hero.levelUp());
        Console.WriteLine(hero2.levelUp());
        Console.WriteLine(hero3.levelUp());
        Console.WriteLine(hero4.levelUp()); 
        
        Console.WriteLine();

        Console.WriteLine(hero.ToString());
        Console.WriteLine(hero2.ToString());
        Console.WriteLine(hero3.ToString());
        Console.WriteLine(hero4.ToString());                      

    }
}