
public static class Kata
{
    public static int MakeNegative(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else if (number < 0)
        {
            return number;
        }
        return -1 * number;
    }
}