using System;
using System.Globalization;

namespace DesalocMemoria 
{
    internal class produto
    {
        public string Nome { get; private set; }
        public double Preco { get; set; }
        public int Quantia { get; set; }

        public produto(string nome, double preco, int quantia)
        {
            Nome = nome;
            Preco = preco;
            Quantia = quantia;
        }

        public double ValorEstoq()
        {
            return Preco * Quantia;
        }

        public double Vendas1(int quantiaVendas)
        {
            return quantiaVendas * Preco;
        }

        public double Vendas2(int quantiaVendas)
        {
            return quantiaVendas * Preco;
        }
    } 
} 