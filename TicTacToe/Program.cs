namespace TicTacToe
{
    class Program
    {


        // Create the playfield
        static char[,] playField =
        {

                {'1','2','3'}, // Row 0
                {'4','5','6'}, // Row 1 
                {'7','8','9'} // Row 2
        };


        static int turns = 0;


        public static void Main(string[] args)
        {

            int player = 2; // player 1
            int input = 0;
            bool inputCorrect = true;

            do
            {

                if (player == 2)
                {
                    player = 1;
                    enterXorO(player, input);
                } else if (player == 1)
                {
                    player = 2;
                    enterXorO(player, input);
                }
                SetField();

                #region
                //Check winning player
                char[] playerChars = { 'X', 'O' };
                foreach(char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) 
                       || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                       || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                       || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                       || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                       || ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                       || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                       || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                       || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                       || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))

                        )
                    {
                        if(playerChar == 'X'){

                            Console.WriteLine("Player 2 has won!");

                        } else
                        {
                            Console.WriteLine("Player 1 has won !");
                        }

                        Console.WriteLine("Please press any key to reset the game !");
                        Console.ReadKey();
                        // Reset field
                        ResetField();
                        
                        break;
                    }                 
                    else if(turns == 10)
                    {
                        Console.WriteLine("DRAW !!!");
                        Console.WriteLine("Please press any key to reset the game !");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                #endregion

                #region
                // Test if field is already taken
                do
                {
                    Console.WriteLine("Player {0}: Choose your field !", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number:");

                    }
                    if(input == 1 && (playField[0,0] == '1'))
                    {
                        inputCorrect = true;
                    } 
                    else if ((input == 2) && (playField[0,1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    } else
                    {
                        Console.WriteLine("Incorrect Input ! Please try again");
                        inputCorrect = false;
                    }


                } while (!inputCorrect);
                #endregion
            }
            while (true);
        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
{

                {'1','2','3'}, // Row 0
                {'4','5','6'}, // Row  
                {'7','8','9'} // Row 2
        };

            playField = playFieldInitial;
            SetField();
            turns = 0;

        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("       |        |       ");
            // To do replace numbers with variables
            Console.WriteLine(" {0}     |  {1}     |     {2}", playField[0, 0], playField[0, 1], playField[0,2]);
            Console.WriteLine("_______|________|_________");
            Console.WriteLine("       |        |       ");
            Console.WriteLine("       |        |       ");
            // To do replace numbers with variables
            Console.WriteLine(" {0}     |  {1}     |     {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_______|________|_________");
            Console.WriteLine("       |        |       ");
            // To do replace numbers with variables
            Console.WriteLine(" {0}     |  {1}     |     {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("       |        |       ");
            turns++;

        }

        public static void enterXorO(int player, int input)
        {
            char playerSign = ' ';
            if(player == 1)
            {
                playerSign = 'X';
            } else if (player == 2) {
                playerSign = 'O';
            }


            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }

        }
    }
}