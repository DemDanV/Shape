using Xunit;
using Shape;
using System;

namespace Shape.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_CalculateArea_ReturnsCorrectResult()
        {
            // Arrange
            double radius = 5;
            IShape circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * radius * radius, area, 5);
        }

        [Fact]
        public void Triangle_CalculateArea_ReturnsCorrectResult()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            IShape triangle = new Triangle(a, b, c);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area, 5); // Площадь должна быть 6
        }

        [Fact]
        public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 6);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRight);
        }
    }
}