namespace _100ekadarOlanAsalSayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i < 100; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    if (count == 2)
                    {
                        break;
                    }
                }            
                if(count==2)
                {
                    count = 0;

                }
                else
                {
                    count = 0;
                    Console.Write(i+" ");
                }
            }
        }
    }
}
