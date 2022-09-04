namespace HomeTask1
{
    internal class Program
    {
       
        public static void GoodDay()
        {
            Console.WriteLine("Have a nice day!");
        }

        public static void Greeting (string name)
        {
            Console.WriteLine($"Greetings, {name}!");
            GoodDay();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            
            Greeting(name);
        }
    }
}