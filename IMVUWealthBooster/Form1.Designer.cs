namespace IMVUWealthBooster
{
    partial class Form1
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
            this.loadCombosBtn = new MetroFramework.Controls.MetroButton();
            this.loadProxiesBtn = new MetroFramework.Controls.MetroButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.proxyTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.botCountTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.botCountLabel = new MetroFramework.Controls.MetroLabel();
            this.startStopBtn = new MetroFramework.Controls.MetroButton();
            this.selectItemMetroBox = new MetroFramework.Controls.MetroButton();
            this.itemNameLabel = new MetroFramework.Controls.MetroLabel();
            this.selectItemTextBox = new MetroFramework.Controls.MetroTextBox();
            this.itemPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.combosProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.totalWealthLabel = new MetroFramework.Controls.MetroLabel();
            this.retriesLabel = new MetroFramework.Controls.MetroLabel();
            this.totalWealthLabelValue = new MetroFramework.Controls.MetroLabel();
            this.retriesLabelValue = new MetroFramework.Controls.MetroLabel();
            this.deadAccountsLabelValue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // loadCombosBtn
            // 
            this.loadCombosBtn.Location = new System.Drawing.Point(23, 63);
            this.loadCombosBtn.Name = "loadCombosBtn";
            this.loadCombosBtn.Size = new System.Drawing.Size(122, 40);
            this.loadCombosBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.loadCombosBtn.TabIndex = 0;
            this.loadCombosBtn.Text = "Load Combos";
            this.loadCombosBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadCombosBtn.UseSelectable = true;
            this.loadCombosBtn.UseStyleColors = true;
            this.loadCombosBtn.Click += new System.EventHandler(this.LoadCombosBtn_Click);
            // 
            // loadProxiesBtn
            // 
            this.loadProxiesBtn.Location = new System.Drawing.Point(23, 109);
            this.loadProxiesBtn.Name = "loadProxiesBtn";
            this.loadProxiesBtn.Size = new System.Drawing.Size(122, 40);
            this.loadProxiesBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.loadProxiesBtn.TabIndex = 1;
            this.loadProxiesBtn.Text = "Load Proxies";
            this.loadProxiesBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadProxiesBtn.UseSelectable = true;
            this.loadProxiesBtn.UseStyleColors = true;
            this.loadProxiesBtn.Click += new System.EventHandler(this.LoadProxiesBtn_Click);
            // 
            // proxyTypeComboBox
            // 
            this.proxyTypeComboBox.FormattingEnabled = true;
            this.proxyTypeComboBox.ItemHeight = 23;
            this.proxyTypeComboBox.Items.AddRange(new object[] {
            "NONE",
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.proxyTypeComboBox.Location = new System.Drawing.Point(23, 178);
            this.proxyTypeComboBox.Name = "proxyTypeComboBox";
            this.proxyTypeComboBox.Size = new System.Drawing.Size(122, 29);
            this.proxyTypeComboBox.TabIndex = 2;
            this.proxyTypeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.proxyTypeComboBox.UseSelectable = true;
            this.proxyTypeComboBox.UseStyleColors = true;
            this.proxyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ProxyTypeComboBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Choose Proxy Type";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // botCountTrackBar
            // 
            this.botCountTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.botCountTrackBar.Location = new System.Drawing.Point(23, 232);
            this.botCountTrackBar.Maximum = 500;
            this.botCountTrackBar.Minimum = 1;
            this.botCountTrackBar.Name = "botCountTrackBar";
            this.botCountTrackBar.Size = new System.Drawing.Size(250, 23);
            this.botCountTrackBar.Style = MetroFramework.MetroColorStyle.Teal;
            this.botCountTrackBar.TabIndex = 4;
            this.botCountTrackBar.Text = "metroTrackBar1";
            this.botCountTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.botCountTrackBar.Value = 20;
            this.botCountTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BotCountTrackBar_Scroll);
            // 
            // botCountLabel
            // 
            this.botCountLabel.AutoSize = true;
            this.botCountLabel.Location = new System.Drawing.Point(23, 210);
            this.botCountLabel.Name = "botCountLabel";
            this.botCountLabel.Size = new System.Drawing.Size(89, 19);
            this.botCountLabel.TabIndex = 5;
            this.botCountLabel.Text = "Bot Count: 20";
            this.botCountLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.botCountLabel.UseStyleColors = true;
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(23, 387);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(250, 40);
            this.startStopBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.startStopBtn.TabIndex = 6;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startStopBtn.UseSelectable = true;
            this.startStopBtn.UseStyleColors = true;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // selectItemMetroBox
            // 
            this.selectItemMetroBox.Location = new System.Drawing.Point(151, 109);
            this.selectItemMetroBox.Name = "selectItemMetroBox";
            this.selectItemMetroBox.Size = new System.Drawing.Size(122, 40);
            this.selectItemMetroBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.selectItemMetroBox.TabIndex = 7;
            this.selectItemMetroBox.Text = "Select Item";
            this.selectItemMetroBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectItemMetroBox.UseSelectable = true;
            this.selectItemMetroBox.UseStyleColors = true;
            this.selectItemMetroBox.Click += new System.EventHandler(this.SelectItemMetroBox_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(151, 155);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(48, 19);
            this.itemNameLabel.TabIndex = 8;
            this.itemNameLabel.Text = "Name:";
            this.itemNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.itemNameLabel.UseStyleColors = true;
            // 
            // selectItemTextBox
            // 
            // 
            // 
            // 
            this.selectItemTextBox.CustomButton.Image = null;
            this.selectItemTextBox.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.selectItemTextBox.CustomButton.Name = "";
            this.selectItemTextBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.selectItemTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.selectItemTextBox.CustomButton.TabIndex = 1;
            this.selectItemTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.selectItemTextBox.CustomButton.UseSelectable = true;
            this.selectItemTextBox.CustomButton.Visible = false;
            this.selectItemTextBox.Lines = new string[0];
            this.selectItemTextBox.Location = new System.Drawing.Point(151, 63);
            this.selectItemTextBox.MaxLength = 32767;
            this.selectItemTextBox.Name = "selectItemTextBox";
            this.selectItemTextBox.PasswordChar = '\0';
            this.selectItemTextBox.PromptText = "Enter Item ID here";
            this.selectItemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.selectItemTextBox.SelectedText = "";
            this.selectItemTextBox.SelectionLength = 0;
            this.selectItemTextBox.SelectionStart = 0;
            this.selectItemTextBox.ShortcutsEnabled = true;
            this.selectItemTextBox.Size = new System.Drawing.Size(122, 40);
            this.selectItemTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.selectItemTextBox.TabIndex = 9;
            this.selectItemTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.selectItemTextBox.UseSelectable = true;
            this.selectItemTextBox.WaterMark = "Enter Item ID here";
            this.selectItemTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.selectItemTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(151, 178);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(41, 19);
            this.itemPriceLabel.TabIndex = 10;
            this.itemPriceLabel.Text = "Price:";
            this.itemPriceLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.itemPriceLabel.UseStyleColors = true;
            // 
            // combosProgressBar
            // 
            this.combosProgressBar.Location = new System.Drawing.Point(23, 358);
            this.combosProgressBar.Name = "combosProgressBar";
            this.combosProgressBar.Size = new System.Drawing.Size(250, 23);
            this.combosProgressBar.Style = MetroFramework.MetroColorStyle.Teal;
            this.combosProgressBar.TabIndex = 11;
            this.combosProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // totalWealthLabel
            // 
            this.totalWealthLabel.AutoSize = true;
            this.totalWealthLabel.Location = new System.Drawing.Point(23, 262);
            this.totalWealthLabel.Name = "totalWealthLabel";
            this.totalWealthLabel.Size = new System.Drawing.Size(90, 19);
            this.totalWealthLabel.TabIndex = 12;
            this.totalWealthLabel.Text = "Total Wealth: ";
            this.totalWealthLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.totalWealthLabel.UseStyleColors = true;
            // 
            // retriesLabel
            // 
            this.retriesLabel.AutoSize = true;
            this.retriesLabel.Location = new System.Drawing.Point(23, 290);
            this.retriesLabel.Name = "retriesLabel";
            this.retriesLabel.Size = new System.Drawing.Size(51, 19);
            this.retriesLabel.TabIndex = 13;
            this.retriesLabel.Text = "Retries:";
            this.retriesLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.retriesLabel.UseStyleColors = true;
            // 
            // totalWealthLabelValue
            // 
            this.totalWealthLabelValue.AutoSize = true;
            this.totalWealthLabelValue.Location = new System.Drawing.Point(126, 262);
            this.totalWealthLabelValue.Name = "totalWealthLabelValue";
            this.totalWealthLabelValue.Size = new System.Drawing.Size(16, 19);
            this.totalWealthLabelValue.Style = MetroFramework.MetroColorStyle.Green;
            this.totalWealthLabelValue.TabIndex = 14;
            this.totalWealthLabelValue.Text = "0";
            this.totalWealthLabelValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // retriesLabelValue
            // 
            this.retriesLabelValue.AutoSize = true;
            this.retriesLabelValue.Location = new System.Drawing.Point(126, 290);
            this.retriesLabelValue.Name = "retriesLabelValue";
            this.retriesLabelValue.Size = new System.Drawing.Size(16, 19);
            this.retriesLabelValue.Style = MetroFramework.MetroColorStyle.Green;
            this.retriesLabelValue.TabIndex = 15;
            this.retriesLabelValue.Text = "0";
            this.retriesLabelValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // deadAccountsLabelValue
            // 
            this.deadAccountsLabelValue.AutoSize = true;
            this.deadAccountsLabelValue.Location = new System.Drawing.Point(126, 319);
            this.deadAccountsLabelValue.Name = "deadAccountsLabelValue";
            this.deadAccountsLabelValue.Size = new System.Drawing.Size(16, 19);
            this.deadAccountsLabelValue.Style = MetroFramework.MetroColorStyle.Green;
            this.deadAccountsLabelValue.TabIndex = 17;
            this.deadAccountsLabelValue.Text = "0";
            this.deadAccountsLabelValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 319);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Dead Accounts:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.deadAccountsLabelValue);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.retriesLabelValue);
            this.Controls.Add(this.totalWealthLabelValue);
            this.Controls.Add(this.retriesLabel);
            this.Controls.Add(this.totalWealthLabel);
            this.Controls.Add(this.combosProgressBar);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.selectItemTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.selectItemMetroBox);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.botCountLabel);
            this.Controls.Add(this.botCountTrackBar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.proxyTypeComboBox);
            this.Controls.Add(this.loadProxiesBtn);
            this.Controls.Add(this.loadCombosBtn);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "IMVU Wealth Booster";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton loadCombosBtn;
        private MetroFramework.Controls.MetroButton loadProxiesBtn;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private MetroFramework.Controls.MetroComboBox proxyTypeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar botCountTrackBar;
        private MetroFramework.Controls.MetroLabel botCountLabel;
        private MetroFramework.Controls.MetroButton startStopBtn;
        private MetroFramework.Controls.MetroButton selectItemMetroBox;
        private MetroFramework.Controls.MetroLabel itemNameLabel;
        private MetroFramework.Controls.MetroTextBox selectItemTextBox;
        private MetroFramework.Controls.MetroLabel itemPriceLabel;
        private MetroFramework.Controls.MetroProgressBar combosProgressBar;
        private MetroFramework.Controls.MetroLabel totalWealthLabel;
        private MetroFramework.Controls.MetroLabel retriesLabel;
        private MetroFramework.Controls.MetroLabel totalWealthLabelValue;
        private MetroFramework.Controls.MetroLabel retriesLabelValue;
        private MetroFramework.Controls.MetroLabel deadAccountsLabelValue;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

