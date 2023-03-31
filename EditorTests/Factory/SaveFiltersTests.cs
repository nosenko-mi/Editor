using Microsoft.VisualStudio.TestTools.UnitTesting;
using Editor.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.utils.file;
using System.Windows.Forms;

namespace Editor.Factory.Tests
{
    [TestClass()]
    public class SaveFiltersTests
    {

        private static string filters = SaveFilters.All();
        string[] split = filters.Split('|');


        [TestMethod()]
        public void GetFactoryTestText()
        {
            // Arrange
            int index = 1;

            // Act
            string actual = split[(index - 1) * 2] + "|" + split[(index - 1) * 2 + 1];

            // Assert
            string expected = "Text file (*.txt)|*.txt";
            Assert.AreEqual(expected, actual, $"Filter is not correct:\n expected {expected}\n actual{actual}");
        }

        [TestMethod()]
        public void GetFactoryTestHTML()
        {
            // Arrange
            int index = 2;

            // Act
            string actual = split[(index - 1) * 2] + "|" + split[(index - 1) * 2 + 1];

            // Assert
            string expected = "HTML file (*.html)|*.html";
            Assert.AreEqual(expected, actual, $"Filter is not correct:\n expected {expected}\n actual{actual}");
        }

        [TestMethod()]
        public void GetFactoryTestBin()
        {
            // Arrange
            int index = 3;

            // Act
            string actual = split[(index - 1) * 2] + "|" + split[(index - 1) * 2 + 1];

            // Assert
            string expected = "Binary file (*.bin)|*.bin";
            Assert.AreEqual(expected, actual, $"Filter is not correct:\n expected {expected}\n actual{actual}");
        }
    }
}