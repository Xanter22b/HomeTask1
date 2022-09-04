namespace HomeTask1
{
    internal class Program
    {
       
        public static void GoodDay()
        {
            Console.WriteLine("Have a nice day!");
            Console.WriteLine("The winter is coming");
        }

        public static void Greeting (string name)
        {
            Console.WriteLine($"Greetings, {name}!");
            GoodDay();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name");
            string fullName = Console.ReadLine();
            
            Greeting(fullName);
        }
    }
}