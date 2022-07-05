//Estrutura: Classe, Construtor e Método;


public class ContaCorrente 
{


//Títular, numero_conta, Agencia e Saldo são ATRIBUTOS DE CLASSE

// tipo de acesso, tipo de variavel nome da variavel
   public string Titular; //Quando cria uma conta é como estanciar um objeto
   public int numero_conta;
   public int Agencia;
   public double Saldo;

   public ContaCorrente (string Titular,  int Agencia, int numero_conta, double Saldo)// é um construtor, cria o objeto
    {
      //this é o objeto sendo usado no momento
      this.Titular = Titular;
      this.numero_conta = numero_conta;
      this.Agencia = Agencia;
      this.Saldo = Saldo;
      
 //Console.WriteLine("A conta é do(a) "+ this.Titular + ". A agência é "+ this.Agencia + ". O número da conta é "+this.numero_conta + ". O saldo é de: "+this.Saldo+" reais.");
      
   }

//void é um retorno vazio

// para criar umma funlçao sem retorno usa o void antes do nome da função

// tipo bool é o retorno do méthodo SacarDinheiro

      public bool SacarDinheiro(double ValorSaque){
          
          if(this.Saldo >= ValorSaque){
            this.Saldo = this.Saldo - ValorSaque;
           return true;
          }
 return false;
        

        }

}