using DesignPatternsTest.Creational.FactoryMethod;

namespace DesignPatternsTest.CreationalFactoryMethod
{
    public class Calca : PecaDeRoupa
    {
        public Calca() : base()
        {
            Nome = "Calca";
        }
        public override void ProduzirPeca()
        {
            _partesDaRoupa.Add(new PernaComprida());
            _partesDaRoupa.Add(new PernaComprida());
        }
    }
}