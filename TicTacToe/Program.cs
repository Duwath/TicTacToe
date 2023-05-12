using System;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {
            //Playernames
            string Player1 = "";
            string Player2 = "";
            Console.Write("Player 1 gib deinen Namen ein: ");
            Player1 = PlayerName();
            Console.Write("Player 1 gib deinen Namen ein: ");
            Player2 = PlayerName();
            Console.Write("Heißer Scheiß! "+Player1+ " hat das Symbol X "+ Player2+" hat das Symbol O.\n");
            ShowSpielfeld();
            Console.Write("Ok. " + Player1 + " beginnt! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");

        }
        private static string PlayerName()
                {
            return Console.ReadLine();
        }
        
        private static void ShowSpielfeld()
        {
            string Leerzeile = "------------- ";
            string Zeile1 = "| 1 | 2 | 3 |";
            string Zeile2 = "| 4 | 5 | 6 |";
            string Zeile3 = "| 7 | 8 | 9 |";


            Console.WriteLine(Leerzeile);
            Console.WriteLine(Zeile1);
            Console.WriteLine(Leerzeile);
            Console.WriteLine(Zeile2);
            Console.WriteLine(Leerzeile);
            Console.WriteLine(Zeile3);
            Console.WriteLine(Leerzeile);
        }
    }
}
