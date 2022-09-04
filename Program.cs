namespace HomeTask1
{
    internal class Program
    {
       
        public static void Greeting (string name)
        {
            Console.WriteLine($"Greetings, {name}!");
        }
        
        static void Main(string[] args)
        {
            Greeting("Vasia");
        }
    }
}