namespace HomeTask1
{
    internal class Program
    {
       
        public static void Greeting (string fullName)
        {
            Console.WriteLine($"Greetings, {fullName}!");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name");
            string fullName = Console.ReadLine();
            
            Greeting(fullName);
        }
    }
}