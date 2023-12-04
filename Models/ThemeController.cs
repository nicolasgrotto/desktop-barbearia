using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interdisciplinar2.Models
{
    public static class ThemeController
    {
        public static readonly Color LightThemeBackColor;
        public static readonly Color LightThemeForeColor;
        public static readonly Color LightThemeItemBackColor;
        public static readonly Color LightThemeBtnBackColor;
        public static readonly Color DarkThemeBackColor;

        static ThemeController()
        {
            LightThemeBackColor = Color.FromArgb(255, 255, 255);
            LightThemeForeColor = Color.FromArgb(0, 0, 0);
            LightThemeItemBackColor = Color.WhiteSmoke;
            LightThemeBtnBackColor = Color.FromArgb(215, 215, 215);

            DarkThemeBackColor = Color.FromArgb(40, 40, 40);
        }

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