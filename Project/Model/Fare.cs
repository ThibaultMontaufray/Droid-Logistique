using Newtonsoft.Json;
using System.Collections.Generic;

namespace Droid_logistique
{
    public class Fare
    {
        #region Attribute
        private bool _found;
        private Total _total;
        private List<Link> _links;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "found")]
        public bool Found
        {
            get { return _found; }
            set { _found = value; }
        }
        [JsonProperty(PropertyName = "total")]
        public Total Total
        {
            get { return _total; }
            set { _total = value; }
        }
        [JsonProperty(PropertyName = "links")]
        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }
        #endregion

        #region Constructor
        public Fare()
        {

        }
        #endregion
    }
}
