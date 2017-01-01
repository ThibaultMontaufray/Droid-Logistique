namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class GeoJson
    {
        #region Attribute
        private string _type;
        private KeyValuePair<double, double> _coord;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [JsonProperty(PropertyName = "coordinates")]
        public KeyValuePair<double, double> Coord
        {
            get { return _coord; }
            set { _coord = value; }
        }
        #endregion

        #region Constructor
        public GeoJson()
        {

        }
        #endregion
    }
}
