namespace interdisciplinar2
{
    partial class DashboardScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlTotalSchedules = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalSchedules = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTotalSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(12, 18);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(134, 23);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(169, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(134, 23);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.Visible = false;
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast30Days.Location = new System.Drawing.Point(654, 11);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(98, 42);
            this.btnLast30Days.TabIndex = 3;
            this.btnLast30Days.Text = "Últimos 30 dias";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            this.btnLast30Days.MouseEnter += new System.EventHandler(this.btnLast30Days_MouseEnter);
            this.btnLast30Days.MouseLeave += new System.EventHandler(this.btnLast30Days_MouseLeave);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLast7Days.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast7Days.Location = new System.Drawing.Point(542, 11);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(106, 42);
            this.btnLast7Days.TabIndex = 4;
            this.btnLast7Days.Text = "Últimos 7 dias";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            this.btnLast7Days.MouseEnter += new System.EventHandler(this.btnLast7Days_MouseEnter);
            this.btnLast7Days.MouseLeave += new System.EventHandler(this.btnLast7Days_MouseLeave);
            // 
            // btnToday
            // 
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToday.Location = new System.Drawing.Point(437, 11);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(99, 42);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Hoje";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            this.btnToday.MouseEnter += new System.EventHandler(this.btnToday_MouseEnter);
            this.btnToday.MouseLeave += new System.EventHandler(this.btnToday_MouseLeave);
            // 
            // btnCustom
            // 
            this.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCustom.Location = new System.Drawing.Point(314, 11);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(117, 42);
            this.btnCustom.TabIndex = 6;
            this.btnCustom.Text = "Personalizado";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            this.btnCustom.MouseEnter += new System.EventHandler(this.btnCustom_MouseEnter);
            this.btnCustom.MouseLeave += new System.EventHandler(this.btnCustom_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(266, 47);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(37, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // pnlTotalSchedules
            // 
            this.pnlTotalSchedules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlTotalSchedules.Controls.Add(this.iconPictureBox2);
            this.pnlTotalSchedules.Controls.Add(this.lblTotalSchedules);
            this.pnlTotalSchedules.Controls.Add(this.lblTitle1);
            this.pnlTotalSchedules.Location = new System.Drawing.Point(12, 93);
            this.pnlTotalSchedules.Name = "pnlTotalSchedules";
            this.pnlTotalSchedules.Size = new System.Drawing.Size(222, 61);
            this.pnlTotalSchedules.TabIndex = 8;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 44;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 22);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(44, 48);
            this.iconPictureBox2.TabIndex = 13;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblTotalSchedules
            // 
            this.lblTotalSchedules.AutoSize = true;
            this.lblTotalSchedules.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSchedules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalSchedules.Location = new System.Drawing.Point(53, 31);
            this.lblTotalSchedules.Name = "lblTotalSchedules";
            this.lblTotalSchedules.Size = new System.Drawing.Size(46, 21);
            this.lblTotalSchedules.TabIndex = 9;
            this.lblTotalSchedules.Text = "0000";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.lblTitle1.Location = new System.Drawing.Point(3, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(181, 21);
            this.lblTitle1.TabIndex = 9;
            this.lblTitle1.Text = "Agendamentos Totais";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Controls.Add(this.lblTotalRevenue);
            this.panel1.Controls.Add(this.lblTitle2);
            this.panel1.Location = new System.Drawing.Point(240, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 61);
            this.panel1.TabIndex = 9;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 39;
            this.iconPictureBox3.Location = new System.Drawing.Point(7, 22);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(58, 39);
            this.iconPictureBox3.TabIndex = 14;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalRevenue.Location = new System.Drawing.Point(70, 31);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(46, 21);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "0000";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.lblTitle2.Location = new System.Drawing.Point(3, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(244, 21);
            this.lblTitle2.TabIndex = 9;
            this.lblTitle2.Text = "Dinheiro Recebido no Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblTitle3);
            this.panel2.Location = new System.Drawing.Point(526, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 61);
            this.panel2.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 36;
            this.iconPictureBox1.Location = new System.Drawing.Point(7, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 36);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(56, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "nome";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.lblTitle3.Location = new System.Drawing.Point(3, 0);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(163, 21);
            this.lblTitle3.TabIndex = 9;
            this.lblTitle3.Text = "Cliente mais fiel";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.chart.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.AxisY.LabelStyle.Format = "R${0}";
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 169);
            this.chart.Name = "chart";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 20;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            series1.MarkerSize = 14;
            series1.Name = "Qntd.Dinheiro";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(740, 315);
            this.chart.TabIndex = 11;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            title1.Name = "Title1";
            title1.Text = "Dinheiro Recebido";
            this.chart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(149, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "-";
            this.label1.Visible = false;
            // 
            // DashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTotalSchedules);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "DashboardScreen";
            this.Text = "DashboardScreen";
            this.Load += new System.EventHandler(this.DashboardScreen_Load);
            this.pnlTotalSchedules.ResumeLayout(false);
            this.pnlTotalSchedules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlTotalSchedules;
        private System.Windows.Forms.Label lblTotalSchedules;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}