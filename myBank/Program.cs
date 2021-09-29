using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionarioMagrelinho = new Funcionario();
            funcionarioMagrelinho.Nome = "André";
            funcionarioMagrelinho.CPF = "124.124.124-24";
            funcionarioMagrelinho.Cargo = "Só anda";
            funcionarioMagrelinho.Salario = 1.50;

            Funcionario funcionarioFabin = new Funcionario();
            funcionarioFabin.Nome = "Sr Fábio";
            funcionarioFabin.CPF = "127.332.190-24";
            funcionarioFabin.Cargo = "Vendedor";
            funcionarioFabin.Salario = 1500;

            ContaCorrente contaDoJoaoV = new ContaCorrente("João Vitor L", 1234, 1200.00, funcionarioFabin);
            contaDoJoaoV.Conta = 789;
            ContaCorrente contaDoTuke = new ContaCorrente("Túlio", 1234, 1500.90, funcionarioMagrelinho);
            contaDoTuke.Conta = 790;
            ContaCorrente contaDaTiaVirginia = new ContaCorrente("Virginia", 1234, 1499.99, funcionarioFabin);
            contaDaTiaVirginia.Conta = 990;
            ContaCorrente contaDoMarquinhosdoGrau = new ContaCorrente("Marco Antonio", 1234, 124.24, funcionarioMagrelinho);
            contaDoMarquinhosdoGrau.Conta = 124;

            Console.WriteLine("O saldo da conta da João Vitor L é: " + contaDoJoaoV.Saldo);
            Console.WriteLine("O saldo da conta do Túlio é: " + contaDoTuke.Saldo);

            Console.WriteLine("A comissao do Vendedor Fábio é: " + funcionarioFabin.Comissao);
            Console.WriteLine("A comissao do Vendedor André é: " + funcionarioMagrelinho.Comissao);

            Console.WriteLine("O salário do Fábio é: " + funcionarioFabin.Salario);

            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);
            Console.WriteLine("O total de comissao a ser pago é: " + ContaCorrente.TotalDeComissao);
        }
    }
}
