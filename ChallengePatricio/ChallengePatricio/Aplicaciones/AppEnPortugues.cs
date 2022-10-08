using ChallengePatricio.BaseDeDatos;
using ChallengePatricio.Clases;
using ChallengePatricio.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.Aplicaciones
{
    class AppEnPortugues
    {
        public void MostrarAppEnPortugues()
        {
            Listas lista = new Listas();

            List<Cuadrado> listaCuadrados = lista.listaCuadrados();
            List<Circulo> listaCirculos = lista.listaCirculos();
            List<TrianguloEquilatero> listaTrianguloEquilatero = lista.listaTrianguloEquilatero();
            List<TrapecioRectangulo> listaTrapecioRectangulo = lista.listaTrapecioRectangulo();

            int cantidadDeFiguras = listaCuadrados.Count() + listaCirculos.Count() + listaTrianguloEquilatero.Count();

            Console.WriteLine(TraduccionPortugues.MensajeBienvenida);
            int opcion;

            do
            {
                Console.WriteLine(TraduccionPortugues.Menu);
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Cuadrado cuadrado = new Cuadrado();
                        cuadrado.MostrarCuadradoInformacionEnPortugues(listaCuadrados);
                        break;

                    case 2:
                        Circulo circulo = new Circulo();
                        circulo.MostrarCirculoInformacionEnPortugues(listaCirculos);
                        break;

                    case 3:
                        TrianguloEquilatero trianguloEqui = new TrianguloEquilatero();
                        trianguloEqui.MostrartrianguloEquilateroInformacionEnPortugues(listaTrianguloEquilatero);
                        break;

                    case 4:
                        TrapecioRectangulo trapecioRect = new TrapecioRectangulo();
                        trapecioRect.MostrarTrapecioRectanguloInformacionEnPortugues(listaTrapecioRectangulo);
                        break;

                    case 5:
                        Console.WriteLine($"\n{TraduccionPortugues.CantidadFiguras}: {cantidadDeFiguras}\n");
                        break;

                    case 6:
                        opcion = 6;
                        break;

                    default:
                        Console.WriteLine(TraduccionPortugues.OpcionIncorrecta);
                        break;
                }

            } while (opcion != 6);

            Console.WriteLine(TraduccionPortugues.Despedida + "\n");
        }
    }
}
