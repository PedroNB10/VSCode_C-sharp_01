using System;

namespace PRIMEIRO_PROJETO

{

    class Program
    {
        static void Main(string[] args)
        {
            //tipo de variavel "ContaCorrente", "conta" é a variavel
             ContaCorrente conta_do_pedro = new ContaCorrente("Pedro Nogueira",111,223,1000); // conta_do_pedro é uma variável que tem um objeto
             ContaCorrente conta_do_Ednaldo = new ContaCorrente("Ednaldo",222,233,3000);
             ContaCorrente conta_da_Cecilia = new ContaCorrente("Cecilia",333,226,-1000); //new ==> new object

            // conta_do_pedro.Titular = "Pedro Nogueira";
            // conta_do_pedro.Agencia = 111;
            // conta_do_pedro.numero_conta = 223;
            // conta_do_pedro.Saldo = 1000;
        

            // conta_do_Ednaldo.Titular = "Ednaldo";
            // conta_do_Ednaldo.Agencia = 111;
            // conta_do_Ednaldo.numero_conta = 245;
            // conta_do_Ednaldo.Saldo = -1000;
            

            // conta_da_Cecilia.Titular = "Cecilia";
            // conta_da_Cecilia.Agencia = 111;
            // conta_da_Cecilia.numero_conta = 233;
            // conta_da_Cecilia.Saldo = 200;
             //A conta é do(a) Pedro Nogueira. A agência é 111. O número da conta é 223. O saldo é de: 1000 reais.

             Console.WriteLine("A conta é do(a) "+ conta_do_pedro.Titular + ". A agência é "+ conta_do_pedro.Agencia + ". O número da conta é "+conta_do_pedro.numero_conta + ". O saldo é de: "+conta_do_pedro.Saldo+" reais.");
            //  Console.WriteLine("A conta é do(a) "+ conta_do_Ednaldo.Titular + ". A agência é "+ conta_do_Ednaldo.Agencia + ". O número da conta é "+conta_do_Ednaldo.numero_conta + ". O saldo é de: "+conta_do_Ednaldo.Saldo+" reais.");
            //  Console.WriteLine("A conta é do(a) "+ conta_da_Cecilia.Titular + ". A agência é "+ conta_da_Cecilia.Agencia + ". O número da conta é "+conta_da_Cecilia.numero_conta + ". O saldo é de: "+conta_da_Cecilia.Saldo+" reais.");
            
            bool sacar_conta_pedro =  conta_do_pedro.SacarDinheiro(100); // a variavel tem que ter o mesmo tipo do retorno do método
             Console.WriteLine(sacar_conta_pedro);
                Console.WriteLine("A conta é do(a) "+ conta_do_pedro.Titular + ". A agência é "+ conta_do_pedro.Agencia + ". O número da conta é "+conta_do_pedro.numero_conta + ". O saldo é de: "+conta_do_pedro.Saldo+" reais.");
     
           bool depositar_conta_pedro =  conta_do_pedro.DepositarDinheiro(200);

             Console.WriteLine("A conta é do(a) "+ conta_do_pedro.Titular + ". A agência é "+ conta_do_pedro.Agencia + ". O número da conta é "+conta_do_pedro.numero_conta + ". O saldo é de: "+conta_do_pedro.Saldo+" reais.");
        }

    }

}




// See https://aka.ms/new-console-template for more information
