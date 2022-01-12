using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanto ByteBank");

            LancaExcessao();
            TestaContas();



            Console.ReadLine();
        }

        public static void LancaExcessao()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }

        }

        public static void TestaContas()
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(876, 86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            conta.Depositar(200);
            Console.WriteLine(conta.Saldo);
        }

    }
}
