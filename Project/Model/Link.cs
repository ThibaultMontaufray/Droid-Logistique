namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Link
    {
        #region Attribute
        private string _href;
        private string _type;
        private string _rel;
        private string _templated;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "templated")]
        public string Templated
        {
            get { return _templated; }
            set { _templated = value; }
        }
        [JsonProperty(PropertyName = "rel")]
        public string Rel
        {
            get { return _rel; }
            set { _rel = value; }
        }
        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [JsonProperty(PropertyName = "href")]
        public string Href
        {
            get { return _href; }
            set { _href = value; }
        }
        #endregion

        #region Constructor
        public Link()
        {

        }
        #endregion
    }
}
