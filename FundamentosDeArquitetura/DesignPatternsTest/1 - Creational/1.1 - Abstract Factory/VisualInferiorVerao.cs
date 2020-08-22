using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisualInferiorVerao : VisualInferior
    {
        public override void VestirParteDeBaixo()
        {
            Console.WriteLine("Vestir bermuda");
        }
    }
}
