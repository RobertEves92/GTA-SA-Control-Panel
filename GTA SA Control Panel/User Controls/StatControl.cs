using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GTASAControlPanel.UserControls
{
    /// <summary>
    /// User Control for player stats
    /// </summary>
    public partial class StatControl : UserControl
    {
        /// <summary>
        /// Event handler for when the track bar value is changed
        /// </summary>
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user changes the track bar value")]
        public event EventHandler TrackValueChanged;

        /// <summary>
        /// Initialises the StatControl class components
        /// </summary>
        public StatControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Gets or Sets the stat controls maximum permitted value
        /// </summary>
        public int ControlMaxValue
        {
            get => trkValue.Maximum;
            set => trkValue.Maximum = value;
        }
        /// <summary>
        /// Gets or Sets the stat controls value
        /// </summary>
        public int ControlCurrentValue
        {
            get => trkValue.Value;
            set
            {
                trkValue.Value = value;
                if (ControlValueAsPercent)
                {
                    double percent = value / (double)ControlMaxValue;
                    lblValue.Text = (percent * 100).ToString() + "%";
                }
                else
                {
                    lblValue.Text = value.ToString();
                }
            }
        }
        /// <summary>
        /// Gets or Sets the stat control caption text
        /// </summary>
        public string ControlText
        {
            get => lblCaption.Text;
            set => lblCaption.Text = value;
        }
        /// <summary>
        /// Gets or Sets the trackbar tick frequency
        /// </summary>
        public int ControlTick
        {
            get => trkValue.TickFrequency;
            set => trkValue.TickFrequency = value;
        }
        /// <summary>
        /// Gets or Sets the lock status of the control
        /// </summary>
        public bool ControlLock
        {
            get => chkLock.Checked;
            set => chkLock.Checked = value;
        }
        /// <summary>
        /// Gets or Sets the value to lock the stat control at
        /// </summary>
        public int ControlLockValue { get; set; }

        /// <summary>
        /// Enable or disable the control lock checkbox
        /// </summary>
        public bool ControlLockVisible
        {
            get => chkLock.Visible;
            set
            {
                chkLock.Visible = value;
                lblLock.Visible = value;

                if (value)
                {
                    trkValue.Size = new System.Drawing.Size(145, 45);
                }
                else
                {
                    trkValue.Size = new System.Drawing.Size(175, 45);
                }
            }
        }

        /// <summary>
        /// Sets whether the control value should be displayed as a percentage of the maximum permitted value, or as the raw value
        /// </summary>
        public bool ControlValueAsPercent { get; set; }

        private void trkValue_Scroll(object sender, EventArgs e)
        {
            UpdateValue(e);
        }
        /// <summary>
        /// Triggers event when the trackbar value is changed by the user
        /// </summary>
        /// <param name="e">Event Arguments</param>
        public void UpdateValue(EventArgs e)
        {
            //bubble the event up to the parent
            if (TrackValueChanged != null)
            {
                TrackValueChanged(this, e);
            }
        }
        private void chkLock_CheckedChanged(object sender, EventArgs e)
        {
            ControlLockValue = trkValue.Value;
        }
    }
}
