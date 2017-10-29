using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;

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

    public class ReadAndWriteLines {

        public string userMovieChoice = "";

        public void menu() {
            int userChoice;
            Console.WriteLine("Please choose an options:" +
                "\n1. Search by movie title");
            userChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + userChoice);


            switch (userChoice)
            {
                case 1:
                    setUserMovieTitle();
                    break;
                default:
                    break;
            }
        }

        public void setUserMovieTitle()
        {
            var load = new Loader();
            var parser = new JSONParser();
            Console.WriteLine("\nPlease enter the tiltle of the movie you are looking for\n");
            userMovieChoice = Console.In.ReadLine();

            Console.WriteLine("\nYou entered: " + this.userMovieChoice);

            
            load.setURL();
            parser.Load();
            

        }
        public string getUserMovieTitle() => this.userMovieChoice;
    }




    public class JSONParser 
    {
        public void Load()
        {
            var loader = new Loader();
            var load = JsonConvert.DeserializeObject<RootObject>(loader.GetTestObjects().Result);
            Console.WriteLine("\n\n Hey hey, here's some details about that movie !\n\n");
            Console.WriteLine("\nTitle: " + load.results[0].title);
            Console.WriteLine("\nPopularity: " + load.results[0].popularity);
            Console.WriteLine("\nRelease Date: " + load.results[0].release_date);
        }
    }

    public class Loader 
    {
  

        public string url ="";

        //public string url = "https://api.themoviedb.org/3/movie/550?api_key=d8c52a74451cfcc5a2637148713e11be";
        public void setURL()
        {
            var details = new ReadAndWriteLines();
            Console.WriteLine("getUSerMOvieTitle: " + details.getUserMovieTitle());
            url = "https://api.themoviedb.org/3/search/movie?api_key=d8c52a74451cfcc5a2637148713e11be&query=" + details.getUserMovieTitle();
            Console.WriteLine("The URL is now set to: " + url);
        }
        


        public async Task <String> GetTestObjects()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }


    public class RootObject 
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<Result> results { get; set; }
    }
 
    public class Result 
    {
        public int vote_count { get; set; }
        public int id { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public string title { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<object> genre_ids { get; set; }
        public string backdrop_path { get; set; }
        public bool adult { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
    }

}
