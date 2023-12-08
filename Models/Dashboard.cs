using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace interdisciplinar2.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal totalAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberOfDays;

        public List<RevenueByDate> RevenueByDateList { get; private set; }
        public int numberOfSchedules { get; private set; }
        public string ClientWithMostSchedules { get; set; }
        public decimal totalRevenue { get; set; }

        public Dashboard()
        {
        }

        private void GetNumberOfSchedules()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = @"SELECT COUNT(id_agendamento) FROM tb_agendamento WHERE datahora BETWEEN @fromDate AND @toDate;";

                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;

                        numberOfSchedules = int.Parse(command.ExecuteScalar().ToString());

                        command.CommandText = "SELECT nome FROM tb_clientes INNER JOIN tb_agendamento ON tb_clientes.id_cliente = tb_agendamento.id_cliente GROUP BY nome;";

                        ClientWithMostSchedules = (string)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetResultGraphic()
        {
            RevenueByDateList = new List<RevenueByDate>();
            totalRevenue = 0;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = @"SELECT datahora, COUNT(id_agendamento) FROM tb_agendamento WHERE datahora BETWEEN @fromDate AND @toDate  GROUP BY datahora;";

                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;

                        MySqlDataReader reader = command.ExecuteReader();

                        var resultTable = new List<KeyValuePair<DateTime, decimal>>();

                        while (reader.Read())
                        {
                            resultTable.Add(new KeyValuePair<DateTime, decimal>(reader.GetDateTime(0), reader.GetDecimal(1)));
                            totalRevenue += reader.GetDecimal(1) * 20;
                        }
                        reader.Close();

                        if (numberOfDays < 1)
                        {
                            RevenueByDateList = (from list in resultTable
                                                 group list by list.Key.ToString("HH:MM") into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = grouped.Key + "h",
                                                     totalAmount = grouped.Sum(amount => amount.Value) * 20
                                                 }).ToList();
                        }
                        else if (numberOfDays < 30)
                        {
                            RevenueByDateList = (from list in resultTable
                                                 group list by list.Key.ToString("dd MMM") into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = grouped.Key,
                                                     totalAmount = grouped.Sum(amount => amount.Value) * 20
                                                 }).ToList();

                            //foreach (var item in resultTable)
                            //{
                            //    RevenueByDateList.Add(new RevenueByDate() { Date = item.Key.ToString("dd MMM"), totalAmount = item.Value * 20 });
                            //}
                        }
                        else if (numberOfDays < 92)
                        {
                            RevenueByDateList = (from list in resultTable
                                                 group list by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(list.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday) into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = "Semana " + grouped.Key.ToString(),
                                                     totalAmount = grouped.Sum(amount => amount.Value) * 20
                                                 }).ToList();
                        }
                        else if (numberOfDays < (365 * 2))
                        {
                            bool isYear = numberOfDays > 365 ? true : false;

                            RevenueByDateList = (from list in resultTable
                                                 group list by list.Key.ToString("MMM yyyy") into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = isYear ? grouped.Key.Substring(0, grouped.Key.IndexOf(" ")) : grouped.Key,
                                                     totalAmount = grouped.Sum(amount => amount.Value) * 20
                                                 }).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);

            if (this.startDate != startDate || this.endDate != endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberOfDays = (endDate - startDate).Days;

                GetNumberOfSchedules();
                GetResultGraphic();

                return true;
            }
            else return false;
        }
    }
}