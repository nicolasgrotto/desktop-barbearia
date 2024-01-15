using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class HistoricScreen : Form
    {
        private ProgramTheme programTheme;
        private Schedule schedule;

        public HistoricScreen()
        {
            InitializeComponent();

            List<Label> labels = new List<Label>();
            labels.Add(tituloSelecionado);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.labels = labels;

            schedule = new Schedule();
        }

        private void HistoricScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                schedule.StartDate = DateTime.Now;

                schedule.GetAllPastSchedules(dgvHistorico);
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
                        schedule.StartDate = DateTime.Now.AddDays(-7);
                        schedule.EndDate = DateTime.Now;
                        schedule.GetPastSchedulesByDate(dgvHistorico);
                        break;

                    case 1:
                        schedule.StartDate = DateTime.Now.AddMonths(-1);
                        schedule.EndDate = DateTime.Now;
                        schedule.GetPastSchedulesByDate(dgvHistorico);
                        break;

                    case 2:
                        schedule.StartDate = DateTime.Now;
                        schedule.GetAllPastSchedules(dgvHistorico);
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