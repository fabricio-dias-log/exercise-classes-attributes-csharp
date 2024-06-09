namespace ExerciseClassesAttr;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria contaBancaria;
        int option;
        double quantia;
        char desejaValorInicial;
        
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Cadastro de Conta bancária:");
        Console.WriteLine("-----------------------------");
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o nome do titular da conta: ");
        string nomeTitular = Console.ReadLine();

        Console.Write("Haverá valor inicial (s/n)?");
        desejaValorInicial = char.Parse(Console.ReadLine());

        if (desejaValorInicial == 's' || desejaValorInicial == 'S')
        {
            Console.Write("Digite o valor de depósito inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());
            contaBancaria = new ContaBancaria(numeroConta, nomeTitular, saldoInicial);
            Console.Clear();
            Console.WriteLine(contaBancaria);
        }
        else
        {
            contaBancaria = new ContaBancaria(numeroConta, nomeTitular);
            Console.Clear();
            Console.WriteLine(contaBancaria);
        }
        
        do
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Dados da Conta bancária");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Saque");
            Console.WriteLine("-----------------------------");
            Console.Write("Opção: ");

            option = int.Parse(Console.ReadLine());
            
            Console.Clear();

            switch (option)
            {
                case 1:
                    Console.WriteLine(contaBancaria);
                    break;
                case 2:
                    Console.Write("Digite o valor para depósito: ");
                    quantia = double.Parse(Console.ReadLine());
                    
                    contaBancaria.Deposito(quantia);
                    break;
                case 3:
                    Console.Write("Digite o valor para saque: ");
                    quantia = double.Parse(Console.ReadLine()) ;
                    
                    contaBancaria.Saque(quantia);
                    break;
                default:
                    return;
            }

        } while (true);
    }
}