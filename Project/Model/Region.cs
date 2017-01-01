using Newtonsoft.Json;
using System.Collections.Generic;

namespace Droid_logistique
{
    public class Region
    {
        #region Attribute
        private string _insee;
        private string _name;
        private int _level;
        private Coord _coord;
        private string _label;
        private string _id;
        private string _zip_code;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "insee")]
        public string Insee
        {
            get { return _insee; }
            set { _insee = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "level")]
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        [JsonProperty(PropertyName = "coord")]
        public Coord Coord
        {
            get { return _coord; }
            set { _coord = value; }
        }
        [JsonProperty(PropertyName = "label")]
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode
        {
            get { return _zip_code; }
            set { _zip_code = value; }
        }
        #endregion

        #region Constructor
        public Region()
        {

        }
        #endregion
    }
}
