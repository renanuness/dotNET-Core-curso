using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisualInvernoFactory : VisualFactory
    {
        public VisualInferior CriarVisualInferior()
        {
            return new VisualInferiorInverno();
        }

        public VisualSuperior CriarVisualSuperior()
        {
            return new VisualSuperiorInverno();
        }
    }
}
