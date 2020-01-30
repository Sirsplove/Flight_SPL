using System;

namespace Flight_SPL
{
    public class City
    {

        private readonly String name;
        private readonly double latitude;
        private readonly double longitude;

        private City()
        {
            name = "";
            latitude = 0.0;
            longitude = 0.0;
        }

        public City(String name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public String getName()
        {
            return name;
        }

        public double getLatitude()
        {
            return latitude;
        }

        public double getLongitude()
        {
            return longitude;
        }


        public override String ToString()
        {
            return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
        }
    }
}