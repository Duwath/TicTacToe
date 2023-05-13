using System;

namespace TicTacToe
{
    class Program
    {
   
        static void Main(string[] args)
        {
            //Possibility to see whos turn it is
            int SpielzugCounter = 1;
            //Identify the Player by Number in the Game
            int Player1Number = 1;
            int Player2Number = 2;
            //Playernames
            string Player1 = "";
            string Player2 = "";
            //Playernames inputs
            Console.Write("Player 1 gib deinen Namen ein: ");
            Player1 = PlayerName();
            Console.Write("Player 2 gib deinen Namen ein: ");
            Player2 = PlayerName();
            //Symbol Explanation
            Console.Write("Heißer Scheiß! " + Player1 + " hat das Symbol X " + Player2 + " hat das Symbol O.\n");
            ShowBspfeld();
            Console.Write("Ok. " + Player1 + " beginnt! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");
            
            int[] Spielstand = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

            Game(Spielstand, SpielzugCounter);
            SpielzugCounter=Zaehler(SpielzugCounter);

            Console.Write(SpielzugCounter + "\n");
            for (int i = 0; i < Spielstand.Length; i++)
            {
                Console.WriteLine("Element " + i + ": " + Spielstand[i]);
            };



        }
        private static int Zaehler(int SpielzugCounter)
        {
            SpielzugCounter++;
            return SpielzugCounter;
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
        
        
        private static int[] Game(int[]Spielstand, int SpielzugCounter)
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
                            Game(Spielstand, SpielzugCounter);
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
                            Game(Spielstand, SpielzugCounter);
                        }

                    }                    
                    break;
                case "2":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[1] == 0)
                        {
                            Spielstand[1] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[1] == 0)
                        {
                            Spielstand[1] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "3":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[2] == 0)
                        {
                            Spielstand[2] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[2] == 0)
                        {
                            Spielstand[2] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "4":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[3] == 0)
                        {
                            Spielstand[3] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[3] == 0)
                        {
                            Spielstand[3] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "5":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[4] == 0)
                        {
                            Spielstand[4] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[4] == 0)
                        {
                            Spielstand[4] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "6":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[5] == 0)
                        {
                            Spielstand[5] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[5] == 0)
                        {
                            Spielstand[5] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "7":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[6] == 0)
                        {
                            Spielstand[6] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[6] == 0)
                        {
                            Spielstand[6] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "8":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[7] == 0)
                        {
                            Spielstand[7] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[7] == 0)
                        {
                            Spielstand[7] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;
                case "9":
                    if (SpielzugCounter % 2 == 0)
                    {
                        if (Spielstand[8] == 0)
                        {
                            Spielstand[8] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }
                    }
                    else
                    {
                        if (Spielstand[8] == 0)
                        {
                            Spielstand[8] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand, SpielzugCounter);

                        }

                    }
                    break;

                default:
                    Console.WriteLine("Diese Eingabe entspricht nicht den Zahlen von 1-9. Try again.");
                    Game(Spielstand, SpielzugCounter);
                    break;                    
            }            
            return  Spielstand;            
        }
    }
}

