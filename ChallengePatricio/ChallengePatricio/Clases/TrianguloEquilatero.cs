using ChallengePatricio.Abstracciones;
using ChallengePatricio.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.Clases
{
    public class TrianguloEquilatero: FormaGeometrica
    {
        public override decimal _lado { get; set; }

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public TrianguloEquilatero()
        {}

        public override decimal CalcularArea()
        {
            try
            {
                return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
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
                return _lado * 3;
            }
            catch (Exception)
            {

               throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
            
        }

        public void MostrartrianguloEquilateroInformacion(List<TrianguloEquilatero> triangulosEquilateros)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var triangulosEquilatero in triangulosEquilateros)
            {

                cantidad++;
                decimal area = triangulosEquilatero.CalcularArea();
                decimal perimetro = triangulosEquilatero.CalcularPerimetro();


                Console.WriteLine($"------- TRIANGULO EQUI {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"Perimetro: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;
            }

            Console.WriteLine($"Cantidad de Triangulos Equilateros en la lista: {cantidad}\n\n" +
                              $"Area Total: {totalArea}\n" +
                              $"Perimetro Total: {totalPerimetro}\n\n");

        }

        #region Metodos en ingles y portugues

        public void MostrartrianguloEquilateroInformacionEnIngles(List<TrianguloEquilatero> triangulosEquilateros)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var triangulosEquilatero in triangulosEquilateros)
            {

                cantidad++;
                decimal area = triangulosEquilatero.CalcularArea();
                decimal perimetro = triangulosEquilatero.CalcularPerimetro();


                Console.WriteLine($"------- {TraduccionIngles.TrianguloEquilatero} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionIngles.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;
            }

            Console.WriteLine($"{TraduccionIngles.TriangulosEnLista}: {cantidad}\n\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionIngles.Perimetro}: {totalPerimetro}\n\n");

        }

        public void MostrartrianguloEquilateroInformacionEnPortugues(List<TrianguloEquilatero> triangulosEquilateros)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var triangulosEquilatero in triangulosEquilateros)
            {

                cantidad++;
                decimal area = triangulosEquilatero.CalcularArea();
                decimal perimetro = triangulosEquilatero.CalcularPerimetro();


                Console.WriteLine($"------- {TraduccionPortugues.TrianguloEquilatero} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionIngles.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;
            }

            Console.WriteLine($"{TraduccionPortugues.TriangulosEnLista}: {cantidad}\n\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionPortugues.Perimetro}: {totalPerimetro}\n\n");

        }
        #endregion
    }
}
