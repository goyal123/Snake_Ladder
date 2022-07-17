namespace SnakeLadder
{
    public class MultiPlayer
    {
        public static int Multigame(int player_pos,int dice_num,int options)
        {
            int sum=player_pos;
            switch (options)
                {
                    case 0:
                        player_pos = sum;
                        //Console.WriteLine("Player position = " + player_pos);
                        break;

                    case 1:
                        if ((sum + dice_num) > 100)
                            player_pos=sum;

                        if ((sum + dice_num) <= 100)
                        {
                            sum = sum + dice_num;
                            player_pos = sum;
                            Console.WriteLine("Player position = " + player_pos);
                            dice_num = RollDice.Dice_Roll();
                            Console.WriteLine("again roll = " + dice_num);
                            options = RollDice.Roll_Options();
                            Console.WriteLine("again options = " + options);
                            player_pos=MultiPlayer.Multigame(player_pos, dice_num, options);
                         
                        }

                        break;

                    case 2:
                        if ((sum - dice_num) < 0)
                        {
                            //sum = 0;
                            player_pos = 0;

                        }
                        else
                        {
                            sum = sum - dice_num;
                            player_pos = sum;
                        }
                        //Console.WriteLine("Player position = " + player_pos);
                        break;
                }
            return player_pos;

        }
            



        
    }
}