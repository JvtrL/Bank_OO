using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoJoaoV = new ContaCorrente("Joao V", 1234, 789, 100.50);

            ContaCorrente contaDoTuke = new ContaCorrente("Tuke", 1234, 790, 50.50);

            ContaCorrente contaDaTiaVirginia = new ContaCorrente("Tia Virginia", 1234, 907, 10000.99);

            contaDoJoaoV.Saldo += 500;

            /*contaDoJoaoV.Sacar(90);*/

            Console.WriteLine("O saldo da conta do JoaoV é:" + contaDoJoaoV.Saldo);
        }
    }
}
