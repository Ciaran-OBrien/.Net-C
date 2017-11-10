using JSON_API_Paser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Parser_Tests
{
    [TestClass]
    public class JsonParserTests
    {
        // Public object used for runnging the program's methods in the test methods below
        ReadAndWriteLines testings = new ReadAndWriteLines();

        /// <summary>
        /// Quick test of setting the user's movieChoice
        /// Sample data used, "Fight Club"
        /// </summary>
        [TestMethod]
        public void MovieSetTesting()
        {
            string exspectedMovieName = "Fight Club";
            
            testings.setUserMovieTitle(exspectedMovieName);

            string actual = testings.getUserMovieTitle();

            Assert.AreEqual(exspectedMovieName,actual,"Testing movie name succesful");

        }

        /// <summary>
        /// Testing the async and wait aspect of program
        /// </summary>
        [TestMethod]
        public void AsyncTest()
        {
            Task<string> actualList;
            actualList = testings.GetTestObjects();

            Assert.AreNotEqual(null, actualList,"Json String List succesffuly created");
        }

        /// <summary>
        ///  Testing of my custom logging method for JSON serialization
        /// </summary>
        [TestMethod]
        public void CustomJSONLogTest() {
            var actualLog = new JsonSerializerSettings();

            Assert.AreNotEqual(null,actualLog,"Custom Log file created succesfully");

        }
    }
}
