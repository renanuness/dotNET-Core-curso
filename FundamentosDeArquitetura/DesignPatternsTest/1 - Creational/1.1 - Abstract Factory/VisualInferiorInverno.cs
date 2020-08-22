using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisualInferiorInverno : VisualInferior
    {
        public override void VestirParteDeBaixo()
        {
            Console.WriteLine("Calças quentes");
        }
    }
}
