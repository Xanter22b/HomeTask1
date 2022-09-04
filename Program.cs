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
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            
            Greeting(name);
        }
    }
}