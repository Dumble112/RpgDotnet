using rpg.src.Entties;

namespace dotnet__poo
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight Arus = new Knight(" Arus",23,"Knight");
           Wizard Jenica = new Wizard(" Jenica",33,"White Wizard");
           Ninja Wedge = new Ninja(" Wedge",34,"Ninja");
           Wizard Topapa = new Wizard(" Topapa",28,"Black Wizard");
           Console.WriteLine(Jenica.Attack(4));
           Console.WriteLine(Arus.Attack(4));
           Console.WriteLine(Wedge.Attack(8));
           Console.WriteLine(Topapa.Attack(7));
           
        }
    }
}
