namespace TriTest
{
    public class Tests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Trianglesana.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // // Arrange
            int firstAngle = 90;
            int secondAngle = 45;
            int thirdAngle = 45;
            // Act
            string result = Trianglesana.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreNotEqual("The triangle is invalid.", result);
        }

        [Test]
        public void ValidTriangle_InvalidInput_ReturnstoinvalidMessage()
        {
            // // Arrange
            int firstAngle = 100;
            int secondAngle = 40;
            int thirdAngle = 40;
            // Act
            string result = Trianglesana.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreNotEqual("The triangle is invalid.", result);
        }
        [Test]
        public void ValidTriangle_validInput_ReturnsisvalidMessage()
        {
            // // Arrange
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 0;
            // Act
            string result = Trianglesana.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_validInput_ReturnsvalidMessage()
        {
            // // Arrange
            int firstAngle = 120;
            int secondAngle = 60;
            int thirdAngle = 10;
            // Act
            string result = Trianglesana.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

    }


}





