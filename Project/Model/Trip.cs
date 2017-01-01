namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class Trip
    {
        #region Attribute
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
        #endregion

        #region Constructor
        public Trip()
        {

        }
        #endregion
    }
}
