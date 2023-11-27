using interdisciplinar2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (data == true)
            {
                lblTotalSchedules.Text = dashboard.numberOfSchedules.ToString();
                lblTotalRevenue.Text = dashboard.totalRevenue.ToString();
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
        }

        private void btnLast30Days_MouseLeave(object sender, EventArgs e)
        {
            btnLast30Days.BackColor = Color.Transparent;
        }

        private void btnLast7Days_MouseLeave(object sender, EventArgs e)
        {
            btnLast7Days.BackColor = Color.Transparent;
        }

        private void btnToday_MouseLeave(object sender, EventArgs e)
        {
            btnToday.BackColor = Color.Transparent;
        }

        private void btnCustom_MouseLeave(object sender, EventArgs e)
        {
            btnCustom.BackColor = Color.Transparent;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.Transparent;
        }

        private void btnThisMonth_MouseEnter(object sender, EventArgs e)
        {
            btnThisMonth.BackColor = Color.FromArgb(225, 177, 44);
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
            DisableCustomDate();

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;

            LoadFormData();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            DisableCustomDate();

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            LoadFormData();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            DisableCustomDate();

            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;

            LoadFormData();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            DisableCustomDate();

            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            LoadFormData();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpEndDate.Visible = true;
            dtpStartDate.Visible = true;
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DisableCustomDate();

            LoadFormData();
        }

        private void btnThisMonth_MouseLeave(object sender, EventArgs e)
        {
            btnThisMonth.BackColor = Color.Transparent;
        }
    }
}