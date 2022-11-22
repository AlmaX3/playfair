using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace playfair
{
    internal class Program
    {
        static char[,] Feltoltes()
        {
            char[,] toSend = new char[5,5];
            int idx = 0;
            StreamReader sr = new StreamReader("kulcstabla.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                char[] lineAsCharArray = line.ToCharArray();
                for (int i = 0; i < toSend.GetLength(0); i++)
                {
                    toSend[idx, i] = lineAsCharArray[i];
                }
                idx++;
            }
            sr.Close();

            return toSend;
        }

        static void Kereses(PlayfairKodolo playfairKodolo)
        {
            Console.Write("6. Feladat: Kérem adjon egy angol ÁBÉCÉ nagy betűjelét: ");
            string Keresni = Console.ReadLine().ToUpper();
            char HelyesKeresett = Keresni[0];

            int sor = playfairKodolo.SorIndex(HelyesKeresett);

            int oszlop = playfairKodolo.OszlopIndex(HelyesKeresett);
            Console.WriteLine($"A keresett érték ({HelyesKeresett}) sor indexe: {sor}");
            Console.WriteLine($"A keresett érték ({HelyesKeresett}) oszlop indexe: {oszlop}");
        }
        static void Main(string[] args)
        {
            char[,] karakterKodolo = Feltoltes();
            PlayfairKodolo playfairKodolo = new PlayfairKodolo(karakterKodolo);
            Kereses(playfairKodolo);
            Console.Write("Kérek egy betűpárt: ");
            string karakterpar = Console.ReadLine();
            string kodol = playfairKodolo.KodolBetupar(karakterpar);
            Console.WriteLine($"Kódolva: {kodol}");
        }
    }
}