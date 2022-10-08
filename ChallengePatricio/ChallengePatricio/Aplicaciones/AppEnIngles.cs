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
    public class AppEnIngles
    {
        public void MostrarAppEnIngles()
        {
            Listas lista = new Listas();

            List<Cuadrado> listaCuadrados = lista.listaCuadrados();
            List<Circulo> listaCirculos = lista.listaCirculos();
            List<TrianguloEquilatero> listaTrianguloEquilatero = lista.listaTrianguloEquilatero();
            List<TrapecioRectangulo> listaTrapecioRectangulo = lista.listaTrapecioRectangulo();

            int cantidadDeFiguras = listaCuadrados.Count() + listaCirculos.Count() + listaTrianguloEquilatero.Count();

            Console.WriteLine(TraduccionIngles.MensajeBienvenida);
            int opcion;

            do
            {
                Console.WriteLine(TraduccionIngles.Menu);
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Cuadrado cuadrado = new Cuadrado();
                        cuadrado.MostrarCuadradoInformacionEnIngles(listaCuadrados);
                        break;

                    case 2:
                        Circulo circulo = new Circulo();
                        circulo.MostrarCirculoInformacionEnIngles(listaCirculos);
                        break;

                    case 3:
                        TrianguloEquilatero trianguloEqui = new TrianguloEquilatero();
                        trianguloEqui.MostrartrianguloEquilateroInformacionEnIngles(listaTrianguloEquilatero);
                        break;

                    case 4:
                        TrapecioRectangulo trapecioRect = new TrapecioRectangulo();
                        trapecioRect.MostrarTrapecioRectanguloInformacionEnIngles(listaTrapecioRectangulo);
                        break;

                    case 5:
                        Console.WriteLine($"\n{TraduccionIngles.CantidadFiguras}: {cantidadDeFiguras}\n");
                        break;

                    case 6:
                        opcion = 6;
                        break;

                    default:
                        Console.WriteLine(TraduccionIngles.OpcionIncorrecta);
                        break;
                }

            } while (opcion != 6);

            Console.WriteLine(TraduccionIngles.Despedida + "\n");
        }
    }
}
