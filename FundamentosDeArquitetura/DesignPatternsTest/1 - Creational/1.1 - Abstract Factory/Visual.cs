using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class Visual
    {
        public VisualSuperior VisualSuperior { get; set; }
        public VisualInferior VisualInferior { get; set; }
    }
}
