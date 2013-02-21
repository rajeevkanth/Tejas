using System;
using ServiceProvider.Implementation;
using Tejas.Domain.DomainModel;

namespace TejasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var provider = new TejasProvider();
                var product = new Product {Cost = 100, Name = "Tejas"};
                provider.AddProduct(product);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
