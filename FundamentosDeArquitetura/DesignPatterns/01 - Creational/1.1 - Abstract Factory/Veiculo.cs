using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Veiculo
    {
        public Veiculo(string Modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }

    public enum Porte
    {
        Pequeno,
        Medio,
        Grande
    };

    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string Modelo, Porte porte) : base(Modelo, porte)
        {
        }
    }

    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string Modelo, Porte porte) : base(Modelo, porte)
        {
        }
    }

    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string Modelo, Porte porte) : base(Modelo, porte)
        {
        }
    }

    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch ( porte )
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo, porte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, porte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, porte);
                default:
                    throw new ApplicationException("Porte de veiculo desconhecido");
            }
        }
    }
}
