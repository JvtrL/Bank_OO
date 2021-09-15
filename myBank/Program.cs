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

            Console.WriteLine("O titular da conta é:" + contaDoJoaoV.titular);
            Console.WriteLine("O titular da conta é:" + contaDoTuke.titular);
            Console.WriteLine("O titular da conta é:" + contaDaTiaVirginia.titular);

            contaDoJoaoV.Sacar(90);
            contaDoTuke.Sacar(0.10);
            contaDaTiaVirginia.Sacar(700.99);

            Console.WriteLine("O saldo da conta do JoaoV é:" + contaDoJoaoV.saldo);
            Console.WriteLine("O saldo da conta do Tuke é:" + contaDoTuke.saldo);
            Console.WriteLine("O saldo da conta da Tia Virginia é:" + contaDaTiaVirginia.saldo);

            contaDoJoaoV.Depositar(1200);

            Console.WriteLine("O saldo da conta do JoaoV é:" + contaDoJoaoV.saldo);

            contaDaTiaVirginia.Transferir(200, contaDoTuke);

            Console.WriteLine("O saldo da conta da Tia Virginia é:" + contaDaTiaVirginia.saldo);
            Console.WriteLine("O saldo da conta do Tuke é:" + contaDoTuke.saldo);
        }
    }
}
