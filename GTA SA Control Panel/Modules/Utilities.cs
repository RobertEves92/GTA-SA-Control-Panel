using GTASAControlPanel.UserControls;
using System.Windows.Forms;

namespace GTASAControlPanel.Modules
{
    /// <summary>
    /// Provides support functionality
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Resets all controls on a specified form
        /// </summary>
        /// <param name="form">Form to reset</param>
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.Tag == null)
                    PerformReset(control);
                else if (!control.Tag.ToString().Contains("NoReset"))
                    PerformReset(control);
            }

            void PerformReset(Control control)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0;
                    }
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is Label)
                {
                    if (control.Name.StartsWith("lbl"))
                    {
                        control.Text = "0";
                    }
                }

                if (control is TrackBar)
                {
                    TrackBar trackBar = (TrackBar)control;
                    trackBar.Value = 0;
                }

                if (control is StatControl)
                {
                    StatControl statControl = (StatControl)control;
                    statControl.ControlCurrentValue = 0;
                }
            }
        }
    }
}
