namespace oshte_franklin_i_nedqlko
{
    internal class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var currentNum = 1;

            int sum = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(sum + " ");
                    sum++;
                    if (sum > n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }    }
    }
}