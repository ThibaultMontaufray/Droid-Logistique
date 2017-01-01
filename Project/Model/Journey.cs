using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Droid_logistique
{
    public class Journey
    {
        #region Attribute
        private Fare _fare;
        private string _status;
        private string[] _tag;
        private int _nb_transfert;
        private Duration _durations;
        private string _arrival_date_time;
        private List<Calendar> _calendars;
        private string _departure_date_time;
        private string _requested_date_time;
        private List<Section> _sections;
        private Co2_emission _co2_emission;
        private int _duration;
        private string _type;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "fare")]
        public Fare Fare
        {
            get { return _fare; }
            set { _fare = value; }
        }
        [JsonProperty(PropertyName = "status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        [JsonProperty(PropertyName = "tag")]
        public string[] Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        [JsonProperty(PropertyName = "nb_transfert")]
        public int Nb_transfert
        {
            get { return _nb_transfert; }
            set { _nb_transfert = value; }
        }
        [JsonProperty(PropertyName = "durations")]
        public Duration Durations
        {
            get { return _durations; }
            set { _durations = value; }
        }
        [JsonProperty(PropertyName = "arrival_date_time")]
        public string Arrival_date_time
        {
            get { return _arrival_date_time; }
            set { _arrival_date_time = value; }
        }
        [JsonProperty(PropertyName = "calendars")]
        public List<Calendar> Calendars
        {
            get { return _calendars; }
            set { _calendars = value; }
        }
        [JsonProperty(PropertyName = "departure_date_time")]
        public string Departure_date_time
        {
            get { return _departure_date_time; }
            set { _departure_date_time = value; }
        }
        [JsonProperty(PropertyName = "requested_date_time")]
        public string Requested_date_time
        {
            get { return _requested_date_time; }
            set { _requested_date_time = value; }
        }
        [JsonProperty(PropertyName = "sections")]
        public List<Section> Sections
        {
            get { return _sections; }
            set { _sections = value; }
        }
        [JsonProperty(PropertyName = "co2_emission")]
        public Co2_emission Co2_emission
        {
            get { return _co2_emission; }
            set { _co2_emission = value; }
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
        #endregion

        #region Constructor
        public Journey()
        {

        }
        #endregion
    }
}
