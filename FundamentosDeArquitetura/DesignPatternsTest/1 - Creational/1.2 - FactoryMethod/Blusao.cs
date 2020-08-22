using DesignPatternsTest.Creational.FactoryMethod;

namespace DesignPatternsTest.CreationalFactoryMethod
{
    public class Blusao : PecaDeRoupa
    {
        public Blusao() : base()
        {
            Nome = "Blusao";
        }

        public override void ProduzirPeca()
        {
            _partesDaRoupa.Add(new MangaComprida());
            _partesDaRoupa.Add(new MangaComprida());
            _partesDaRoupa.Add(new TroncoDeLam());
        }
    }
}