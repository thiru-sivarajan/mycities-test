using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCityInfo.API.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public  List<CityModel> Cities = new List<CityModel>();

        public CitiesDataStore()
        {
            Cities.Add(new CityModel() { Id = 1, Decription = "The Garden City" });
            Cities.Add(new CityModel() { Id = 2, Name = "Chennai", Decription = "One of the best cities in India" });
        }
    }
}
