

#region using statements


#endregion

namespace RandomDataGenerator
{

    #region class MemberCreatorControl
    /// <summary>
    /// method [Enter Method Description]
    /// </summary>
    partial class MemberCreatorControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxControl MinAddressNumberControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl MaxAddressNumberControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl StreetNamesCountControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl ZipCodesCountControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl LastNamesCountControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl FirstNamesCountControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl MembersToCreateControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl UseDataTierNetCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl UseEntityFrameworkCheckBox;
        private System.Windows.Forms.Button CreateMembersButton;
        private System.Windows.Forms.Button DoneButton;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.CreateMembersButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.PercentApartmentsSlider = new System.Windows.Forms.TrackBar();
            this.PercentNumericSlider = new System.Windows.Forms.TrackBar();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PercentUnitNumericControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.PercentApartmentsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.UseEntityFrameworkCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.UseDataTierNetCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.MembersToCreateControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.LastNamesCountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.FirstNamesCountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.ZipCodesCountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StreetNamesCountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.MaxAddressNumberControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.MinAddressNumberControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StatusMessageLabel = new System.Windows.Forms.Label();
            this.CreateShufflersButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PercentApartmentsSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumericSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateMembersButton
            // 
            this.CreateMembersButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateMembersButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.WoodButtonWidth640Disabled;
            this.CreateMembersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateMembersButton.Enabled = false;
            this.CreateMembersButton.FlatAppearance.BorderSize = 0;
            this.CreateMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMembersButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMembersButton.Location = new System.Drawing.Point(370, 440);
            this.CreateMembersButton.Name = "CreateMembersButton";
            this.CreateMembersButton.Size = new System.Drawing.Size(180, 36);
            this.CreateMembersButton.TabIndex = 11;
            this.CreateMembersButton.Text = "Create Members";
            this.CreateMembersButton.UseVisualStyleBackColor = false;
            this.CreateMembersButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.CreateMembersButton.Click += new System.EventHandler(this.CreateMembersButton_Click);
            this.CreateMembersButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.CreateMembersButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.WoodButtonWidth640;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(642, 440);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(80, 36);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            this.DoneButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.DoneButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // PercentApartmentsSlider
            // 
            this.PercentApartmentsSlider.LargeChange = 1;
            this.PercentApartmentsSlider.Location = new System.Drawing.Point(314, 96);
            this.PercentApartmentsSlider.Name = "PercentApartmentsSlider";
            this.PercentApartmentsSlider.Size = new System.Drawing.Size(400, 45);
            this.PercentApartmentsSlider.TabIndex = 16;
            this.PercentApartmentsSlider.TabStop = false;
            this.PercentApartmentsSlider.ValueChanged += new System.EventHandler(this.PercentApartmentsSlider_ValueChanged);
            // 
            // PercentNumericSlider
            // 
            this.PercentNumericSlider.LargeChange = 1;
            this.PercentNumericSlider.Location = new System.Drawing.Point(314, 138);
            this.PercentNumericSlider.Name = "PercentNumericSlider";
            this.PercentNumericSlider.Size = new System.Drawing.Size(400, 45);
            this.PercentNumericSlider.TabIndex = 17;
            this.PercentNumericSlider.TabStop = false;
            this.PercentNumericSlider.ValueChanged += new System.EventHandler(this.PercentNumericSlider_ValueChanged);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadDataButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.WoodButtonWidth640;
            this.LoadDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadDataButton.FlatAppearance.BorderSize = 0;
            this.LoadDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoadDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoadDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDataButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataButton.Location = new System.Drawing.Point(42, 440);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(136, 36);
            this.LoadDataButton.TabIndex = 18;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = false;
            this.LoadDataButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            this.LoadDataButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.LoadDataButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(28, 407);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(694, 16);
            this.Graph.TabIndex = 19;
            this.Graph.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(25, 386);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(71, 20);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.Visible = false;
            // 
            // PercentUnitNumericControl
            // 
            this.PercentUnitNumericControl.BackColor = System.Drawing.Color.Transparent;
            this.PercentUnitNumericControl.BottomMargin = 0;
            this.PercentUnitNumericControl.Editable = true;
            this.PercentUnitNumericControl.Encrypted = false;
            this.PercentUnitNumericControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentUnitNumericControl.LabelBottomMargin = 0;
            this.PercentUnitNumericControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.PercentUnitNumericControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.PercentUnitNumericControl.LabelText = "% Unit Numeric:";
            this.PercentUnitNumericControl.LabelTopMargin = 0;
            this.PercentUnitNumericControl.LabelWidth = 180;
            this.PercentUnitNumericControl.Location = new System.Drawing.Point(18, 140);
            this.PercentUnitNumericControl.MultiLine = false;
            this.PercentUnitNumericControl.Name = "PercentUnitNumericControl";
            this.PercentUnitNumericControl.OnTextChangedListener = null;
            this.PercentUnitNumericControl.PasswordMode = false;
            this.PercentUnitNumericControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PercentUnitNumericControl.Size = new System.Drawing.Size(288, 32);
            this.PercentUnitNumericControl.TabIndex = 5;
            this.PercentUnitNumericControl.TextBoxBottomMargin = 0;
            this.PercentUnitNumericControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.PercentUnitNumericControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.PercentUnitNumericControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.PercentUnitNumericControl.TextBoxTopMargin = 0;
            // 
            // PercentApartmentsControl
            // 
            this.PercentApartmentsControl.BackColor = System.Drawing.Color.Transparent;
            this.PercentApartmentsControl.BottomMargin = 0;
            this.PercentApartmentsControl.Editable = true;
            this.PercentApartmentsControl.Encrypted = false;
            this.PercentApartmentsControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentApartmentsControl.LabelBottomMargin = 0;
            this.PercentApartmentsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.PercentApartmentsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.PercentApartmentsControl.LabelText = "% Apartments:";
            this.PercentApartmentsControl.LabelTopMargin = 0;
            this.PercentApartmentsControl.LabelWidth = 180;
            this.PercentApartmentsControl.Location = new System.Drawing.Point(18, 98);
            this.PercentApartmentsControl.MultiLine = false;
            this.PercentApartmentsControl.Name = "PercentApartmentsControl";
            this.PercentApartmentsControl.OnTextChangedListener = null;
            this.PercentApartmentsControl.PasswordMode = false;
            this.PercentApartmentsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PercentApartmentsControl.Size = new System.Drawing.Size(288, 32);
            this.PercentApartmentsControl.TabIndex = 4;
            this.PercentApartmentsControl.TextBoxBottomMargin = 0;
            this.PercentApartmentsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.PercentApartmentsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.PercentApartmentsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.PercentApartmentsControl.TextBoxTopMargin = 0;
            // 
            // UseEntityFrameworkCheckBox
            // 
            this.UseEntityFrameworkCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.UseEntityFrameworkCheckBox.CheckBoxHorizontalOffSet = 0;
            this.UseEntityFrameworkCheckBox.CheckBoxVerticalOffSet = 4;
            this.UseEntityFrameworkCheckBox.CheckChangedListener = null;
            this.UseEntityFrameworkCheckBox.Checked = false;
            this.UseEntityFrameworkCheckBox.Editable = true;
            this.UseEntityFrameworkCheckBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseEntityFrameworkCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.UseEntityFrameworkCheckBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseEntityFrameworkCheckBox.LabelText = "Entity Framework:";
            this.UseEntityFrameworkCheckBox.LabelWidth = 180;
            this.UseEntityFrameworkCheckBox.Location = new System.Drawing.Point(388, 340);
            this.UseEntityFrameworkCheckBox.Name = "UseEntityFrameworkCheckBox";
            this.UseEntityFrameworkCheckBox.Size = new System.Drawing.Size(206, 28);
            this.UseEntityFrameworkCheckBox.TabIndex = 12;
            // 
            // UseDataTierNetCheckBox
            // 
            this.UseDataTierNetCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.UseDataTierNetCheckBox.CheckBoxHorizontalOffSet = 0;
            this.UseDataTierNetCheckBox.CheckBoxVerticalOffSet = 4;
            this.UseDataTierNetCheckBox.CheckChangedListener = null;
            this.UseDataTierNetCheckBox.Checked = true;
            this.UseDataTierNetCheckBox.Editable = true;
            this.UseDataTierNetCheckBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDataTierNetCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.UseDataTierNetCheckBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDataTierNetCheckBox.LabelText = "DataTier.Net:";
            this.UseDataTierNetCheckBox.LabelWidth = 180;
            this.UseDataTierNetCheckBox.Location = new System.Drawing.Point(388, 306);
            this.UseDataTierNetCheckBox.Name = "UseDataTierNetCheckBox";
            this.UseDataTierNetCheckBox.Size = new System.Drawing.Size(206, 28);
            this.UseDataTierNetCheckBox.TabIndex = 11;
            // 
            // MembersToCreateControl
            // 
            this.MembersToCreateControl.BackColor = System.Drawing.Color.Transparent;
            this.MembersToCreateControl.BottomMargin = 0;
            this.MembersToCreateControl.Editable = true;
            this.MembersToCreateControl.Encrypted = false;
            this.MembersToCreateControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersToCreateControl.LabelBottomMargin = 0;
            this.MembersToCreateControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MembersToCreateControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.MembersToCreateControl.LabelText = "Create Members #:";
            this.MembersToCreateControl.LabelTopMargin = 0;
            this.MembersToCreateControl.LabelWidth = 180;
            this.MembersToCreateControl.Location = new System.Drawing.Point(20, 340);
            this.MembersToCreateControl.MultiLine = false;
            this.MembersToCreateControl.Name = "MembersToCreateControl";
            this.MembersToCreateControl.OnTextChangedListener = null;
            this.MembersToCreateControl.PasswordMode = false;
            this.MembersToCreateControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MembersToCreateControl.Size = new System.Drawing.Size(288, 32);
            this.MembersToCreateControl.TabIndex = 8;
            this.MembersToCreateControl.TextBoxBottomMargin = 0;
            this.MembersToCreateControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MembersToCreateControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MembersToCreateControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.MembersToCreateControl.TextBoxTopMargin = 0;
            // 
            // LastNamesCountControl
            // 
            this.LastNamesCountControl.BackColor = System.Drawing.Color.Transparent;
            this.LastNamesCountControl.BottomMargin = 0;
            this.LastNamesCountControl.Editable = true;
            this.LastNamesCountControl.Encrypted = false;
            this.LastNamesCountControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamesCountControl.LabelBottomMargin = 0;
            this.LastNamesCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.LastNamesCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.LastNamesCountControl.LabelText = "Last Names #:";
            this.LastNamesCountControl.LabelTopMargin = 0;
            this.LastNamesCountControl.LabelWidth = 180;
            this.LastNamesCountControl.Location = new System.Drawing.Point(20, 220);
            this.LastNamesCountControl.MultiLine = false;
            this.LastNamesCountControl.Name = "LastNamesCountControl";
            this.LastNamesCountControl.OnTextChangedListener = null;
            this.LastNamesCountControl.PasswordMode = false;
            this.LastNamesCountControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNamesCountControl.Size = new System.Drawing.Size(288, 32);
            this.LastNamesCountControl.TabIndex = 1;
            this.LastNamesCountControl.TextBoxBottomMargin = 0;
            this.LastNamesCountControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.LastNamesCountControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.LastNamesCountControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.LastNamesCountControl.TextBoxTopMargin = 0;
            // 
            // FirstNamesCountControl
            // 
            this.FirstNamesCountControl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNamesCountControl.BottomMargin = 0;
            this.FirstNamesCountControl.Editable = true;
            this.FirstNamesCountControl.Encrypted = false;
            this.FirstNamesCountControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamesCountControl.LabelBottomMargin = 0;
            this.FirstNamesCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FirstNamesCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.FirstNamesCountControl.LabelText = "First Names #:";
            this.FirstNamesCountControl.LabelTopMargin = 0;
            this.FirstNamesCountControl.LabelWidth = 180;
            this.FirstNamesCountControl.Location = new System.Drawing.Point(20, 180);
            this.FirstNamesCountControl.MultiLine = false;
            this.FirstNamesCountControl.Name = "FirstNamesCountControl";
            this.FirstNamesCountControl.OnTextChangedListener = null;
            this.FirstNamesCountControl.PasswordMode = false;
            this.FirstNamesCountControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FirstNamesCountControl.Size = new System.Drawing.Size(288, 32);
            this.FirstNamesCountControl.TabIndex = 0;
            this.FirstNamesCountControl.TextBoxBottomMargin = 0;
            this.FirstNamesCountControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.FirstNamesCountControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.FirstNamesCountControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.FirstNamesCountControl.TextBoxTopMargin = 0;
            // 
            // ZipCodesCountControl
            // 
            this.ZipCodesCountControl.BackColor = System.Drawing.Color.Transparent;
            this.ZipCodesCountControl.BottomMargin = 0;
            this.ZipCodesCountControl.Editable = true;
            this.ZipCodesCountControl.Encrypted = false;
            this.ZipCodesCountControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipCodesCountControl.LabelBottomMargin = 0;
            this.ZipCodesCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodesCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.ZipCodesCountControl.LabelText = "Zip Codes #:";
            this.ZipCodesCountControl.LabelTopMargin = 0;
            this.ZipCodesCountControl.LabelWidth = 180;
            this.ZipCodesCountControl.Location = new System.Drawing.Point(20, 300);
            this.ZipCodesCountControl.MultiLine = false;
            this.ZipCodesCountControl.Name = "ZipCodesCountControl";
            this.ZipCodesCountControl.OnTextChangedListener = null;
            this.ZipCodesCountControl.PasswordMode = false;
            this.ZipCodesCountControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ZipCodesCountControl.Size = new System.Drawing.Size(288, 32);
            this.ZipCodesCountControl.TabIndex = 7;
            this.ZipCodesCountControl.TextBoxBottomMargin = 0;
            this.ZipCodesCountControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ZipCodesCountControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ZipCodesCountControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.ZipCodesCountControl.TextBoxTopMargin = 0;
            // 
            // StreetNamesCountControl
            // 
            this.StreetNamesCountControl.BackColor = System.Drawing.Color.Transparent;
            this.StreetNamesCountControl.BottomMargin = 0;
            this.StreetNamesCountControl.Editable = true;
            this.StreetNamesCountControl.Encrypted = false;
            this.StreetNamesCountControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNamesCountControl.LabelBottomMargin = 0;
            this.StreetNamesCountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StreetNamesCountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.StreetNamesCountControl.LabelText = "St Names #:";
            this.StreetNamesCountControl.LabelTopMargin = 0;
            this.StreetNamesCountControl.LabelWidth = 180;
            this.StreetNamesCountControl.Location = new System.Drawing.Point(20, 260);
            this.StreetNamesCountControl.MultiLine = false;
            this.StreetNamesCountControl.Name = "StreetNamesCountControl";
            this.StreetNamesCountControl.OnTextChangedListener = null;
            this.StreetNamesCountControl.PasswordMode = false;
            this.StreetNamesCountControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StreetNamesCountControl.Size = new System.Drawing.Size(288, 32);
            this.StreetNamesCountControl.TabIndex = 6;
            this.StreetNamesCountControl.TextBoxBottomMargin = 0;
            this.StreetNamesCountControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.StreetNamesCountControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.StreetNamesCountControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.StreetNamesCountControl.TextBoxTopMargin = 0;
            // 
            // MaxAddressNumberControl
            // 
            this.MaxAddressNumberControl.BackColor = System.Drawing.Color.Transparent;
            this.MaxAddressNumberControl.BottomMargin = 0;
            this.MaxAddressNumberControl.Editable = true;
            this.MaxAddressNumberControl.Encrypted = false;
            this.MaxAddressNumberControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxAddressNumberControl.LabelBottomMargin = 0;
            this.MaxAddressNumberControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MaxAddressNumberControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.MaxAddressNumberControl.LabelText = "Max Street #:";
            this.MaxAddressNumberControl.LabelTopMargin = 0;
            this.MaxAddressNumberControl.LabelWidth = 180;
            this.MaxAddressNumberControl.Location = new System.Drawing.Point(18, 60);
            this.MaxAddressNumberControl.MultiLine = false;
            this.MaxAddressNumberControl.Name = "MaxAddressNumberControl";
            this.MaxAddressNumberControl.OnTextChangedListener = null;
            this.MaxAddressNumberControl.PasswordMode = false;
            this.MaxAddressNumberControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MaxAddressNumberControl.Size = new System.Drawing.Size(288, 32);
            this.MaxAddressNumberControl.TabIndex = 3;
            this.MaxAddressNumberControl.TextBoxBottomMargin = 0;
            this.MaxAddressNumberControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MaxAddressNumberControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MaxAddressNumberControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.MaxAddressNumberControl.TextBoxTopMargin = 0;
            // 
            // MinAddressNumberControl
            // 
            this.MinAddressNumberControl.BackColor = System.Drawing.Color.Transparent;
            this.MinAddressNumberControl.BottomMargin = 0;
            this.MinAddressNumberControl.Editable = true;
            this.MinAddressNumberControl.Encrypted = false;
            this.MinAddressNumberControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinAddressNumberControl.LabelBottomMargin = 0;
            this.MinAddressNumberControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MinAddressNumberControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.MinAddressNumberControl.LabelText = "Min Street #:";
            this.MinAddressNumberControl.LabelTopMargin = 0;
            this.MinAddressNumberControl.LabelWidth = 180;
            this.MinAddressNumberControl.Location = new System.Drawing.Point(18, 20);
            this.MinAddressNumberControl.MultiLine = false;
            this.MinAddressNumberControl.Name = "MinAddressNumberControl";
            this.MinAddressNumberControl.OnTextChangedListener = null;
            this.MinAddressNumberControl.PasswordMode = false;
            this.MinAddressNumberControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MinAddressNumberControl.Size = new System.Drawing.Size(288, 32);
            this.MinAddressNumberControl.TabIndex = 2;
            this.MinAddressNumberControl.TextBoxBottomMargin = 0;
            this.MinAddressNumberControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MinAddressNumberControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MinAddressNumberControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.MinAddressNumberControl.TextBoxTopMargin = 0;
            // 
            // StatusMessageLabel
            // 
            this.StatusMessageLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMessageLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusMessageLabel.Location = new System.Drawing.Point(92, 386);
            this.StatusMessageLabel.Name = "StatusMessageLabel";
            this.StatusMessageLabel.Size = new System.Drawing.Size(622, 20);
            this.StatusMessageLabel.TabIndex = 21;
            this.StatusMessageLabel.Visible = false;
            // 
            // CreateShufflersButton
            // 
            this.CreateShufflersButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateShufflersButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.WoodButtonWidth640Disabled;
            this.CreateShufflersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateShufflersButton.Enabled = false;
            this.CreateShufflersButton.FlatAppearance.BorderSize = 0;
            this.CreateShufflersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateShufflersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateShufflersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateShufflersButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateShufflersButton.Location = new System.Drawing.Point(184, 440);
            this.CreateShufflersButton.Name = "CreateShufflersButton";
            this.CreateShufflersButton.Size = new System.Drawing.Size(180, 36);
            this.CreateShufflersButton.TabIndex = 22;
            this.CreateShufflersButton.Text = "Create Shufflers";
            this.CreateShufflersButton.UseVisualStyleBackColor = false;
            this.CreateShufflersButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.CreateShufflersButton.Click += new System.EventHandler(this.CreateShufflersButton_Click);
            this.CreateShufflersButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.CreateShufflersButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImage = global::RandomDataGenerator.Properties.Resources.WoodButtonWidth640Disabled;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(556, 440);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 36);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.SaveButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // MemberCreatorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CreateShufflersButton);
            this.Controls.Add(this.StatusMessageLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.PercentNumericSlider);
            this.Controls.Add(this.PercentApartmentsSlider);
            this.Controls.Add(this.PercentUnitNumericControl);
            this.Controls.Add(this.PercentApartmentsControl);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CreateMembersButton);
            this.Controls.Add(this.UseEntityFrameworkCheckBox);
            this.Controls.Add(this.UseDataTierNetCheckBox);
            this.Controls.Add(this.MembersToCreateControl);
            this.Controls.Add(this.LastNamesCountControl);
            this.Controls.Add(this.FirstNamesCountControl);
            this.Controls.Add(this.ZipCodesCountControl);
            this.Controls.Add(this.StreetNamesCountControl);
            this.Controls.Add(this.MaxAddressNumberControl);
            this.Controls.Add(this.MinAddressNumberControl);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MemberCreatorControl";
            this.Size = new System.Drawing.Size(748, 496);
            ((System.ComponentModel.ISupportInitialize)(this.PercentApartmentsSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumericSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }
        #endregion

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl PercentApartmentsControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl PercentUnitNumericControl;
        private System.Windows.Forms.TrackBar PercentApartmentsSlider;
        private System.Windows.Forms.TrackBar PercentNumericSlider;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusMessageLabel;
        private System.Windows.Forms.Button CreateShufflersButton;
        private System.Windows.Forms.Button SaveButton;
    }
    #endregion

}
