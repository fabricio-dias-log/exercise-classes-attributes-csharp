using System.Globalization;

namespace ExerciseClassesAttr;

public class ContaBancaria
{
    public int NumeroConta { get; private set; }
    public string NomeTitular { get; set; }
    public double Saldo { get; private set; } = 0;

    public ContaBancaria()
    {
        
    }

    public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
    {
        Deposito(depositoInicial);
    }

    public ContaBancaria(int numeroConta, string nomeTitular)
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
    }

    public void CadastrarConta()
    {
        
        
        Console.Clear();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(this);
    }

    public void Deposito(double quantia)
    {
        this.Saldo += quantia;

        Console.Clear();
        Console.WriteLine("Dados atualizados: ");
        Console.WriteLine(this);
    }
    
    public void Saque(double quantia)
    {
        double taxaSaque = 5.00;
        
        this.Saldo -= quantia + taxaSaque;

        Console.Clear();
        Console.WriteLine("Dados atualizados: ");
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return $"Conta: {this.NumeroConta} | Titular: {this.NomeTitular} | Saldo: R$ {this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}