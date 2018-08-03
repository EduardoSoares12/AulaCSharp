using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto.Modelo {

    class Carro : Veiculo, Motorizado {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Pisando no pedal...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Pisando no freio...");
            Velocidade -= 5;
        }
    }
}
