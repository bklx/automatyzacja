using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class MathematicsTEST
    {
        [Theory]
        [InlineData(10,20,30)]
        [InlineData(5,5,10)]
        public void TheoryExample(double x, double y, double expected)
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Add(x, y);

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Method_add_returns_add_of_given_values2()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Add(40, -20);

            // assert
            Assert.Equal(20, result);
        }
        [Fact]
        public void Method_add_returns_sub_of_given_values()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Substract(40, -20);

            // assert
            Assert.Equal(60, result);
        }
        [Fact]
        public void Method_add_returns_sub_of_given_values2()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Substract(100, 99);

            // assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Method_add_returns_divide_of_given_values1()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Divide(-10, -10);

            // assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Method_divide_returns__of_given_values2()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Divide(100, 100);

            // assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Method_multiply_returns__of_given_values1()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Multiply(100, -20);

            // assert
            Assert.Equal(-2000, result);
        }
        [Fact]
        public void Method_multiply_returns__of_given_values2()
        {
            // arrange
            var math = new Mathematics();

            // act
            var result = math.Multiply(6, -6);

            // assert
            Assert.Equal(-36, result);
        }
    }
}
