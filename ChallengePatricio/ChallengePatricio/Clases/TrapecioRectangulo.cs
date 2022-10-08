using ChallengePatricio.Abstracciones;
using ChallengePatricio.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.Clases
{
    public class TrapecioRectangulo: FormaGeometrica
    {
        public override decimal _lado { get; set; }
        public decimal BaseMayor { get; set; }
        public decimal BaseMenor { get; set; }
        public decimal Altura { get; set; }

        public TrapecioRectangulo(decimal lado, decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _lado = lado;
            BaseMayor = baseMenor;
            BaseMenor = baseMenor;
            Altura = altura;
        }

        public TrapecioRectangulo()
        { }

        public override decimal CalcularArea()
        {
            try
            {
                return ((BaseMayor + BaseMenor) * Altura) / 2;
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

        public void MostrarTrapecioRectanguloInformacion(List<TrapecioRectangulo> cuadrados)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var cuadrado in cuadrados)
            {
                cantidad++;
                decimal area = cuadrado.CalcularArea();
                decimal perimetro = cuadrado.CalcularPerimetro();


                Console.WriteLine($"------- TRAPECIO RECTANGULO {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"Perimetro: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"Cantidad de Trapecios Rectangulos en la lista: {cantidad}\n" +
                              $"Area Total: {totalArea}\n" +
                              $"Perimetro Total: {totalPerimetro}\n\n");

        }

        #region Metodos en ingles y portugues

        public void MostrarTrapecioRectanguloInformacionEnIngles(List<TrapecioRectangulo> trapeciosRectangulos)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var trapecio in trapeciosRectangulos)
            {
                cantidad++;
                decimal area = trapecio.CalcularArea();
                decimal perimetro = trapecio.CalcularPerimetro();


                Console.WriteLine($"------- {TraduccionIngles.TrapecioRectangulo} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionIngles.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"{TraduccionIngles.TrapeciosRectEnLista}: {cantidad}\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionIngles.Perimetro}: {totalPerimetro}\n\n");

        }

        public void MostrarTrapecioRectanguloInformacionEnPortugues(List<TrapecioRectangulo> trapeciosRectangulos)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var trapecio in trapeciosRectangulos)
            {
                cantidad++;
                decimal area = trapecio.CalcularArea();
                decimal perimetro = trapecio.CalcularPerimetro();


                Console.WriteLine($"------- {TraduccionPortugues.TrapecioRectangulo} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionPortugues.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"{TraduccionPortugues.TrapecioRectEnLista}: {cantidad}\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionPortugues.Perimetro}: {totalPerimetro}\n\n");

        }

        #endregion
    }
}
