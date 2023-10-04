using System;

namespace inluppg3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara j för ja och n för nej");
            char ansG = char.Parse(Console.ReadLine());
            Console.WriteLine("Hur gammal är du?");
            int ansA = int.Parse(Console.ReadLine());

            if (ansG == 'j' && ansA < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu :(");
            }
        }
    }
}