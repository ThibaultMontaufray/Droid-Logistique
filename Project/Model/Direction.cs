namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Direction
    {
        #region Attributes
        private string _type;
        private int _quality;
        private StopArea _stopArea;
        private string _name;
        private string _id;

        #endregion

        #region Properties
        [JsonProperty(PropertyName = "stop_area")]
        public StopArea StopArea
        {
            get { return _stopArea; }
            set { _stopArea = value; }
        }
        [JsonProperty(PropertyName = "quality")]
        public int Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }
        [JsonProperty(PropertyName = "embedded_type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public Direction()
        {
        }
        #endregion
    }
}
