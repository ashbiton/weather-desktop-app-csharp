using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;

namespace DAL
{
    public class WeatherDAL
    {
        public class TempData
        {
            public ForcastObject.RootObject _root;
            public ForcastObject.City _city;
            public List<ForcastObject.List> _list;
        }
        public class InfoWeatherContext : DbContext
        {
            public DbSet<ForcastObject.RootObject> ForcastWeatherData { get; set; }
            public DbSet<TodayObject._RootObject> CurrentWeatherData { get; set; }
        }

        public WeatherDAL()
        {
            getForcastDataByCity("Jerusalem");
        }


        public TodayObject._RootObject getNowWeather(string city)
        {
            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(
                "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&APPID=542ffd081e67f4512b705f89d2a611b2&units=metric"));

                WebReq.Method = "GET";

                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                string jsonString;
                using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }

                TodayObject._RootObject rootObject = JsonConvert.DeserializeObject<TodayObject._RootObject>(jsonString);
                UpdateCurrentDB(rootObject);
                rootObject.main.temp = Convert.ToInt32(rootObject.main.temp);
                return rootObject;

            }
            catch (WebException)
            {
                using (var db = new InfoWeatherContext())
                {
                    var result =
                        (from curr in db.CurrentWeatherData
                         where curr.name.Equals(city)
                         select curr).FirstOrDefault();
                    return (TodayObject._RootObject)result;

                }
            }
        }

        private void UpdateCurrentDB(TodayObject._RootObject rootObject)
        {
            using (var db = new InfoWeatherContext())
            {
                var result =
                    (from curr in db.CurrentWeatherData
                     where curr.name.Equals(rootObject.name)
                     select curr).FirstOrDefault();
                if (result != null)
                {
                    db.Entry(result).CurrentValues.SetValues(rootObject);
                }
                else
                {
                    db.CurrentWeatherData.Add(rootObject);
                }

                db.SaveChanges();
            }
        }

        public ForcastObject.RootObject getForcastDataByCity(string city)
        {

            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(
                "http://api.openweathermap.org/data/2.5/forecast?q=" + city + ",il&mode=json&units=metric&appid=542ffd081e67f4512b705f89d2a611b2"));

                WebReq.Method = "GET";

                HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

                string jsonString;
                using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }

                ForcastObject.RootObject rootObject = JsonConvert.DeserializeObject<ForcastObject.RootObject>(jsonString);
                rootObject.setKeyValues();
                UpdateForcastDB(rootObject);
                return rootObject;

            }
            catch (WebException)
            {
                using (var db = new InfoWeatherContext())
                {
                    var result =
                        (from curr in db.ForcastWeatherData
                         where curr.key_id.Equals(city)
                         select new TempData
                         {
                             _root = curr,
                             _city = curr.city,
                             _list = curr.list,
                         }).FirstOrDefault();

                    ForcastObject.RootObject rootObject = result._root;
                    rootObject.list = result._list;
                    rootObject.city = result._city;
                    var _weather = (from curr in db.ForcastWeatherData
                                     where curr.key_id.Equals(city)
                                     select (
                                     from i in curr.list
                                     select i.weather
                                     )).FirstOrDefault();
                   rootObject.list[0].weather = _weather.ElementAt(0);

                    return rootObject;

                }
            }

        }

        private void UpdateForcastDB(ForcastObject.RootObject rootObject)
        {
            using (var db = new InfoWeatherContext())
            {
                var exist =
                    (from info in db.ForcastWeatherData
                     where info.key_id.Equals(rootObject.key_id)
                     select info).FirstOrDefault();
                if (exist != null)
                {
                    db.Entry(exist).CurrentValues.SetValues(rootObject);
                }
                else
                {
                    db.ForcastWeatherData.Add(rootObject);
                }
                db.SaveChanges();

            }
        }
    }
}


