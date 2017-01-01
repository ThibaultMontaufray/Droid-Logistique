namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class FeedPublisher
    {
        #region Attribute
        private string _url;
        private string _id;
        private string _licence;
        private string _name;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "licence")]
        public string Licence
        {
            get { return _licence; }
            set { _licence = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "url")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        #endregion

        #region Constructor
        public FeedPublisher()
        {

        }
        #endregion
    }
}
