using System;
using MyProject;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class UnitTest1
    {
        ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void UsuarioEMaiorDeIdade()
        {
            // Arrange
            var usuario = new Usuario("José", 50);
            var esperado = true;

            // Act
            var resultado = usuario.MaiorDeIdade();
            _output.WriteLine($"resultado: {resultado}");

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void UsuarioEMenorDeIdade()
        {
            // Arrange
            var usuario = new Usuario("João", 17);
            var esperado = false;

            // Act
            var resultado = usuario.MaiorDeIdade();

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Category", "Sums")]
        public void SumFivePlusTwoIsEqualSeven()
        {
            // Arrange
            var first = 5;
            var second = 2;
            var expected = 7;
            // Act
            var result = first + second;
            // Assert
            _output.WriteLine($"SumFivePlusTwoIsEqualSeven: {first} + {second} = {expected}");
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Sums theories")]
        [Trait("Category", "Sums")]
        [InlineData(1, 1, 2)]
        [InlineData(14, 78, 92)]
        [InlineData(30, 45, 75)]
        [InlineData(7, 12, 19)]
        public void SumFirstPlusSecondIsEqualThird(int first, int second, int expected)
        {
            // Arrange
            // Act
            var result = first + second;
            // Assert
            _output.WriteLine($"SumFirstPlusSecondIsEqualThird: {first} + {second} = {expected}");
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "DivisionByZero not implemented", Skip = "Not implemented")]
        public void DivisionByZero()
        {
            // TODO: Needs to be implemented or
            // HACK: Needs to be implemented or
            // UNDONE: Needs to be implemented
        }
    }
}
