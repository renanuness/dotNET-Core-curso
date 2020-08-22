using DesignPatternsTest.Creational.AbstractFactory;
using DesignPatternsTest.Creational.Singleton;
using DesignPatternsTest.CreationalFactoryMethod;
using DesignPatternsTest.Structural.Adapter;
using System;
using System.Windows;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            while ( true )
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("");
                Console.WriteLine("1: Abstract Factory:");
                Console.WriteLine("2: Factory Method:");
                Console.WriteLine("3: Singleton:");
                Console.WriteLine("------------------------");
                Console.WriteLine("4: Adapter:");
                Console.WriteLine("5: Facade:");
                Console.WriteLine("1: Composite:");
                Console.WriteLine("------------------------");
                Console.WriteLine("7: Command:");
                Console.WriteLine("8: Observer:");
                Console.WriteLine("9: Strategy:");
                var key = Console.ReadKey();

                switch ( key.KeyChar )
                {
                    case '1':
                        ExecucaoAbstractFactory.Executar();
                        break;
                    case '2':
                        ExecucaoFactoryMethod.Executar();
                        break;
                    case '3':
                        ExecucaoSingleton.Executar();
                        break;
                    case '4':
                        ExecucaoAdapter.Executar();
                        break;
                    case '\u001b':
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
