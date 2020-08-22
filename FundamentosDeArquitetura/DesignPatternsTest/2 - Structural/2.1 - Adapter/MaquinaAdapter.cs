using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Structural.Adapter
{
    public class MaquinaAdapter : IMaquinaCostura
    {
        ICostureira _costureira;

        public MaquinaAdapter(ICostureira costureira)
        {
            _costureira = costureira;
        }
        public void Costura()
        {
            _costureira.CosturaMao();
        }
    }
}
