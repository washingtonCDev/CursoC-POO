namespace RefEOut
{
    internal class Calculato
    {
        public static void Triple(ref int x)
        {
           x = x * 3;
        }
        public static void Triple1(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}