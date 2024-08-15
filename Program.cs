namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelUgh ugh = new DelUgh(Delolo.GetUgh);
            var result = ugh(210, 2);
            Console.WriteLine(result.ToString());

            DelYaaa yaaa = new DelYaaa(Delolo.GetYaaa);
            var result1 = yaaa(210, 210 );
            Console.WriteLine(result.ToString());

            DelTho tho = new DelTho(Delolo.GetTho);
            var result2 = tho(450, 30);
            Console.WriteLine(result.ToString());
        }
    }

    public delegate int DelUgh(int wadapuk, int wadahil);
    public delegate int DelYaaa(int hihihi, int hahaha);
    public delegate int DelTho(int x, int y);
    class Delolo
    {
        public static int GetUgh(int wadapuk, int wadahil)
        {
            return wadapuk * wadahil;
        }
        public static int GetYaaa(int hihihi, int hahaha)
        {
            return hihihi + hahaha;
        }
        public static int GetTho(int x, int y)
        {
            return x - y;
        }
    }
}
