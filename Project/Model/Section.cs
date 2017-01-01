using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Droid_logistique
{
    public class Section    
    {
        #region Attribute
        private Destination _from;
        private List<Link> _links;
        private string _arrival_date_time;
        private Co2_emission _co2_emission;
        private Destination _to;
        private string _departure_date_time;
        private int _duration;
        private string _type;
        private string _id;
        private string _mode;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "from")]
        public Destination From
        {
            get { return _from; }
            set { _from = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }
        [JsonProperty(PropertyName = "arrival_date_time")]
        public string Arrival_date_time
        {
            get { return _arrival_date_time; }
            set { _arrival_date_time = value; }
        }
        [JsonProperty(PropertyName = "co2_emission")]
        public Co2_emission Co2_emission
        {
            get { return _co2_emission; }
            set { _co2_emission = value; }
        }
        [JsonProperty(PropertyName = "to")]
        public Destination To
        {
            get { return _to; }
            set { _to = value; }
        }
        [JsonProperty(PropertyName = "departure_date_time")]
        public string Departure_date_time
        {
            get { return _departure_date_time; }
            set { _departure_date_time = value; }
        }
        [JsonProperty(PropertyName = "duration")]
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "mode")]
        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        #endregion

        #region Constructor
        public Section()
        {

        }
        #endregion
    }
}
