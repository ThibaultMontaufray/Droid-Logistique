using Newtonsoft.Json;

namespace Droid_logistique
{
    public class Coord
    {
        #region Attribute
        private double _lat;
        private double _lon;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "lon")]
        public double Lon
        {
            get { return _lon; }
            set { _lon = value; }
        }
        [JsonProperty(PropertyName = "lat")]
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        #endregion

        #region Constructor
        public Coord()
        {

        }
        #endregion
    }
}

