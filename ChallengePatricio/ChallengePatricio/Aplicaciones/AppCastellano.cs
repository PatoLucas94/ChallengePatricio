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
    public class AppCastellano
    {
        public void MostrarAppEnCastellano()
        {
            Listas lista = new Listas();

            List<Cuadrado> listaCuadrados = lista.listaCuadrados();
            List<Circulo> listaCirculos = lista.listaCirculos();
            List<TrianguloEquilatero> listaTrianguloEquilatero = lista.listaTrianguloEquilatero();
            List<TrapecioRectangulo> listaTrapecioRectangulo = lista.listaTrapecioRectangulo();

            int cantidadDeFiguras = listaCuadrados.Count() + listaCirculos.Count() + listaTrianguloEquilatero.Count();

            Console.WriteLine("Bienvenidos a la app de las figuras, por favor elija una opcion para visualizar");
            int opcion;

            do
            {
                Console.WriteLine("1- Cuadrado / 2- Circulo / 3- Triangulo Equilatero / 4- Trapecio Rectangulo / 5- Total de Figuras / 6- EXIT");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Cuadrado cuadrado = new Cuadrado();
                        cuadrado.MostrarCuadradoInformacion(listaCuadrados);
                        break;

                    case 2:
                        Circulo circulo = new Circulo();
                        circulo.MostrarCirculoInformacion(listaCirculos);
                        break;

                    case 3:
                        TrianguloEquilatero trianguloEqui = new TrianguloEquilatero();
                        trianguloEqui.MostrartrianguloEquilateroInformacion(listaTrianguloEquilatero);
                        break;

                    case 4:
                        TrapecioRectangulo trapecioRect = new TrapecioRectangulo();
                        trapecioRect.MostrarTrapecioRectanguloInformacion(listaTrapecioRectangulo);
                        break;

                    case 5:
                        Console.WriteLine($"\nLa Cantidad de figuras es: {cantidadDeFiguras}\n");
                        break;

                    case 6:
                        opcion = 6;
                        break;

                    default:
                        Console.WriteLine("No es la opcion correcta, intente nuevamente");
                        break;
                }

            } while (opcion != 6);

            Console.WriteLine("GRACIAS VUELVA PRONTOS\n");
        }
    }
}
