namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Disruption
    {
        #region Attribute
        private string _status;
        private string _disruptionId;
        private Severity _severity;
        private string _impactId;
        private List<ApplicationPeriod> _applicationPeriod;
        private string _updatedAt;
        private string _uri;
        private List<ImpactedObject> _impactedObject;
        private string _disruptionUri;
        private string _contributor;
        private string _cause;
        private string _id;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "cause")]
        public string Cause
        {
            get { return _cause; }
            set { _cause = value; }
        }
        [JsonProperty(PropertyName = "contributor")]
        public string Contributor
        {
            get { return _contributor; }
            set { _contributor = value; }
        }
        [JsonProperty(PropertyName = "disruption_uri")]
        public string DisruptionUri
        {
            get { return _disruptionUri; }
            set { _disruptionUri = value; }
        }
        [JsonProperty(PropertyName = "impacted_objects")]
        public List<ImpactedObject> ImpactedObject
        {
            get { return _impactedObject; }
            set { _impactedObject = value; }
        }
        [JsonProperty(PropertyName = "uri")]
        public string Uri
        {
            get { return _uri; }
            set { _uri = value; }
        }
        [JsonProperty(PropertyName = "updated_at")]
        public string UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
        [JsonProperty(PropertyName = "application_periods")]
        public List<ApplicationPeriod> ApplicationPeriod
        {
            get { return _applicationPeriod; }
            set { _applicationPeriod = value; }
        }
        [JsonProperty(PropertyName = "impacted_id")]
        public string ImpactId
        {
            get { return _impactId; }
            set { _impactId = value; }
        }
        [JsonProperty(PropertyName = "severity")]
        public Severity Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }
        [JsonProperty(PropertyName = "disruption_id")]
        public string DisruptionId
        {
            get { return _disruptionId; }
            set { _disruptionId = value; }
        }
        [JsonProperty(PropertyName = "status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region Constructor
        public Disruption()
        {
            _impactedObject = new List<ImpactedObject>();
            _applicationPeriod = new List<ApplicationPeriod>();
        }
        #endregion
    }
}
