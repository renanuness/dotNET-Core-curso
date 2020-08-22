using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.FactoryMethod
{
    public class Camiseta : PecaDeRoupa
    {
        public Camiseta() : base()
        {
            Nome = "Camiseta";
        }
        public override void ProduzirPeca()
        {
            _partesDaRoupa.Add(new Manga());
            _partesDaRoupa.Add(new Manga());
            _partesDaRoupa.Add(new Tronco());
        }
    }
}
