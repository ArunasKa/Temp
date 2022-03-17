namespace Bendras
{
    class Program
    {
        static void Main(string[] args)
        {//-------------------------------------------- 3 UZDUOTIS ------------------------------------------
            double a = 10;
            double b = 15;
            
            Console.Writeline($"Pirma staciojo trikampio krastine: {a}");
            Console.WriteLine($"Anras staciojo trikampio krastine: {b}");
            double c = Console.WriteLine($"Staciojo trikampio zambine: {a * a + b * b}");

            //--------------------------------------- 4 UZDUOTIS ---------------------------------------------

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Viso kintamuju: 3");
            Console.WriteLine("1 kintamasis: ");
            Console.WriteLine("2 kintamasis: ");
            Console.WriteLine("3 kintamasis: ");
            Console.WriteLine($"Kintamuju suma: {kint1 + kint2 + kint3}");
            Console.WriteLine($"Kintamuju vidurkis: {(kint1 + kint2 + kint3) / kintSkaicius}" );
            Console.WriteLine("*************************************************************************");
        }
    }
}