using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisualSuperiorVerao : VisualSuperior
    {
        public override void VestirParteDeCima()
        {
            Console.WriteLine("Vestir camiseta");
        }
    }
}
