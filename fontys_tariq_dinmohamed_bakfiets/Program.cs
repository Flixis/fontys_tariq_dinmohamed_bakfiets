namespace fontys_tariq_dinmohamed_bakfiets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            String some = Deeznuts.hello("Nuteh");
            Console.WriteLine(some);
        }
    }

    internal class Deeznuts
    {
        public static String hello(string deez)
        {
            return deez;
        }
    }
}
