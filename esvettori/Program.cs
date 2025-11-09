
namespace eserciziArray
{
    internal class Program
    {
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

            int[] array7 = { 4, -5, 2, 10, -7 };
            int contan = 0;
            Console.WriteLine("dammi l'inizio dell'intervallo");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dammi la fine dell'intervallo");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; n1 <= n2; i++)
            {
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
                for (int i = n3; n3 <= n4; i++)
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
        }
    }
}