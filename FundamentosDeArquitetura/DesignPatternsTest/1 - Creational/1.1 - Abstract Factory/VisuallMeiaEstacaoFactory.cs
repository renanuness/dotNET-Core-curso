namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisuallMeiaEstacaoFactory : VisualFactory
    {
        public VisualInferior CriarVisualInferior()
        {
            return new VisualInferiorInverno();
        }

        public VisualSuperior CriarVisualSuperior()
        {
            return new VisualSuperiorVerao();
        }
    }
}