namespace Lab1_test
{
    [TestClass]
    public sealed class BlueTest
    {
        Lab1.Blue main = new Lab1.Blue();

        [TestMethod]
        public void Test1()
        {
            // Arrange
            var input = new int[] { 0, 5, 2, -3, -2, 11, 22, -31, -418 };
            var answer = new bool[] { false, true, false, true, false, true, false, true, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task1(input[i], input[(i + 1) % input.Length]);
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
            var answer = new bool[] { false, true, false, false, false, true, true, true };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task2(input[i]);
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
            var input = new int[] { 0, 5, 2, -1, -3, -2, 11, 22, 11, -418 };
            var answer = new bool[] { true, false, true, false, false, false, false, true, false, false };
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
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { 1.5, 3, 3, 3, -2.3, -2.3, 0.78, 1.5 };
            var test = new double[answer.Length];
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
            var input = new double[] { 0, -0.55, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { 1, 0.45, 1, 1, 0, 0, 1, 0.7 };
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
                { 0, 1.5,   1, 3.9, 5, 1.3, 0.1, 12, 12, 12.34 },
                { 0, 2.3, 3.9,   1, 5, 0.1, 1.3, 14, 18, 34.12 }
            };
            var answer = new bool[] { true, true, true, false, false, false, true, false, true };
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
            var input = new double[] { 0, 1.5, 1, 3, -1, -2.3, 0.78, -0.3 };
            var answer = new double[] { 0, 1, -1, 0, 0, 1, 0, 0 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task7(input[i], input[(i + 1) % input.Length]);
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
                { 0, 1, 8, 1, 3, 3, 30, 30, 33, 33 },
                { 0, 6, 4, 5, 5, 3, 30, 50, 34, 35 },
                { 0, 1, 2, 1, 2, 3, 40, 40, 33, 33 }
            };
            var answer = new bool[] { false, true, false, true, false, true, true, true, false, false };
            var test = new bool[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task8(input[0, i], (int)input[1, i], (int)input[2, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}
