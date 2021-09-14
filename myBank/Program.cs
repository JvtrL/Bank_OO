using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoJoaoV = new ContaCorrente("JoaoV", 1234, 789, 100.50);

            ContaCorrente contaDoTuke = new ContaCorrente("Tuke", 1234, 790, 50.50);

            ContaCorrente contaDaTiaVirginia = new ContaCorrente("TiaVirginia", 1234, 907, 10000.99);

            Console.WriteLine("O titular da conta é:" + contaDoJoaoV.titular);
            Console.WriteLine("O titular da conta é:" + contaDoTuke.titular);
            Console.WriteLine("O titular da conta é:" + contaDaTiaVirginia.titular);

        }
    }
}
