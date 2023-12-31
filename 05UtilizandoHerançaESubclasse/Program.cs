using _05UtilizandoHerançaESubclasse.Models;

class Program
{
    static void Main()
    {
        // Leitura das informações do personagem
        string nome = Console.ReadLine();
        int mana = Convert.ToInt32(Console.ReadLine());
        int danoBase = Convert.ToInt32(Console.ReadLine());

        // Criando um objeto Subclasse usando o construtor
        Subclasse personagem = new Subclasse(nome, mana, danoBase);

        // Leitura da quantidade de mana usada no ataque
        int quantidadeManaUsada = Convert.ToInt32(Console.ReadLine());

        // Chamando o método CalcularDano para mostrar o resultado do ataque
        personagem.CalcularDano(quantidadeManaUsada);
    }
}
