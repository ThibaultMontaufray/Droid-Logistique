namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Trafic
    {
        #region Attribute
        private List<StopArea> _stopAreas;
        private List<Departure> _departures;
        private List<Arrivals> _arrivals;
        private List<Disruption> _disruptions;
        private List<FeedPublisher> _feedPublisher;
        private List<Exceptions> _exceptions;

        private DateTime _lastQuery;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "stop_areas")]
        public List<StopArea> StopAreas
        {
            get { return _stopAreas; }
            set { _stopAreas = value; }
        }
        [JsonProperty(PropertyName = "departures")]
        public List<Departure> Departures
        {
            get { return _departures; }
            set { _departures = value; }
        }
        [JsonProperty(PropertyName = "arrivals")]
        public List<Arrivals> Arrivals
        {
            get { return _arrivals; }
            set { _arrivals = value; }
        }
        [JsonProperty(PropertyName = "disruptions")]
        public List<Disruption> Disruptions
        {
            get { return _disruptions; }
            set { _disruptions = value; }
        }
        public List<FeedPublisher> FeedPublisher
        {
            get { return _feedPublisher; }
            set { _feedPublisher = value; }
        }
        public DateTime LastQuery
        {
            get { return _lastQuery; }
            set { _lastQuery = value; }
        }
        public List<Exceptions> Exceptions
        {
            get { return _exceptions; }
            set { _exceptions = value; }
        }
        #endregion

        #region Constructor
        public Trafic()
        {
            _stopAreas = new List<StopArea>();
            _departures = new List<Departure>();
            _disruptions = new List<Disruption>();
            _feedPublisher = new List<FeedPublisher>();
            _exceptions = new List<Exceptions>();

            _lastQuery = DateTime.MinValue;
        }
        #endregion
    }
}
