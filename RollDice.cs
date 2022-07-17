namespace SnakeLadder
{
    public class RollDice
    {
        public static int Dice_Roll()
        {
            int dice_num;
            Random rand = new Random();
            dice_num = rand.Next(1, 6);
            return dice_num;
        }
        public static int Roll_Options()
        {
            int options;
            Random rand = new Random();
            options = rand.Next(0, 3);
            return options;
        }
    }
}