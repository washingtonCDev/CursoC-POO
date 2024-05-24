using System;
namespace Exer
{
    internal class produto
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public int Numero { get; set; }

        public void AdValor(double ValorAdicional)
        {
            Valor += ValorAdicional;
        }

        public void AdNome(string AdNome)
        {
            Nome += AdNome;
        }

        public int? AdNumero(int AdicionalNumero)
        {
            if (AdicionalNumero == 84123)
            {
                Numero = AdicionalNumero;
                return Numero;
            }
            else
            {
                return null;
            }
        }
        public string ObterNomePeloNumero(int numero)
        {
            if (numero == Numero)
            {
                return Nome;
            }
            else
            {
                return null;
            }
        }
    }
}