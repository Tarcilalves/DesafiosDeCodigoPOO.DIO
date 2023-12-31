using _02UtilizandoPropriedadesEMétodos.Models;


static void Main()
    {
        // Leitura da entrada
        string[] valores = Console.ReadLine().Split(' ');
        int vmin = int.Parse(valores[0]);
        int vmax = int.Parse(valores[1]);

        string comandos = Console.ReadLine();

        // Criando um objeto Robo
        Robo robo = new Robo(vmin, vmax);

        // Executando os comandos
        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.Acelerar();
            }
            else if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }

        // Exibindo a velocidade final do robô
        Console.WriteLine(robo.VelocidadeAtual);
    }

