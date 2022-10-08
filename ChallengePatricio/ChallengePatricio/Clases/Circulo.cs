using ChallengePatricio.Abstracciones;
using ChallengePatricio.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.Clases
{
    public class Circulo: FormaGeometrica
    {
        public override decimal _lado { get; set; }

        public Circulo(decimal lado)
        {
            _lado = lado;
        }

        public Circulo()
        {}

        public override decimal CalcularArea()
        {
            try
            {
                return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
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
                return (decimal)Math.PI * _lado;
            }
            catch (Exception)
            {

                throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
            
        }

        public void MostrarCirculoInformacion(List<Circulo> circulos)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var circulo in circulos)
            {

                cantidad++;
                decimal area = circulo.CalcularArea();
                decimal perimetro = circulo.CalcularPerimetro();

                Console.WriteLine($"------- CIRCULO {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"Perimetro: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"Cantidad de Circulos en la lista: {cantidad}\n\n" +
                              $"Area Total: {totalArea}\n" +
                              $"Perimetro Total: {totalPerimetro}\n\n");

        }

        #region Metodos en ingles y portugues
        public void MostrarCirculoInformacionEnIngles(List<Circulo> circulos)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var circulo in circulos)
            {

                cantidad++;
                decimal area = circulo.CalcularArea();
                decimal perimetro = circulo.CalcularPerimetro();

                Console.WriteLine($"------- {TraduccionIngles.Circulo} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionIngles.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"{TraduccionIngles.CirculosEnLista}: {cantidad}\n\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionIngles.Perimetro}: {totalPerimetro}\n\n");
        }

        public void MostrarCirculoInformacionEnPortugues(List<Circulo> circulos)
        {
            int cantidad = 0;
            decimal totalArea = 0;
            decimal totalPerimetro = 0;

            foreach (var circulo in circulos)
            {

                cantidad++;
                decimal area = circulo.CalcularArea();
                decimal perimetro = circulo.CalcularPerimetro();

                Console.WriteLine($"------- {TraduccionPortugues.Circulo} {cantidad} --------\n\n" +
                                  $"Area: {area}\n" +
                                  $"{TraduccionPortugues.Perimetro}: {perimetro}\n\n");

                totalArea += area;
                totalPerimetro += perimetro;

            }

            Console.WriteLine($"{TraduccionPortugues.CirculosEnLista}: {cantidad}\n\n" +
                              $"Total Area: {totalArea}\n" +
                              $"Total {TraduccionPortugues.Perimetro}: {totalPerimetro}\n\n");
        }
        #endregion
    }
}
