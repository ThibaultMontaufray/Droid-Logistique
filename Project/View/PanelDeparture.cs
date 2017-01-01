namespace Droid_logistique
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class PanelDeparture : UserControl
    {
        #region Attribute
        private System.Windows.Forms.Timer _timer;
        private InterfaceLogistique _intLog;
        private string _station;
        #endregion

        #region Properties
        public string Station
        {
            get { return _station; }
            set
            {
                _station = value;
                RefreshPreview();
            }
        }
        public string TextHtml
        {
            get { return _webBrowser.DocumentText; }
            set { _webBrowser.DocumentText = value; }
        }
        #endregion

        #region Constructor
        public PanelDeparture()
        {
            _intLog = new InterfaceLogistique();
            
            InitializeComponent();
            
            RefreshPreview();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 10;
            _timer.Tick += _timer_Tick;
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void RefreshPreview()
        {
            if (!string.IsNullOrEmpty(_station) && (DateTime.Now.AddSeconds(-60) - InterfaceLogistique.LastQuery).Ticks > 0)
            {
                //_intLog.GetDepartures(_station);
                _intLog.GetArrivals(_station);
                _webBrowser.DocumentText = _intLog.HtmlResult;
                _timer.Start();
            }
        }
        #endregion

        #region Event
        private void _timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.AddSeconds(-60) - InterfaceLogistique.LastQuery;
            progressBar1.Value = progressBar1.Maximum + ts.Milliseconds + (ts.Seconds * 1000) > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Maximum + ts.Milliseconds + (ts.Seconds * 1000);
            if (progressBar1.Value >= progressBar1.Maximum) _timer.Stop();
        }
        #endregion
    }
}
