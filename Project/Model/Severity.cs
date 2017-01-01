namespace Droid_logistique
{
    using Newtonsoft.Json;

    public class Severity
    {
        #region Attribute
        private string _color;
        private string _priority;
        private string _name;
        private string _effect;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "effect")]
        public string Effect
        {
            get { return _effect; }
            set { _effect = value; }
        }
        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty(PropertyName = "priority")]
        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        [JsonProperty(PropertyName = "color")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        #endregion

        #region Constructor
        public Severity()
        {

        }
        #endregion
    }
}
