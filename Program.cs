using System;

namespace memeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
           string memeToNervoso;

           //<---inicio(digite)--->//
           Console.WriteLine("usuario, o que voce pensa sobre mim?");
           memeToNervoso = Console.ReadLine();
           Console.Write( "\n" );
           //---fim(digite)--->//

           //<---inicio(memeToNervoso)--->//
           Console.WriteLine(" -e sabe o que eu penso de voce?");
           Console.WriteLine($"{memeToNervoso.Remove(10)} ... não, pera .\nTo nervoso");
           //<---fim(memeToNervoso)--->//

           //<---inicio(sair)--->//
           Console.WriteLine("pressione enter para finalizar");
           Console.ReadKey();
           //<---fim(sair)--->//
        }  
    }
}
