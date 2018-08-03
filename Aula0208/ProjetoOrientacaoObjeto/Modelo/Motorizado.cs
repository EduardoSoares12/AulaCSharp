using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto.Modelo
{
    interface Motorizado
    {

        int Velocidade { get; set; }
        void Acelerar();
        void Frenar();

    }
}
