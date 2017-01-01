using Newtonsoft.Json;
using System;

namespace Droid_logistique
{
    public class ActivePeriod
    {
        #region Attribute
        private string _begin;
        private string _end;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "begin")]
        public string Begin
        {
            get { return _begin; }
            set { _begin = value; }
        }
        [JsonProperty(PropertyName = "end")]
        public string End
        {
            get { return _end; }
            set { _end = value; }
        }
        #endregion

        #region Constructor
        public ActivePeriod()
        {

        }
        #endregion
    }
}
