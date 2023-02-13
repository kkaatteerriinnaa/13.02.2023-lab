using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        public class Matrix
        {
            public float[,] matrix = null;

            public int CountColumn { get; private set; }
            public int CountRow { get; private set; }

            public Matrix(int x = 1, int y = 1)
            {
                matrix = new float[x, y];

                CountColumn = y;
                CountRow = x;
            }

            public float this[int x, int y]
            {
                get { return matrix[x, y]; }
                set { matrix[x, y] = value; }
            }
            public override string ToString()
            {
                StringBuilder ret = new StringBuilder();
                if (matrix == null) return ret.ToString();

                for (int i = 0; i < CountRow; i++)
                {
                    for (int t = 0; t < CountColumn; t++)
                    {
                        ret.Append(matrix[i, t]);
                        ret.Append("\t");
                    }
                    ret.Append("\n");
                }
                return ret.ToString();
            }
        }
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(2, 2);
            m1.matrix[0, 0] = 1;
            m1.matrix[1, 0] = 1;
            m1.matrix[0, 1] = 1;
            m1.matrix[1, 1] = 1;
            Console.WriteLine("{0}", m1);
            Console.ReadKey(true);
        }
    }

}
