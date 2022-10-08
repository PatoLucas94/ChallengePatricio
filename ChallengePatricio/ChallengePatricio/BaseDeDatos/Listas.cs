using ChallengePatricio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.BaseDeDatos
{
    public class Listas
    {
        public List<Cuadrado> listaCuadrados()
        {
            return new List<Cuadrado>()
            {
              new Cuadrado(3),
              new Cuadrado(5),
              new Cuadrado(8)
            };
        }

        public List<Circulo> listaCirculos()
        {
            return new List<Circulo>()
            {
                new Circulo(4),
                new Circulo(1)
            };
        }

        public List<TrianguloEquilatero> listaTrianguloEquilatero()
        {
            return new List<TrianguloEquilatero>()
            {
                new TrianguloEquilatero(4),
                new TrianguloEquilatero(9)
            };
        }

        public List<TrapecioRectangulo> listaTrapecioRectangulo()
        {
            return new List<TrapecioRectangulo>()
            {
                new TrapecioRectangulo(4, 15, 10, 20),
                new TrapecioRectangulo(5, 8, 4, 5),
                new TrapecioRectangulo(20, 10, 8, 25),
                new TrapecioRectangulo(14, 16, 8, 30)
            };
        }
    }
}
