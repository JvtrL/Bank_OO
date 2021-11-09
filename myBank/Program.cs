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
               Salario = 1750.00,
               NumeroDeAgencias = 3,
            };

            Vendedor vendedorMagrelinho = new Vendedor()
            {
                Nome = "André",
                CPF = "124.124.124-24",
                Salario = 1200.00,
                NumeroDeClientesAtendidos = 1,
            };

            Vendedor vendedorFabin = new Vendedor()
            {
                Nome = "Fábio",
                CPF = "127.332.190-24",
                Salario = 1200.00,
                NumeroDeClientesAtendidos = 1,
            };

            Vendedor vendedorGaibro = new Vendedor()
            {
                Nome = "Ofélio",
                CPF = "127-345-058-47",
                Salario = 1200.00,
                NumeroDeClientesAtendidos = 1,
            };

        vendedorFabin.Bonificacao = vendedorFabin.Salario;

            ContaCorrente contaDoJoaoV = new ContaCorrente("João Vitor Lima da Silveira", 1234, 1200.00, vendedorFabin);
            contaDoJoaoV.Conta = 789;
            ContaCorrente contaDoTuke = new ContaCorrente("Túlio", 1234, 1500.90, vendedorMagrelinho);
            contaDoTuke.Conta = 790;
            ContaCorrente contaDaTiaVirginia = new ContaCorrente("Virginia", 1234, 1499.99, vendedorGaibro);
            contaDaTiaVirginia.Conta = 990;
            ContaCorrente contaDoMarquinhosdoGrau = new ContaCorrente("Marco Antonio", 1234, 124.24, vendedorMagrelinho);
            contaDoMarquinhosdoGrau.Conta = 124;

            Console.WriteLine("O titular da conta é o: " + contaDoJoaoV.Titular);
            Console.WriteLine("O titular da conta é o: " + contaDoTuke.Titular);
            Console.WriteLine("O titular da conta é a: " + contaDaTiaVirginia.Titular);

            Console.WriteLine("O primeiro vendedor é o : " + vendedorFabin.Nome);
            Console.WriteLine("O segundo vendedor é o : " + vendedorMagrelinho.Nome);
            Console.WriteLine("O terceiro vendedor é o : " + vendedorGaibro.Nome);

            Console.WriteLine("O gerente das contas é o : " + gerenteChr_istian.Nome);

            Console.WriteLine("A bonificação do vendedor " + vendedorFabin.Nome + " é: " + vendedorFabin.Bonificacao);
            Console.WriteLine("A bonificação do vendedor " + vendedorMagrelinho.Nome + " é: " + vendedorMagrelinho.Bonificacao);
            Console.WriteLine("A bonificação do vendedor " + vendedorGaibro.Nome + " é: " + vendedorGaibro.Bonificacao);
            Console.WriteLine("A bonificação do gerente " + gerenteChr_istian.Nome + " é: " + gerenteChr_istian.Bonificacao);

            Console.WriteLine("A remuneração total do vendedor " + vendedorFabin.Nome + " é: " + vendedorFabin.RemuneracaoTotal(vendedorFabin.Salario, vendedorFabin.Bonificacao));
            Console.WriteLine("A remuneração total do vendedor " + vendedorMagrelinho.Nome + " é: " + vendedorMagrelinho.RemuneracaoTotal(vendedorMagrelinho.Salario, vendedorMagrelinho.Bonificacao)); 
            Console.WriteLine("A remuneração total do vendedor " + vendedorGaibro.Nome + " é: " + vendedorGaibro.RemuneracaoTotal(vendedorGaibro.Salario, vendedorGaibro.Bonificacao));   
            Console.WriteLine("A remuneração total do gerente " + gerenteChr_istian.Nome + " é: " + gerenteChr_istian.RemuneracaoTotal(gerenteChr_istian.Salario, gerenteChr_istian.Bonificacao));      

            Console.WriteLine("O gerente terá: " + gerenteChr_istian.CalcularFerias() + " dias de ferias.");
            Console.WriteLine("O vendedor terá: " + vendedorFabin.CalcularFerias() + " dias de ferias.");

            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}
