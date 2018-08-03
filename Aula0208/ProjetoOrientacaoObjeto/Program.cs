using ProjetoOrientacaoObjeto.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto { 

    class Program { 
    
        static void Main(string[] args) {

            Carro car = new Carro();
            car.Modelo = "Audi";
            car.Acelerar();
            ExecutaTesteMotor(car);
            Console.ReadKey();

            Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();
        
        }

        static void ExecutaTesteMotor(Motorizado vec)
        {

            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);

        }
    }
}
