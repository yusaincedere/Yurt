namespace Yurt
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.girisButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.sifreGosterGirisCheck = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.passwordText = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tcNoText = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.topPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.kucultButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.genisletButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.icon = new Bunifu.UI.WinForms.BunifuImageButton();
            this.kapatButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.girisMesaj = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisButton
            // 
            this.girisButton.ActiveBorderThickness = 1;
            this.girisButton.ActiveCornerRadius = 1;
            this.girisButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.girisButton.ActiveForecolor = System.Drawing.Color.White;
            this.girisButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.girisButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisButton.BackgroundImage")));
            this.girisButton.ButtonText = "Giriş Yap";
            this.girisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.girisButton.IdleBorderThickness = 1;
            this.girisButton.IdleCornerRadius = 1;
            this.girisButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.girisButton.IdleForecolor = System.Drawing.Color.White;
            this.girisButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.girisButton.Location = new System.Drawing.Point(141, 398);
            this.girisButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(154, 54);
            this.girisButton.TabIndex = 1;
            this.girisButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.girisButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuLabel4);
            this.panel1.Controls.Add(this.sifreGosterGirisCheck);
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.tcNoText);
            this.panel1.Location = new System.Drawing.Point(81, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 275);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel4.Location = new System.Drawing.Point(72, 199);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(78, 17);
            this.bunifuLabel4.TabIndex = 5;
            this.bunifuLabel4.Text = "Şifreyi Göster";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // sifreGosterGirisCheck
            // 
            this.sifreGosterGirisCheck.AllowBindingControlAnimation = true;
            this.sifreGosterGirisCheck.AllowBindingControlColorChanges = false;
            this.sifreGosterGirisCheck.AllowBindingControlLocation = true;
            this.sifreGosterGirisCheck.AllowCheckBoxAnimation = false;
            this.sifreGosterGirisCheck.AllowCheckmarkAnimation = true;
            this.sifreGosterGirisCheck.AllowOnHoverStates = true;
            this.sifreGosterGirisCheck.AutoCheck = true;
            this.sifreGosterGirisCheck.BackColor = System.Drawing.Color.Transparent;
            this.sifreGosterGirisCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sifreGosterGirisCheck.BackgroundImage")));
            this.sifreGosterGirisCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sifreGosterGirisCheck.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.sifreGosterGirisCheck.BorderRadius = 12;
            this.sifreGosterGirisCheck.Checked = false;
            this.sifreGosterGirisCheck.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.sifreGosterGirisCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.sifreGosterGirisCheck.CustomCheckmarkImage = null;
            this.sifreGosterGirisCheck.Location = new System.Drawing.Point(160, 192);
            this.sifreGosterGirisCheck.MinimumSize = new System.Drawing.Size(17, 17);
            this.sifreGosterGirisCheck.Name = "sifreGosterGirisCheck";
            this.sifreGosterGirisCheck.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.sifreGosterGirisCheck.OnCheck.BorderRadius = 12;
            this.sifreGosterGirisCheck.OnCheck.BorderThickness = 2;
            this.sifreGosterGirisCheck.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.sifreGosterGirisCheck.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.sifreGosterGirisCheck.OnCheck.CheckmarkThickness = 2;
            this.sifreGosterGirisCheck.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.sifreGosterGirisCheck.OnDisable.BorderRadius = 12;
            this.sifreGosterGirisCheck.OnDisable.BorderThickness = 2;
            this.sifreGosterGirisCheck.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.sifreGosterGirisCheck.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.sifreGosterGirisCheck.OnDisable.CheckmarkThickness = 2;
            this.sifreGosterGirisCheck.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sifreGosterGirisCheck.OnHoverChecked.BorderRadius = 12;
            this.sifreGosterGirisCheck.OnHoverChecked.BorderThickness = 2;
            this.sifreGosterGirisCheck.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sifreGosterGirisCheck.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.sifreGosterGirisCheck.OnHoverChecked.CheckmarkThickness = 2;
            this.sifreGosterGirisCheck.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sifreGosterGirisCheck.OnHoverUnchecked.BorderRadius = 12;
            this.sifreGosterGirisCheck.OnHoverUnchecked.BorderThickness = 1;
            this.sifreGosterGirisCheck.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.sifreGosterGirisCheck.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.sifreGosterGirisCheck.OnUncheck.BorderRadius = 12;
            this.sifreGosterGirisCheck.OnUncheck.BorderThickness = 1;
            this.sifreGosterGirisCheck.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.sifreGosterGirisCheck.Size = new System.Drawing.Size(22, 22);
            this.sifreGosterGirisCheck.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.sifreGosterGirisCheck.TabIndex = 4;
            this.sifreGosterGirisCheck.ThreeState = false;
            this.sifreGosterGirisCheck.ToolTipText = null;
            this.sifreGosterGirisCheck.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.bunifuCheckBox1_CheckedChanged);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel2.Location = new System.Drawing.Point(52, 117);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(26, 17);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Şifre";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // passwordText
            // 
            this.passwordText.AcceptsReturn = false;
            this.passwordText.AcceptsTab = false;
            this.passwordText.AnimationSpeed = 200;
            this.passwordText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordText.BackColor = System.Drawing.Color.Transparent;
            this.passwordText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordText.BackgroundImage")));
            this.passwordText.BorderColorActive = System.Drawing.Color.Gray;
            this.passwordText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordText.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordText.BorderColorIdle = System.Drawing.Color.Gray;
            this.passwordText.BorderRadius = 1;
            this.passwordText.BorderThickness = 2;
            this.passwordText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passwordText.DefaultText = "";
            this.passwordText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.passwordText.ForeColor = System.Drawing.Color.Silver;
            this.passwordText.HideSelection = true;
            this.passwordText.IconLeft = null;
            this.passwordText.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.IconPadding = 10;
            this.passwordText.IconRight = null;
            this.passwordText.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.Lines = new string[0];
            this.passwordText.Location = new System.Drawing.Point(52, 149);
            this.passwordText.MaxLength = 11;
            this.passwordText.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordText.Modified = false;
            this.passwordText.Multiline = false;
            this.passwordText.Name = "passwordText";
            stateProperties9.BorderColor = System.Drawing.Color.Gray;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordText.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordText.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordText.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Gray;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            stateProperties12.ForeColor = System.Drawing.Color.Silver;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordText.OnIdleState = stateProperties12;
            this.passwordText.Padding = new System.Windows.Forms.Padding(3);
            this.passwordText.PasswordChar = '*';
            this.passwordText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordText.PlaceholderText = "";
            this.passwordText.ReadOnly = false;
            this.passwordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.ShortcutsEnabled = true;
            this.passwordText.Size = new System.Drawing.Size(130, 37);
            this.passwordText.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordText.TabIndex = 2;
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordText.TextMarginBottom = 0;
            this.passwordText.TextMarginLeft = 3;
            this.passwordText.TextMarginTop = 0;
            this.passwordText.TextPlaceholder = "";
            this.passwordText.UseSystemPasswordChar = false;
            this.passwordText.WordWrap = true;
            this.passwordText.TextChanged += new System.EventHandler(this.bunifuTextBox2_TextChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel1.Location = new System.Drawing.Point(52, 40);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(34, 17);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "TC No";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // tcNoText
            // 
            this.tcNoText.AcceptsReturn = false;
            this.tcNoText.AcceptsTab = false;
            this.tcNoText.AnimationSpeed = 200;
            this.tcNoText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tcNoText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tcNoText.BackColor = System.Drawing.Color.Transparent;
            this.tcNoText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcNoText.BackgroundImage")));
            this.tcNoText.BorderColorActive = System.Drawing.Color.Gray;
            this.tcNoText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tcNoText.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tcNoText.BorderColorIdle = System.Drawing.Color.Gray;
            this.tcNoText.BorderRadius = 1;
            this.tcNoText.BorderThickness = 2;
            this.tcNoText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tcNoText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcNoText.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tcNoText.DefaultText = "";
            this.tcNoText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.tcNoText.ForeColor = System.Drawing.Color.Silver;
            this.tcNoText.HideSelection = true;
            this.tcNoText.IconLeft = null;
            this.tcNoText.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tcNoText.IconPadding = 10;
            this.tcNoText.IconRight = null;
            this.tcNoText.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tcNoText.Lines = new string[0];
            this.tcNoText.Location = new System.Drawing.Point(52, 63);
            this.tcNoText.MaxLength = 11;
            this.tcNoText.MinimumSize = new System.Drawing.Size(1, 1);
            this.tcNoText.Modified = false;
            this.tcNoText.Multiline = false;
            this.tcNoText.Name = "tcNoText";
            stateProperties13.BorderColor = System.Drawing.Color.Gray;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tcNoText.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tcNoText.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tcNoText.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Gray;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            stateProperties16.ForeColor = System.Drawing.Color.Silver;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tcNoText.OnIdleState = stateProperties16;
            this.tcNoText.Padding = new System.Windows.Forms.Padding(3);
            this.tcNoText.PasswordChar = '\0';
            this.tcNoText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tcNoText.PlaceholderText = "";
            this.tcNoText.ReadOnly = false;
            this.tcNoText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tcNoText.SelectedText = "";
            this.tcNoText.SelectionLength = 0;
            this.tcNoText.SelectionStart = 0;
            this.tcNoText.ShortcutsEnabled = true;
            this.tcNoText.Size = new System.Drawing.Size(130, 37);
            this.tcNoText.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tcNoText.TabIndex = 0;
            this.tcNoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tcNoText.TextMarginBottom = 0;
            this.tcNoText.TextMarginLeft = 3;
            this.tcNoText.TextMarginTop = 0;
            this.tcNoText.TextPlaceholder = "";
            this.tcNoText.UseSystemPasswordChar = false;
            this.tcNoText.WordWrap = true;
            this.tcNoText.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuLabel3.Location = new System.Drawing.Point(133, 54);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(136, 21);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "KIRKLARELİ YURDU";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.BorderRadius = 3;
            this.topPanel.BorderThickness = 1;
            this.topPanel.Controls.Add(this.kucultButton);
            this.topPanel.Controls.Add(this.genisletButton);
            this.topPanel.Controls.Add(this.icon);
            this.topPanel.Controls.Add(this.kapatButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShowBorders = true;
            this.topPanel.Size = new System.Drawing.Size(447, 33);
            this.topPanel.TabIndex = 9;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // kucultButton
            // 
            this.kucultButton.ActiveImage = null;
            this.kucultButton.AllowAnimations = true;
            this.kucultButton.AllowBuffering = false;
            this.kucultButton.AllowToggling = false;
            this.kucultButton.AllowZooming = true;
            this.kucultButton.AllowZoomingOnFocus = false;
            this.kucultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kucultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kucultButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kucultButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("kucultButton.ErrorImage")));
            this.kucultButton.FadeWhenInactive = false;
            this.kucultButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.kucultButton.Image = global::Yurt.Properties.Resources.kucult;
            this.kucultButton.ImageActive = null;
            this.kucultButton.ImageLocation = null;
            this.kucultButton.ImageMargin = 10;
            this.kucultButton.ImageSize = new System.Drawing.Size(17, 17);
            this.kucultButton.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.kucultButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("kucultButton.InitialImage")));
            this.kucultButton.Location = new System.Drawing.Point(350, 3);
            this.kucultButton.Name = "kucultButton";
            this.kucultButton.Rotation = 0;
            this.kucultButton.ShowActiveImage = true;
            this.kucultButton.ShowCursorChanges = true;
            this.kucultButton.ShowImageBorders = true;
            this.kucultButton.ShowSizeMarkers = false;
            this.kucultButton.Size = new System.Drawing.Size(27, 27);
            this.kucultButton.TabIndex = 8;
            this.kucultButton.ToolTipText = "";
            this.kucultButton.WaitOnLoad = false;
            this.kucultButton.Zoom = 10;
            this.kucultButton.ZoomSpeed = 10;
            this.kucultButton.Click += new System.EventHandler(this.kucultButton_Click);
            // 
            // genisletButton
            // 
            this.genisletButton.ActiveImage = null;
            this.genisletButton.AllowAnimations = true;
            this.genisletButton.AllowBuffering = false;
            this.genisletButton.AllowToggling = false;
            this.genisletButton.AllowZooming = true;
            this.genisletButton.AllowZoomingOnFocus = false;
            this.genisletButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genisletButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.genisletButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.genisletButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("genisletButton.ErrorImage")));
            this.genisletButton.FadeWhenInactive = false;
            this.genisletButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.genisletButton.Image = global::Yurt.Properties.Resources.genislet;
            this.genisletButton.ImageActive = null;
            this.genisletButton.ImageLocation = null;
            this.genisletButton.ImageMargin = 10;
            this.genisletButton.ImageSize = new System.Drawing.Size(17, 17);
            this.genisletButton.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.genisletButton.InitialImage = null;
            this.genisletButton.Location = new System.Drawing.Point(383, 3);
            this.genisletButton.Name = "genisletButton";
            this.genisletButton.Rotation = 0;
            this.genisletButton.ShowActiveImage = true;
            this.genisletButton.ShowCursorChanges = true;
            this.genisletButton.ShowImageBorders = true;
            this.genisletButton.ShowSizeMarkers = false;
            this.genisletButton.Size = new System.Drawing.Size(27, 27);
            this.genisletButton.TabIndex = 7;
            this.genisletButton.ToolTipText = "";
            this.genisletButton.WaitOnLoad = false;
            this.genisletButton.Zoom = 10;
            this.genisletButton.ZoomSpeed = 10;
            this.genisletButton.Click += new System.EventHandler(this.genisletButton_Click);
            // 
            // icon
            // 
            this.icon.ActiveImage = null;
            this.icon.AllowAnimations = true;
            this.icon.AllowBuffering = false;
            this.icon.AllowToggling = false;
            this.icon.AllowZooming = true;
            this.icon.AllowZoomingOnFocus = false;
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.icon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.icon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("icon.ErrorImage")));
            this.icon.FadeWhenInactive = false;
            this.icon.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.ImageActive = null;
            this.icon.ImageLocation = null;
            this.icon.ImageMargin = 10;
            this.icon.ImageSize = new System.Drawing.Size(17, 17);
            this.icon.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("icon.InitialImage")));
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Rotation = 0;
            this.icon.ShowActiveImage = true;
            this.icon.ShowCursorChanges = true;
            this.icon.ShowImageBorders = true;
            this.icon.ShowSizeMarkers = false;
            this.icon.Size = new System.Drawing.Size(27, 27);
            this.icon.TabIndex = 6;
            this.icon.ToolTipText = "";
            this.icon.WaitOnLoad = false;
            this.icon.Zoom = 10;
            this.icon.ZoomSpeed = 10;
            // 
            // kapatButton
            // 
            this.kapatButton.ActiveImage = null;
            this.kapatButton.AllowAnimations = true;
            this.kapatButton.AllowBuffering = false;
            this.kapatButton.AllowToggling = false;
            this.kapatButton.AllowZooming = true;
            this.kapatButton.AllowZoomingOnFocus = false;
            this.kapatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kapatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.kapatButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kapatButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("kapatButton.ErrorImage")));
            this.kapatButton.FadeWhenInactive = false;
            this.kapatButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.kapatButton.Image = global::Yurt.Properties.Resources.kapat;
            this.kapatButton.ImageActive = null;
            this.kapatButton.ImageLocation = null;
            this.kapatButton.ImageMargin = 10;
            this.kapatButton.ImageSize = new System.Drawing.Size(17, 17);
            this.kapatButton.ImageZoomSize = new System.Drawing.Size(27, 27);
            this.kapatButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("kapatButton.InitialImage")));
            this.kapatButton.Location = new System.Drawing.Point(416, 3);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Rotation = 0;
            this.kapatButton.ShowActiveImage = true;
            this.kapatButton.ShowCursorChanges = true;
            this.kapatButton.ShowImageBorders = true;
            this.kapatButton.ShowSizeMarkers = false;
            this.kapatButton.Size = new System.Drawing.Size(27, 27);
            this.kapatButton.TabIndex = 5;
            this.kapatButton.ToolTipText = "";
            this.kapatButton.WaitOnLoad = false;
            this.kapatButton.Zoom = 10;
            this.kapatButton.ZoomSpeed = 10;
            this.kapatButton.Click += new System.EventHandler(this.kapatButton_Click);
            // 
            // girisMesaj
            // 
            this.girisMesaj.AllowParentOverrides = false;
            this.girisMesaj.AutoEllipsis = false;
            this.girisMesaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.girisMesaj.CursorType = System.Windows.Forms.Cursors.Default;
            this.girisMesaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisMesaj.ForeColor = System.Drawing.Color.DarkGray;
            this.girisMesaj.Location = new System.Drawing.Point(133, 350);
            this.girisMesaj.Name = "girisMesaj";
            this.girisMesaj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.girisMesaj.Size = new System.Drawing.Size(0, 0);
            this.girisMesaj.TabIndex = 10;
            this.girisMesaj.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.girisMesaj.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.girisMesaj.Visible = false;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(447, 489);
            this.Controls.Add(this.girisMesaj);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.girisButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 girisButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox passwordText;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox tcNoText;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPanel topPanel;
        private Bunifu.UI.WinForms.BunifuImageButton kucultButton;
        private Bunifu.UI.WinForms.BunifuImageButton genisletButton;
        private Bunifu.UI.WinForms.BunifuImageButton icon;
        private Bunifu.UI.WinForms.BunifuImageButton kapatButton;
        private Bunifu.UI.WinForms.BunifuLabel girisMesaj;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuCheckBox sifreGosterGirisCheck;
    }
}