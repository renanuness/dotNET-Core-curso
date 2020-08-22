using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisualVeraoFactory : VisualFactory
    {
        public VisualInferior CriarVisualInferior()
        {
            return new VisualInferiorVerao();
        }

        public VisualSuperior CriarVisualSuperior()
        {
            return new VisualSuperiorVerao();
        }
    }
}
