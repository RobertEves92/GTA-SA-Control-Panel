
namespace GTASAControlPanel.UserControls
{
    partial class PlayerStats
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
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeaponSkills = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBullets = new System.Windows.Forms.CheckBox();
            this.chkFire = new System.Windows.Forms.CheckBox();
            this.chkExplosions = new System.Windows.Forms.CheckBox();
            this.chkCollisions = new System.Windows.Forms.CheckBox();
            this.statGambling = new GTASAControlPanel.UserControls.StatControl();
            this.statLung = new GTASAControlPanel.UserControls.StatControl();
            this.statPlane = new GTASAControlPanel.UserControls.StatControl();
            this.statCycle = new GTASAControlPanel.UserControls.StatControl();
            this.statBiking = new GTASAControlPanel.UserControls.StatControl();
            this.statDriving = new GTASAControlPanel.UserControls.StatControl();
            this.statMuscle = new GTASAControlPanel.UserControls.StatControl();
            this.statStamina = new GTASAControlPanel.UserControls.StatControl();
            this.statFat = new GTASAControlPanel.UserControls.StatControl();
            this.statArmour = new GTASAControlPanel.UserControls.StatControl();
            this.statHealth = new GTASAControlPanel.UserControls.StatControl();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(52, 3);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(97, 20);
            this.txtMoney.TabIndex = 12;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoney_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Money:";
            // 
            // btnWeaponSkills
            // 
            this.btnWeaponSkills.Location = new System.Drawing.Point(185, 1);
            this.btnWeaponSkills.Name = "btnWeaponSkills";
            this.btnWeaponSkills.Size = new System.Drawing.Size(172, 23);
            this.btnWeaponSkills.TabIndex = 25;
            this.btnWeaponSkills.Text = "Weapon Skills";
            this.btnWeaponSkills.UseVisualStyleBackColor = true;
            this.btnWeaponSkills.Click += new System.EventHandler(this.btnWeaponSkills_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Prevent damage from:";
            // 
            // chkBullets
            // 
            this.chkBullets.AutoSize = true;
            this.chkBullets.Location = new System.Drawing.Point(366, 22);
            this.chkBullets.Name = "chkBullets";
            this.chkBullets.Size = new System.Drawing.Size(57, 17);
            this.chkBullets.TabIndex = 28;
            this.chkBullets.Tag = "NoReset";
            this.chkBullets.Text = "Bullets";
            this.chkBullets.UseVisualStyleBackColor = true;
            // 
            // chkFire
            // 
            this.chkFire.AutoSize = true;
            this.chkFire.Location = new System.Drawing.Point(366, 45);
            this.chkFire.Name = "chkFire";
            this.chkFire.Size = new System.Drawing.Size(43, 17);
            this.chkFire.TabIndex = 29;
            this.chkFire.Tag = "NoReset";
            this.chkFire.Text = "Fire";
            this.chkFire.UseVisualStyleBackColor = true;
            // 
            // chkExplosions
            // 
            this.chkExplosions.AutoSize = true;
            this.chkExplosions.Location = new System.Drawing.Point(366, 68);
            this.chkExplosions.Name = "chkExplosions";
            this.chkExplosions.Size = new System.Drawing.Size(76, 17);
            this.chkExplosions.TabIndex = 30;
            this.chkExplosions.Tag = "NoReset";
            this.chkExplosions.Text = "Explosions";
            this.chkExplosions.UseVisualStyleBackColor = true;
            // 
            // chkCollisions
            // 
            this.chkCollisions.AutoSize = true;
            this.chkCollisions.Location = new System.Drawing.Point(366, 91);
            this.chkCollisions.Name = "chkCollisions";
            this.chkCollisions.Size = new System.Drawing.Size(69, 17);
            this.chkCollisions.TabIndex = 31;
            this.chkCollisions.Tag = "NoReset";
            this.chkCollisions.Text = "Collisions";
            this.chkCollisions.UseVisualStyleBackColor = true;
            // 
            // statGambling
            // 
            this.statGambling.ControlCurrentValue = 0;
            this.statGambling.ControlLock = false;
            this.statGambling.ControlLockValue = 0;
            this.statGambling.ControlLockVisible = true;
            this.statGambling.ControlMaxValue = 1000;
            this.statGambling.ControlText = "Gambling Skill";
            this.statGambling.ControlTick = 125;
            this.statGambling.ControlValueAsPercent = false;
            this.statGambling.Location = new System.Drawing.Point(7, 330);
            this.statGambling.Name = "statGambling";
            this.statGambling.Size = new System.Drawing.Size(172, 43);
            this.statGambling.TabIndex = 24;
            this.statGambling.TrackValueChanged += new System.EventHandler(this.statGambling_TrackValueChanged);
            // 
            // statLung
            // 
            this.statLung.ControlCurrentValue = 0;
            this.statLung.ControlLock = false;
            this.statLung.ControlLockValue = 0;
            this.statLung.ControlLockVisible = true;
            this.statLung.ControlMaxValue = 1000;
            this.statLung.ControlText = "Lung Capacity";
            this.statLung.ControlTick = 125;
            this.statLung.ControlValueAsPercent = false;
            this.statLung.Location = new System.Drawing.Point(7, 274);
            this.statLung.Name = "statLung";
            this.statLung.Size = new System.Drawing.Size(172, 43);
            this.statLung.TabIndex = 23;
            this.statLung.TrackValueChanged += new System.EventHandler(this.statLung_TrackValueChanged);
            // 
            // statPlane
            // 
            this.statPlane.ControlCurrentValue = 0;
            this.statPlane.ControlLock = false;
            this.statPlane.ControlLockValue = 0;
            this.statPlane.ControlLockVisible = true;
            this.statPlane.ControlMaxValue = 1000;
            this.statPlane.ControlText = "Flying Skill";
            this.statPlane.ControlTick = 125;
            this.statPlane.ControlValueAsPercent = false;
            this.statPlane.Location = new System.Drawing.Point(185, 176);
            this.statPlane.Name = "statPlane";
            this.statPlane.Size = new System.Drawing.Size(172, 43);
            this.statPlane.TabIndex = 22;
            this.statPlane.TrackValueChanged += new System.EventHandler(this.statPlane_TrackValueChanged);
            // 
            // statCycle
            // 
            this.statCycle.ControlCurrentValue = 0;
            this.statCycle.ControlLock = false;
            this.statCycle.ControlLockValue = 0;
            this.statCycle.ControlLockVisible = true;
            this.statCycle.ControlMaxValue = 1000;
            this.statCycle.ControlText = "Cycling Skill";
            this.statCycle.ControlTick = 125;
            this.statCycle.ControlValueAsPercent = false;
            this.statCycle.Location = new System.Drawing.Point(185, 127);
            this.statCycle.Name = "statCycle";
            this.statCycle.Size = new System.Drawing.Size(172, 43);
            this.statCycle.TabIndex = 21;
            this.statCycle.TrackValueChanged += new System.EventHandler(this.statCycle_TrackValueChanged);
            // 
            // statBiking
            // 
            this.statBiking.ControlCurrentValue = 0;
            this.statBiking.ControlLock = false;
            this.statBiking.ControlLockValue = 0;
            this.statBiking.ControlLockVisible = true;
            this.statBiking.ControlMaxValue = 1000;
            this.statBiking.ControlText = "Biking Skill";
            this.statBiking.ControlTick = 125;
            this.statBiking.ControlValueAsPercent = false;
            this.statBiking.Location = new System.Drawing.Point(185, 78);
            this.statBiking.Name = "statBiking";
            this.statBiking.Size = new System.Drawing.Size(172, 43);
            this.statBiking.TabIndex = 20;
            this.statBiking.TrackValueChanged += new System.EventHandler(this.statBiking_TrackValueChanged);
            // 
            // statDriving
            // 
            this.statDriving.ControlCurrentValue = 0;
            this.statDriving.ControlLock = false;
            this.statDriving.ControlLockValue = 0;
            this.statDriving.ControlLockVisible = true;
            this.statDriving.ControlMaxValue = 1000;
            this.statDriving.ControlText = "Driving Skill";
            this.statDriving.ControlTick = 125;
            this.statDriving.ControlValueAsPercent = false;
            this.statDriving.Location = new System.Drawing.Point(185, 29);
            this.statDriving.Name = "statDriving";
            this.statDriving.Size = new System.Drawing.Size(172, 43);
            this.statDriving.TabIndex = 19;
            this.statDriving.TrackValueChanged += new System.EventHandler(this.statDriving_TrackValueChanged);
            // 
            // statMuscle
            // 
            this.statMuscle.ControlCurrentValue = 0;
            this.statMuscle.ControlLock = false;
            this.statMuscle.ControlLockValue = 0;
            this.statMuscle.ControlLockVisible = true;
            this.statMuscle.ControlMaxValue = 1000;
            this.statMuscle.ControlText = "Muscle";
            this.statMuscle.ControlTick = 125;
            this.statMuscle.ControlValueAsPercent = false;
            this.statMuscle.Location = new System.Drawing.Point(7, 225);
            this.statMuscle.Name = "statMuscle";
            this.statMuscle.Size = new System.Drawing.Size(172, 43);
            this.statMuscle.TabIndex = 18;
            this.statMuscle.TrackValueChanged += new System.EventHandler(this.statMuscle_TrackValueChanged);
            // 
            // statStamina
            // 
            this.statStamina.ControlCurrentValue = 0;
            this.statStamina.ControlLock = false;
            this.statStamina.ControlLockValue = 0;
            this.statStamina.ControlLockVisible = true;
            this.statStamina.ControlMaxValue = 1000;
            this.statStamina.ControlText = "Stamina";
            this.statStamina.ControlTick = 125;
            this.statStamina.ControlValueAsPercent = false;
            this.statStamina.Location = new System.Drawing.Point(7, 176);
            this.statStamina.Name = "statStamina";
            this.statStamina.Size = new System.Drawing.Size(172, 43);
            this.statStamina.TabIndex = 17;
            this.statStamina.TrackValueChanged += new System.EventHandler(this.statStamina_TrackValueChanged);
            // 
            // statFat
            // 
            this.statFat.ControlCurrentValue = 0;
            this.statFat.ControlLock = false;
            this.statFat.ControlLockValue = 0;
            this.statFat.ControlLockVisible = true;
            this.statFat.ControlMaxValue = 1000;
            this.statFat.ControlText = "Fat";
            this.statFat.ControlTick = 125;
            this.statFat.ControlValueAsPercent = false;
            this.statFat.Location = new System.Drawing.Point(7, 127);
            this.statFat.Name = "statFat";
            this.statFat.Size = new System.Drawing.Size(172, 43);
            this.statFat.TabIndex = 16;
            this.statFat.TrackValueChanged += new System.EventHandler(this.statFat_TrackValueChanged);
            // 
            // statArmour
            // 
            this.statArmour.ControlCurrentValue = 0;
            this.statArmour.ControlLock = false;
            this.statArmour.ControlLockValue = 0;
            this.statArmour.ControlLockVisible = true;
            this.statArmour.ControlMaxValue = 150;
            this.statArmour.ControlText = "Current Armour";
            this.statArmour.ControlTick = 50;
            this.statArmour.ControlValueAsPercent = false;
            this.statArmour.Location = new System.Drawing.Point(7, 78);
            this.statArmour.Name = "statArmour";
            this.statArmour.Size = new System.Drawing.Size(172, 43);
            this.statArmour.TabIndex = 14;
            this.statArmour.TrackValueChanged += new System.EventHandler(this.statArmour_TrackValueChanged);
            // 
            // statHealth
            // 
            this.statHealth.ControlCurrentValue = 0;
            this.statHealth.ControlLock = false;
            this.statHealth.ControlLockValue = 0;
            this.statHealth.ControlLockVisible = true;
            this.statHealth.ControlMaxValue = 400;
            this.statHealth.ControlText = "Current Health";
            this.statHealth.ControlTick = 50;
            this.statHealth.ControlValueAsPercent = false;
            this.statHealth.Location = new System.Drawing.Point(7, 29);
            this.statHealth.Name = "statHealth";
            this.statHealth.Size = new System.Drawing.Size(172, 43);
            this.statHealth.TabIndex = 13;
            this.statHealth.TrackValueChanged += new System.EventHandler(this.statHealth_TrackValueChanged);
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkCollisions);
            this.Controls.Add(this.chkExplosions);
            this.Controls.Add(this.chkFire);
            this.Controls.Add(this.chkBullets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWeaponSkills);
            this.Controls.Add(this.statGambling);
            this.Controls.Add(this.statLung);
            this.Controls.Add(this.statPlane);
            this.Controls.Add(this.statCycle);
            this.Controls.Add(this.statBiking);
            this.Controls.Add(this.statDriving);
            this.Controls.Add(this.statMuscle);
            this.Controls.Add(this.statStamina);
            this.Controls.Add(this.statFat);
            this.Controls.Add(this.statArmour);
            this.Controls.Add(this.statHealth);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label1);
            this.Name = "PlayerStats";
            this.Size = new System.Drawing.Size(781, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatControl statPlane;
        private StatControl statCycle;
        private StatControl statBiking;
        private StatControl statDriving;
        private StatControl statMuscle;
        private StatControl statStamina;
        private StatControl statFat;
        private StatControl statArmour;
        private StatControl statHealth;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private StatControl statLung;
        private StatControl statGambling;
        private System.Windows.Forms.Button btnWeaponSkills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBullets;
        private System.Windows.Forms.CheckBox chkFire;
        private System.Windows.Forms.CheckBox chkExplosions;
        private System.Windows.Forms.CheckBox chkCollisions;
    }
}
