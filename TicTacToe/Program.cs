using System;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {
            
            //Identify the Player by Number in the Game
            int Player1Number = 1;
            int Player2Number = 2;
            //Displays the Development of the Game
            //every Space in this Array displays a Field on the Board
            int[] Spielstand = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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
            ShowBspfeld(Spielstand);
            Console.Write("Ok. " + Player1 + " beginnt! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");


            Game(Spielstand);
            ShowBspfeld(Spielstand);
            Console.Write("Ok. " + Player2 + " ist dran! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");
            Game(Spielstand);
            ShowBspfeld(Spielstand);



            //for (int i = 0; i < Spielstand.Length; i++)
            //{
            //    Console.WriteLine("Element " + i + ": " + Spielstand[i]);
            //};



        }
        

        private static string PlayerName()
        {
            return Console.ReadLine();
        }

        private static void ShowBspfeld(int[]Spielstand)
        {
            string Leerzeile = "------------- ";
            string Zeile1 = "| " + Spielstand[1] + " | " + Spielstand[2] + " | " + Spielstand[3] + " |";
            string Zeile2 = "| " + Spielstand[4] + " | " + Spielstand[5] + " | " + Spielstand[6] + " |";
            string Zeile3 = "| " + Spielstand[7] + " | " + Spielstand[8] + " | " + Spielstand[9] + " |";

            Console.WriteLine(Leerzeile);
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine(Leerzeile);
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine(Leerzeile);
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine(Leerzeile);

            Console.WriteLine(Leerzeile);
            Console.WriteLine(Zeile1);
            Console.WriteLine(Leerzeile);
            Console.WriteLine(Zeile2);
            Console.WriteLine(Leerzeile);
            Console.WriteLine(Zeile3);
            Console.WriteLine(Leerzeile);
        }


        private static int[] Game(int[] Spielstand)
        {
            string Auswahl = "";
            Auswahl = Console.ReadLine();

            switch (Auswahl)
            {
                case "1":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[1] == 0)
                        {
                            Spielstand[1] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );
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
                            Game(Spielstand );
                        }

                    }
                    break;
                case "2":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[2] == 0)
                        {
                            Spielstand[2] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

                        }

                    }
                    break;
                case "3":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[3] == 0)
                        {
                            Spielstand[3] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Console.WriteLine("Dieses Feld ist schon von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

                        }

                    }
                    break;
                case "4":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[4] == 0)
                        {
                            Spielstand[4] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Game(Spielstand );

                        }

                    }
                    break;
                case "5":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[5] == 0)
                        {
                            Spielstand[5] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Game(Spielstand );

                        }

                    }
                    break;
                case "6":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[6] == 0)
                        {
                            Spielstand[6] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Game(Spielstand );

                        }

                    }
                    break;
                case "7":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[7] == 0)
                        {
                            Spielstand[7] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Game(Spielstand );

                        }

                    }
                    break;
                case "8":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[8] == 0)
                        {
                            Spielstand[8] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

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
                            Game(Spielstand );

                        }

                    }
                    break;
                case "9":
                    if (Spielstand[0] % 2 == 0)
                    {
                        if (Spielstand[9] == 0)
                        {
                            Spielstand[9] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

                        }
                    }
                    else
                    {
                        if (Spielstand[9] == 0)
                        {
                            Spielstand[9] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Dieses Feld ist schon von von einem Spieler belegt. Wähle ein anderes.");
                            Game(Spielstand );

                        }

                    }
                    break;

                default:
                    Console.WriteLine("Diese Eingabe entspricht nicht den Zahlen von 1-9. Try again.");
                    Game(Spielstand );
                    break;
            }
            Spielstand[0] = Spielstand[0]+1;
            return Spielstand;
        }
    }
}

