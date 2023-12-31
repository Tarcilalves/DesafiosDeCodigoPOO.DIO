using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02UtilizandoPropriedadesEMétodos.Models
{
    public class Robo
    {
        //Propriedade ou atributo
        public int VelocidadeAtual { get; set; } = 0;
        public int VelocidadeMaxima { get; }
        public int VelocidadeMinima { get; }

        //Métodos
        public Robo(int vmin, int vmax)
        {
            VelocidadeMinima = vmin;
            VelocidadeMaxima = vmax;
            VelocidadeAtual = vmin;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual < VelocidadeMaxima)
            {
                VelocidadeAtual++;
            }
        }

        public void Desacelerar()
        {
            if (VelocidadeAtual > VelocidadeMinima)
            {
                VelocidadeAtual--;
            }
        }
    }
}