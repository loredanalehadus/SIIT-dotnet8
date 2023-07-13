namespace ClassesExplained
{
    public static class Util // cannot instantiated
        // don't store a state
    {
        public static double PI = 3.14;

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void CircleRadius(int r)
        {
            Console.WriteLine(PI * r * r);
        }
    }

}


