using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSON_API_Paser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_API_Paser.Tests
{
    [TestClass()]
    public class ReadAndWriteLinesTests
    {
        [TestMethod()]
        public void getUserMovieTitleTest()
        {
            String exspectedMovieName = "Fight Club";

            ReadAndWriteLines testingObject = new ReadAndWriteLines();
            testingObject.setUserMovieTitle(exspectedMovieName);

            String actualMovieName = testingObject.getUserMovieTitle();

            Assert.AreEqual(exspectedMovieName,actualMovieName,"The movie title has been correctly set");

        }
    }
}