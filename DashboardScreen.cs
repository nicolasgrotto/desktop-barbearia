using FontAwesome.Sharp;
using interdisciplinar2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class DashboardScreen : Form
    {
        private Dashboard dashboard;
        private ProgramTheme programTheme;

        public DashboardScreen()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            dashboard = new Dashboard();
            LoadFormData();

            List<Button> btns = new List<Button>();
            btns.Add(btnLast30Days);
            btns.Add(btnLast7Days);
            btns.Add(btnToday);
            btns.Add(btnCustom);
            btns.Add(btnOk);

            List<Label> lbls = new List<Label>();
            lbls.Add(lblTotalSchedules);
            lbls.Add(lblTotalRevenue);
            lbls.Add(lblName);

            List<Panel> pnls = new List<Panel>();
            pnls.Add(pnlTotalSchedules);
            pnls.Add(panel1);
            pnls.Add(panel2);

            List<IconPictureBox> ipBoxes = new List<IconPictureBox>();
            ipBoxes.Add(iconPictureBox1);
            ipBoxes.Add(iconPictureBox2);
            ipBoxes.Add(iconPictureBox3);

            programTheme = new ProgramTheme();

            programTheme.form = this;
            programTheme.buttons = btns;
            programTheme.labels = lbls;
            programTheme.panels = pnls;
            programTheme.chart = chart;
            programTheme.iPictureBoxes = ipBoxes;
        }

        private void LoadFormData()
        {
            var data = dashboard.LoadData(dtpStartDate.Value, dtpEndDate.Value);

            if (data)
            {
                lblTotalSchedules.Text = dashboard.numberOfSchedules.ToString();
                lblTotalRevenue.Text = "R$" + dashboard.totalRevenue.ToString();
                lblName.Text = dashboard.ClientWithMostSchedules;

                chart.DataSource = dashboard.RevenueByDateList;
                chart.Series[0].XValueMember = "Date";
                chart.Series[0].YValueMembers = "totalAmount";
                chart.DataBind();
            }
        }

        private void DisableCustomDate()
        {
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;
            btnOk.Visible = false;
            label1.Visible = false;
        }

        private void ReturnButtonToNormalColor(Button btn)
        {
            if (ProgramTheme.GetTheme() == "light")
            {
                btn.BackColor = ProgramTheme.LightThemeBtnBackColor;
                btn.ForeColor = ProgramTheme.LightThemeForeColor;
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromName("ControlLightLight");
            }
        }

        private void ButtonGetDate()
        {
            DisableCustomDate();

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;

            LoadFormData();
        }

        private void ButtonGetDate(int days)
        {
            DisableCustomDate();

            dtpStartDate.Value = DateTime.Today.AddDays(-days);
            dtpEndDate.Value = DateTime.Now;

            LoadFormData();
        }

        private void btnLast30Days_MouseLeave(object sender, EventArgs e)
        {
            ReturnButtonToNormalColor(btnLast30Days);
        }

        private void btnLast7Days_MouseLeave(object sender, EventArgs e)
        {
            ReturnButtonToNormalColor(btnLast7Days);
        }

        private void btnToday_MouseLeave(object sender, EventArgs e)
        {
            ReturnButtonToNormalColor(btnToday);
        }

        private void btnCustom_MouseLeave(object sender, EventArgs e)
        {
            ReturnButtonToNormalColor(btnCustom);
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            ReturnButtonToNormalColor(btnOk);
        }

        private void btnLast30Days_MouseEnter(object sender, EventArgs e)
        {
            btnLast30Days.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnLast7Days_MouseEnter(object sender, EventArgs e)
        {
            btnLast7Days.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnToday_MouseEnter(object sender, EventArgs e)
        {
            btnToday.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnCustom_MouseEnter(object sender, EventArgs e)
        {
            btnCustom.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            ButtonGetDate();

            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            if (chart.Series[0].ChartType != System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea)
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

            ButtonGetDate(7);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            if (chart.Series[0].ChartType != System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea)
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

            ButtonGetDate(30);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpEndDate.Visible = true;
            dtpStartDate.Visible = true;
            btnOk.Visible = true;
            label1.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtpEndDate.Value > DateTime.Now)
            {
                dtpEndDate.Value = DateTime.Now;
            }

            if (chart.Series[0].ChartType != System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea)
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

            DisableCustomDate();
            LoadFormData();
        }

        private void DashboardScreen_Load(object sender, EventArgs e)
        {
            //if (ProgramTheme.GetTheme() == "light")
            //{
            //    pnlTotalSchedules.BackColor = ProgramTheme.LightThemeItemBackColor;
            //    panel1.BackColor = ProgramTheme.LightThemeItemBackColor;
            //    panel2.BackColor = ProgramTheme.LightThemeItemBackColor;

            //    chart.BackColor = ProgramTheme.LightThemeItemBackColor;
            //    chart.Legends[0].BackColor = ProgramTheme.LightThemeItemBackColor;
            //    chart.Legends[0].ForeColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].AxisX.MajorGrid.LineColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].AxisY.MajorGrid.LineColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].AxisY.LineColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].AxisX.LineColor = ProgramTheme.LightThemeForeColor;
            //    chart.ChartAreas[0].BackColor = ProgramTheme.LightThemeBackColor;

            //    lblTotalSchedules.ForeColor = ProgramTheme.LightThemeForeColor;
            //    lblTotalRevenue.ForeColor = ProgramTheme.LightThemeForeColor;
            //    lblName.ForeColor = ProgramTheme.LightThemeForeColor;

            //    btnToday.BackColor = ProgramTheme.LightThemeBtnBackColor;
            //    btnLast7Days.BackColor = ProgramTheme.LightThemeBtnBackColor;
            //    btnLast30Days.BackColor = ProgramTheme.LightThemeBtnBackColor;
            //    btnCustom.BackColor = ProgramTheme.LightThemeBtnBackColor;
            //    btnOk.BackColor = ProgramTheme.LightThemeBtnBackColor;

            //    btnToday.ForeColor = ProgramTheme.LightThemeForeColor;
            //    btnLast7Days.ForeColor = ProgramTheme.LightThemeForeColor;
            //    btnLast30Days.ForeColor = ProgramTheme.LightThemeForeColor;
            //    btnCustom.ForeColor = ProgramTheme.LightThemeForeColor;
            //    btnOk.ForeColor = ProgramTheme.LightThemeForeColor;

            //    label1.ForeColor = ProgramTheme.LightThemeForeColor;

            //    iconPictureBox1.IconColor = Color.Black;
            //    iconPictureBox2.IconColor = Color.Black;
            //    iconPictureBox3.IconColor = Color.Black;
            //}

            programTheme.LoadTheme();
        }
    }
}