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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelLeft = new System.Windows.Forms.Panel();
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFormIcon)).BeginInit();
            this.panelMainForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
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
            this.ibHistorico.Text = "Histórico";
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
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.panelHeader.Controls.Add(this.ipbMinimize);
            this.panelHeader.Controls.Add(this.ipbMaximize);
            this.panelHeader.Controls.Add(this.lblFormName);
            this.panelHeader.Controls.Add(this.ipbFormIcon);
            this.panelHeader.Controls.Add(this.lblExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(780, 55);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // ipbMinimize
            // 
            this.ipbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
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
            this.ipbMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
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
            this.panelMainForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panelMainForms.Controls.Add(this.lblDate);
            this.panelMainForms.Controls.Add(this.lblHour);
            this.panelMainForms.Controls.Add(this.pictureBox1);
            this.panelMainForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForms.Location = new System.Drawing.Point(220, 55);
            this.panelMainForms.Name = "panelMainForms";
            this.panelMainForms.Size = new System.Drawing.Size(780, 545);
            this.panelMainForms.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.lblDate.Location = new System.Drawing.Point(308, 319);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(187, 39);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "dd/mm/yyyy";
            // 
            // lblHour
            // 
            this.lblHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.lblHour.Location = new System.Drawing.Point(323, 280);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(153, 39);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::interdisciplinar2.Properties.Resources.barber_logo_no_bg_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(296, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerHour
            // 
            this.timerHour.Interval = 950;
            this.timerHour.Tick += new System.EventHandler(this.timerHour_Tick);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFormIcon)).EndInit();
            this.panelMainForms.ResumeLayout(false);
            this.panelMainForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ipbMinimize;
        private FontAwesome.Sharp.IconPictureBox ipbMaximize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Timer timerHour;
    }
}