using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class UnboundedWorldTests
    {
        [TestMethod]
        public void UnboundedWorldEnsureICanCreateInstance()
        {
            UnboundedWorld my_world = new UnboundedWorld();
            Assert.IsNotNull(my_world);
        }

        [TestMethod]
        public void UnboundedWorldEnsureTheWorldHasZeroCells()
        {
            // Arrange
            UnboundedWorld my_world = new UnboundedWorld();

            // Act
            int expected_number_of_cells = 0;
            int actual_number_of_cells = my_world.CellCount();

            // Assert
            Assert.AreEqual(expected_number_of_cells, actual_number_of_cells);
        }

        [TestMethod]
        public void UnboundedWorldEnsureThereAreCells()
        {
            // Arrange
            UnboundedWorld my_world = new UnboundedWorld();

            // Act
            int x = 4;
            int y = 3;
            my_world.AddCell(x,y);

            // Assert
            Assert.AreEqual(1, my_world.CellCount());
        }
    }
}
