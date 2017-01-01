using Newtonsoft.Json;

namespace Droid_logistique
{
    public class WeekPatern
    {
        #region Attribute
        private bool _monday;
        private bool _tuesday;
        private bool _wednesday;
        private bool _thursday;
        private bool _friday;
        private bool _saturday;
        private bool _sunday;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "monday")]
        public bool Monday
        {
            get { return _monday; }
            set { _monday = value; }
        }
        [JsonProperty(PropertyName = "tuesday")]
        public bool Tuesday
        {
            get { return _tuesday; }
            set { _tuesday = value; }
        }
        [JsonProperty(PropertyName = "wednesday")]
        public bool Wednesday
        {
            get { return _wednesday; }
            set { _wednesday = value; }
        }
        [JsonProperty(PropertyName = "thursday")]
        public bool Thursday
        {
            get { return _thursday; }
            set { _thursday = value; }
        }
        [JsonProperty(PropertyName = "friday")]
        public bool Friday
        {
            get { return _friday; }
            set { _friday = value; }
        }
        [JsonProperty(PropertyName = "saturday")]
        public bool Saturday
        {
            get { return _saturday; }
            set { _saturday = value; }
        }
        [JsonProperty(PropertyName = "sunday")]
        public bool Sunday
        {
            get { return _sunday; }
            set { _sunday = value; }
        }
        #endregion

        #region Constructor
        public WeekPatern()
        {

        }
        #endregion
    }
}
