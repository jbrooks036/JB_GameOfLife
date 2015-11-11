using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class BoundedWorldTests
    {
        [TestMethod]
        public void BoundedWorldEnsureICanCreateInstance()
        {
            BoundedWorld my_world = new BoundedWorld();
            Assert.IsNotNull(my_world);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            /* Arrage */
            int height = 80;
            int width = 80;

            /* Act */
            BoundedWorld my_world = new BoundedWorld(width, height);

            /* Assert */
            Assert.IsNotNull(my_world);
        }

        [TestMethod]
        public void BoundedWorldEnsureIHaveArrayOfCorrectSize()
        {
            // Arrange
            int height = 80;
            int width = 80;

            // Act
            BoundedWorld my_world = new BoundedWorld(width, height);
            int expected_height = height;
            int expected_width = width;

            int actual_height = my_world.Height;
            int actual_width = my_world.Width;

            // Assert
            Assert.AreEqual(expected_height, actual_height);
            Assert.AreEqual(expected_width, actual_width);

        }

        [TestMethod]
        public void BoundedWorldEnsureWorldHasCells()
        {
            // Arrange
            int height = 100;
            int width = 100;
            BoundedWorld my_world = new BoundedWorld(width, height);

            // Act
            int expected_number_of_dead_cells = 10000;
            int expected_number_of_alive_cells = 0;
            int actual_number_of_dead_cells = my_world.DeadCellCount();
            int actual_number_of_alive_cells = my_world.AliveCellCount();

            // Assert
            Assert.AreEqual(expected_number_of_dead_cells, actual_number_of_dead_cells);
            Assert.AreEqual(expected_number_of_alive_cells, actual_number_of_alive_cells);

        }

        [TestMethod]
        public void BoundedWorldEnsureThereAreCells()
        {
            // Arrange
            int width = 80;
            int height = 80;
            BoundedWorld my_world = new BoundedWorld(width, height);

            // Act
            int x = 4;
            int y = 3;
            my_world.AddCell(x,y);

            // Assert
            Assert.AreEqual(1, my_world.AliveCellCount());
        }

        [TestMethod]
        public void BoundedWorldApplyUnderPopulationToOneCell()
        {
            // Arrange
            BoundedWorld my_world = new BoundedWorld(10, 10);
            my_world.AddCell(4, 5);

            // Act
            my_world.UnderPopulationRule();

            // Assert
            Assert.AreEqual(0, my_world.AliveCellCount());
        }

        [TestMethod]
        public void BoundedWorldEnsureThereAreZeroLiveNeighbors()
        {
            // Arrange
            BoundedWorld my_world = new BoundedWorld(10, 10);

            // Act
            int expected_alive_neighbors = 0;
            int actual_alive_neighbors = my_world.AliveNeighborCount(4,5);

            // Assert
            Assert.AreEqual(expected_alive_neighbors, my_world.AliveCellCount());
        }
    }
}
