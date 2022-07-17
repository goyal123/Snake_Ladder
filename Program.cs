namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1_pos=0,player2_pos = 0,dice_num,options,count=0;
            Console.WriteLine("Welcome to Snake Ladder Game!");
            Random rand=new Random();

            while ((player1_pos != 100) && (player2_pos != 100))
            {
                dice_num = RollDice.Dice_Roll();
                count += 1;
                Console.WriteLine("Number on dice = " + dice_num);
                options = RollDice.Roll_Options();
                Console.WriteLine("Choosing option " + options);

                if (count % 2 == 1)
                {
                    player1_pos = MultiPlayer.Multigame(player1_pos, dice_num, options);
                    Console.WriteLine("Player 1 position = " + player1_pos);
                    if (player1_pos == 100)
                    {
                        Console.WriteLine("\nWinner of Game is Player 1");
                        break;
                    }
                    else
                        continue;

                }
                else
                {
                    player2_pos = MultiPlayer.Multigame(player2_pos, dice_num, options);
                    Console.WriteLine("Player 2 position = " + player2_pos);
                    if (player2_pos == 100)
                    {
                        Console.WriteLine("\nWinner of Game is Player 2");
                        break;
                    }
                    else
                        continue;

                }
                  
            }
                
            

        }
    }
}