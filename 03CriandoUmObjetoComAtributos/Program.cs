using _03CriandoUmObjetoComAtributos.Models;  // Certifique-se de que está importando o namespace correto

class Program
{
    static void Main()
    {
        // Leitura das informações do jogador
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = Convert.ToInt32(Console.ReadLine());
        string posicao = Console.ReadLine();

        // Criando um objeto Jogador usando o construtor
        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

        // Exibindo as informações do jogador criado
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(jogador.Nome);
        Console.WriteLine(jogador.Nacionalidade);
        Console.WriteLine(jogador.Idade);
        Console.WriteLine("Posição: " + jogador.Posicao);
    }
}

