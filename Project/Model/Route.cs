namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Route
    {
        #region Attributes
        private Direction _directions;
        private Dictionary<string, string> _code;
        private string _name;
        private List<Link> _links;
        private bool _isFrequence;
        private GeoJson _geoJson;
        private string _type;
        private Line _line;
        private string _id;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "code")]
        public Dictionary<string, string> Code
        {
            get { return _code; }
            set { _code = value; }
        }
        [JsonProperty(PropertyName = "direction")]
        public Direction Directions
        {
            get { return _directions; }
            set { _directions = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }
        [JsonProperty(PropertyName = "is_frequence")]
        public bool IsFrequence
        {
            get { return _isFrequence; }
            set { _isFrequence = value; }
        }
        [JsonProperty(PropertyName = "geojson")]
        public GeoJson GeoJson
        {
            get { return _geoJson; }
            set { _geoJson = value; }
        }
        [JsonProperty(PropertyName = "direction_type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [JsonProperty(PropertyName = "line")]
        public Line Line
        {
            get { return _line; }
            set { _line = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public Route()
        {
            _links = new List<Link>();
        }
        #endregion
    }
}
