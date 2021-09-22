using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoJoaoV = new ContaCorrente("Joao V", 1234, 100.50);
            contaDoJoaoV.Conta = 789;
            ContaCorrente contaDoTuke = new ContaCorrente("Tuke", 1234, 50.50);
            contaDoTuke.Conta = 790;
            ContaCorrente contaDaTiaVirginia = new ContaCorrente("Tia Virginia", 1234, 10000.99);
            contaDaTiaVirginia.Conta = 990;

            contaDoJoaoV.Saldo += 500;

            /*contaDoJoaoV.Sacar(90);*/

            Console.WriteLine("O saldo da conta do JoaoV é:" + contaDoJoaoV.Saldo);
        }
    }
}
