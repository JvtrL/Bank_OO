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
            ContaCorrente contaDoMarquinhosdoGrau = new ContaCorrente("Marco Antonio", 1234, 524.50);
            contaDoMarquinhosdoGrau.Conta = 124;

            contaDoJoaoV.Saldo += 500;

            Console.WriteLine("O número de contas criadas é:" + ContaCorrente.TotaldeContasCriadas);

            Console.WriteLine("O saldo da conta do JoaoV é:" + contaDoJoaoV.Saldo);
        }
    }
}
