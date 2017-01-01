using Droid_web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Droid_logistique
{
    public class InterfaceLogistique
    {
        #region Attribute
        private const string HTMLFORMAT = @"<style>
                        *{{font-family:Arial,helvetica,sans-serif;}}
                        table{{border:0px;width:100%; border-collapse:collapse;}}
                        td{{border:0px;padding:7px;}}
                        .row1{{background - color:#373737;color:#FFF;}}
                        .row0{{background - color:#737373;color:#FFF;}}
	                    #name{{
		                    color:#FFF;
                            background-color:#900;
		                    font:arial,helvetica,sans-serif;
		                    font-size:16px;
		                    font-style:bold;
		                    text-align:left;
                            height:25px;
                            padding:5px;
                            padding-left:10px;
	                      }}
                            </style>
                            <table border='0'>
                            <tr><th id='name' colspan=10>{0}</th></tr>
                            {1}
                            </table>";
        private string _token = Tools4Libraries.Params.LogisticSncfToken;
        private bool _flag = true;
        private static DateTime _lastQuery;
        private TraficControler _tcStopArea;
        private TraficControler _tcConnexion;
        private Trafic _trafic;
        private string _htmlResult;

        private static InterfaceLogistique _this;
        #endregion

        #region Properties
        public static DateTime LastQuery
        {
            get { return _lastQuery; }
            set { _lastQuery = value; }
        }
        public string HtmlResult
        {
            get { return _htmlResult; }
            set { _htmlResult = value; }
        }
        #endregion

        #region Constructor
        public InterfaceLogistique()
        {
            Init();
        }
        #endregion

        #region Methods public
        public bool GetDepartures(string _station)
        {
            string html = string.Empty;
            string title = string.Empty;
            string onTime;
            if (!string.IsNullOrEmpty(_station) && (DateTime.Now.AddSeconds(-60) - InterfaceLogistique.LastQuery).Ticks > 0)
            {
                List<Departure> traj = null;
                if (RequestDepartures(_station, ref traj))
                {
                    title = "Depart en " + traj[0].StopPoint.Label.Replace("de le", "du").Replace("de Le", "du");
                    foreach (var item in traj)
                    {
                        _flag = !_flag;
                        DateTime dt = DateTime.ParseExact(item.Date.Departure, "yyyyMMddTHHmmss", CultureInfo.InvariantCulture);

                        onTime = "à l'heure";
                        if (_trafic.Disruptions.Count > 0)
                        {
                            foreach (Disruption dis in _trafic.Disruptions)
                            {
                                foreach (var impObject in dis.ImpactedObject)
                                {
                                    foreach (var sp in impObject.ImpactedStop)
                                    {
                                        var v1 = new string[3] { sp.StopPoint.Id, sp.StopTimeEffect, sp.BaseArrivalTime };
                                        if (item.StopPoint.Id == sp.StopPoint.Id)
                                        {
                                            DateTime baseTime = DateTime.ParseExact(sp.BaseArrivalTime, "HHmmss", CultureInfo.InvariantCulture);
                                            DateTime amendedTime = DateTime.ParseExact(sp.AmendedArrivalTime, "HHmmss", CultureInfo.InvariantCulture);
                                            if ((amendedTime - baseTime).Minutes != 0) onTime = string.Format("<span style='color:#FFD800;'>{0}</span>", sp.StopTimeEffect + " " + (amendedTime - baseTime).Minutes.ToString() + " minutes");
                                        }
                                    }
                                }
                                Console.WriteLine("Disruptions !");
                            }
                        }

                        html += string.Format("<tr class='{0}'><td>{1}</td><td style='text-align:center;'>{2}</td><td style='color:#FFD800;font-weight:bold;text-align:center;'>{3}</td><td>{4}</td></tr>",
                            _flag ? "row1" : "row0",
                            item.DisplayInformation.CommercialMode,
                            item.DisplayInformation.HeadSign + "</br>" + onTime,
                            dt.ToString("HH:mm"),
                            item.Route.Directions.StopArea.Name.Replace("gare de ", string.Empty).Trim());
                    }
                    HtmlResult = string.Format(HTMLFORMAT, title, html);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetArrivals(string _station)
        {
            string html = string.Empty;
            string title = string.Empty;
            string onTime;
            if (!string.IsNullOrEmpty(_station) && (DateTime.Now.AddSeconds(-60) - InterfaceLogistique.LastQuery).Ticks > 0)
            {
                List<Arrivals> traj = null;
                if (RequestArrivals(_station, ref traj))
                {
                    title = "Arrivées en " + traj[0].StopPoint.Label.Replace("de le", "du").Replace("de Le", "du");
                    foreach (var item in traj)
                    {
                        _flag = !_flag;
                        DateTime dt = DateTime.ParseExact(item.Date.Departure, "yyyyMMddTHHmmss", CultureInfo.InvariantCulture);

                        onTime = "à l'heure";
                        if (_trafic.Disruptions.Count > 0)
                        {
                            foreach (Disruption dis in _trafic.Disruptions)
                            {
                                foreach (var impObject in dis.ImpactedObject)
                                {
                                    foreach (var sp in impObject.ImpactedStop)
                                    {
                                        var v1 = new string[3] { sp.StopPoint.Id, sp.StopTimeEffect, sp.BaseArrivalTime };
                                        if (item.StopPoint.Id == sp.StopPoint.Id)
                                        {
                                            DateTime baseTime = DateTime.ParseExact(sp.BaseArrivalTime, "HHmmss", CultureInfo.InvariantCulture);
                                            DateTime amendedTime = DateTime.ParseExact(sp.AmendedArrivalTime, "HHmmss", CultureInfo.InvariantCulture);
                                            if ((amendedTime - baseTime).Minutes != 0) onTime = string.Format("<span style='color:#FFD800;'>{0}</span>", sp.StopTimeEffect + " " + (amendedTime - baseTime).Minutes.ToString() + " minutes");
                                        }
                                    }
                                }
                                Console.WriteLine("Disruptions !");
                            }
                        }

                        html += string.Format("<tr class='{0}'><td>{1}</td><td style='text-align:center;'>{2}</td><td style='color:#FFD800;font-weight:bold;text-align:center;'>{3}</td><td>{4}</td></tr>",
                            _flag ? "row1" : "row0",
                            item.DisplayInformation.CommercialMode,
                            item.DisplayInformation.HeadSign + "</br>" + onTime,
                            dt.ToString("HH:mm"),
                            item.Route.Directions.StopArea.Name.Replace("gare de ", string.Empty).Trim());
                    }
                    HtmlResult = string.Format(HTMLFORMAT, title, html);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        #region ACTIONS
        public static string ACTION_130_afficher_departs(string gare)
        {
            if (_this == null) { _this = new InterfaceLogistique(); }
            _this.GetDepartures(gare);
            return _this.HtmlResult;
        }
        public static string ACTION_131_afficher_arrive(string gare)
        {
            if (_this == null) { _this = new InterfaceLogistique(); }
            _this.GetArrivals(gare);
            return _this.HtmlResult;
        }
        public static string ACTION_132_decrire_gare(string gare)
        {
            if (_this == null) { _this = new InterfaceLogistique(); }
            _this.RequestStationDetails(gare);
            return _this.HtmlResult;
        }
        public static string ACTION_133_partir_train(string gare_depart, string gare_arrive, DateTime depart)
        {
            if (_this == null) { _this = new InterfaceLogistique(); }
            Departure departure = null;
            _this.RequestNextDeparture(gare_depart, gare_arrive, depart, ref departure);
            return _this.HtmlResult;
        }
        public static string ACTION_134_arrive_train(string gare_depart, string gare_arrive, DateTime arrival)
        {
            if (_this == null) { _this = new InterfaceLogistique(); }
            //Departure departure = null;
            //_this.RequestNextDeparture(gare_depart, gare_arrive, arrival, ref departure);
            //return _this.HtmlResult;
            return string.Empty;
        }
        #endregion
        #endregion

        #region Methods private
        private void Init()
        {
            _trafic = new Trafic();
            _tcStopArea = new TraficControler("stop_areas");
            _tcConnexion = new TraficControler("connections");
        }
        private bool RequestNextDeparture(string stationFrom, string stationTo, DateTime whichDate, ref Departure departure)
        {
            List<Departure> listDep = null;
            Journeys jor = null;
            RequestJourney(stationFrom, stationTo, whichDate, ref jor);

            if (RequestDepartures(stationFrom, ref listDep))
            {
                foreach (Departure dep in listDep.Where(d => d.StopPoint.Label.Contains(stationTo)))
                {

                }
                return true;
            }
            return false;
        }
        private bool RequestDepartures(string station, ref List<Departure> listDep)
        {
            List<Departure> listDeparture = new List<Departure>();
            StopArea gareId = null;
            if (RequestStation(station, ref gareId))
            {
                if (gareId != null && _trafic.LastQuery < DateTime.Now.AddSeconds(-60))
                {
                    string json = Web.GetJson(_token, string.Empty, string.Format("https://api.sncf.com/v1/coverage/sncf/stop_areas/{0}/departures", gareId.Id));
                    _trafic.LastQuery = DateTime.Now;
                    _trafic = JsonConvert.DeserializeObject<Trafic>(json);
                }
                _lastQuery = DateTime.Now;
                if (_trafic != null)
                {
                    listDep = _trafic.Departures;
                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }
        private bool RequestArrivals(string station, ref List<Arrivals> listArr)
        {
            List<Arrivals> listArrivals = new List<Arrivals>();
            StopArea gareId = null;
            if (RequestStation(station, ref gareId))
            {
                if (gareId != null && _trafic.LastQuery < DateTime.Now.AddSeconds(-60))
                {
                    string json = Web.GetJson(_token, string.Empty, string.Format("https://api.sncf.com/v1/coverage/sncf/stop_areas/{0}/arrivals", gareId.Id));
                    _trafic.LastQuery = DateTime.Now;
                    _trafic = JsonConvert.DeserializeObject<Trafic>(json);
                }
                _lastQuery = DateTime.Now;
                if (_trafic != null)
                {
                    listArr = _trafic.Arrivals;
                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }
        private bool RequestStationDetails(string stationName)
        {
            StopArea station = null;
            if (RequestStation(stationName, ref station))
            {
                string html = string.Empty;
                html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Name<td class='" + (_flag ? "row1" : "row0") + "'>" + station.Name + "</td></tr>";
                _flag = !_flag;
                html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Timezone<td class='" + (_flag ? "row1" : "row0") + "'>" + station.TimeZone + "</td></tr>";
                _flag = !_flag;
                html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Latitude<td class='" + (_flag ? "row1" : "row0") + "'>" + station.Coord.Lat + "</td></tr>";
                _flag = !_flag;
                html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Longitude<td class='" + (_flag ? "row1" : "row0") + "'>" + station.Coord.Lon + "</td></tr>";
                _flag = !_flag;
                foreach (var item in station.AdministrativeRegion)
                {
                    html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Region administrative<td class='" + (_flag ? "row1" : "row0") + "'>" + item.Label + "</td></tr>";
                    _flag = !_flag;
                }
                html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Code<td class='" + (_flag ? "row1" : "row0") + "'>" + station.Code + "</td></tr>";
                _flag = !_flag;
                html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>Identifiant<td class='" + (_flag ? "row1" : "row0") + "'>" + station.Id + "</td></tr>";
                HtmlResult = string.Format(HTMLFORMAT, station.Label, html);
                return true;
            }
            return false;
        }
        private bool RequestStation(string stationName, ref StopArea station)
        {
            try
            {
                string cleanStationName;
                string inStation = stationName.ToLower().Replace('-', ' ').Replace('_', ' ').Replace(',', ' ');
                var list = _tcStopArea.Objects.Where(o => (o as StopArea).Label.ToLower().Replace('-', ' ').Replace('_', ' ').Replace(',', ' ').StartsWith("gare de " + inStation)).ToList();
                if (list.Count > 1)
                {
                    string html = string.Empty;
                    foreach (StopArea item in list)
                    {
                        cleanStationName = item.Name;
                        if (cleanStationName.ToLower().Equals("gare de " + stationName))
                        {
                            station = item;
                            return true;
                        }
                        html += "<tr><td class='" + (_flag ? "row1" : "row0") + "'>" + item.Label.Replace("gare de ", string.Empty) + "</td></tr>";
                        _flag = !_flag;
                    }
                    HtmlResult = string.Format(HTMLFORMAT, "Gares", html);
                    return false;
                }
                else if (list.Count == 1)
                {
                    station = list[0] as StopArea;
                    return true;
                }
                else
                {
                    HtmlResult = string.Format(HTMLFORMAT, "Aucune gare de trouvée.", string.Empty);
                    return false;
                }
            }
            catch (Exception exp)
            {
                HtmlResult = string.Format(HTMLFORMAT, "Exception lors de la récupération des gares : " + exp.Message, string.Empty);
            }
            return false;
        }
        private bool RequestJourney(string stationFromName, string stationToName, DateTime date, ref Journeys journeys)
        {
            _flag = true;
            string url = "https://api.sncf.com/v1/coverage/sncf/journeys?from={0}&to={1}&datetime={2}";
            StopArea stationFrom = null;
            StopArea stationTo = null;

            if (RequestStation(stationFromName, ref stationFrom) && RequestStation(stationToName, ref stationTo))
            {
                string json = Web.GetJson(_token, string.Empty, string.Format(url, stationFrom.Id, stationTo.Id, date.ToString("yyyyMMddThhmmss")));
                journeys = JsonConvert.DeserializeObject<Journeys>(json);
                
                string html = string.Empty;
                foreach (var jor in journeys.Journey)
                {
                    html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>Type</td><td>" + jor.Type + "</td></tr>";
                    _flag = !_flag;
                    html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>Start</td><td>" + jor.Departure_date_time + "</td></tr>";
                    _flag = !_flag;
                    html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>Arrival</td><td>" + jor.Arrival_date_time + "</td></tr>";
                    _flag = !_flag;
                    html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>Duration</td><td>" + jor.Duration + "</td></tr>";
                    _flag = !_flag;
                    html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>Changements</td><td>" + jor.Nb_transfert + "</td></tr>";
                    _flag = !_flag;
                    foreach (Section sec in jor.Sections)
                    {
                        html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>Section</td><td>" + (string.IsNullOrEmpty(sec.Mode) ? "by train " : sec.Mode) + " from " + sec.From.Name + " to " + sec.To.Name + " " + sec.Duration + "</td></tr>";
                        _flag = !_flag;
                    }
                    html += "<tr class='" + (_flag ? "row1" : "row0") + "'><td>CO2</td><td>" + jor.Co2_emission.Value + " " + jor.Co2_emission.Unit + "</td></tr>";
                    _flag = !_flag;
                }
                HtmlResult = string.Format(HTMLFORMAT, "Gares", html);
            }
            return false;
        }
        #endregion
    }
}
