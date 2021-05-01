
namespace LaunchpadHero
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.devicesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.testButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTileA = new MetroFramework.Controls.MetroTile();
            this.metroTileS = new MetroFramework.Controls.MetroTile();
            this.metroTileD = new MetroFramework.Controls.MetroTile();
            this.metroTileF = new MetroFramework.Controls.MetroTile();
            this.metroTileG = new MetroFramework.Controls.MetroTile();
            this.metroTileUp1 = new MetroFramework.Controls.MetroTile();
            this.metroTileUp2 = new MetroFramework.Controls.MetroTile();
            this.metroTileStar = new MetroFramework.Controls.MetroTile();
            this.labelWarning = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTileESC = new MetroFramework.Controls.MetroTile();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.refreshButtton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.ItemHeight = 23;
            this.devicesComboBox.Location = new System.Drawing.Point(23, 100);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(196, 29);
            this.devicesComboBox.TabIndex = 0;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Devices";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(23, 170);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(196, 29);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test Device";
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(252, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Settings";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(241, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(5, 500);
            this.metroTile1.TabIndex = 4;
            // 
            // metroTileA
            // 
            this.metroTileA.Location = new System.Drawing.Point(268, 63);
            this.metroTileA.Name = "metroTileA";
            this.metroTileA.Size = new System.Drawing.Size(64, 64);
            this.metroTileA.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileA.TabIndex = 5;
            this.metroTileA.Text = "A";
            this.metroTileA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileA_MouseClick);
            // 
            // metroTileS
            // 
            this.metroTileS.Location = new System.Drawing.Point(338, 63);
            this.metroTileS.Name = "metroTileS";
            this.metroTileS.Size = new System.Drawing.Size(64, 64);
            this.metroTileS.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileS.TabIndex = 6;
            this.metroTileS.Text = "S";
            this.metroTileS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileS_MouseClick);
            // 
            // metroTileD
            // 
            this.metroTileD.Location = new System.Drawing.Point(408, 63);
            this.metroTileD.Name = "metroTileD";
            this.metroTileD.Size = new System.Drawing.Size(64, 64);
            this.metroTileD.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileD.TabIndex = 7;
            this.metroTileD.Text = "D";
            this.metroTileD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileD_MouseClick);
            // 
            // metroTileF
            // 
            this.metroTileF.Location = new System.Drawing.Point(478, 63);
            this.metroTileF.Name = "metroTileF";
            this.metroTileF.Size = new System.Drawing.Size(64, 64);
            this.metroTileF.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTileF.TabIndex = 8;
            this.metroTileF.Text = "F";
            this.metroTileF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileF_MouseClick);
            // 
            // metroTileG
            // 
            this.metroTileG.Location = new System.Drawing.Point(548, 63);
            this.metroTileG.Name = "metroTileG";
            this.metroTileG.Size = new System.Drawing.Size(64, 64);
            this.metroTileG.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileG.TabIndex = 9;
            this.metroTileG.Text = "G";
            this.metroTileG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileG_MouseClick);
            // 
            // metroTileUp1
            // 
            this.metroTileUp1.Location = new System.Drawing.Point(268, 144);
            this.metroTileUp1.Name = "metroTileUp1";
            this.metroTileUp1.Size = new System.Drawing.Size(64, 64);
            this.metroTileUp1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTileUp1.TabIndex = 10;
            this.metroTileUp1.Text = "UP 1";
            this.metroTileUp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileUp1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileUp1_MouseClick);
            // 
            // metroTileUp2
            // 
            this.metroTileUp2.Location = new System.Drawing.Point(338, 144);
            this.metroTileUp2.Name = "metroTileUp2";
            this.metroTileUp2.Size = new System.Drawing.Size(64, 64);
            this.metroTileUp2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTileUp2.TabIndex = 11;
            this.metroTileUp2.Text = "UP 2";
            this.metroTileUp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileUp2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileUp2_MouseClick);
            // 
            // metroTileStar
            // 
            this.metroTileStar.Location = new System.Drawing.Point(408, 144);
            this.metroTileStar.Name = "metroTileStar";
            this.metroTileStar.Size = new System.Drawing.Size(64, 64);
            this.metroTileStar.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTileStar.TabIndex = 12;
            this.metroTileStar.Text = "STAR";
            this.metroTileStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileStar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileStar_MouseClick);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.CustomForeColor = true;
            this.labelWarning.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelWarning.ForeColor = System.Drawing.Color.White;
            this.labelWarning.Location = new System.Drawing.Point(258, 229);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(365, 25);
            this.labelWarning.TabIndex = 13;
            this.labelWarning.Text = "Click on a Launchpad Key to assign the control";
            this.labelWarning.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 205);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(196, 29);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "How To Setup";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTileESC
            // 
            this.metroTileESC.Location = new System.Drawing.Point(478, 144);
            this.metroTileESC.Name = "metroTileESC";
            this.metroTileESC.Size = new System.Drawing.Size(64, 64);
            this.metroTileESC.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTileESC.TabIndex = 15;
            this.metroTileESC.Text = "ESC";
            this.metroTileESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileESC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTileESC_MouseClick);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 280);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(196, 29);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Exit";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // refreshButtton
            // 
            this.refreshButtton.Location = new System.Drawing.Point(23, 135);
            this.refreshButtton.Name = "refreshButtton";
            this.refreshButtton.Size = new System.Drawing.Size(196, 29);
            this.refreshButtton.TabIndex = 17;
            this.refreshButtton.Text = "Refresh Devices";
            this.refreshButtton.Click += new System.EventHandler(this.refreshButtton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(66, 312);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 15);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "github.com/bruxo00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 332);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.refreshButtton);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTileESC);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.metroTileStar);
            this.Controls.Add(this.metroTileUp2);
            this.Controls.Add(this.metroTileUp1);
            this.Controls.Add(this.metroTileG);
            this.Controls.Add(this.metroTileF);
            this.Controls.Add(this.metroTileD);
            this.Controls.Add(this.metroTileS);
            this.Controls.Add(this.metroTileA);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.devicesComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Launchpad Hero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox devicesComboBox;
        private MetroFramework.Controls.MetroButton testButton;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTileStar;
        private MetroFramework.Controls.MetroTile metroTileUp2;
        private MetroFramework.Controls.MetroTile metroTileUp1;
        private MetroFramework.Controls.MetroTile metroTileG;
        private MetroFramework.Controls.MetroTile metroTileF;
        private MetroFramework.Controls.MetroTile metroTileD;
        private MetroFramework.Controls.MetroTile metroTileS;
        private MetroFramework.Controls.MetroTile metroTileA;
        private MetroFramework.Controls.MetroLabel labelWarning;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTileESC;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton refreshButtton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

