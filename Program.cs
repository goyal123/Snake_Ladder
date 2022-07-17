namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player_pos = 0,dice_num;
            Console.WriteLine("Welcome to Snake Ladder Game!");
            Random rand=new Random();
            dice_num=rand.Next(1, 6);
            Console.WriteLine(dice_num);


        }
    }
}