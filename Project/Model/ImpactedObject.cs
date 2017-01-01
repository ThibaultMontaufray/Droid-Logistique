namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ImpactedObject
    {
        #region Attribute
        private List<ImpactedStop> _impactedStop;
        private PtObject _ptObject;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "pt_object")]
        public PtObject PtObject
        {
            get { return _ptObject; }
            set { _ptObject = value; }
        }
        [JsonProperty(PropertyName = "impacted_stops")]
        public List<ImpactedStop> ImpactedStop
        {
            get { return _impactedStop; }
            set { _impactedStop = value; }
        }
        #endregion

        #region Constructor
        public ImpactedObject()
        {
            _impactedStop = new List<ImpactedStop>();
        }
        #endregion
    }
}
