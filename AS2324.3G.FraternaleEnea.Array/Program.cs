namespace AS2324._3G.FraternaleEnea.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci quante persone siete");
            int dim=int.Parse(Console.ReadLine());
            double[] peso= new double[dim];
            int[] eta=new int[dim];

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
    }
}