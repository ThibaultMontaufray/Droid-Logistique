namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class Context
    {
        #region Attribute
        private CarDirectPath _car_direct_path;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "car_direct_path")]
        public CarDirectPath Car_direct_path
        {
            get { return _car_direct_path; }
            set { _car_direct_path = value; }
        }
        #endregion

        #region Constructor
        public Context()
        {
        }
        #endregion
    }
}
