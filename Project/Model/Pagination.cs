namespace Droid_logistique
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Pagination
    {
        #region Attribute
        private int _startPage;
        private int _itemsOnPage;
        private int _itemsPerPage;
        private int _totalResult;
        #endregion

        #region Properties
        [JsonProperty(PropertyName = "total_result")]
        public int TotalResult
        {
            get { return _totalResult; }
            set { _totalResult = value; }
        }
        [JsonProperty(PropertyName = "items_per_page")]
        public int ItemsPerPage
        {
            get { return _itemsPerPage; }
            set { _itemsPerPage = value; }
        }
        [JsonProperty(PropertyName = "items_on_page")]
        public int ItemsOnPage
        {
            get { return _itemsOnPage; }
            set { _itemsOnPage = value; }
        }
        [JsonProperty(PropertyName = "start_page")]
        public int StartPage
        {
            get { return _startPage; }
            set { _startPage = value; }
        }
        #endregion

        #region Constructor
        public Pagination()
        {

        }
        #endregion
    }
}
