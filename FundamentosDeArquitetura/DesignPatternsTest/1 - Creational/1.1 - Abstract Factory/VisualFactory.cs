using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public interface VisualFactory
    {
        VisualSuperior CriarVisualSuperior();
        VisualInferior CriarVisualInferior();
    }
}
