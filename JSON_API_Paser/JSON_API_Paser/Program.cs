using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Linq;
using System.IO;

namespace JSON_API_Paser
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var consoleData = new ReadAndWriteLines();
            consoleData.menu();
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }

    }

    public class ReadAndWriteLines : IConstruct{
        
        public string userMovieChoice = "";
        public string url = "";

        // TODO Change to IList 
        List<RootObject> pulledData = new List<RootObject>();
        List<string> errors = new List<string>();

        public List<RootObject> PulledData { get; private set; }

        /// <summary>
        /// A menu of sorts.
        /// The logic co-ordination of the application
        /// </summary>
        public void menu() {
            int userChoice;
            Console.WriteLine("Please choose an options:" +
                "\n1. Search by movie title");
            userChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + userChoice);


            switch (userChoice)
            {
                case 1:
                    
                    Console.WriteLine("\nPlease enter the tiltle of the movie you are looking for\n");
                    userMovieChoice = Console.In.ReadLine();
                    setUserMovieTitle(userMovieChoice);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Using asyncronous process, the url is requested upon the awaited thread 
        /// </summary>
        /// <returns>Result which a string array of JSON data.</returns>
        public async Task<string> GetTestObjects()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        /// <summary>
        /// Output of the JSON data from a list of type <RootObject>
        /// </summary>
        public void ShowLINQ() {
            PulledData = BuildList();
            Console.WriteLine("Search results, ,in alphabetical order:\n");
            // Ltest comn=ment
            // LINQ Concept 
            var subset = from theData in PulledData
                         orderby theData.title
                         select theData;
            foreach (RootObject theData in subset) {
                Console.WriteLine("\n\nTitle: " + theData.title + "\tRelease Data: " + theData.release_date + "\tPopularity: " + theData.popularity);
            }
            SaveToFile(PulledData);
        }
        
        /// <summary>
        /// Populates the list from the string data returned after the async and wait method
        /// </summary>
        /// <returns>Describe return value.</returns>
        public List<RootObject> BuildList()
        {
            List<RootObject> parse = new List<RootObject>();
            var load = JsonConvert.DeserializeObject<RootObject>(GetTestObjects().Result, Log());
            Console.WriteLine("\n\n Hey hey, here's some details about that search !\n\n");
                foreach (var data in load.results) { 
                
                        parse.Add(new RootObject() {title = data.title, popularity = data.popularity, release_date = data.release_date});
                }
                return parse;
        }

        /// <summary>
        /// Movie Choice getter
        /// </summary>
        /// <returns>userMovieChoice</returns>
        public string getUserMovieTitle()
        {
            return userMovieChoice;

        }

        /// <summary>
        /// Ask and set user's movie Choice
        /// </summary>
        public void setUserMovieTitle(string setMovie)
        {
            userMovieChoice = setMovie;
            setURL();
            ShowLINQ();
        }

        /// <summary>
        /// Setting the url for the API call
        /// </summary>
        public void setURL()
        {
            url = "https://api.themoviedb.org/3/search/movie?api_key=d8c52a74451cfcc5a2637148713e11be&query=" + getUserMovieTitle();
        }
        
        /// <summary>
        /// Custom logging for JSON.NET deserailization
        /// log catching from JSON.net source code
        /// </summary>
        public JsonSerializerSettings Log()
        {

            var log = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Error = (sender, args) =>
                {
                    args.ErrorContext.Handled = true;
                }
            };


            return log;
        }

        /// <summary>
        /// Serialization of pulled JSON data into a .json file
        /// /// <param name="userPulledData">List of type RootObject</param>
        /// </summary>
        public void SaveToFile(List<RootObject> userPulledData)
        {
            string output = JsonConvert.SerializeObject(userPulledData, Formatting.Indented);

            using (StreamWriter writetext = new StreamWriter("results.json"))
            {
                writetext.WriteLine(output);
            }
        }
    }

    /// <summary>
    /// The below code was generated with the aid of https://quicktype.io
    /// Data mapping the JSON code pulled from API
    /// </summary>
    public class RootObject : Result
    {
        [JsonProperty(PropertyName = "page")]
        public int page { get; set; }
        [JsonProperty(PropertyName = "total_results")]
        public int total_results { get; set; }
        [JsonProperty(PropertyName = "total_pages")]
        public int total_pages { get; set; }
        [JsonProperty(PropertyName = "results")]
        public List<Result> results { get; set; }
    }
 
    public class Result 
    {
        [JsonProperty(PropertyName = "vote_count")]
        public int vote_count { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }
        [JsonProperty(PropertyName = "video")]
        public bool video { get; set; }
        [JsonProperty(PropertyName = "vote_average")]
        public double vote_average { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }
        [JsonProperty(PropertyName = "popularity")]
        public double popularity { get; set; }
        [JsonProperty(PropertyName = "resultsposter_path")]
        public string poster_path { get; set; }
        [JsonProperty(PropertyName = "original_language")]
        public string original_language { get; set; }
        [JsonProperty(PropertyName = "original_title")]
        public string original_title { get; set; }
        [JsonProperty(PropertyName = "genre_ids")]
        public List<object> genre_ids { get; set; }
        [JsonProperty(PropertyName = "backdrop_path")]
        public string backdrop_path { get; set; }
        [JsonProperty(PropertyName = "adult")]
        public bool adult { get; set; }
        [JsonProperty(PropertyName = "overview")]
        public string overview { get; set; }
        [JsonProperty(PropertyName = "rearelease_date")]
        public string release_date { get; set; }
    }

    
}
