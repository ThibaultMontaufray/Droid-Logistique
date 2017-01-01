namespace Droid_logistique
{
    partial class Demo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxArrivals = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDepartures = new System.Windows.Forms.Button();
            this.textBoxDepartures = new System.Windows.Forms.TextBox();
            this.buttonStations = new System.Windows.Forms.Button();
            this.textBoxStations = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonDepartureDate = new System.Windows.Forms.Button();
            this.buttonArrivalDate = new System.Windows.Forms.Button();
            this.panelDeparture1 = new Droid_logistique.PanelDeparture();
            this.SuspendLayout();
            // 
            // textBoxArrivals
            // 
            this.textBoxArrivals.Location = new System.Drawing.Point(12, 12);
            this.textBoxArrivals.Name = "textBoxArrivals";
            this.textBoxArrivals.Size = new System.Drawing.Size(566, 20);
            this.textBoxArrivals.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(584, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Arrivals";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonArrivals_Click);
            // 
            // buttonDepartures
            // 
            this.buttonDepartures.Location = new System.Drawing.Point(584, 39);
            this.buttonDepartures.Name = "buttonDepartures";
            this.buttonDepartures.Size = new System.Drawing.Size(123, 23);
            this.buttonDepartures.TabIndex = 4;
            this.buttonDepartures.Text = "Departures";
            this.buttonDepartures.UseVisualStyleBackColor = true;
            this.buttonDepartures.Click += new System.EventHandler(this.buttonDepartures_Click);
            // 
            // textBoxDepartures
            // 
            this.textBoxDepartures.Location = new System.Drawing.Point(12, 41);
            this.textBoxDepartures.Name = "textBoxDepartures";
            this.textBoxDepartures.Size = new System.Drawing.Size(566, 20);
            this.textBoxDepartures.TabIndex = 3;
            // 
            // buttonStations
            // 
            this.buttonStations.Location = new System.Drawing.Point(584, 68);
            this.buttonStations.Name = "buttonStations";
            this.buttonStations.Size = new System.Drawing.Size(123, 23);
            this.buttonStations.TabIndex = 6;
            this.buttonStations.Text = "Stations";
            this.buttonStations.UseVisualStyleBackColor = true;
            this.buttonStations.Click += new System.EventHandler(this.buttonStations_Click);
            // 
            // textBoxStations
            // 
            this.textBoxStations.Location = new System.Drawing.Point(12, 70);
            this.textBoxStations.Name = "textBoxStations";
            this.textBoxStations.Size = new System.Drawing.Size(566, 20);
            this.textBoxStations.TabIndex = 5;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(53, 96);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(127, 20);
            this.textBoxFrom.TabIndex = 7;
            this.textBoxFrom.Text = "rouen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(235, 96);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(127, 20);
            this.textBoxTo.TabIndex = 9;
            this.textBoxTo.Text = "le havre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "At";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(413, 96);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(97, 20);
            this.timePicker.TabIndex = 12;
            // 
            // buttonDepartureDate
            // 
            this.buttonDepartureDate.Location = new System.Drawing.Point(534, 94);
            this.buttonDepartureDate.Name = "buttonDepartureDate";
            this.buttonDepartureDate.Size = new System.Drawing.Size(85, 23);
            this.buttonDepartureDate.TabIndex = 13;
            this.buttonDepartureDate.Text = "Departure";
            this.buttonDepartureDate.UseVisualStyleBackColor = true;
            this.buttonDepartureDate.Click += new System.EventHandler(this.buttonDepartureDate_Click);
            // 
            // buttonArrivalDate
            // 
            this.buttonArrivalDate.Location = new System.Drawing.Point(622, 94);
            this.buttonArrivalDate.Name = "buttonArrivalDate";
            this.buttonArrivalDate.Size = new System.Drawing.Size(85, 23);
            this.buttonArrivalDate.TabIndex = 14;
            this.buttonArrivalDate.Text = "Arrival";
            this.buttonArrivalDate.UseVisualStyleBackColor = true;
            this.buttonArrivalDate.Click += new System.EventHandler(this.buttonArrivalDate_Click);
            // 
            // panelDeparture1
            // 
            this.panelDeparture1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeparture1.Location = new System.Drawing.Point(12, 123);
            this.panelDeparture1.Name = "panelDeparture1";
            this.panelDeparture1.Size = new System.Drawing.Size(695, 344);
            this.panelDeparture1.Station = null;
            this.panelDeparture1.TabIndex = 0;
            this.panelDeparture1.TextHtml = "";
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 479);
            this.Controls.Add(this.buttonArrivalDate);
            this.Controls.Add(this.buttonDepartureDate);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.buttonStations);
            this.Controls.Add(this.textBoxStations);
            this.Controls.Add(this.buttonDepartures);
            this.Controls.Add(this.textBoxDepartures);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxArrivals);
            this.Controls.Add(this.panelDeparture1);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelDeparture panelDeparture1;
        private System.Windows.Forms.TextBox textBoxArrivals;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDepartures;
        private System.Windows.Forms.TextBox textBoxDepartures;
        private System.Windows.Forms.Button buttonStations;
        private System.Windows.Forms.TextBox textBoxStations;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button buttonDepartureDate;
        private System.Windows.Forms.Button buttonArrivalDate;
    }
}
