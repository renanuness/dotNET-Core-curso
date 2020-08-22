using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.FactoryMethod
{
    public abstract class PecaDeRoupa
    {
        public List<ParteDaRoupa> _partesDaRoupa = new List<ParteDaRoupa>();
        public string Nome { get; set; }

        public PecaDeRoupa()
        {
            ProduzirPeca();
        }

        public abstract void ProduzirPeca();

        public void DescreverPecaDeRoupa()
        {
            Console.WriteLine($"A roupa {0} contém", Nome);
            foreach ( var parteDeRoupa in _partesDaRoupa )
            {
                Console.WriteLine(parteDeRoupa.Nome);
            }
        }
    }
}
