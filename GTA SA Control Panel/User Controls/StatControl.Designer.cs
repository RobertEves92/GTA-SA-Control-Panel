
namespace GTASAControlPanel.UserControls
{
    partial class StatControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValue = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.trkValue = new System.Windows.Forms.TrackBar();
            this.chkLock = new System.Windows.Forms.CheckBox();
            this.lblLock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(83, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 13);
            this.lblValue.TabIndex = 8;
            this.lblValue.Text = "0";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(-3, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(43, 13);
            this.lblCaption.TabIndex = 7;
            this.lblCaption.Text = "Caption";
            // 
            // trkValue
            // 
            this.trkValue.LargeChange = 50;
            this.trkValue.Location = new System.Drawing.Point(0, 13);
            this.trkValue.Maximum = 400;
            this.trkValue.Name = "trkValue";
            this.trkValue.Size = new System.Drawing.Size(145, 45);
            this.trkValue.SmallChange = 25;
            this.trkValue.TabIndex = 6;
            this.trkValue.TickFrequency = 50;
            this.trkValue.Scroll += new System.EventHandler(this.trkValue_Scroll);
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.Location = new System.Drawing.Point(151, 26);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(15, 14);
            this.chkLock.TabIndex = 9;
            this.chkLock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkLock.UseVisualStyleBackColor = true;
            this.chkLock.CheckedChanged += new System.EventHandler(this.chkLock_CheckedChanged);
            // 
            // lblLock
            // 
            this.lblLock.AutoSize = true;
            this.lblLock.Location = new System.Drawing.Point(143, 0);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(31, 13);
            this.lblLock.TabIndex = 10;
            this.lblLock.Text = "Lock";
            // 
            // StatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLock);
            this.Controls.Add(this.chkLock);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.trkValue);
            this.Name = "StatControl";
            this.Size = new System.Drawing.Size(172, 43);
            ((System.ComponentModel.ISupportInitialize)(this.trkValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TrackBar trkValue;
        private System.Windows.Forms.CheckBox chkLock;
        private System.Windows.Forms.Label lblLock;
    }
}
