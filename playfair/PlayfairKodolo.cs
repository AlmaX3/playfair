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

        public string KodolBetupar(string Betupar)
        {
            int betuSor1 = SorIndex(Betupar[0]);
            int betuOszlo1 = OszlopIndex(Betupar[0]);
            int betuSor2 = SorIndex(Betupar[1]);
            int betuOszlo2 = OszlopIndex(Betupar[1]);
            
            if(betuOszlo1 + 1 >= 5 && betuSor1 == betuSor2)
            {
                betuOszlo1 = 0;
                betuOszlo2++;

                return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
            }

            if (betuOszlo2 + 1 >= 5 && betuSor1 == betuSor2)
            {
                betuOszlo2 = 0;
                betuOszlo1++;

                return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
            }

            if(betuOszlo1+1 == betuOszlo2 && betuSor1 == betuSor2)
            {
                betuOszlo1++;
                betuOszlo2++;
                return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
            }

            if (betuSor1 + 1 >= 5)
            {
                betuSor1 = 0;
                betuSor2++;

                return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
            }

            if (betuSor2 + 1 >= 5)
            {
                betuSor2 = 0;
                betuSor1++;

                return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
            }

            if (betuOszlo1 == betuOszlo2 && betuSor1+1 == betuSor2)
            {
                betuSor1++;
                betuSor2++;
                return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
            }

            if(betuOszlo1 != betuOszlo2 && betuSor1 != betuSor2)
            {
                return $"{karakterMatrix[betuSor1, karakterMatrix.GetLength(1) - (betuOszlo1 + 1)]}{karakterMatrix[betuSor2, karakterMatrix.GetLength(1) - (betuOszlo2 + 1)]}";
            }

            return $"{karakterMatrix[betuSor1, betuOszlo1]}{karakterMatrix[betuSor2, betuOszlo2]}";
        }
    }
}
