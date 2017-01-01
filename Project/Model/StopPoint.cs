namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class StopPoint
    {
        #region Attribute
        private Dictionary<string, string> _code;
        private string _name;
        private string _link;
        private Coord _coord;
        private string _label;
        private string _id;
        private List<Region> _administrative_region;
        private List<Equipment> _equipments;
        private StopArea _stopArea;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "code")]
        public Dictionary<string, string> Code
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
        [JsonProperty(PropertyName = "link")]
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }
        [JsonProperty(PropertyName = "coord")]
        public Coord Coord
        {
            get { return _coord; }
            set { _coord = value; }
        }
        [JsonProperty(PropertyName = "label")]
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "administrative_regions")]
        public List<Region> AdministrativeRegion
        {
            get { return _administrative_region; }
            set { _administrative_region = value; }
        }
        [JsonProperty(PropertyName = "equipments")]
        public List<Equipment> Equipments
        {
            get { return _equipments; }
            set { _equipments = value; }
        }
        [JsonProperty(PropertyName = "stop_area")]
        public StopArea StopArea
        {
            get { return _stopArea; }
            set { _stopArea = value; }
        }
        #endregion

        #region Constructor
        public StopPoint()
        {
            _administrative_region = new List<Region>();
            _equipments = new List<Equipment>();
        }
        #endregion
    }
}
