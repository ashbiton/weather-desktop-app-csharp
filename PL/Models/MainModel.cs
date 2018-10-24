using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PL.Models
{
    public class MainModel
    {
        public MainModel()
        {
            
        }

        public BL.WeatherBL getModel()
        {
            return new BL.WeatherBL();
        }

        public string[] getListOfCities()
        {
            string[] cities = { "Jerusalem", "Tel Aviv", "Haifa", "Beer Sheva", "Zefat", "Tiberias" , "Ashdod" , "Mitzpe Ramon" , "Netanya" ,
            "Ashkelon" , "Lod" , "Afula" , "Katzrin" , "Ein Gedi" };
            return cities;
        }
    }
}
