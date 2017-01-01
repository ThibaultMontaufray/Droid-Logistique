using Newtonsoft.Json;
using System.Collections.Generic;

namespace Droid_logistique
{
    public class Calendar
    {
        #region Attribute
        private List<Exceptions> _exceptions;
        private List<ActivePeriod> _active_periods;
        private WeekPatern _week_patern;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "exceptions")]
        public List<Exceptions> Exceptions
        {
            get { return _exceptions; }
            set { _exceptions = value; }
        }
        [JsonProperty(PropertyName = "active_periods")]
        public List<ActivePeriod> Active_periods
        {
            get { return _active_periods; }
            set { _active_periods = value; }
        }
        [JsonProperty(PropertyName = "week_patern")]
        public WeekPatern Week_patern
        {
            get { return _week_patern; }
            set { _week_patern = value; }
        }
        #endregion

        #region Constructor
        public Calendar()
        {

        }
        #endregion
    }
}
