using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Matrix a = new Matrix(2, 2);
            Matrix b = new Matrix(2, 2);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            //Console.WriteLine(a.Adunare(b).ToString());
            //Console.WriteLine(a.Scadere(b).ToString());
            //Console.WriteLine(a.Inmultire(b).ToString());
            Console.WriteLine(a.Putere(2).ToString());

            Console.WriteLine(a.calculatorDeterminant(a.A));
        }

        class Matrix
        {   
            Random rnd = new Random();
            public int n, m;
            public double[,] A;

            public Matrix(int n = 0, int m = 0) 
            {
                this.n = n;
                this.m = m;
                A = new double[this.n, this.m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        A[i, j] = rnd.Next(10);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++) 
                        sb.AppendFormat("{0,11:0.00}", A[i, j]);
                    sb.Append("\n");
                }
                return sb.ToString();
            }

            public Matrix Adunare(Matrix matrix)
            {
                if (matrix.n == this.n && matrix.m == this.m)
                {
                    Matrix rez = new Matrix(this.n, this.m);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            rez.A[i, j] = A[i, j] + matrix.A[i, j];
                        }
                    }
                    return rez;
                }
                else
                    Console.WriteLine("Matricile nu se pot aduna. Dimensiunile matricelor trebuie sa fie egale!!");
                return null;
            }

            public Matrix Scadere(Matrix matrix)
            {
                if (matrix.n == this.n && matrix.m == this.m)
                {
                    Matrix rez = new Matrix(this.n, this.m);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            rez.A[i, j] = A[i, j] - matrix.A[i, j];
                        }
                    }
                    return rez;
                }
                else
                    Console.WriteLine("Nu se poate efectua operatia de scadere. Dimensiunile matricelor trebuie sa fie egale!!");
                return null;
            }

            public Matrix Inmultire(Matrix matrix)
            {
                if (this.m == matrix.n)
                {
                    Matrix rez = new Matrix(this.n, matrix.m);
                    for (int i = 0; i < this.n; i++)
                    {
                        for (int j = 0; j < matrix.m; j++)
                        {
                            rez.A[i, j] = 0.0;
                            for (int k = 0; k < this.m; k++)
                            {
                                rez.A[i, j] += A[i, k] * matrix.A[k, j];
                            }
                        }
                    }
                    return rez;
                }
                else
                    Console.WriteLine("Matricile nu se pot inmulti. Numarul de linii trebuie sa fie egal cu numarul de coloane!!");
                return null;
            }

            public Matrix Putere(int k)
            {
                Matrix rez = new Matrix(this.n, this.m);
                for(int i = 0; i < this.n; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        if (i == j)
                            rez.A[i, j] = 1;
                        else
                            rez.A[i, j] = 0;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    rez = rez.Inmultire(this);
                }
                return rez;
            }

            public Matrix Inversa(Matrix matrix)
            {
                if(this.n == this.m)
                {

                }
                return null;
            }

            public double calculatorDeterminant(double[,] A)
            {
                double linii = A.GetLength(0);
                double coloane = A.GetLength(1);

                if (linii == 1 && coloane == 1)
                {
                    return A[0, 0];
                }
                else if (linii == 2 && coloane == 2)
                {
                    return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
                }
                else
                {
                    double determinant = 0;
                    for (int i = 0; i < linii; i++)
                    {
                        determinant += A[0, i] * Math.Pow(-1, i) * calculatorDeterminant(taie(A, 0, i));
                    }
                    return determinant;
                }
            }

            static double[,] taie(double[,] A, int linieT, int coloanaT)
            {
                int l = A.GetLength(0);
                int c = A.GetLength(1);

                double[,] submatrice = new double[l - 1, c - 1];

                for (int i = 0, linieSM = 0; i < l; i++)
                {
                    if (i == linieT)
                        continue;
                    for (int j = 0, coloanaSM = 0; j < c; j++)
                    {
                        if (j == coloanaT)
                            continue;
                        submatrice[linieSM, coloanaSM] = A[i, j];
                        coloanaSM++;
                    }
                    linieSM++;
                }
                return submatrice;
            }
        }   
    }
}
