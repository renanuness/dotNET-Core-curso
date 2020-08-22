using DesignPatternsTest.Creational.FactoryMethod;

namespace DesignPatternsTest.CreationalFactoryMethod
{
    public class Bermuda : PecaDeRoupa
    {
        public Bermuda() : base()
        {
            Nome = "Bermuda";
        }

        public override void ProduzirPeca()
        {
            _partesDaRoupa.Add(new PernaCurta());
            _partesDaRoupa.Add(new PernaCurta());
        }
    }
}