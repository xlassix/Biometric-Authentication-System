using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class AdminHome : Form
    {
        TempStorage tempstorage = TempStorage.Instance;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creat_Staff create_staff = new Creat_Staff();
            create_staff.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show_Attendance show_attendace = new Show_Attendance();
            show_attendace.Show();
        }

        private void timeInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Attendance start_attendance = new Start_Attendance();
            start_attendance.Show();
        }

        private void timeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Attendance stop_attendance = new Stop_Attendance();
            stop_attendance.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Staff show_staff = new Show_Staff();
            show_staff.Show();
        }

        private void formclosing_event(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
