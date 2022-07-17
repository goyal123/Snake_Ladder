namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player_pos = 0,dice_num,options,sum=0;
            Console.WriteLine("Welcome to Snake Ladder Game!");
            Random rand=new Random();
                    
            while (player_pos != 100)
            {
                dice_num = rand.Next(1, 6);
                Console.WriteLine("Number on dice = " + dice_num);
                options = rand.Next(0, 3);
                Console.WriteLine("Choosing option " + options);
                switch (options)
                {
                    case 0:
                        player_pos = sum; ;
                        Console.WriteLine("Player position = " + player_pos);
                        break;

                    case 1:
                        if ((sum + dice_num) > 100)
                            sum = player_pos;

                        if ((sum + dice_num) < 100)
                        {
                            sum = sum + dice_num;
                            player_pos = sum;
                        }
                        Console.WriteLine("Player position = " + player_pos);
                        break;

                    case 2:
                        if ((sum - dice_num) < 0)
                        {
                            sum = 0;
                            player_pos = 0;

                        }
                        else
                        {
                            sum = sum - dice_num;
                            player_pos = sum;
                        }
                        Console.WriteLine("Player position = " + player_pos);
                        break;
                }
            }



        }
    }
}