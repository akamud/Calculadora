using NUnit.Framework;
using System;

namespace Calculadora.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void SomaValores()
        {
            var calculadora = new Calculadora();

            var valorSomado = calculadora.Soma(11, 31);

            Assert.AreEqual(42, valorSomado);
        }

        [Test]
        public void DivideValores()
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Divide(15, 5);

            Assert.AreEqual(3, resultado);
        }
    }
}
