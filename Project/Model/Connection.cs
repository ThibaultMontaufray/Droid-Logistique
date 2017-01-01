namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class Connection
    {
        #region Attribute
        private Origin _origin;
        private int _duration;
        private Destination _destination;
        private int _displayDuration;
        private int _maxDuration;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "max_duration")]
        public int MaxDuration
        {//OCE:SP:TGV-87741769
            get { return _maxDuration; }
            set { _maxDuration = value; }
        }
        [JsonProperty(PropertyName = "display_duration")]
        public int DisplayDuration
        {
            get { return _displayDuration; }
            set { _displayDuration = value; }
        }
        [JsonProperty(PropertyName = "destination")]
        public Destination Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
        [JsonProperty(PropertyName = "duration")]
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        [JsonProperty(PropertyName = "origin")]
        public Origin Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }
        #endregion

        #region Constructor
        public Connection()
        {

        }
        #endregion
    }
}
