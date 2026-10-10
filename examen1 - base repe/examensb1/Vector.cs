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
            int j = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % m != 0)
                {
                    v[j] = v[i];
                    j++;
                }
            }

            n = j - 1;
        }









        //ejercicio 2 -----------------------------------------------

        public void ejercicio2(int a, int b)
        {
            int k = a;

            for (int i = a; i <= b; i++)
            {
                if (frecuenciaRango(v[i], a, b) > 1)
                {
                    intercambiar(i, k);
                    k++;
                }
            }

            Ordenar_Desc_Rango(a, k - 1);
            Ordenar_Desc_Rango(k, b);
        }

        public int frecuenciaRango(int ele, int a, int b)
        {
            int c = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                    c++;
            }

            return c;
        }
        public void Ordenar_Desc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] > v[i])
                        intercambiar(i, j);
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
    }
}
