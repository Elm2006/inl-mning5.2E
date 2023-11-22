using System;
namespace inlämning5.__2E
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3] { 1, 2,0 };
            Console.WriteLine("Skriv ett tal");
            tal[2] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                Console.Write(tal[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
