namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Line
    {
        #region Attribute
        private string _code;
        private string _name;
        private List<Link> _link;
        private string _color;
        private GeoJson _geoJson;
        private string _textColor;
        private List<Code> _codes;
        private string _closingTime;
        private string _openingTime;
        private string _id;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "code")]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Link
        {
            get { return _link; }
            set { _link = value; }
        }
        [JsonProperty(PropertyName = "color")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        [JsonProperty(PropertyName = "geojson")]
        public GeoJson GeoJson
        {
            get { return _geoJson; }
            set { _geoJson = value; }
        }
        [JsonProperty(PropertyName = "text_color")]
        public string TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }
        [JsonProperty(PropertyName = "codes")]
        public List<Code> Codes
        {
            get { return _codes; }
            set { _codes = value; }
        }
        [JsonProperty(PropertyName = "opening_time")]
        public string OpeningTime
        {
            get { return _openingTime; }
            set { _openingTime = value; }
        }
        [JsonProperty(PropertyName = "closing_time")]
        public string ClosingTime
        {
            get { return _closingTime; }
            set { _closingTime = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public Line()
        {
            _link = new List<Link>();
            _codes = new List<Code>();
        }
        #endregion
    }
}
