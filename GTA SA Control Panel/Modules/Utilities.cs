using GTASAControlPanel.UserControls;
using System.Windows.Forms;

namespace GTASAControlPanel.Modules
{
    /// <summary>Provides support functionality</summary>
    public static class Utilities
    {
        /// <summary>Resets all controls on a specified form</summary>
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
                if (control is TextBox textBox)
                {
                    textBox.Text = null;
                }

                if (control is ComboBox comboBox && comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                if (control is ListBox listBox)
                {
                    listBox.ClearSelected();
                }

                if (control is Label && control.Name.StartsWith("lbl"))
                {
                    control.Text = "0";
                }

                if (control is TrackBar trackBar)
                {
                    trackBar.Value = 0;
                }

                if (control is StatControl statControl)
                {
                    statControl.ControlCurrentValue = 0;
                }
            }
        }
    }
}