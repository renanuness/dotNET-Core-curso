using DesignPatternsTest.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.CreationalFactoryMethod
{
    public static class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            PecaDeRoupa pecaDeRoupa = null;

            Console.WriteLine("Escolha a peça de roupa:");
            Console.WriteLine("1 - Camiseta");
            Console.WriteLine("2 - Calça");
            Console.WriteLine("3 - Blusão");
            Console.WriteLine("4 - Bermuda");

            var opcao = Console.ReadKey();

            switch ( opcao.KeyChar )
            {
                case '1':
                    pecaDeRoupa = new Camiseta();
                    break;
                case '2':
                    pecaDeRoupa = new Calca();
                    break;
                case '3':
                    pecaDeRoupa = new Blusao();
                    break;
                case '4':
                    pecaDeRoupa = new Bermuda();
                    break;
            }
            pecaDeRoupa.DescreverPecaDeRoupa();
        }
    }
}
