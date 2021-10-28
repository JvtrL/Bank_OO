using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente gerenteChr_istian = new Gerente()
            {
               Nome = "Christian",
               CPF = "120.789.456-90",
               Salario = 2200.00,
            };

            Vendedor vendedorMagrelinho = new Vendedor()
            {
                Nome = "André",
                CPF = "124.124.124-24",
                Salario = 1500.00,
            };

            Vendedor vendedorFabin = new Vendedor()
            {
                Nome = "Sr Fábio",
                CPF = "127.332.190-24",
                Salario = 900.00,
            };

        vendedorFabin.Bonificacao = vendedorFabin.Salario;

            ContaCorrente contaDoJoaoV = new ContaCorrente("João Vitor L", 1234, 1200.00, vendedorFabin);
            contaDoJoaoV.Conta = 789;
            ContaCorrente contaDoTuke = new ContaCorrente("Túlio", 1234, 1500.90, vendedorMagrelinho);
            contaDoTuke.Conta = 790;
            ContaCorrente contaDaTiaVirginia = new ContaCorrente("Virginia", 1234, 1499.99, vendedorFabin);
            contaDaTiaVirginia.Conta = 990;
            ContaCorrente contaDoMarquinhosdoGrau = new ContaCorrente("Marco Antonio", 1234, 124.24, vendedorMagrelinho);
            contaDoMarquinhosdoGrau.Conta = 124;

            Console.WriteLine("O titular da conta é o: " + contaDoJoaoV.Titular);
            Console.WriteLine("O titular da conta é o: " + contaDoTuke.Titular);
            Console.WriteLine("O titular da conta é o: " + contaDaTiaVirginia.Titular);
            Console.WriteLine("O saldo da conta do João Vitor L é: " + contaDoJoaoV.Saldo);

            Console.WriteLine("A comissao do Vendedor Fábio é: " + vendedorFabin.Comissao);
            Console.WriteLine("A comissao do Vendedor André é: " + vendedorMagrelinho.Comissao);

            contaDoJoaoV.Sacar(100);
            Console.WriteLine("Seu saldo após o saque de R$100,00 é: " + contaDoJoaoV.Saldo);
            contaDoJoaoV.Depositar(150);
            Console.WriteLine("Seu saldo após o deposito de R$150,00 é: " + contaDoJoaoV.Saldo);
            contaDoJoaoV.Transferir(100, contaDoMarquinhosdoGrau);
            Console.WriteLine("Seu saldo após a transferência de R$100,00 é: " + contaDoJoaoV.Saldo);

            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}
