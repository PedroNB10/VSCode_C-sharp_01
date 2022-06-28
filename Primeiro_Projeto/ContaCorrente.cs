public class ContaCorrente 
{


//Títular, numero_conta, Agencia e Saldo são ATRIBUTOS DE CLASSE
   public string Titular;
   public int numero_conta;
   public int Agencia;
   public double Saldo;

   public ContaCorrente (string Titular,  int Agencia, int numero_conta, double Saldo)
    {

      this.Titular = Titular;
      this.numero_conta = numero_conta;
      this.Agencia = Agencia;
      this.Saldo = Saldo;
      
 Console.WriteLine("A conta é do(a) "+ this.Titular + ". A agência é "+ this.Agencia + ". O número da conta é "+this.numero_conta + ". O saldo é de: "+this.Saldo+" reais.");
      
   }

}