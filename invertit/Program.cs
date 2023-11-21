using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese una cadena de texto: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string invertirTexto = new string(charArray);

        Console.WriteLine("Cadena invertida: " + invertirTexto);

        Console.ReadLine();


    }
}
