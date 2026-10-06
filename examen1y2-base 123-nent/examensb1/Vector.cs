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


        public void ejercicio1(Vector v2, ref Vector vr)
        {
            vr.n = 0;

         
            for (int i = 1; i <= n; i++)
            {
                if (v2.Buscar_ele(v[i]) == false)
                {
                    if (vr.Buscar_ele(v[i]) == false)
                    {
                        vr.insertar(v[i]);
                    }
                }
            }

           
            for (int i = 1; i <= v2.n; i++)
            {
                if (Buscar_ele(v2.v[i]) == false)
                {
                    if (vr.Buscar_ele(v2.v[i]) == false)
                    {
                        vr.insertar(v2.v[i]);
                    }
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
                {
                    ban = true;
                }
                else
                {
                    i++;
                }
            }

            return ban;
        }

        public void insertar(int ele)
        {
            n = n + 1;
            v[n] = ele;
        }





        //ejercicio 2 


        public void ejercicio2(int a, int b, ref Vector ve, ref Vector vf)
        {
            ve.n = 0;
            vf.n = 0;

            Ordenar_Asc_Rango(a, b);

            for (int i = a; i <= b; i++)
            {
                NEnt num = new NEnt();
                num.Cargar(v[i]);

                if (num.VerifPrimo())
                {
                    if (ve.Buscar_ele(v[i]) == false)
                    {
                        int c = 0;

                        for (int j = a; j <= b; j++)
                        {
                            if (v[j] == v[i])
                                c++;
                        }

                        ve.insertar(v[i]);
                        vf.insertar(c);
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
