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
            bool SpielBeendet = false;
            //Displays the Development of the Game
            //every Space in this Array displays a Field on the Board
            int[] Spielstand = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //Playernames
            Player player1 = new Player( 1, "X");
            Player player2 = new Player( 2, "O");
            //Playernames inputs
            Console.Write("Player 1 gib deinen Namen ein: ");
            player1.SetName();
            Console.Write("Player 2 gib deinen Namen ein: ");
            player2.SetName();
            //Symbol Explanation            
            ShowBspfeld(Spielstand);
            Console.Write("Heißer Scheiß! " + player1.GetName() + " hat das Symbol X " + player2.GetName() + " hat das Symbol O.\n");
            Console.Write("Ok. " + player1.GetName() + " beginnt! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");
            SpielBeendet = false;

            while (!Gewonnen(Spielstand) && !Voll(Spielstand))
            {

                Game(Spielstand);
                ShowBspfeld(Spielstand);
                if (Spielstand[0] % 2 == 0)
                {
                    Console.Write(player2.GetName() + " ist dran! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");

                }
                else
                {
                    Console.Write(player1.GetName() + " ist dran! Wähle eine Zahl um deine Position auf dem Spielfeld zu wählen.\n");
                }



            }
            if (Gewonnen(Spielstand))
            {
                if (Spielstand[0] % 2 == 0)
                {
                    Console.Write(player1.GetName() + " gewinnt im "+(Spielstand[0]-1)+ "ten Zug!\n");

                }
                else
                {
                    Console.Write(player2.GetName() + " gewinnt im "+(Spielstand[0]-1)+ "ten Zug.\n");
                }
            }
            else if (Voll(Spielstand))
            {
                Console.WriteLine("Unentschieden! Alle Felder sind belegt, und es gibt keinen Gewinner.");
            }
        }






        private static bool Gewonnen(int[] Spielstand)
        {

            if (Spielstand[1] == Spielstand[2] && Spielstand[1] == Spielstand[3] && (Spielstand[1] == 1 || Spielstand[1] == 2))
            {
                return true;
            }
            if (Spielstand[4] == Spielstand[5] && Spielstand[4] == Spielstand[6] && (Spielstand[4] == 1 || Spielstand[4] == 2))
            {
                return true;
            }
            if (Spielstand[7] == Spielstand[8] && Spielstand[7] == Spielstand[9] && (Spielstand[7] == 1 || Spielstand[7] == 2))
            {
                return true;
            }
            if (Spielstand[1] == Spielstand[4] && Spielstand[1] == Spielstand[7] && (Spielstand[1] == 1 || Spielstand[1] == 2))
            {
                return true;
            }
            if (Spielstand[2] == Spielstand[5] && Spielstand[2] == Spielstand[8] && (Spielstand[2] == 1 || Spielstand[2] == 2))
            {
                return true;
            }
            if (Spielstand[3] == Spielstand[6] && Spielstand[3] == Spielstand[9] && (Spielstand[3] == 1 || Spielstand[3] == 2))
            {
                return true;
            }
            if (Spielstand[1] == Spielstand[5] && Spielstand[1] == Spielstand[9] && (Spielstand[1] == 1 || Spielstand[1] == 2))
            {
                return true;
            }
            if (Spielstand[3] == Spielstand[5] && Spielstand[3] == Spielstand[7] && (Spielstand[3] == 1 || Spielstand[3] == 2))
            {
                return true;
            }

            return false;

        }
        private static bool Voll(int[] Spielstand)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (Spielstand[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }


        

        private static void ShowBspfeld(int[] Spielstand)
        {

            string Leerzeile1 = " ------------- ";
            string Leerzeile2 = " ----+---+---- ";
            string Zeile1 = " | " + Symbol(Spielstand[1]) + " | " + Symbol(Spielstand[2]) + " | " + Symbol(Spielstand[3]) + " |";
            string Zeile2 = " | " + Symbol(Spielstand[4]) + " | " + Symbol(Spielstand[5]) + " | " + Symbol(Spielstand[6]) + " |";
            string Zeile3 = " | " + Symbol(Spielstand[7]) + " | " + Symbol(Spielstand[8]) + " | " + Symbol(Spielstand[9]) + " |";
            Console.Clear();
            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("###TicTacToe###");
            Console.WriteLine("###############");
            Console.WriteLine("###############");

            Console.WriteLine(Leerzeile1);
            Console.WriteLine(" | 1 | 2 | 3 |");
            Console.WriteLine(Leerzeile2);
            Console.WriteLine(" | 4 | 5 | 6 |");
            Console.WriteLine(Leerzeile2);
            Console.WriteLine(" | 7 | 8 | 9 |");
            Console.WriteLine(Leerzeile1);

            Console.WriteLine(Leerzeile1);
            Console.WriteLine(Zeile1);
            Console.WriteLine(Leerzeile2);
            Console.WriteLine(Zeile2);
            Console.WriteLine(Leerzeile2);
            Console.WriteLine(Zeile3);
            Console.WriteLine(Leerzeile1);
        }
        private static string Symbol(int value)
        {
            switch (value)
            {
                case 1:
                    return "X";
                case 2:
                    return "O";
                default:
                    return " ";
            }
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
                            Game(Spielstand);
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
                            Game(Spielstand);
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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

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
                            Game(Spielstand);

                        }

                    }
                    break;

                default:
                    Console.WriteLine("Diese Eingabe entspricht nicht den Zahlen von 1-9. Try again.");
                    Game(Spielstand);
                    break;
            }
            Spielstand[0] = Spielstand[0] + 1;
            return Spielstand;
        }
    }
}




