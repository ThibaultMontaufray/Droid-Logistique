namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class ApplicationPeriod
    {
        #region Attribute
        private string _begin;
        private string _end;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "end")]
        public string End
        {
            get { return _end; }
            set { _end = value; }
        }
        [JsonProperty(PropertyName = "begin")]
        public string Begin
        {
            get { return _begin; }
            set { _begin = value; }
        }
        #endregion

        #region Constructor
        public ApplicationPeriod()
        {

        }
        #endregion
    }
}
