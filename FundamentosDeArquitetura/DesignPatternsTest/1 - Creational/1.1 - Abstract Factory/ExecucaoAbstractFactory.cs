using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public static class ExecucaoAbstractFactory
    {

        public static void Executar()
        {
            VisualFactory visualFactory;

            Console.WriteLine("1 - Inverno");
            Console.WriteLine("2 - Verão");
            var key = Console.ReadKey();

            switch ( key.KeyChar )
            {
                case '1':
                    visualFactory = new VisualInvernoFactory();
                    break;
                case '2':
                    visualFactory = new VisualVeraoFactory();
                    break;
                case '3':
                    visualFactory = new VisuallMeiaEstacaoFactory();
                    break;
                default:
                    throw new ApplicationException("Opção inválida.");
            }

            visualFactory.CriarVisualInferior().VestirParteDeBaixo();
            visualFactory.CriarVisualSuperior().VestirParteDeCima();
        }
    }
}
