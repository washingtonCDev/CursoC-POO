using System.Globalization;
namespace ExerPROP
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public double Deposito { get; set; }
        public double Saldo { get; private set; }
        public double Saque { get; set; }
        public char Resposta1 { get; set; }
        public char Resposta2 { get; set; }

        public Produto()
        {
        }

        public void AdicionarSaldo(double saldo)
        {
            Deposito += saldo;
        }
        public void SacarSaldo(double saldo)
        {
            Saldo += saldo;
        }

        public double ValorTotal()
        {
            return Deposito - Saque;
        }

        public override string ToString()
        {
            return "Número da conta: " + Numero
            + ", Titular da conta: " + Nome
            + ", Deposito: " + Deposito.ToString("F2", CultureInfo.InvariantCulture)
            + ", Saque: $ " + Saque.ToString("F2", CultureInfo.InvariantCulture)
            + ", Saldo: $ " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}