using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playfair
{
    class PlayfairKodolo
    {
        public char[,] karakterMatrix { get; set; } = new char[5, 5];

        public PlayfairKodolo(char[,] _karakterMatrix)
        {
            this.karakterMatrix = _karakterMatrix;
        }

        public void Kiiratas()
        {
            for (int i = 0; i < karakterMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < karakterMatrix.GetLength(1); j++)
                {
                    Console.Write(karakterMatrix[i, j]);
                }
                Console.WriteLine("");
            }

        }

        public int SorIndex(char keresett)
        {
            for (int i = 0; i < karakterMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < karakterMatrix.GetLength(1); j++)
                {
                    if(keresett == karakterMatrix[i, j])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int OszlopIndex(char keresett)
        {
            for (int i = 0; i < karakterMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < karakterMatrix.GetLength(1); j++)
                {
                    if (keresett == karakterMatrix[i, j])
                    {
                        return j;
                    }
                }
            }
            return -1;
        }

        public string KodolBetupar(string bp)
        {
            if (Index(bp[0]).S == Index(bp[1]).S) return
                    $"{karakterMatrix[Index(bp[0]).S, Index(bp[0]).O == 4 ? 0 : Index(bp[0]).O + 1]}" +
                    $"{karakterMatrix[Index(bp[1]).S, Index(bp[1]).O == 4 ? 0 : Index(bp[1]).O + 1]}";
            else if (Index(bp[0]).O == Index(bp[1]).O) return
                    $"{karakterMatrix[Index(bp[0]).S == 4 ? 0 : Index(bp[0]).S + 1, Index(bp[0]).O]}" +
                    $"{karakterMatrix[Index(bp[1]).S == 4 ? 0 : Index(bp[1]).S + 1, Index(bp[1]).O]}";
            else return
                    $"{karakterMatrix[Index(bp[0]).S, Index(bp[1]).O]}" +
                    $"{karakterMatrix[Index(bp[1]).S, Index(bp[0]).O]}";
        }

        public (int S, int O) Index(char c)
        {
            for (int s = 0; s < karakterMatrix.GetLength(0); s++)
                for (int o = 0; o < karakterMatrix.GetLength(1); o++)
                    if (karakterMatrix[s, o] == c) return new(s, o);
            return new(-1, -1);
        }

    }
}
