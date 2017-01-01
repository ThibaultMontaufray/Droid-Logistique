namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class Code
    {
        #region Attribute
        private string _type;
        private string _value;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "value")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion

        #region Constructor
        public Code()
        {

        }
        #endregion
    }
}