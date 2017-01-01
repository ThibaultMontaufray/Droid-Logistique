namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class CarDirectPath
    {
        #region Attribute
        private Co2_emission _co2_emission;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "co2_emission")]
        public Co2_emission Co2_emission
        {
            get { return _co2_emission; }
            set { _co2_emission = value; }
        }
        #endregion

        #region Constructor
        public CarDirectPath()
        {
        }
        #endregion
    }
}
