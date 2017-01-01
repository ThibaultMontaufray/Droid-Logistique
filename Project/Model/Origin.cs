namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Origin
    {
        #region Attribute
        private List<Code> _code;
        private string _name;
        private List<string> _links;
        private Coord _coord;
        private string _label;
        private Equipment _equipment;
        private string _id;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "equipment")]
        public Equipment Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }
        [JsonProperty(PropertyName = "label")]
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        [JsonProperty(PropertyName = "coord")]
        public Coord Coord
        {
            get { return _coord; }
            set { _coord = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<string> Links
        {
            get { return _links; }
            set { _links = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "codes")]
        public List<Code> Code
        {
            get { return _code; }
            set { _code = value; }
        }
        #endregion

        #region Constructor
        public Origin()
        {
            _links = new List<string>();
            _code = new List<Code>();
        }
        #endregion
    }
}
