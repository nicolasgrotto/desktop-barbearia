using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class DashboardScreen : Form
    {
        private Dashboard dashboard;

        public DashboardScreen()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            dashboard = new Dashboard();
            LoadFormData();
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
            if (ThemeController.GetTheme() == "light")
            {
                btn.BackColor = ThemeController.LightThemeBtnBackColor;
                btn.ForeColor = ThemeController.LightThemeForeColor;
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
            if (ThemeController.GetTheme() == "light")
            {
                pnlTotalSchedules.BackColor = ThemeController.LightThemeItemBackColor;
                panel1.BackColor = ThemeController.LightThemeItemBackColor;
                panel2.BackColor = ThemeController.LightThemeItemBackColor;

                chart.BackColor = ThemeController.LightThemeItemBackColor;
                chart.Legends[0].BackColor = ThemeController.LightThemeItemBackColor;
                chart.Legends[0].ForeColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].AxisX.MajorGrid.LineColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].AxisY.LineColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].AxisX.LineColor = ThemeController.LightThemeForeColor;
                chart.ChartAreas[0].BackColor = ThemeController.LightThemeBackColor;

                lblTotalSchedules.ForeColor = ThemeController.LightThemeForeColor;
                lblTotalRevenue.ForeColor = ThemeController.LightThemeForeColor;
                lblName.ForeColor = ThemeController.LightThemeForeColor;

                btnToday.BackColor = ThemeController.LightThemeBtnBackColor;
                btnLast7Days.BackColor = ThemeController.LightThemeBtnBackColor;
                btnLast30Days.BackColor = ThemeController.LightThemeBtnBackColor;
                btnCustom.BackColor = ThemeController.LightThemeBtnBackColor;
                btnOk.BackColor = ThemeController.LightThemeBtnBackColor;

                btnToday.ForeColor = ThemeController.LightThemeForeColor;
                btnLast7Days.ForeColor = ThemeController.LightThemeForeColor;
                btnLast30Days.ForeColor = ThemeController.LightThemeForeColor;
                btnCustom.ForeColor = ThemeController.LightThemeForeColor;
                btnOk.ForeColor = ThemeController.LightThemeForeColor;

                label1.ForeColor = ThemeController.LightThemeForeColor;

                iconPictureBox1.IconColor = Color.Black;
                iconPictureBox2.IconColor = Color.Black;
                iconPictureBox3.IconColor = Color.Black;
            }
        }
    }
}