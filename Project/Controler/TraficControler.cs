namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using System.Linq;

    public class TraficControler
    {
        #region Attribute
        private const string URL = "https://api.sncf.com/v1/coverage/sncf/stop_areas?start_page=";
        private const string DIRECTORY = @"C:\Users\tmontauf040213\Documents\";

        private int _count;
        private WebBrowser _webBro;
        private List<object> _objects;
        private string _jsonTypeName;
        #endregion

        #region Properties
        public string JsonTypeName
        {
            get { return _jsonTypeName; }
            set { _jsonTypeName = value; }
        }
        public List<dynamic> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        #endregion

        #region Constructor
        public TraficControler(string jsontype)
        {
            _jsonTypeName = jsontype;
            _objects = new List<object>();
            GetData();
        }
        #endregion

        #region Methods public
        public void GetData()
        {
            GetDataFromFile();
        }
        #endregion

        #region Methods private
        private void GetDataFromWeb()
        {
            _count = 0;
            _webBro = new WebBrowser();
            _webBro.ScriptErrorsSuppressed = false;
            _webBro.DocumentCompleted += _webBro_DocumentCompleted;
            _webBro.Url = new System.Uri(URL + _count);
        }
        private void GetDataFromFile()
        {
            List<StopArea> lstTmp;
            string dump = string.Empty;
            JsonSerializer serializer = new JsonSerializer();
            foreach (string filename in Directory.GetFiles(DIRECTORY + _jsonTypeName))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    dump = sr.ReadToEnd();

                    using (var stringReader = new StringReader(dump))
                    using (var jsonReader = new JsonTextReader(stringReader))
                    {
                        try
                        {
                            while (jsonReader.Read())
                            {
                                if (jsonReader.TokenType == JsonToken.PropertyName && (string)jsonReader.Value == _jsonTypeName)
                                {
                                    jsonReader.Read();
                                    switch (_jsonTypeName)
                                    {
                                        case "stop_areas":
                                            //_objects.AddRange(serializer.Deserialize<List<StopArea>>(jsonReader));
                                            lstTmp = serializer.Deserialize<List<StopArea>>(jsonReader);
                                            _objects.AddRange(lstTmp);
                                            break;
                                        case "stop_point":
                                            _objects.AddRange(serializer.Deserialize<List<StopPoint>>(jsonReader));
                                            break;
                                        case "departures":
                                            _objects.AddRange(serializer.Deserialize<List<Departure>>(jsonReader));
                                            break;
                                        case "connections":
                                            _objects.AddRange(serializer.Deserialize<List<Connection>>(jsonReader));
                                            break;
                                        case "disruptions":
                                            _objects.AddRange(serializer.Deserialize<List<Disruption>>(jsonReader));
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(string.Format("cannot load file {0} with reader {1} : {2}", filename, jsonReader.ValueType, exp.Message));
                        }
                    }
                }
            }
        }
        #endregion

        #region Event
        private void _webBro_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //using (StreamWriter sw = new StreamWriter("StopArea.json", true))
            //{
            //    sw.Write(_webBro.Document.Body.InnerText);
            //}
            //_count++;
            //if (_count < 123)
            //{ 
            //    _webBro.Url = new System.Uri(URL + _count);
            //    System.Console.WriteLine("scanning page : " + _count);
            //}
            //else
            //{
            //    System.Console.WriteLine("Completed");
            //}
        }
        #endregion
    }
}
