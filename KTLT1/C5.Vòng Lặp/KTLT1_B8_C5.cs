using System;
namespace Bangcuuchuong
{
    public class Program
    {
        static void Main(string[]args)
        {
            for(int i = 2 ; i <= 10 ; i++)
            {
                for(int j = 1; j <= 10 ; j ++)
                {
                    int sum = i * j;
                    Console.WriteLine("{0} x {1} = {2}",i,j,sum);
                }
                Console.WriteLine("");
            }
        }  
    }
}