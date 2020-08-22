using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Structural.Adapter
{
    public class Costureira : ICostureira
    {
        public void CosturaMao()
        {
            Console.WriteLine("Costura a mao");
        }
    }
}
