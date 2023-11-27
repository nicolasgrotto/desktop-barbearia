namespace interdisciplinar2
{
    partial class MainScreen
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblAgendamentos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleButton1 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.panelLeftBtn = new System.Windows.Forms.Panel();
            this.ibAlterarSenha = new FontAwesome.Sharp.IconButton();
            this.ibDashboard = new FontAwesome.Sharp.IconButton();
            this.ibHistorico = new FontAwesome.Sharp.IconButton();
            this.ibAgendamentos = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ipbMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.ipbMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            this.ipbFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelMainForms = new System.Windows.Forms.Panel();
            this.timerToggleButton = new System.Windows.Forms.Timer(this.components);
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.panelLeft.SuspendLayout();
            this.pnlDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFormIcon)).BeginInit();
            this.panelMainForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.panelLeft.Controls.Add(this.pnlDropDown);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.toggleButton1);
            this.panelLeft.Controls.Add(this.panelLeftBtn);
            this.panelLeft.Controls.Add(this.ibAlterarSenha);
            this.panelLeft.Controls.Add(this.ibDashboard);
            this.panelLeft.Controls.Add(this.ibHistorico);
            this.panelLeft.Controls.Add(this.ibAgendamentos);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 600);
            this.panelLeft.TabIndex = 0;
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDropDown.Controls.Add(this.lblHistorico);
            this.pnlDropDown.Controls.Add(this.lblAgendamentos);
            this.pnlDropDown.Location = new System.Drawing.Point(0, 438);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(220, 70);
            this.pnlDropDown.TabIndex = 3;
            this.pnlDropDown.Visible = false;
            // 
            // lblHistorico
            // 
            this.lblHistorico.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHistorico.Location = new System.Drawing.Point(0, 35);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(220, 35);
            this.lblHistorico.TabIndex = 4;
            this.lblHistorico.Text = "Histórico";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHistorico.Click += new System.EventHandler(this.lblHistorico_Click);
            this.lblHistorico.MouseEnter += new System.EventHandler(this.lblHistorico_MouseEnter);
            this.lblHistorico.MouseLeave += new System.EventHandler(this.lblHistorico_MouseLeave);
            // 
            // lblAgendamentos
            // 
            this.lblAgendamentos.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAgendamentos.Location = new System.Drawing.Point(0, 0);
            this.lblAgendamentos.Name = "lblAgendamentos";
            this.lblAgendamentos.Size = new System.Drawing.Size(220, 35);
            this.lblAgendamentos.TabIndex = 3;
            this.lblAgendamentos.Text = "Agendamentos Futuros";
            this.lblAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgendamentos.Click += new System.EventHandler(this.lblAgendamentos_Click);
            this.lblAgendamentos.MouseEnter += new System.EventHandler(this.lblAgendamentos_MouseEnter);
            this.lblAgendamentos.MouseLeave += new System.EventHandler(this.lblAgendamentos_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modo Escuro";
            // 
            // toggleButton1
            // 
            activeStateCollection1.Text = "DESATIVAR";
            this.toggleButton1.ActiveState = activeStateCollection1;
            this.toggleButton1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.Text = "ATIVAR";
            this.toggleButton1.InactiveState = inactiveStateCollection1;
            this.toggleButton1.Location = new System.Drawing.Point(129, 539);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(75, 30);
            this.toggleButton1.Slider = sliderCollection1;
            this.toggleButton1.TabIndex = 4;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.ThemeName = "";
            this.toggleButton1.ThemeStyle.ActiveForeColor = System.Drawing.Color.White;
            this.toggleButton1.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.toggleButton1.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.toggleButton1.ThemeStyle.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleButton1_ToggleStateChanged);
            this.toggleButton1.Click += new System.EventHandler(this.toggleButton1_Click);
            // 
            // panelLeftBtn
            // 
            this.panelLeftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.panelLeftBtn.Location = new System.Drawing.Point(3, 200);
            this.panelLeftBtn.Name = "panelLeftBtn";
            this.panelLeftBtn.Size = new System.Drawing.Size(7, 58);
            this.panelLeftBtn.TabIndex = 2;
            this.panelLeftBtn.Visible = false;
            // 
            // ibAlterarSenha
            // 
            this.ibAlterarSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibAlterarSenha.FlatAppearance.BorderSize = 0;
            this.ibAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAlterarSenha.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAlterarSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibAlterarSenha.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.ibAlterarSenha.IconColor = System.Drawing.Color.White;
            this.ibAlterarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAlterarSenha.Location = new System.Drawing.Point(0, 374);
            this.ibAlterarSenha.Name = "ibAlterarSenha";
            this.ibAlterarSenha.Size = new System.Drawing.Size(220, 58);
            this.ibAlterarSenha.TabIndex = 3;
            this.ibAlterarSenha.Text = "Alterar Senha";
            this.ibAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAlterarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAlterarSenha.UseVisualStyleBackColor = true;
            this.ibAlterarSenha.Click += new System.EventHandler(this.ibAlterarSenha_Click);
            this.ibAlterarSenha.MouseEnter += new System.EventHandler(this.ibAlterarSenha_MouseEnter);
            this.ibAlterarSenha.MouseLeave += new System.EventHandler(this.ibAlterarSenha_MouseLeave);
            // 
            // ibDashboard
            // 
            this.ibDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibDashboard.FlatAppearance.BorderSize = 0;
            this.ibDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDashboard.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibDashboard.IconColor = System.Drawing.Color.White;
            this.ibDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDashboard.Location = new System.Drawing.Point(0, 316);
            this.ibDashboard.Name = "ibDashboard";
            this.ibDashboard.Size = new System.Drawing.Size(220, 58);
            this.ibDashboard.TabIndex = 2;
            this.ibDashboard.Text = "Dashboard";
            this.ibDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibDashboard.UseVisualStyleBackColor = true;
            this.ibDashboard.Click += new System.EventHandler(this.ibDashboard_Click);
            this.ibDashboard.MouseEnter += new System.EventHandler(this.ibDashboard_MouseEnter);
            this.ibDashboard.MouseLeave += new System.EventHandler(this.ibDashboard_MouseLeave);
            // 
            // ibHistorico
            // 
            this.ibHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibHistorico.FlatAppearance.BorderSize = 0;
            this.ibHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibHistorico.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibHistorico.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.ibHistorico.IconColor = System.Drawing.Color.White;
            this.ibHistorico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHistorico.Location = new System.Drawing.Point(0, 258);
            this.ibHistorico.Name = "ibHistorico";
            this.ibHistorico.Size = new System.Drawing.Size(220, 58);
            this.ibHistorico.TabIndex = 1;
            this.ibHistorico.Text = "Agendamentos";
            this.ibHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibHistorico.UseVisualStyleBackColor = true;
            this.ibHistorico.Click += new System.EventHandler(this.ibHistorico_Click);
            this.ibHistorico.MouseEnter += new System.EventHandler(this.ibHistorico_MouseEnter);
            this.ibHistorico.MouseLeave += new System.EventHandler(this.ibHistorico_MouseLeave);
            // 
            // ibAgendamentos
            // 
            this.ibAgendamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ibAgendamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibAgendamentos.FlatAppearance.BorderSize = 0;
            this.ibAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgendamentos.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAgendamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibAgendamentos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibAgendamentos.IconColor = System.Drawing.Color.White;
            this.ibAgendamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgendamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgendamentos.Location = new System.Drawing.Point(0, 200);
            this.ibAgendamentos.Name = "ibAgendamentos";
            this.ibAgendamentos.Size = new System.Drawing.Size(220, 58);
            this.ibAgendamentos.TabIndex = 1;
            this.ibAgendamentos.Text = "Agendamentos";
            this.ibAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAgendamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAgendamentos.UseVisualStyleBackColor = false;
            this.ibAgendamentos.Click += new System.EventHandler(this.ibAgendamentos_Click);
            this.ibAgendamentos.MouseEnter += new System.EventHandler(this.ibAgendamentos_MouseEnter);
            this.ibAgendamentos.MouseLeave += new System.EventHandler(this.ibAgendamentos_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 200);
            this.panel1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::interdisciplinar2.Properties.Resources.barber_logo_no_bg_removebg_preview;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(220, 200);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.ipbMinimize);
            this.panelHeader.Controls.Add(this.ipbMaximize);
            this.panelHeader.Controls.Add(this.lblFormName);
            this.panelHeader.Controls.Add(this.ipbFormIcon);
            this.panelHeader.Controls.Add(this.lblExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(780, 39);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // ipbMinimize
            // 
            this.ipbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ipbMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ipbMinimize.IconColor = System.Drawing.Color.White;
            this.ipbMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMinimize.IconSize = 41;
            this.ipbMinimize.Location = new System.Drawing.Point(663, 0);
            this.ipbMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ipbMinimize.Name = "ipbMinimize";
            this.ipbMinimize.Size = new System.Drawing.Size(43, 41);
            this.ipbMinimize.TabIndex = 7;
            this.ipbMinimize.TabStop = false;
            this.ipbMinimize.Click += new System.EventHandler(this.ipbMinimize_Click);
            this.ipbMinimize.MouseEnter += new System.EventHandler(this.ipbMinimize_MouseEnter);
            this.ipbMinimize.MouseLeave += new System.EventHandler(this.ipbMinimize_MouseLeave);
            // 
            // ipbMaximize
            // 
            this.ipbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ipbMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ipbMaximize.IconColor = System.Drawing.Color.White;
            this.ipbMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMaximize.IconSize = 38;
            this.ipbMaximize.Location = new System.Drawing.Point(706, 0);
            this.ipbMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.ipbMaximize.Name = "ipbMaximize";
            this.ipbMaximize.Size = new System.Drawing.Size(38, 41);
            this.ipbMaximize.TabIndex = 6;
            this.ipbMaximize.TabStop = false;
            this.ipbMaximize.Click += new System.EventHandler(this.ipbMaximize_Click);
            this.ipbMaximize.MouseEnter += new System.EventHandler(this.ipbMaximize_MouseEnter);
            this.ipbMaximize.MouseLeave += new System.EventHandler(this.ipbMaximize_MouseLeave);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormName.Location = new System.Drawing.Point(59, 9);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(60, 28);
            this.lblFormName.TabIndex = 5;
            this.lblFormName.Text = "Home";
            // 
            // ipbFormIcon
            // 
            this.ipbFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ipbFormIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ipbFormIcon.IconColor = System.Drawing.Color.White;
            this.ipbFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbFormIcon.Location = new System.Drawing.Point(18, 9);
            this.ipbFormIcon.Margin = new System.Windows.Forms.Padding(0);
            this.ipbFormIcon.Name = "ipbFormIcon";
            this.ipbFormIcon.Size = new System.Drawing.Size(32, 32);
            this.ipbFormIcon.TabIndex = 1;
            this.ipbFormIcon.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExit.Location = new System.Drawing.Point(744, -2);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExit.Size = new System.Drawing.Size(36, 43);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // panelMainForms
            // 
            this.panelMainForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMainForms.Controls.Add(this.clock1);
            this.panelMainForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForms.Location = new System.Drawing.Point(220, 39);
            this.panelMainForms.Name = "panelMainForms";
            this.panelMainForms.Size = new System.Drawing.Size(780, 561);
            this.panelMainForms.TabIndex = 2;
            // 
            // timerToggleButton
            // 
            this.timerToggleButton.Interval = 1000;
            this.timerToggleButton.Tick += new System.EventHandler(this.timerToggleButton_Tick);
            // 
            // clock1
            // 
            this.clock1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clock1.BeforeTouchSize = new System.Drawing.Size(336, 336);
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Circle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2023, 11, 27, 0, 40, 17, 555);
            this.clock1.CustomTime = new System.DateTime(2023, 11, 27, 0, 40, 17, 555);
            this.clock1.DigitalRenderer = digitalClockRenderer1;
            this.clock1.DisplayDates = true;
            this.clock1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.clock1.Location = new System.Drawing.Point(221, 88);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2023, 11, 27, 0, 40, 17, 555);
            this.clock1.Renderer = clockRenderer1;
            this.clock1.ShowClockFrame = false;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(336, 336);
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 3;
            this.clock1.Text = "clock1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainForms);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.pnlDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFormIcon)).EndInit();
            this.panelMainForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private FontAwesome.Sharp.IconButton ibAgendamentos;
        private FontAwesome.Sharp.IconButton ibHistorico;
        private FontAwesome.Sharp.IconButton ibAlterarSenha;
        private FontAwesome.Sharp.IconButton ibDashboard;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panelLeftBtn;
        private FontAwesome.Sharp.IconPictureBox ipbFormIcon;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Panel panelMainForms;
        private FontAwesome.Sharp.IconPictureBox ipbMinimize;
        private FontAwesome.Sharp.IconPictureBox ipbMaximize;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleButton1;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblAgendamentos;
        private System.Windows.Forms.Timer timerToggleButton;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
    }
}