using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    public class ForcastObject
    {
        public class _Main
        {
            public double temp { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double sea_level { get; set; }
            public double grnd_level { get; set; }
            public int humidity { get; set; }
            public double temp_kf { get; set; }
        }

        public class _Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class _Clouds
        {
            public int all { get; set; }
        }

        public class _Wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
        }

        public class _Sys
        {
            public string pod { get; set; }
        }

        public class List
        {
            [Key]
            [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
            public int _id { get; set; }
            public int dt { get; set; }
            public _Main main { get; set; }
            public List<_Weather> weather { get; set; }
            public _Clouds clouds { get; set; }
            public _Wind wind { get; set; }
            public _Sys sys { get; set; }
            public string dt_txt { get; set; }
        }

        public class _Coord
        {
            public double lat { get; set; }
            public double lon { get; set; }
        }

        public class City
        {
            public int id { get; set; }
            [Key]
            public string name { get; set; }
            public _Coord coord { get; set; }
            public string country { get; set; }
            public int population { get; set; }
        }

        public class RootObject
        {
            [Key]
            public string key_id { get; set; }
            public City city { get; set; }
            public string cod { get; set; }
            public double message { get; set; }
            public int cnt { get; set; }
            public List<List> list { get; set; }

            public RootObject()
            {
                setKeyValues();
            }

            public void setKeyValues()
            {
                if (city != null)
                {
                    key_id = city.name;
                }
            }

        }

    }
}
