using ImageModification.BLL;
using ImageModification.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageModificationTests
{
    /// <summary>
    /// InputOutputTest unit test class to test the methods of the InputOutput class
    /// </summary>
    [TestClass]
    public class InputOutputTest
    {

        /// <summary>
        /// CompareBitmap to compare images
        /// </summary>
        private CompareBitmap comparatorBitmap = new CompareBitmap();

        /// <summary>
        /// InputOutput interface that is substituted 
        /// </summary>
        private IInputOutput inputOutput = Substitute.For<IInputOutput>();

        /// <summary>
        /// InputOutput class
        /// </summary>
        private InputOutput inputOutputClass = new InputOutput();


        /// <summary>
        /// Load image test
        /// </summary>
        [TestMethod]
        public void LoadImageTest()
        {
            Bitmap imageToLoad = Properties.Resources.penguins;

        }

    }
}
