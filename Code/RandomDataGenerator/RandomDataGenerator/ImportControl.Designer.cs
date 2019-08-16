namespace RandomDataGenerator
{
    partial class ImportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportControl));
            this.FirstNamesControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ImportFirstNamesLabel = new System.Windows.Forms.Label();
            this.ImportFirstNamesButton = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.Graph2 = new System.Windows.Forms.ProgressBar();
            this.ImportLastNamesButton = new System.Windows.Forms.Button();
            this.ImportLastNamesLabel = new System.Windows.Forms.Label();
            this.LastNamesControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.Graph3 = new System.Windows.Forms.ProgressBar();
            this.ImportStreetNamesButton = new System.Windows.Forms.Button();
            this.ImportStreetNamesLabel = new System.Windows.Forms.Label();
            this.StreetNamesControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.Graph4 = new System.Windows.Forms.ProgressBar();
            this.ImportZipButton = new System.Windows.Forms.Button();
            this.ImportCityStateZipLabel = new System.Windows.Forms.Label();
            this.ZipCodeControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.SuspendLayout();
            // 
            // FirstNamesControl
            // 
            this.FirstNamesControl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNamesControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.FirstNamesControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("FirstNamesControl.ButtonImage")));
            this.FirstNamesControl.ButtonWidth = 48;
            this.FirstNamesControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.FirstNamesControl.Editable = false;
            this.FirstNamesControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.FirstNamesControl.Filter = null;
            this.FirstNamesControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.FirstNamesControl.HideBrowseButton = false;
            this.FirstNamesControl.LabelBottomMargin = 0;
            this.FirstNamesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FirstNamesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.FirstNamesControl.LabelText = "FirstNames.txt:";
            this.FirstNamesControl.LabelTopMargin = 0;
            this.FirstNamesControl.LabelWidth = 168;
            this.FirstNamesControl.Location = new System.Drawing.Point(20, 50);
            this.FirstNamesControl.Name = "FirstNamesControl";
            this.FirstNamesControl.OnTextChangedListener = null;
            this.FirstNamesControl.OpenCallback = null;
            this.FirstNamesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FirstNamesControl.SelectedPath = null;
            this.FirstNamesControl.Size = new System.Drawing.Size(754, 32);
            this.FirstNamesControl.StartPath = null;
            this.FirstNamesControl.TabIndex = 0;
            this.FirstNamesControl.TextBoxBottomMargin = 0;
            this.FirstNamesControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.FirstNamesControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.FirstNamesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.FirstNamesControl.TextBoxTopMargin = 0;
            this.FirstNamesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ImportFirstNamesLabel
            // 
            this.ImportFirstNamesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportFirstNamesLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportFirstNamesLabel.Location = new System.Drawing.Point(20, 20);
            this.ImportFirstNamesLabel.Name = "ImportFirstNamesLabel";
            this.ImportFirstNamesLabel.Size = new System.Drawing.Size(180, 23);
            this.ImportFirstNamesLabel.TabIndex = 1;
            this.ImportFirstNamesLabel.Text = "Import First Names";
            this.ImportFirstNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportFirstNamesButton
            // 
            this.ImportFirstNamesButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.BlackButton;
            this.ImportFirstNamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportFirstNamesButton.Enabled = false;
            this.ImportFirstNamesButton.FlatAppearance.BorderSize = 0;
            this.ImportFirstNamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImportFirstNamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImportFirstNamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportFirstNamesButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportFirstNamesButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportFirstNamesButton.Location = new System.Drawing.Point(780, 48);
            this.ImportFirstNamesButton.Name = "ImportFirstNamesButton";
            this.ImportFirstNamesButton.Size = new System.Drawing.Size(84, 36);
            this.ImportFirstNamesButton.TabIndex = 2;
            this.ImportFirstNamesButton.Text = "Start";
            this.ImportFirstNamesButton.UseVisualStyleBackColor = true;
            this.ImportFirstNamesButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.ImportFirstNamesButton.Click += new System.EventHandler(this.ImportFirstNamesButton_Click);
            this.ImportFirstNamesButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportFirstNamesButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(23, 92);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(751, 16);
            this.Graph.TabIndex = 3;
            this.Graph.Visible = false;
            // 
            // Graph2
            // 
            this.Graph2.Location = new System.Drawing.Point(23, 208);
            this.Graph2.Name = "Graph2";
            this.Graph2.Size = new System.Drawing.Size(751, 16);
            this.Graph2.TabIndex = 7;
            this.Graph2.Visible = false;
            // 
            // ImportLastNamesButton
            // 
            this.ImportLastNamesButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.BlackButton;
            this.ImportLastNamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportLastNamesButton.Enabled = false;
            this.ImportLastNamesButton.FlatAppearance.BorderSize = 0;
            this.ImportLastNamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImportLastNamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImportLastNamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportLastNamesButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLastNamesButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportLastNamesButton.Location = new System.Drawing.Point(780, 164);
            this.ImportLastNamesButton.Name = "ImportLastNamesButton";
            this.ImportLastNamesButton.Size = new System.Drawing.Size(84, 36);
            this.ImportLastNamesButton.TabIndex = 6;
            this.ImportLastNamesButton.Text = "Start";
            this.ImportLastNamesButton.UseVisualStyleBackColor = true;
            this.ImportLastNamesButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.ImportLastNamesButton.Click += new System.EventHandler(this.ImportLastNamesButton_Click);
            this.ImportLastNamesButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportLastNamesButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ImportLastNamesLabel
            // 
            this.ImportLastNamesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLastNamesLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportLastNamesLabel.Location = new System.Drawing.Point(20, 136);
            this.ImportLastNamesLabel.Name = "ImportLastNamesLabel";
            this.ImportLastNamesLabel.Size = new System.Drawing.Size(180, 23);
            this.ImportLastNamesLabel.TabIndex = 5;
            this.ImportLastNamesLabel.Text = "Import Last Names";
            this.ImportLastNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNamesControl
            // 
            this.LastNamesControl.BackColor = System.Drawing.Color.Transparent;
            this.LastNamesControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.LastNamesControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("LastNamesControl.ButtonImage")));
            this.LastNamesControl.ButtonWidth = 48;
            this.LastNamesControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.LastNamesControl.Editable = false;
            this.LastNamesControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.LastNamesControl.Filter = null;
            this.LastNamesControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.LastNamesControl.HideBrowseButton = false;
            this.LastNamesControl.LabelBottomMargin = 0;
            this.LastNamesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.LastNamesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.LastNamesControl.LabelText = "LastNames.txt:";
            this.LastNamesControl.LabelTopMargin = 0;
            this.LastNamesControl.LabelWidth = 168;
            this.LastNamesControl.Location = new System.Drawing.Point(20, 166);
            this.LastNamesControl.Name = "LastNamesControl";
            this.LastNamesControl.OnTextChangedListener = null;
            this.LastNamesControl.OpenCallback = null;
            this.LastNamesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNamesControl.SelectedPath = null;
            this.LastNamesControl.Size = new System.Drawing.Size(754, 32);
            this.LastNamesControl.StartPath = null;
            this.LastNamesControl.TabIndex = 4;
            this.LastNamesControl.TextBoxBottomMargin = 0;
            this.LastNamesControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.LastNamesControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.LastNamesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.LastNamesControl.TextBoxTopMargin = 0;
            this.LastNamesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph3
            // 
            this.Graph3.Location = new System.Drawing.Point(23, 324);
            this.Graph3.Name = "Graph3";
            this.Graph3.Size = new System.Drawing.Size(751, 16);
            this.Graph3.TabIndex = 11;
            this.Graph3.Visible = false;
            // 
            // ImportStreetNamesButton
            // 
            this.ImportStreetNamesButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.BlackButton;
            this.ImportStreetNamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportStreetNamesButton.Enabled = false;
            this.ImportStreetNamesButton.FlatAppearance.BorderSize = 0;
            this.ImportStreetNamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImportStreetNamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImportStreetNamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportStreetNamesButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportStreetNamesButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportStreetNamesButton.Location = new System.Drawing.Point(780, 280);
            this.ImportStreetNamesButton.Name = "ImportStreetNamesButton";
            this.ImportStreetNamesButton.Size = new System.Drawing.Size(84, 36);
            this.ImportStreetNamesButton.TabIndex = 10;
            this.ImportStreetNamesButton.Text = "Start";
            this.ImportStreetNamesButton.UseVisualStyleBackColor = true;
            this.ImportStreetNamesButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.ImportStreetNamesButton.Click += new System.EventHandler(this.ImportStreetNamesButton_Click);
            this.ImportStreetNamesButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportStreetNamesButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ImportStreetNamesLabel
            // 
            this.ImportStreetNamesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportStreetNamesLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportStreetNamesLabel.Location = new System.Drawing.Point(20, 252);
            this.ImportStreetNamesLabel.Name = "ImportStreetNamesLabel";
            this.ImportStreetNamesLabel.Size = new System.Drawing.Size(324, 23);
            this.ImportStreetNamesLabel.TabIndex = 9;
            this.ImportStreetNamesLabel.Text = "Import Street Names";
            this.ImportStreetNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StreetNamesControl
            // 
            this.StreetNamesControl.BackColor = System.Drawing.Color.Transparent;
            this.StreetNamesControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.StreetNamesControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("StreetNamesControl.ButtonImage")));
            this.StreetNamesControl.ButtonWidth = 48;
            this.StreetNamesControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.StreetNamesControl.Editable = false;
            this.StreetNamesControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.StreetNamesControl.Filter = null;
            this.StreetNamesControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.StreetNamesControl.HideBrowseButton = false;
            this.StreetNamesControl.LabelBottomMargin = 0;
            this.StreetNamesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StreetNamesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.StreetNamesControl.LabelText = "StreetNames.txt:";
            this.StreetNamesControl.LabelTopMargin = 0;
            this.StreetNamesControl.LabelWidth = 168;
            this.StreetNamesControl.Location = new System.Drawing.Point(20, 282);
            this.StreetNamesControl.Name = "StreetNamesControl";
            this.StreetNamesControl.OnTextChangedListener = null;
            this.StreetNamesControl.OpenCallback = null;
            this.StreetNamesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StreetNamesControl.SelectedPath = null;
            this.StreetNamesControl.Size = new System.Drawing.Size(754, 32);
            this.StreetNamesControl.StartPath = null;
            this.StreetNamesControl.TabIndex = 8;
            this.StreetNamesControl.TextBoxBottomMargin = 0;
            this.StreetNamesControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.StreetNamesControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.StreetNamesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.StreetNamesControl.TextBoxTopMargin = 0;
            this.StreetNamesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph4
            // 
            this.Graph4.Location = new System.Drawing.Point(23, 440);
            this.Graph4.Name = "Graph4";
            this.Graph4.Size = new System.Drawing.Size(751, 16);
            this.Graph4.TabIndex = 15;
            this.Graph4.Visible = false;
            // 
            // ImportZipButton
            // 
            this.ImportZipButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.BlackButton;
            this.ImportZipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportZipButton.Enabled = false;
            this.ImportZipButton.FlatAppearance.BorderSize = 0;
            this.ImportZipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImportZipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImportZipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportZipButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportZipButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportZipButton.Location = new System.Drawing.Point(780, 396);
            this.ImportZipButton.Name = "ImportZipButton";
            this.ImportZipButton.Size = new System.Drawing.Size(84, 36);
            this.ImportZipButton.TabIndex = 14;
            this.ImportZipButton.Text = "Start";
            this.ImportZipButton.UseVisualStyleBackColor = true;
            this.ImportZipButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.ImportZipButton.Click += new System.EventHandler(this.ImportZipButton_Click);
            this.ImportZipButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ImportZipButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ImportCityStateZipLabel
            // 
            this.ImportCityStateZipLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportCityStateZipLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ImportCityStateZipLabel.Location = new System.Drawing.Point(20, 368);
            this.ImportCityStateZipLabel.Name = "ImportCityStateZipLabel";
            this.ImportCityStateZipLabel.Size = new System.Drawing.Size(324, 23);
            this.ImportCityStateZipLabel.TabIndex = 13;
            this.ImportCityStateZipLabel.Text = "Import City State Zip";
            this.ImportCityStateZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ZipCodeControl
            // 
            this.ZipCodeControl.BackColor = System.Drawing.Color.Transparent;
            this.ZipCodeControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.ZipCodeControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ZipCodeControl.ButtonImage")));
            this.ZipCodeControl.ButtonWidth = 48;
            this.ZipCodeControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.ZipCodeControl.Editable = false;
            this.ZipCodeControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodeControl.Filter = null;
            this.ZipCodeControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.ZipCodeControl.HideBrowseButton = false;
            this.ZipCodeControl.LabelBottomMargin = 0;
            this.ZipCodeControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodeControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ZipCodeControl.LabelText = "USA-Zip.txt";
            this.ZipCodeControl.LabelTopMargin = 0;
            this.ZipCodeControl.LabelWidth = 168;
            this.ZipCodeControl.Location = new System.Drawing.Point(20, 398);
            this.ZipCodeControl.Name = "ZipCodeControl";
            this.ZipCodeControl.OnTextChangedListener = null;
            this.ZipCodeControl.OpenCallback = null;
            this.ZipCodeControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ZipCodeControl.SelectedPath = null;
            this.ZipCodeControl.Size = new System.Drawing.Size(754, 32);
            this.ZipCodeControl.StartPath = null;
            this.ZipCodeControl.TabIndex = 12;
            this.ZipCodeControl.TextBoxBottomMargin = 0;
            this.ZipCodeControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ZipCodeControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ZipCodeControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.ZipCodeControl.TextBoxTopMargin = 0;
            this.ZipCodeControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ImportControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Graph4);
            this.Controls.Add(this.ImportZipButton);
            this.Controls.Add(this.ImportCityStateZipLabel);
            this.Controls.Add(this.ZipCodeControl);
            this.Controls.Add(this.Graph3);
            this.Controls.Add(this.ImportStreetNamesButton);
            this.Controls.Add(this.ImportStreetNamesLabel);
            this.Controls.Add(this.StreetNamesControl);
            this.Controls.Add(this.Graph2);
            this.Controls.Add(this.ImportLastNamesButton);
            this.Controls.Add(this.ImportLastNamesLabel);
            this.Controls.Add(this.LastNamesControl);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.ImportFirstNamesButton);
            this.Controls.Add(this.ImportFirstNamesLabel);
            this.Controls.Add(this.FirstNamesControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImportControl";
            this.Size = new System.Drawing.Size(1080, 640);
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl FirstNamesControl;
        private System.Windows.Forms.Label ImportFirstNamesLabel;
        private System.Windows.Forms.Button ImportFirstNamesButton;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.ProgressBar Graph2;
        private System.Windows.Forms.Button ImportLastNamesButton;
        private System.Windows.Forms.Label ImportLastNamesLabel;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl LastNamesControl;
        private System.Windows.Forms.ProgressBar Graph3;
        private System.Windows.Forms.Button ImportStreetNamesButton;
        private System.Windows.Forms.Label ImportStreetNamesLabel;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl StreetNamesControl;
        private System.Windows.Forms.ProgressBar Graph4;
        private System.Windows.Forms.Button ImportZipButton;
        private System.Windows.Forms.Label ImportCityStateZipLabel;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ZipCodeControl;
    }
}
