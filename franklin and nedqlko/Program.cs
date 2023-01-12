namespace franklin_and_nedqlko
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //nedqlko i franklin go napraviha
            int N = int.Parse(Console.ReadLine());
            for (int i=0;i<N;i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}