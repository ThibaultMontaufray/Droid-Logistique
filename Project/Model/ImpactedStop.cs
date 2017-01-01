namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class ImpactedStop
    {
        #region Attribute
        private string _amendedArrivalTime;
        private StopPoint _stopPoint;
        private string _stopTimeEffect;
        private string _baseArrivalTime;
        private string _baseDepartureTime;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "base_deptarture_time")]
        public string BaseDepartureTime
        {
            get { return _baseDepartureTime; }
            set { _baseDepartureTime = value; }
        }
        [JsonProperty(PropertyName = "base_arrival_time")]
        public string BaseArrivalTime
        {
            get { return _baseArrivalTime; }
            set { _baseArrivalTime = value; }
        }
        [JsonProperty(PropertyName = "stop_time_effect")]
        public string StopTimeEffect
        {
            get { return _stopTimeEffect; }
            set { _stopTimeEffect = value; }
        }
        [JsonProperty(PropertyName = "stop_point")]
        public StopPoint StopPoint
        {
            get { return _stopPoint; }
            set { _stopPoint = value; }
        }
        [JsonProperty(PropertyName = "amended_arrival_time")]
        public string AmendedArrivalTime
        {
            get { return _amendedArrivalTime; }
            set { _amendedArrivalTime = value; }
        }
        #endregion

        #region Constructor
        public ImpactedStop()
        {

        }
        #endregion
    }
}
