namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Date
    {
        #region Attributes
        private string _arrival;
        private string _departure;
        private List<Link> _link;
        private List<string> _info;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "arrival_date_time")]
        public string Arrival
        {
            get { return _arrival; }
            set { _arrival = value; }
        }
        [JsonProperty(PropertyName = "departure_date_time")]
        public string Departure
        {
            get { return _departure; }
            set { _departure = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Link
        {
            get { return _link; }
            set { _link = value; }
        }
        [JsonProperty(PropertyName = "additionnal_inforamtions")]
        public List<string> Information
        {
            get { return _info; }
            set { _info = value; }
        }
        #endregion

        #region Constructor
        public Date()
        {
            _link = new List<Link>();
            _info = new List<string>();
        }
        #endregion
    }
}
