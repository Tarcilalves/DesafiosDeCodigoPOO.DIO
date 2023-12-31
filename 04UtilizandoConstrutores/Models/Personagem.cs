using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04UtilizandoConstrutores.Models
{
    public class Personagem
    {
        //Propriedade
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; } = 1;
        public int Vida { get; set; } = 10;

        //Construtor
        public Personagem(string nome, string raca, string classe)
        {
            Nome = nome;
            Raca = raca;
            Classe = classe;
        }

        //Métodos
        public void ExibirStatus()
        {
            Console.WriteLine("Status:")
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("Raça:" + Raca);
            Console.WriteLine("Classe:" + Classe);
            Console.WriteLine("Nível:" + Nivel);
            Console.WriteLine("Vida:" + Vida);

        }
    }
}