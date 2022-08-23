namespace odevs
{
    internal class Program
    {


        
        static void Main(string[] args)
        {
            //Kolon sayısını kullanıcıdan al.
            Console.WriteLine("Kaç kolon oynamak istersiniz?");
            int kolonSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //for döngüsü ile istenen sayıda kolon'u birbirinden farklı, küçükten büyüğe sıralanmış 6 sayı ile dolduracağız.

            for (int i = 0; i < kolonSayi; i++)
            {
                Console.Write($"{i + 1}. Kolon: ");
                int[] kolon = new int[6];
                Random sayi = new Random();
                int j = 0;
                //While ile Random sayıların birbirinden farklı olacak.
                while (j < 6)
                {
                    int random = sayi.Next(1, 50);
                    if (kolon.Contains(random))
                        continue;
                    kolon[j] = random;
                    j++;
                }
                //Alttaki metod ile küçükten büyüğe sıraladık.
                Array.Sort(kolon);
                //foreach ile her bir kolonu ekrana yazdırdık.
                foreach (var item in kolon)
                {
                    Console.Write($"{item}    ");
                }

                Console.WriteLine("\n");
            }


        }
        
    }



}