using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest.Structural.Adapter
{
    public static class ExecucaoAdapter
    {
        public static void Executar()
        {
            IMaquinaCostura maquina;

            maquina = new MaquinaAdapter(new Costureira());

            maquina.Costura();
        }

    }
}
