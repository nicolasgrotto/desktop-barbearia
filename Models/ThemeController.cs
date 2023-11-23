using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interdisciplinar2.Models
{
    public static class ThemeController
    {
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