using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto.Modelo
{
    class Barco : Veiculo, Motorizado {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Aciona o manete...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Aciona o freio...");
            Velocidade -= 5;
        }


    }
}
