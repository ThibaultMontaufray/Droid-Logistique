using Newtonsoft.Json;

namespace Droid_logistique
{
    public class Duration
    {
        #region Attribute
        private int _walking;
        private int _total;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "walking")]
        public int Walking
        {
            get { return _walking; }
            set { _walking = value; }
        }
        [JsonProperty(PropertyName = "total")]
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
        #endregion

        #region Constructor
        public Duration()
        {

        }
        #endregion
    }
}
