namespace Common
{
    public class Helper
    {
        public static void Swap<T>(T[] input, int first, int second)
        {
            T temp = input[first];
            input[first] = input[second];
            input[second] = temp;
        }
    }
}