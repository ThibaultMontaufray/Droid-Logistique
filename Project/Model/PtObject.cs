namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class PtObject
    {
        #region Attribute
        private string _embeddedType;
        private Trip _trip;
        private string _quality;
        private string _id;
        private string _name;
        #endregion

        #region Properties
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
        [JsonProperty(PropertyName = "quality")]
        public string Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }
        [JsonProperty(PropertyName = "trip")]
        public Trip Trip
        {
            get { return _trip; }
            set { _trip = value; }
        }
        [JsonProperty(PropertyName = "embedded_type")]
        public string EmbeddedType
        {
            get { return _embeddedType; }
            set { _embeddedType = value; }
        }
        #endregion

        #region Constructor
        public PtObject()
        {

        }
        #endregion
    }
}
