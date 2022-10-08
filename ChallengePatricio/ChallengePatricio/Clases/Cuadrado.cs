using ChallengePatricio.Abstracciones;
using ChallengePatricio.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.Clases
{
    public class Cuadrado: FormaGeometrica
    {
        public override decimal _lado { get; set; }

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public Cuadrado()
        { }

        public override decimal CalcularArea()
        {
            try
            {
                return _lado * _lado;
            }
            catch (Exception)
            {

                throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
            
        }

        public override decimal CalcularPerimetro()
        {
            try
            {
                return _lado * 4;
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
            
        }

        public void MostrarCuadradoInformacion(List<Cuadrado> cuadrados)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var cuadrado in cuadrados)
            {
                cantidad++;
                decimal area = cuadrado.CalcularArea();
                decimal perimetro = cuadrado.CalcularPerimetro();


                Console.WriteLine($"------- CUADRADO {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"Perimetro: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"Cantidad de Cuadrados en la lista: {cantidad}\n" +
                              $"Area Total: {totalArea}\n" +
                              $"Perimetro Total: {totalPerimetro}\n\n");
            
        }

        #region Metodos en ingles y portugues

        public void MostrarCuadradoInformacionEnIngles(List<Cuadrado> cuadrados)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var cuadrado in cuadrados)
            {
                cantidad++;
                decimal area = cuadrado.CalcularArea();
                decimal perimetro = cuadrado.CalcularPerimetro();


                Console.WriteLine($"------- {TraduccionIngles.Cuadrado} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionIngles.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"{TraduccionIngles.CuadradosEnLista}: {cantidad}\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionIngles.Perimetro}: {totalPerimetro}\n\n");

        }

        public void MostrarCuadradoInformacionEnPortugues(List<Cuadrado> cuadrados)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var cuadrado in cuadrados)
            {
                cantidad++;
                decimal area = cuadrado.CalcularArea();
                decimal perimetro = cuadrado.CalcularPerimetro();


                Console.WriteLine($"------- {TraduccionPortugues.Cuadrado} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionPortugues.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"{TraduccionPortugues.CuadradosEnLista}: {cantidad}\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionPortugues.Perimetro}: {totalPerimetro}\n\n");

        }

        #endregion
    }
}
