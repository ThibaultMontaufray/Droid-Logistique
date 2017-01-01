using Newtonsoft.Json;
using System.Collections.Generic;

namespace Droid_logistique
{
    public class Journeys
    {
        #region Attribute
        private List<string> _tickets;
        private List<Link> _links;
        private List<Journey> _journeys;
        private List<Disruption> _disruptions;
        private List<string> _notes;
        private List<FeedPublisher> _feed_publishers;
        private Context _context;
        private List<Exceptions> _exceptions;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "tickets")]
        public List<string> Tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Link
        {
            get { return _links; }
            set { _links = value; }
        }
        [JsonProperty(PropertyName = "journeys")]
        public List<Journey> Journey
        {
            get { return _journeys; }
            set { _journeys = value; }
        }
        [JsonProperty(PropertyName = "disruptions")]
        public List<Disruption> Disruptions
        {
            get { return _disruptions; }
            set { _disruptions = value; }
        }
        [JsonProperty(PropertyName = "notes")]
        public List<string> Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
        [JsonProperty(PropertyName = "feed_publishers")]
        public List<FeedPublisher> Feed_publishers
        {
            get { return _feed_publishers; }
            set { _feed_publishers = value; }
        }
        [JsonProperty(PropertyName = "context")]
        public Context Context
        {
            get { return _context; }
            set { _context = value; }
        }
        [JsonProperty(PropertyName = "exceptions")]
        public List<Exceptions> Exceptions
        {
            get { return _exceptions; }
            set { _exceptions = value; }
        }
        #endregion

        #region Constructor
        public Journeys()
        {
        }
        #endregion
    }
}
