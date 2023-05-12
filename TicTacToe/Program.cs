using System;

namespace TicTacToe
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int SpielzugCounter = 1;
            //Playernames
            string Player1 = "";
            string Player2 = "";
            Console.Write("Player 1 gib deinen Namen ein: ");
            Player1 = PlayerName();
            Console.Write("Player 2 gib deinen Namen ein: ");
            Player2 = PlayerName();
            Console.Write("Heißer Scheiß! " + Player1 + " hat das Symbol X " + Player2 + " hat das Symbol O.\n");
            ShowBspfeld();
            Console.Write("Ok. " + Player1 + " beginnt! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");
            int Player1Number = 1;
            int Player2Number = 2;
            int[] Spielstand = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

            SpielzugCounter = Game(Spielstand, SpielzugCounter, Player1, Player2);

            Console.Write(SpielzugCounter);



        }

        private static string PlayerName()
        {
            return Console.ReadLine();
        }

        private static void ShowBspfeld()
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
        private int Zaehler(int SpielzugCounter)
        {
            SpielzugCounter++;
            return SpielzugCounter;
        }
        private static int Game(int[]Spielstand, int SpielzugCounter, string Player1, string Player2)
        {
            string Auswahl = "";
            Auswahl = Console.ReadLine();         
            


            switch (Auswahl)
            {
                case "1":
                    if (SpielzugCounter  % 2 == 0)
                    {
                        if (Spielstand[0] == 0)
                        {
                            Spielstand[0] = 2;                            
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);
                        }
                    }
                    else
                    {
                        if (Spielstand[0] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);
                        }

                    }                    
                    break;
                case "2":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[1] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[1] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "3":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[2] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[2] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "4":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[3] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[3] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "5":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[4] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[4] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "6":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[5] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[5] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "7":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[6] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[6] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "8":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[7] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[7] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;
                case "9":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[8] == 0)
                        {
                            Spielstand[0] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }
                    }
                    else
                    {
                        if (Spielstand[8] == 0)
                        {
                            Spielstand[0] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter, Player1, Player2);

                        }

                    }
                    break;

                default:
                    Console.WriteLine("Diese Eingabe entspricht nicht den Zahlen von 1-9. Try again.");
                    Game(Spielstand, SpielzugCounter, Player1, Player2);
                    break;                    
            }

            SpielzugCounter++;
            return SpielzugCounter;
        }
    }
}

