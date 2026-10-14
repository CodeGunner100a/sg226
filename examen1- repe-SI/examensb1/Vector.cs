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

        //ejercicio 1

        public void ejercicio1(int a, int b)
        {
            int k = a;

            for (int i = a; i <= b; i++)
            {
                if (Buscar_ele_Rango(v[i], a, k - 1) == false)
                {
                    v[k] = v[i];
                    k++;
                }
            }

            int elim = b - k + 1;

            for (int i = b + 1; i <= n; i++)
            {
                v[i - elim] = v[i];
            }

            n = n - elim;
        }

        public bool Buscar_ele_Rango(int ele, int a, int b)
        {
            int i = a;
            bool ban = false;

            while ((i <= b) && (ban == false))
            {
                if (v[i] == ele)
                    ban = true;
                else
                    i++;
            }

            return ban;
        }



        //ejercicio 2 

        public void ejercicio2(int m, ref Vector ve, ref Vector vf)
        {
            ve.n = 0;
            vf.n = 0;

            for (int i = m; i <= n; i = i + m)
            {
                if (ve.Buscar_ele(v[i]) == false)
                    ve.insertar(v[i]);
            }

            ve.Ordenar_Asc_Rango(1, ve.n);

            for (int i = 1; i <= ve.n; i++)
            {
                int c = 0;

                for (int j = m; j <= n; j = j + m)
                {
                    if (v[j] == ve.v[i])
                        c++;
                }

                vf.insertar(c);
            }
        }

        public void Ordenar_Asc_Rango(int a, int b)
        {
            for (int i = a; i <= b - 1; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    if (v[j] < v[i])
                        intercambiar(i, j);
                }
            }
        }

        public bool Buscar_ele(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                    ban = true;
                else
                    i++;
            }

            return ban;
        }

        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;
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
