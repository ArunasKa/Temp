﻿namespace Bendras
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
        }
    }
}