using _04UtilizandoConstrutores.Models;

class Program
{
    static void Main()
    {
        // Leitura das informações do personagem
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();

        // Criando um objeto Personagem usando o construtor
        Personagem personagem = new Personagem(nome, raca, classe);

        // Chamando o método ExibirStatus para mostrar as informações do personagem
        personagem.ExibirStatus();
    }
}
