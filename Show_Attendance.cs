using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UI_Support
{
    public partial class Show_Attendance : Form
    {
        TempStorage tempstorage = TempStorage.Instance;
        public Show_Attendance()
        {
            InitializeComponent();
        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            const string filename = "sample_db.sqlite";
            const string sql = "select * from attendance;";
            var conn = new SQLiteConnection("Data Source=" + filename + ";");
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds);
                
                //show_attendance_gridview.DataSource = ds.Tables[0].DefaultView;
                show_attendance_gridview.DataSource = tempstorage.TempAttendance;
                //MessageBox.Show("success"+tempstorage.TempStaffs.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
