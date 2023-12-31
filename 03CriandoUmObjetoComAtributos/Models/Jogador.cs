using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03CriandoUmObjetoComAtributos.Models
{
    public class Jogador
    {
       //Propriedade
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }

        //Método
        public void NovoJogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
        }
    }
}