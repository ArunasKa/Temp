namespace Bendras
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 uzduotsis suskaiciuoti rutulio plota, rezultatas i kintamaji
            {
                int spindulys = 6371;
                double plotas = 4 * 3.1415926535898 * Math.Pow(spindulys, 2);
                Console.WriteLine($"rutulio plotas = {plotas}");













            }
            // 2 uzduotis
            {
                int spindulys = 6371;
                double turis = (4/3) * 3.1415926535898 * Math.Pow(spindulys, 3);
                Console.WriteLine($"rutulio plotas = {turis}");
            }
            //-------------------------------------------- 3 UZDUOTIS ------------------------------------------
            double a = 10;
            double b = 15;

            Console.Writeline($"Pirma staciojo trikampio krastine: {a}");
            Console.WriteLine($"Anras staciojo trikampio krastine: {b}");
            double c = Console.WriteLine($"Staciojo trikampio zambine: {a * a + b * b}");

            //--------------------------------------- 4 UZDUOTIS ---------------------------------------------

            double kintSkaicius = 3;

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Viso kintamuju: 3");
            Console.WriteLine($"1 kintamasis: Plotas = {plotas}");
            Console.WriteLine($"2 kintamasis: Turis = {turis}");
            Console.WriteLine($"3 kintamasis: trikampio izambine = {c} ");
            Console.WriteLine($"Kintamuju suma: {plotas + turis + c}");
            Console.WriteLine($"Kintamuju vidurkis: {(plotas + turis + c) / kintSkaicius}");
            Console.WriteLine("*************************************************************************");
        }
    }
}