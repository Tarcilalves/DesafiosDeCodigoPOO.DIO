using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01PrimeiroDesafioComPOO.Models
{
    public class Pessoa
    {

        // Atributos (características da classe)
        private string nome;
        private int idade;

        // Construtor da classe, usado para inicializar os atributos
        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }

        // Método para obter o nome
        public string GetNome()
        {
            return nome;
        }

        // Método para obter a idade
        public int GetIdade()
        {
            return idade;
        }
    }

}
