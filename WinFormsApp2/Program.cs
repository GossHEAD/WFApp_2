using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp2
{
    
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try 
            {
                bool showGreetingOn;
                var file = new StreamReader("ShowGreeting");
                string stringShowGreetingOn = file.ReadLine();
                file.Close();
                showGreetingOn = Convert.ToBoolean(stringShowGreetingOn);
                if (showGreetingOn)
                {
                    MessageBox.Show("Выполнил: Богданов А.Е" + Environment.NewLine +
                                    "Группа: 414" + Environment.NewLine +
                                    "Вариант: 4",
                                    "БД");
                    Application.Run(new Form1());
                }
                if (!showGreetingOn)
                    Application.Run(new Form1());
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("В приложении произошла ошибка, настройки приложения были восстоновлены по умолчанию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var file = new StreamWriter("ShowGreeting", false);
                bool showGreetingOn = true;
                file.WriteLine(showGreetingOn);
                file.Close();
                MessageBox.Show("Выполнил: Богданов А.Е" + Environment.NewLine +
                                    "Группа: 414" + Environment.NewLine +
                                    "Вариант: 4",
                                    "БД");
                Application.Run(new Form1());

            }
            catch (FormatException)
            {
                MessageBox.Show("В приложении произошла ошибка, настройки приложения были восстоновлены по умолчанию!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var file = new StreamWriter("ShowGreeting", false);
                bool showGreetingOn = true;
                file.WriteLine(showGreetingOn);
                file.Close();
                MessageBox.Show("Выполнил: Богданов А.Е" + Environment.NewLine +
                                     "Группа: 414" + Environment.NewLine +
                                     "Вариант: 4",
                                     "БД");
                Application.Run(new Form1());
            }

        }

    }

    
}