namespace Bendras
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 15;
            
            Console.Writeline($"Pirma staciojo trikampio krastine: {a}");
            Console.WriteLine($"Anras staciojo trikampio krastine: {b}");
            double c = Console.WriteLine($"Staciojo trikampio zambine: {a * a + b * b}");

        }
    }
}