using System;

class Program
{
    static void Main()
    {
        Console.Write("Espécie: ");
        string especie = Console.ReadLine()!;

        Console.Write("Raça: ");
        string raca = Console.ReadLine()!;

        Console.Write("Nome (alcunha): ");
        string nome = Console.ReadLine()!;

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        Console.Write("Pelagem/Cor: ");
        string cor = Console.ReadLine()!;

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("+=========================================================+");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("+=========================================================+");

        Console.Write("| Espécie: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(especie.ToUpper().PadRight(12));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" | Raça: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(raca.ToUpper().PadRight(15));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" |");

        Console.WriteLine("+=========================================================+");

        Console.Write("| Atende pela alcunha de: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(nome.ToUpper().PadRight(33));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" |");

        Console.Write("| Idade: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(idade.ToString("D2") + " ano(s)".PadRight(9));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" | Pelagem/cor: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(cor.ToUpper().PadRight(20));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" |");

        Console.WriteLine("+=========================================================+");
        Console.ResetColor();
    }
}
