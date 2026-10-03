using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace examensb1
{
    class Vector
    {

        const int MAX = 50;
        private int[] v;
        private int n;



        public Vector()
        {
            n = 0;
            v = new int[MAX];

        }


        public void CargarRnd(int n1, int a, int b)
        {

            Random r = new Random();

            n = n1;

            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }





        public string Descargar()
        {
            string s = "";

            for (int i = 1; i <= n; i++)
            {

                s = s + v[i] + "  |  ";
            }

            return s;
        }

        //examen

        //ejercicio 1 -----------------------------------------------

        public void ejercicio1(int m)
        {
            for (int i = m; i <= n; i = i + m)
            {
                for (int j = i + m; j <= n; j = j + m)
                {
                    if (v[j] < v[i])
                    {
                        intercambiar(i, j);
                    }
                }
            }
        }

        public void intercambiar(int pos1, int pos2)
        {
            int aux;

            aux = v[pos1];
            v[pos1] = v[pos2];
            v[pos2] = aux;
        }






        //ejercicio 2 -----------------------------------------------
        public void ejercicio2(int a, int b)
        {
            int p = a;

            for (int i = a; i <= b; i++)
            {
                NEnt num = new NEnt();
                num.Cargar(v[i]);

                if (num.VerifPrimo())
                {
                    intercambiar(i, p);
                    p++;
                }
            }

            Ordenar_Asc_Rango(a, p - 1);
            Ordenar_Asc_Rango(p, b);

            int ip = a;
            int inp = p;

            while ((ip < p) && (inp <= b))
            {
                int aux = v[inp];

                for (int j = inp; j > ip + 1; j--)
                {
                    v[j] = v[j - 1];
                }

                v[ip + 1] = aux;

                ip = ip + 2;
                inp++;
            }
        }

        public void Ordenar_Asc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] < v[i])
                    {
                        intercambiar(i, j);
                    }
                }
            }
        }





    }
}
