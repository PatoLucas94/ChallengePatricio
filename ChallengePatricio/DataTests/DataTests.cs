using ChallengePatricio.Aplicaciones;
using ChallengePatricio.BaseDeDatos;
using ChallengePatricio.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestListaCompleta()
        {
            // Arrange
            Listas lista = new Listas();

            // Act
            List<Cuadrado> listaCuadrados = lista.listaCuadrados();

            // Assert
            NUnit.Framework.Assert.IsTrue(listaCuadrados.Count() > 0);
        }

        [TestCase]
        public void TestCirculoCalcularArea()
        {
            // Arrange
            Circulo circulo = new Circulo(8);
            decimal lado = Convert.ToDecimal(8);

            // Act
            decimal areaCirculo = circulo.CalcularArea();
            decimal areaEjemplo = (decimal)Math.PI * (lado / 2) * (lado / 2);

            // Assert
            NUnit.Framework.Assert.AreEqual(areaCirculo, areaEjemplo);
        }

        [TestCase]
        public void TestCirculoCalcularPerimetro()
        {
            // Arrange
            Circulo circulo = new Circulo(8);
            decimal lado = Convert.ToDecimal(8);

            // Act
            decimal perimetroCirculo = circulo.CalcularPerimetro();
            decimal perimetroEjemplo = (decimal)Math.PI * lado;

            // Assert
            NUnit.Framework.Assert.AreEqual(perimetroCirculo, perimetroEjemplo);
        }

    }
}
