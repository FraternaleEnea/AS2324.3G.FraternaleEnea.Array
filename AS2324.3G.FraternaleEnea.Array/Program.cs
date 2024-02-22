namespace AS2324._3G.FraternaleEnea.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci quante persone siete");
            int dim=int.Parse(Console.ReadLine());
            int scelta;
            double[] pesi= new double[dim];
            int[] eta=new int[dim];
            double media = 0;
            double min = 0;
            double max = 0;
            CaricaVettori(ref pesi, ref eta);
            Statistiche(ref pesi, ref media, ref min, ref max);
            Ordina(ref pesi, ref eta);
            Console.WriteLine("\ninserisce la propria scelta");
            do
            {
                Console.WriteLine("inserire 1 se si vuole vedere il peso minimo,il massimo e la media di tutti i pesi");
                Console.WriteLine("inserire 2 se vuoi ordinare i pesi e l'eta delle persone ");
                Console.WriteLine("inserire 9 se si vuole uscire dal menu");
                scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {

                    case 1:
                        
                        Console.WriteLine($"\nil peso più piccolo è {min}, il più grande è {max} e la media di turri i pesi è {media}");

                        break;

                    case 2:
                        
                        for (int i = 0; i < pesi.Length; i++)
                        {
                            Console.WriteLine($"la persona {i} pesa {pesi[i]} KG");  
                        }
                        Console.WriteLine("\n");
                        for (int i = 0; i < eta.Length; i++)
                        {
                            Console.WriteLine($"la persona {i} ha {eta[i]} anni");
                        }
                        Console.WriteLine("\n");
                        break; 
                }
            } while (scelta != 9);
            Console.WriteLine("arrivederci");

        }
        static void CaricaVettori(ref double[] pesi, ref int[] eta)
        {
            Random random = new Random();
            for(int i = 0; i < eta.Length; i++)
            {
                pesi[i]=random.Next(50,101);
                eta[i] = random.Next(18, 100);
            }
        }
        static void Statistiche(ref double[] pesi, ref double media, ref double min, ref double max)
        {
            min = pesi[0];
            max = pesi[0];
            double somma = 0;
            for(int i = 0; i < pesi.Length; i++)
            {
                if (pesi[i] > max)
                {
                    max = pesi[i];
                }
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
                somma += pesi[i];
            }
            media = somma / pesi.Length;
        }
        static void Ordina(ref double[] pesi, ref int[] eta)
        {
            int tempEta;
            double tempPesi;
            for (int i = 0;i < eta.Length-1; i++)
            {
                for(int j = 0; j < eta.Length-i-1; j++)
                {
                    if (eta[j] > eta[j + 1])
                    {
                        tempEta = eta[j];
                        eta[j] = eta[j + 1];
                        eta[j + 1] = tempEta;
                    }
                    if (eta[j] > eta[j + 1])
                    {
                        tempPesi = pesi[j];
                        pesi[j] = pesi[j + 1];
                        pesi[j + 1] = tempPesi;
                    }
                }
            }
        }
    }
}