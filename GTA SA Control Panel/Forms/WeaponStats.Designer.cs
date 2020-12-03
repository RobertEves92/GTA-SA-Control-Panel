
namespace GTASAControlPanel.Forms
{
    /// <summary>
    /// Form to get/set weapon stats
    /// </summary>
    partial class WeaponStats
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
            this.grpHandguns = new System.Windows.Forms.GroupBox();
            this.statDesertEagle = new GTASAControlPanel.UserControls.StatControl();
            this.statSilencedPistol = new GTASAControlPanel.UserControls.StatControl();
            this.statPistol = new GTASAControlPanel.UserControls.StatControl();
            this.grpShotguns = new System.Windows.Forms.GroupBox();
            this.statCombatShotgun = new GTASAControlPanel.UserControls.StatControl();
            this.statSawnoffShotgun = new GTASAControlPanel.UserControls.StatControl();
            this.statShotgun = new GTASAControlPanel.UserControls.StatControl();
            this.grpLMGs = new System.Windows.Forms.GroupBox();
            this.statSMG = new GTASAControlPanel.UserControls.StatControl();
            this.statMachinePistol = new GTASAControlPanel.UserControls.StatControl();
            this.grpARs = new System.Windows.Forms.GroupBox();
            this.statM4 = new GTASAControlPanel.UserControls.StatControl();
            this.statAK47 = new GTASAControlPanel.UserControls.StatControl();
            this.grpHandguns.SuspendLayout();
            this.grpShotguns.SuspendLayout();
            this.grpLMGs.SuspendLayout();
            this.grpARs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHandguns
            // 
            this.grpHandguns.Controls.Add(this.statDesertEagle);
            this.grpHandguns.Controls.Add(this.statSilencedPistol);
            this.grpHandguns.Controls.Add(this.statPistol);
            this.grpHandguns.Location = new System.Drawing.Point(12, 12);
            this.grpHandguns.Name = "grpHandguns";
            this.grpHandguns.Size = new System.Drawing.Size(544, 73);
            this.grpHandguns.TabIndex = 0;
            this.grpHandguns.TabStop = false;
            this.grpHandguns.Text = "Handguns";
            // 
            // statDesertEagle
            // 
            this.statDesertEagle.ControlCurrentValue = 0;
            this.statDesertEagle.ControlLock = false;
            this.statDesertEagle.ControlLockValue = 0;
            this.statDesertEagle.ControlLockVisible = false;
            this.statDesertEagle.ControlMaxValue = 1000;
            this.statDesertEagle.ControlText = "Desert Eagle";
            this.statDesertEagle.ControlTick = 125;
            this.statDesertEagle.ControlValueAsPercent = true;
            this.statDesertEagle.Location = new System.Drawing.Point(362, 19);
            this.statDesertEagle.Name = "statDesertEagle";
            this.statDesertEagle.Size = new System.Drawing.Size(172, 43);
            this.statDesertEagle.TabIndex = 2;
            this.statDesertEagle.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // statSilencedPistol
            // 
            this.statSilencedPistol.ControlCurrentValue = 0;
            this.statSilencedPistol.ControlLock = false;
            this.statSilencedPistol.ControlLockValue = 0;
            this.statSilencedPistol.ControlLockVisible = false;
            this.statSilencedPistol.ControlMaxValue = 1000;
            this.statSilencedPistol.ControlText = "Silenced Pistol";
            this.statSilencedPistol.ControlTick = 125;
            this.statSilencedPistol.ControlValueAsPercent = true;
            this.statSilencedPistol.Location = new System.Drawing.Point(184, 19);
            this.statSilencedPistol.Name = "statSilencedPistol";
            this.statSilencedPistol.Size = new System.Drawing.Size(172, 43);
            this.statSilencedPistol.TabIndex = 1;
            this.statSilencedPistol.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // statPistol
            // 
            this.statPistol.ControlCurrentValue = 0;
            this.statPistol.ControlLock = false;
            this.statPistol.ControlLockValue = 0;
            this.statPistol.ControlLockVisible = false;
            this.statPistol.ControlMaxValue = 1000;
            this.statPistol.ControlText = "Pistol";
            this.statPistol.ControlTick = 125;
            this.statPistol.ControlValueAsPercent = true;
            this.statPistol.Location = new System.Drawing.Point(6, 19);
            this.statPistol.Name = "statPistol";
            this.statPistol.Size = new System.Drawing.Size(172, 43);
            this.statPistol.TabIndex = 0;
            this.statPistol.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // grpShotguns
            // 
            this.grpShotguns.Controls.Add(this.statCombatShotgun);
            this.grpShotguns.Controls.Add(this.statSawnoffShotgun);
            this.grpShotguns.Controls.Add(this.statShotgun);
            this.grpShotguns.Location = new System.Drawing.Point(12, 91);
            this.grpShotguns.Name = "grpShotguns";
            this.grpShotguns.Size = new System.Drawing.Size(544, 73);
            this.grpShotguns.TabIndex = 1;
            this.grpShotguns.TabStop = false;
            this.grpShotguns.Text = "Shotguns";
            // 
            // statCombatShotgun
            // 
            this.statCombatShotgun.ControlCurrentValue = 0;
            this.statCombatShotgun.ControlLock = false;
            this.statCombatShotgun.ControlLockValue = 0;
            this.statCombatShotgun.ControlLockVisible = false;
            this.statCombatShotgun.ControlMaxValue = 1000;
            this.statCombatShotgun.ControlText = "Combat Shotgun";
            this.statCombatShotgun.ControlTick = 125;
            this.statCombatShotgun.ControlValueAsPercent = true;
            this.statCombatShotgun.Location = new System.Drawing.Point(362, 19);
            this.statCombatShotgun.Name = "statCombatShotgun";
            this.statCombatShotgun.Size = new System.Drawing.Size(172, 43);
            this.statCombatShotgun.TabIndex = 2;
            this.statCombatShotgun.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // statSawnoffShotgun
            // 
            this.statSawnoffShotgun.ControlCurrentValue = 0;
            this.statSawnoffShotgun.ControlLock = false;
            this.statSawnoffShotgun.ControlLockValue = 0;
            this.statSawnoffShotgun.ControlLockVisible = false;
            this.statSawnoffShotgun.ControlMaxValue = 1000;
            this.statSawnoffShotgun.ControlText = "Sawnoff Shotgun";
            this.statSawnoffShotgun.ControlTick = 125;
            this.statSawnoffShotgun.ControlValueAsPercent = true;
            this.statSawnoffShotgun.Location = new System.Drawing.Point(184, 19);
            this.statSawnoffShotgun.Name = "statSawnoffShotgun";
            this.statSawnoffShotgun.Size = new System.Drawing.Size(172, 43);
            this.statSawnoffShotgun.TabIndex = 1;
            this.statSawnoffShotgun.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // statShotgun
            // 
            this.statShotgun.ControlCurrentValue = 0;
            this.statShotgun.ControlLock = false;
            this.statShotgun.ControlLockValue = 0;
            this.statShotgun.ControlLockVisible = false;
            this.statShotgun.ControlMaxValue = 1000;
            this.statShotgun.ControlText = "Shotgun";
            this.statShotgun.ControlTick = 125;
            this.statShotgun.ControlValueAsPercent = true;
            this.statShotgun.Location = new System.Drawing.Point(6, 19);
            this.statShotgun.Name = "statShotgun";
            this.statShotgun.Size = new System.Drawing.Size(172, 43);
            this.statShotgun.TabIndex = 0;
            this.statShotgun.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // grpLMGs
            // 
            this.grpLMGs.Controls.Add(this.statSMG);
            this.grpLMGs.Controls.Add(this.statMachinePistol);
            this.grpLMGs.Location = new System.Drawing.Point(12, 170);
            this.grpLMGs.Name = "grpLMGs";
            this.grpLMGs.Size = new System.Drawing.Size(544, 73);
            this.grpLMGs.TabIndex = 2;
            this.grpLMGs.TabStop = false;
            this.grpLMGs.Text = "Machine Pistol / SMG";
            // 
            // statSMG
            // 
            this.statSMG.ControlCurrentValue = 0;
            this.statSMG.ControlLock = false;
            this.statSMG.ControlLockValue = 0;
            this.statSMG.ControlLockVisible = false;
            this.statSMG.ControlMaxValue = 1000;
            this.statSMG.ControlText = "SMG";
            this.statSMG.ControlTick = 125;
            this.statSMG.ControlValueAsPercent = true;
            this.statSMG.Location = new System.Drawing.Point(184, 19);
            this.statSMG.Name = "statSMG";
            this.statSMG.Size = new System.Drawing.Size(172, 43);
            this.statSMG.TabIndex = 1;
            this.statSMG.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // statMachinePistol
            // 
            this.statMachinePistol.ControlCurrentValue = 0;
            this.statMachinePistol.ControlLock = false;
            this.statMachinePistol.ControlLockValue = 0;
            this.statMachinePistol.ControlLockVisible = false;
            this.statMachinePistol.ControlMaxValue = 1000;
            this.statMachinePistol.ControlText = "Machine Pistol";
            this.statMachinePistol.ControlTick = 125;
            this.statMachinePistol.ControlValueAsPercent = true;
            this.statMachinePistol.Location = new System.Drawing.Point(6, 19);
            this.statMachinePistol.Name = "statMachinePistol";
            this.statMachinePistol.Size = new System.Drawing.Size(172, 43);
            this.statMachinePistol.TabIndex = 0;
            this.statMachinePistol.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // grpARs
            // 
            this.grpARs.Controls.Add(this.statM4);
            this.grpARs.Controls.Add(this.statAK47);
            this.grpARs.Location = new System.Drawing.Point(12, 249);
            this.grpARs.Name = "grpARs";
            this.grpARs.Size = new System.Drawing.Size(544, 73);
            this.grpARs.TabIndex = 3;
            this.grpARs.TabStop = false;
            this.grpARs.Text = "Assault Rifles";
            // 
            // statM4
            // 
            this.statM4.ControlCurrentValue = 0;
            this.statM4.ControlLock = false;
            this.statM4.ControlLockValue = 0;
            this.statM4.ControlLockVisible = false;
            this.statM4.ControlMaxValue = 1000;
            this.statM4.ControlText = "M4";
            this.statM4.ControlTick = 125;
            this.statM4.ControlValueAsPercent = true;
            this.statM4.Location = new System.Drawing.Point(184, 19);
            this.statM4.Name = "statM4";
            this.statM4.Size = new System.Drawing.Size(172, 43);
            this.statM4.TabIndex = 1;
            this.statM4.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // statAK47
            // 
            this.statAK47.ControlCurrentValue = 0;
            this.statAK47.ControlLock = false;
            this.statAK47.ControlLockValue = 0;
            this.statAK47.ControlLockVisible = false;
            this.statAK47.ControlMaxValue = 1000;
            this.statAK47.ControlText = "AK47";
            this.statAK47.ControlTick = 125;
            this.statAK47.ControlValueAsPercent = true;
            this.statAK47.Location = new System.Drawing.Point(6, 19);
            this.statAK47.Name = "statAK47";
            this.statAK47.Size = new System.Drawing.Size(172, 43);
            this.statAK47.TabIndex = 0;
            this.statAK47.TrackValueChanged += new System.EventHandler(this.statWeapon_TrackValueChanged);
            // 
            // WeaponStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 330);
            this.Controls.Add(this.grpARs);
            this.Controls.Add(this.grpLMGs);
            this.Controls.Add(this.grpShotguns);
            this.Controls.Add(this.grpHandguns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponStats";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weapon Stats";
            this.Load += new System.EventHandler(this.WeaponStats_Load);
            this.grpHandguns.ResumeLayout(false);
            this.grpShotguns.ResumeLayout(false);
            this.grpLMGs.ResumeLayout(false);
            this.grpARs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHandguns;
        private UserControls.StatControl statDesertEagle;
        private UserControls.StatControl statSilencedPistol;
        private UserControls.StatControl statPistol;
        private System.Windows.Forms.GroupBox grpShotguns;
        private UserControls.StatControl statCombatShotgun;
        private UserControls.StatControl statSawnoffShotgun;
        private UserControls.StatControl statShotgun;
        private System.Windows.Forms.GroupBox grpLMGs;
        private UserControls.StatControl statSMG;
        private UserControls.StatControl statMachinePistol;
        private System.Windows.Forms.GroupBox grpARs;
        private UserControls.StatControl statM4;
        private UserControls.StatControl statAK47;
    }
}