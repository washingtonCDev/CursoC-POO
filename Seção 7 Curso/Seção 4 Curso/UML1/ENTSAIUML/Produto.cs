using System.Globalization;
 
namespace ENTSAIUML 
{ 
    internal class Produto 
    { 
        public string Nome; 
        public double Preco; 
        public int Quantia;

        public double ValorTotalEmEstoque() 
        { 
            return Preco * Quantia; 
        }

        public void AdicionarProduto(int quantidade) 
        { 
            Quantia += quantidade; 
        }

        public void RemoverProduto(int quantidade)
        {
            Quantia -= quantidade;
        }

        public override string ToString() 
        { 
            return Nome 
                + ", $" 
                + Preco.ToString("f2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantia
                + " Unidades, Total: $" 
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture); 
        } 
    } 
} 