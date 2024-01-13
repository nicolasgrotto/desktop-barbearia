using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace interdisciplinar2.Models
{
    public class ProgramTheme
    {
        public Form form;
        public List<Button> buttons;
        public List<Label> labels;
        public List<Panel> panels;
        public Chart chart;
        public List<IconPictureBox> iPictureBoxes;
        public List<IconButton> iButtons;
        public List<TextBox> txtBoxes;

        private static readonly string ThemeFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "barber-desktop_themeFolder");
        private static readonly string ThemeFile = Path.Combine(ThemeFilePath, "theme.txt");

        public static readonly Color YellowColor = Color.FromArgb(24, 161, 251);
        public static readonly Color LightThemeBackColor = Color.FromArgb(255, 255, 255);
        public static readonly Color LightThemeForeColor = Color.FromArgb(0, 0, 0);
        public static readonly Color LightThemeItemBackColor = Color.WhiteSmoke;
        public static readonly Color LightThemeBtnBackColor = Color.FromArgb(215, 215, 215);

        public static readonly Color DarkThemeBackColor = Color.FromArgb(40, 40, 40);
        public static readonly Color DarkThemeForeColor = Color.FromArgb(255, 255, 255);
        public static readonly Color DarkThemeItemBackColor = Color.FromArgb(60, 60, 60);
        public static readonly Color DarkThemeBtnBackColor = Color.Transparent;

        public static void SetTheme(string theme)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(ThemeFilePath)))
                {
                    Directory.CreateDirectory(ThemeFilePath);
                }

                string[] lines = new string[2];
                {
                    lines[0] = "**NÃO ALTERE AS PROPRIEDADES DESSE ARQUIVO**";
                    lines[1] = "theme = " + theme;
                }

                File.WriteAllLines(ThemeFile, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string GetTheme()
        {
            try
            {
                string[] lines = File.ReadAllLines(ThemeFile);

                foreach (string line in lines)
                {
                    switch (line)
                    {
                        case "theme = dark":
                            return "dark";

                        case "theme = light":
                            return "light";
                    }
                }

                SetTheme("dark");

                return "dark";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void LoadDarkTheme()
        {
            if (form != null)
            {
                form.BackColor = DarkThemeBackColor;
            }
            if (buttons != null)
            {
                foreach (Button btn in buttons)
                {
                    btn.BackColor = DarkThemeBtnBackColor;
                    btn.ForeColor = DarkThemeForeColor;
                }
            }
            if (labels != null)
            {
                foreach (Label lbl in labels)
                {
                    lbl.ForeColor = DarkThemeForeColor;
                }
            }
            if (panels != null)
            {
                foreach (Panel pnl in panels)
                {
                    pnl.BackColor = DarkThemeItemBackColor;
                }
            }
            if (chart != null)
            {
                chart.BackColor = ProgramTheme.DarkThemeItemBackColor;
                chart.Legends[0].BackColor = ProgramTheme.DarkThemeItemBackColor;
                chart.Legends[0].ForeColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].AxisX.MajorGrid.LineColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].AxisY.LineColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].AxisX.LineColor = ProgramTheme.DarkThemeForeColor;
                chart.ChartAreas[0].BackColor = ProgramTheme.DarkThemeBackColor;
            }
            if (iPictureBoxes != null)
            {
                foreach (IconPictureBox ib in iPictureBoxes)
                {
                    ib.BackColor = DarkThemeBtnBackColor;
                    ib.IconColor = DarkThemeForeColor;
                }
            }
            if (iButtons != null)
            {
                foreach (IconButton ib in iButtons)
                {
                    ib.BackColor = DarkThemeBtnBackColor;
                    ib.IconColor = DarkThemeForeColor;
                }
            }
            if (txtBoxes != null)
            {
                foreach (TextBox tBox in txtBoxes)
                {
                    tBox.BackColor = DarkThemeBackColor;
                    tBox.ForeColor = DarkThemeForeColor;
                }
            }
        }

        private void LoadLightTheme()
        {
            if (form != null)
            {
                form.BackColor = LightThemeBackColor;
            }
            if (buttons != null)
            {
                foreach (Button btn in buttons)
                {
                    btn.BackColor = LightThemeBtnBackColor;
                    btn.ForeColor = LightThemeForeColor;
                }
            }
            if (labels != null)
            {
                foreach (Label lbl in labels)
                {
                    lbl.ForeColor = LightThemeForeColor;
                }
            }
            if (panels != null)
            {
                foreach (Panel pnl in panels)
                {
                    pnl.BackColor = LightThemeItemBackColor;
                }
            }
            if (chart != null)
            {
                chart.BackColor = ProgramTheme.LightThemeItemBackColor;
                chart.Legends[0].BackColor = ProgramTheme.LightThemeItemBackColor;
                chart.Legends[0].ForeColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].AxisX.MajorGrid.LineColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].AxisY.LineColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].AxisX.LineColor = ProgramTheme.LightThemeForeColor;
                chart.ChartAreas[0].BackColor = ProgramTheme.LightThemeBackColor;
            }
            if (iPictureBoxes != null)
            {
                foreach (IconPictureBox ib in iPictureBoxes)
                {
                    ib.IconColor = LightThemeForeColor;
                }
            }
            if (iButtons != null)
            {
                foreach (IconButton ib in iButtons)
                {
                    ib.BackColor = LightThemeBtnBackColor;
                    ib.IconColor = LightThemeForeColor;
                }
            }
            if (txtBoxes != null)
            {
                foreach (TextBox tBox in txtBoxes)
                {
                    tBox.BackColor = LightThemeBackColor;
                    tBox.ForeColor = LightThemeForeColor;
                }
            }
        }

        public void LoadTheme()
        {
            switch (GetTheme())
            {
                case "dark":
                    LoadDarkTheme();
                    break;

                case "light":
                    LoadLightTheme();
                    break;
            }
        }
    }
}