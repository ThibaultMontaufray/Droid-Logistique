namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class DisplayInformation
    {
        #region Attributes
        private string _direction;
        private string _code;
        private string _description;
        private List<Link> _link;
        private string _color;
        private string _physicalMode;
        private string _headSign;
        private string _commercialMode;
        private List<Equipment> _equipments;
        private string _label;
        private string _network;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "network")]
        public string Network
        {
            get { return _network; }
            set { _network = value; }
        }
        [JsonProperty(PropertyName = "label")]
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        [JsonProperty(PropertyName = "equipments")]
        public List<Equipment> Equipments
        {
            get { return _equipments; }
            set { _equipments = value; }
        }
        [JsonProperty(PropertyName = "commercial_mode")]
        public string CommercialMode
        {
            get { return _commercialMode; }
            set { _commercialMode = value; }
        }
        [JsonProperty(PropertyName = "headsign")]
        public string HeadSign
        {
            get { return _headSign; }
            set { _headSign = value; }
        }
        [JsonProperty(PropertyName = "physical_mode")]
        public string PhysicalMode
        {
            get { return _physicalMode; }
            set { _physicalMode = value; }
        }
        [JsonProperty(PropertyName = "color")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Link
        {
            get { return _link; }
            set { _link = value; }
        }
        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        [JsonProperty(PropertyName = "code")]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        [JsonProperty(PropertyName = "direction")]
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        #endregion

        #region Constructor
        public DisplayInformation()
        {
            _link = new List<Link>();
            _equipments = new List<Equipment>();
        }
        #endregion
    }
}
