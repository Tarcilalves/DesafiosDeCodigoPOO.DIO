using _01PrimeiroDesafioComPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        
            //Solicita ao usuário que insira o nome da pessoa
            Console.WriteLine("Digite o nome da pessoa:");
            string nome = Console.ReadLine();

            // Solicita ao usuário que insira a idade da pessoa
            Console.WriteLine("Digite a idade da pessoa:");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Cria um objeto Pessoa usando o construtor
            Pessoa pessoa = new Pessoa(nome, idade);

            // Exibe na tela o nome e a idade usando os métodos
            Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
    
}