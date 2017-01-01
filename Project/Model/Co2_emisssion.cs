using Newtonsoft.Json;

namespace Droid_logistique
{
    public class Co2_emission
    {
        #region Attribute
        private float _value;
        private string _unit;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "value")]
        public float Value
        {
            get { return _value; }
            set { _value = value; }
        }
        [JsonProperty(PropertyName = "unit")]
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        #endregion

        #region Constructor
        public Co2_emission()
        {

        }
        #endregion
    }
}
