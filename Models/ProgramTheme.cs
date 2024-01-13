using System;
using System.Drawing;
using System.IO;

namespace interdisciplinar2.Models
{
    public static class ProgramTheme
    {
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
            string themeFile = "C:\\Users\\nickg\\source\\repos\\interdisciplinar2\\ThemeFile\\Theme.txt";

            try
            {
                string[] lines = new string[2];
                {
                    lines[0] = "**NÃO ALTERE AS PROPRIEDADES DESSE ARQUIVO**";
                    lines[1] = "theme = " + theme;
                }

                File.WriteAllLines(themeFile, lines);
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
                string[] lines = File.ReadAllLines("C:\\Users\\nickg\\source\\repos\\interdisciplinar2\\ThemeFile\\Theme.txt");

                foreach (string line in lines)
                {
                    if (line.Contains("theme = dark"))
                    {
                        return "dark";
                    }
                    else if (line.Contains("theme = light"))
                    {
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
    }
}