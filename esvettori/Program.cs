
namespace eserciziArray
{
    internal class Program
    {
        static int countElement(int n, int[] array11)
        {
            int c = 0;
            for(int i = 0; i < array11.Length; i++)
            {
                if (array11[i] == n)
                {
                    c++;
                }
            }
            Console.WriteLine("il numero " + n + " e all'interno del vettore per " + c + " volte");
            return n;
        }
        static bool contaN(int n, int[] array12)
        {
            int c = 0;
            for (int i = 0; i < array12.Length; i++)
            {
                if (array12[i] == n)
                {
                    c++;
                }
            }
            if(c >= 1)
            {
                return true;
            }
            return false;
        }
        static int findElement(int n, int[] array13)
        {
            int c = 0;
            for (int i = 0; i < array13.Length; i++)
            {
                if (array13[i] == n)
                {
                    c = i;
                    Console.WriteLine("il numero " + n + " si trova nella posizione " + i);
                }
                else
                {
                    c = -1;
                    Console.WriteLine("il numero " + n + " non si trova in questa posizione");
                }
            }

            return c;

        }
        static int[] copyArray(int[] sorgente, int[] destinazione)
        {
            for (int i = 0 ;  i < sorgente.Length; i++)
            {
                destinazione[i] = sorgente[i];
            }
            for (int i = 0; i < destinazione.Length; ++i)
            {
                Console.WriteLine($"[{destinazione[i]}]");
            }
            return destinazione;
        }
        static int copyReverseArray(int[] sorgente2, int[] destinazione2) 
        {
            for (int i = 0; i < sorgente2.Length; i++)
            {
                destinazione2[i] = sorgente2[i];
            }
            for (int i = destinazione2.Length; i >= 0; i--)
            {
                Console.WriteLine($"[{destinazione2[i]}]");
            }
            return destinazione2;
        }
        static void Main(string[] args)
        {

            int[] num = { 1, 2, 3, 4, 5 };

            for (int z = num.Length - 1; z >= 0; z--)
            {
                Console.WriteLine($"[{num[z]}]");

            }
            Console.WriteLine("-----------------------------");
            int[] array = { 1, 2, 3, 4, 5 };


            for (int i = 0; i < array.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine($"[{array[i]}]");
                }
            }

            Console.WriteLine("-----------------------------");

