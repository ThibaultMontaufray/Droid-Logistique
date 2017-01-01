namespace Droid_logistique
{
    using System;

    public static class Queries
    {
        #region Attribute
        public static readonly string TOKEN = Tools4Libraries.Params.LogisticSncfToken;
        #endregion

        #region Methods public
        public static object GetGareDeparture(DateTime time, StopArea stopArea)
        {
            string query = string.Format("https://api.sncf.com/v1/coverage/sncf/stop_areas/{0}/departures?datetime={1}", stopArea.Id, time.ToString("yyyymmddTHHmmss"));
            return null;
        }
        public static object GetGareArrival(DateTime time, StopArea stopArea)
        {
            string query = string.Format("https://api.sncf.com/v1/coverage/sncf/stop_areas/{0}/arrivals?datetime={1}", stopArea.Id, time.ToString("yyyymmddTHHmmss"));
            return null;
        }
        public static object GetItinerance(DateTime time, StopArea departure, StopArea arrival)
        {
            string query = string.Format("https://api.sncf.com/v1/coverage/sncf/journeys?from={0}&to={1}&datetime={2}", departure.AdministrativeRegion[0].Id, arrival.AdministrativeRegion[0].Id, time.ToString("yyyymmddTHHmmss"));
            return null;
        }
        public static object GetLineDetail(Line line)
        {
            string query = string.Format("https://api.sncf.com/v1/coverage/sncf/lines/{0}", line.Id);
            return null;
        }
        #endregion
    }
}
