namespace ModificadiorParams
{
    internal class Calculator
    {
     public static int sum(params int[] number)
        {
            int sum = 0;
            for (int i = 0; i<number.Length; i++)
            {
                sum += number[i];
            }
            return sum;

        }
    }
}