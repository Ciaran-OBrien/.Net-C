using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_API_Paser
{
    interface IConstruct
    {
        string getUserMovieTitle();
        void setUserMovieTitle(string setMovie);
        void setURL();
        void SaveToFile(List<RootObject> userPulledData);
    }
}