            int[] array2 = { 1, 2, 3, 4, 5 };



            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    Console.WriteLine($"[{array2[i]}]");
                }
            }
            Console.WriteLine("-----------------------------");
            int[] array3 = { 1, 2, 3, 4, 5 };


            int a = 0, p = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 != 0)
                {
                    a++;
                }
                else
                {
                    p++;
                }
            }
            Console.WriteLine("ci sono " + p + " numeri pari");
            Console.WriteLine("ci sono " + a + " numeri dispari");

            Console.WriteLine("-----------------------------");

            int[] array4 = { 1, 2, 3, 4, 5 };


            int max = -10000, min = 10000, somma = 0;
            float media = 0;
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] > max)
                {
                    max = array4[i];
                }
                if (array4[i] < min)
                {
                    min = array4[i];
                }
                somma = array4[i] + somma;
            }
            media = somma / array4.Length;
            Console.WriteLine("il numero piu piccolo e: " + min);
            Console.WriteLine("il numero piu grande e: " + max);
            Console.WriteLine("la media e: " + media);

            Console.WriteLine("-----------------------------");

            int[] array5 = { 1, 2, 3, 4, 5 };
            int x = 0, v1 = 0, v2 = 0, indexv1 = 0, indexv2 = 0;
            Console.WriteLine("Dammi un numero da analizzare");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] < x)
                {

                    v1++;
                }
                if (array5[i] >= x)
                {

                    v2++;
                }

            }
            int[] vet1 = new int[v1];
            int[] vet2 = new int[v2];
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] < x)
                {
                    vet1[indexv1] = array5[i];
                    indexv1++;
                }
                else
                {
                    vet2[indexv2] = array5[i];
                    indexv2++;
                }


            }
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"[{vet1[i]}]");
            }
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < vet2.Length; i++)
            {
                Console.WriteLine($"[{vet2[i]}]");
            }
            Console.WriteLine("-----------------------------");

            int[] vettore1 = { 6, 7, 8, 9, 10 };
            int mass = vettore1[0], minimo = vettore1[0], s = 0, indicemax = 0, indicemin = 0;
            float m = 0;
            for (int i = 0; i < vettore1.Length; i++)
            {
                if (vettore1[i] > mass)
                {
                    mass = vettore1[i];
                    indicemax = i;
                }
                if (vettore1[i] < minimo)
                {
                    minimo = vettore1[i];
                    indicemin = i;
                }
                s = vettore1[i] + s;
            }
            m = s / vettore1.Length;
            Console.WriteLine("il numero piu piccolo e: " + minimo + " e ha indice " + indicemin);
            Console.WriteLine("il numero piu grande e: " + mass + " e ha indice " + indicemax);
            Console.WriteLine("la media e: " + m);
            Console.WriteLine("la somma e: " + s);

            Console.WriteLine("-----------------------------");

            int[] array7 = { 13, 14, 17, 24, 10 };
            int contan = 0;
            Console.WriteLine("dammi l'inizio dell'intervallo");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dammi la fine dell'intervallo");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array7.Length; i++) {
            
            
                if ( array7[i] >= n1 && array7[i] <= n2)
                {
                    Console.WriteLine("il numero " + array7[i] + " e compreso nell'intervallo");
                  
                }
                else
                {
                    Console.WriteLine("il numero " + array7[i] + " non e compreso nell'intervallo");
                    contan++;
                }

            }
            if(contan == 5)
            {
                Console.WriteLine("dammi l'inizio dell'intervallo");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dammi la fine dell'intervallo");
                int n4 = Convert.ToInt32(Console.ReadLine()); 
                for (int i = 0; i < array7.Length; i++)
                { 
                    if (array7[i] >= n3 && array7[i] <= n4)
                    {
                        Console.WriteLine("il numero " + array7[i] + " e compreso nell'intervallo");

                    }
                    else
                    {
                        Console.WriteLine("il numero " + array7[i] + " non e compreso nell'intervallo");
                       
                    }

                }
            }

            Console.WriteLine("-----------------------------");

            int[] vettore = { 2, 3, 5, -8, 79, 108 };
            int[] vet = { 20, 4, 7, 22, 18 };
            int[] v3 = new int[vettore.Length + vet.Length];
            for (int i = 0; i < vettore.Length; i++)
            {
                v3[i] = vettore[i];

            }
            for (int i = vettore.Length; i < v3.Length; i++)
            {
                v3[i] = vet[i - vettore.Length];
            }
            for (int i = 0; i < v3.Length; ++i)
            {
                 Console.WriteLine($"[{ v3[i]}]");
            }

            Console.WriteLine("-----------------------------");

            int[] array11 = { 2, 15, 20, 2, 9 };
            Console.WriteLine("dammi un valore");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(countElement(n, array11));

            Console.WriteLine("-----------------------------");

            int[] array12 = { 2, 15, 20, 2, 9 };
            if(contaN(n, array12) == true)
            {
                Console.WriteLine("il numero " + n + " e contenuto nel vettore");
            }

            Console.WriteLine("-----------------------------");

            int[] array13 = { 2, 15, 20, 2, 9 };
            Console.WriteLine(findElement(n, array13));

            Console.WriteLine("-----------------------------");

            int[] sorgente = { 1, 2, 3, 4, 5 };
            int[] destinazione = new int[sorgente.Length];
            copyArray(sorgente, destinazione);

            Console.WriteLine("-----------------------------");

            int[] sorgente2 = { 1, 2, 3, 4, 5 };
            int[] destinazione2 = new int[sorgente2.Length];
        }
    }
}