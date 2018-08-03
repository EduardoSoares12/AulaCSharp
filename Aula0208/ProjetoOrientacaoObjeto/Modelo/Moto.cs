using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto.Modelo {

    class Moto : Veiculo, Motorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Girando a manopla...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Apertando o freio...");
            Velocidade -= 5;
        }
    }
}
