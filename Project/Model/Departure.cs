namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Departure
    {
        #region Attribute
        private DisplayInformation _displayInformation;
        private StopPoint _stopPoint;
        private Route _route;
        private Date _date;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "display_informations")]
        public DisplayInformation DisplayInformation
        {
            get { return _displayInformation; }
            set { _displayInformation = value; }
        }
        [JsonProperty(PropertyName = "stop_point")]
        public StopPoint StopPoint
        {
            get { return _stopPoint; }
            set { _stopPoint = value; }
        }
        [JsonProperty(PropertyName = "route")]
        public Route Route
        {
            get { return _route; }
            set { _route = value; }
        }
        [JsonProperty(PropertyName = "stop_date_time")]
        public Date Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region Constructor
        public Departure()
        {
        }
        #endregion
    }
}
