using System;
using System.Globalization;
namespace ExerPROP
{
    class Produto /* Classe */
    {
        private string _nome;  /* Membros da classe */
        private double _preco;
        private int _quantidade;

        public Produto() /* Construtor padrão */
        { }

        public Produto(string nome, double preco, int quantidade)/* Construtor de 3 argumentos */
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null & value.Length > 1)
                { _nome = value; }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value != 0 & value > 500)
                { _preco = value; }
            }
        }

        public double value
        {
            get { return _quantidade; }
            set
            {
                if (value != 0 & value > 5)
                { _quantidade = (int)value; }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}