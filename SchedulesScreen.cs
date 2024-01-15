using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class SchedulesScreen : Form
    {
        private ProgramTheme programTheme;
        private Schedule schedule;

        public SchedulesScreen()
        {
            InitializeComponent();

            List<Label> labels = new List<Label>();
            labels.Add(tituloSelecionado);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.labels = labels;

            schedule = new Schedule();
        }

        private void SchedulesScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                schedule.StartDate = DateTime.Now;
                schedule.GetAllFutureSchedules(dgvSchedules);
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
        }

        private void cbHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tituloSelecionado.Text = cbHistorico.Text;

            try
            {
                switch (cbHistorico.SelectedIndex)
                {
                    case 0:
                        schedule.StartDate = DateTime.Now;
                        schedule.EndDate = DateTime.Now.AddDays(7);
                        schedule.GetFutureSchedulesByDate(dgvSchedules);
                        break;

                    case 1:
                        schedule.StartDate = DateTime.Now;
                        schedule.EndDate = DateTime.Now.AddMonths(1);
                        schedule.GetFutureSchedulesByDate(dgvSchedules);
                        break;

                    case 2:
                        schedule.StartDate = DateTime.Now;
                        schedule.GetAllFutureSchedules(dgvSchedules);
                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
        }
    }
}