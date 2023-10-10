using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();

            Console.WriteLine($"\nProduct name: {productName}\nProduct price: {price}");
        }
    }
}