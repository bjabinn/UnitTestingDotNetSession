using System;
using Microsoft.Extensions.DependencyInjection;

namespace xUnitSession
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection().AddScoped<IOperation, Operation>().BuildServiceProvider();
            var operacion = serviceProvider.GetService<IOperation>();            
            Console.WriteLine(operacion.Add(2, 2));
            Console.ReadKey();
        }
    }
}
