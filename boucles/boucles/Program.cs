using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * multiples de 2 de 0 à 20 compris
             */
            // boucle for
            Console.WriteLine("multiples de 2 de 0 à 20 compris avec boucle for");
            for (int i = 0; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Environment.NewLine);

            // boucle while
            Console.WriteLine("multiples de 2 de 0 à 20 compris avec boucle while");
            int j = 0;
            while (j <= 20)
            {
                Console.WriteLine(j);
                j += 2;
            }
            Console.WriteLine(Environment.NewLine);

            /**
             * Somme totale d'un nombre
             */
            Console.WriteLine("Somme totale - Saissisez un nombre: ");
            int i_val;
            int i_somme = 0;
            Int32.TryParse(Console.ReadLine(), out i_val);
            for(int i = 1; i <= i_val; i++)
            {
                i_somme += i;
            }
            Console.WriteLine("Somme totale = " + i_somme + Environment.NewLine);

            /**
             * Moyenne de 5 nombres
             */
            Console.WriteLine("Moyenne sur 5 nombres - Saississez 5 nombres");
            List<double> nombres = new List<double>();
            double d_val;
            double d_somme = 0;
            for (int i = 0; i < 5; i++)
            {
                Double.TryParse(Console.ReadLine(), out d_val);
                nombres.Add(d_val);
            }
            nombres.ForEach(val => d_somme += val);
            Console.WriteLine("Moyenne: " + d_somme / nombres.Count + Environment.NewLine);

            /**
             * Somme des entiers entre x et y
             */
            Console.WriteLine("Somme des entiers entre x et y");
            int x;
            Console.WriteLine("Saissisez x");
            Int32.TryParse(Console.ReadLine(), out x);
            int y;
            Console.WriteLine("Saissisez y");
            Int32.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Somme : " + CalculSommeEntiers(x, y) + Environment.NewLine);

            /**
             * Moyenne d'une liste
             */
            List<double> list = new List<double> { 1.0, 5.5, 9.9, 28, 9.6 };
            Console.WriteLine("Moyenne d'une liste : " + string.Join(" ", list));
            Console.WriteLine("Moyenne : " + CalculMoyenne(list) + Environment.NewLine);

            /**
             * Somme multiples communs
             */
            Console.WriteLine("Somme multiples communs");
            Console.WriteLine(CalculSommeCommunes() + Environment.NewLine);

            Console.ReadLine();
        }

        public static int CalculSommeEntiers(int x, int y)
        {
            int somme = 0;
            for (int i = x; i <= y; i++)
            {
                somme += i;
            }
            return somme;
        }

        public static double CalculMoyenne(List<double> list)
        {
            double somme = 0;
            list.ForEach(val => somme += val);
            return somme / list.Count;
        }

        public static int CalculSommeCommunes()
        {
            List<int> multiples3 = new List<int>();
            for (int i = 3; i <= 100; i += 3)
            {
                multiples3.Add(i);
            }

            List<int> multiples5 = new List<int>();
            for (int i = 5; i <= 100; i += 5)
            {
                multiples5.Add(i);
            }

            int somme = 0;
            foreach (int multiple3 in multiples3)
            {
                foreach (int multiple5 in multiples5)
                {
                    if(multiple3 == multiple5)
                    {
                        somme = somme + multiple3 + multiple5;
                    }
                }
            }
            
            return somme;
        }
    }
}
