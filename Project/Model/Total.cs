using Newtonsoft.Json;

namespace Droid_logistique
{
    public class Total
    {
        #region Attribute
        private string _currency;
        private float _value;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "currency")]
        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        [JsonProperty(PropertyName = "value")]
        public float Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region Constructor
        public Total()
        {

        }
        #endregion
    }
}
