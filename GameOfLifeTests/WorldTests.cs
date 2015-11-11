using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void WorldEnsureICanCreateInstance()
        {
            World my_world = new World();
            Assert.IsNotNull(my_world);
        }
    }
}
