namespace Lab1_test
{
    [TestClass]
    public sealed class GreenTest
    {
        Lab1.Green main = new Lab1.Green();

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new bool[] { false, true, true, true, true, true, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task1(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test2()
        {
            // Arrange
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new bool[] { true, true, true, true, false, false, true, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task2(input[i], input[(i + 1) % input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test3()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            var answer = new bool[] { true, true, false, false, true, true, false, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task3(input[i], input[(i + 1) % input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test4()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            var answer = new int[] { 5, 5, 2, 11, 22, 22, 22, 0, 5 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task4(input[i], input[(i + 1) % input.Length], input[(i + 2) % input.Length]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new double[] { 0, 1.5, 1, 0.3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { -1, 0, 0, -0.91, 0, 0, -0.39159999, -0.91 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task5(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], 0.0001);
            }
        }
        [TestMethod]
        public void Test6()
        {
            // Arrange
            var input = new double[,] {
                { 0, 1.5, 1, 1, -1, 0.3, -1, -0.3, 0.78, -0.3 },
                { 0, 2.3, -1, 1, 1, 0.1, 1.23, -0.2, 0.41, 0.69 }
            };
            var answer = new bool[] { true, false, false, false, false, true, false, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task6(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test7()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            var answer = new bool[] { false, true, false, false, false, true, false, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task7(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod]
        public void Test8()
        {
            // Arrange
            var input = new int[,] {
                { 0,   1,  6,  7,  7,  7, 10, 10, 25 },
                { 0, 200, 50, 30, 50, 60, 50, 60, 30 }
            };
            var answer = new bool[] { false, false, false, false, false, true, true, true, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task8(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}
