using System;
namespace Daonguoc3so{
    class Program
    {
        static void Main(string[]args)
        {
            int num = int.Parse(Console.ReadLine());
            while(num !=0){
                Console.Write(num%10);
                num/=10;
            }
            
        }
    }
}