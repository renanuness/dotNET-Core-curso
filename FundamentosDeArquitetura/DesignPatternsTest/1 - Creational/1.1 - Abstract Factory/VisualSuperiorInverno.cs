using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Creational.AbstractFactory
{
    public class VisualSuperiorInverno : VisualSuperior
    {
        public override void VestirParteDeCima()
        {
            Console.WriteLine("Vestir blusa de lã e manta");
        }
    }
}
