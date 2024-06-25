using System;
using herança.Entities;
namespace herança
{ 
    internal class Program
    { 
        static void Main(string[] args)
        {
           BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0); // deve ser igual à ordem das prop nos construtores.
            Console.WriteLine(account.LoanLimit);

            // account.Balance = 200.0; //Erro por ser protected

        } 
    } 
} 