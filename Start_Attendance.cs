using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class Start_Attendance : Form
    {
        TempStorage tempstorage = TempStorage.Instance;

        public Start_Attendance()
        {
            InitializeComponent();
        }

        public void OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus Status)
        {
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();

            foreach (Staff dt in tempstorage.TempStaffs)
            {
                // Compare feature set with all stored templates.
                foreach (DPFP.Template template in dt.Templates)
                {
                    // Get template from storage.
                    if (template != null)
                    {
                        // Compare feature set with particular template.
                        ver.Verify(FeatureSet, template, ref res);
                        //dt.IsFeatureSetMatched = res.Verified;
                        //dt.FalseAcceptRate = res.FARAchieved;
                        if (res.Verified)
                        {
                            //search for the staff attendance that day
                            Attendance attdance = tempstorage.TempAttendance.Find(x => x.AdminId == tempstorage.TempStaffs.IndexOf(dt).ToString() && x.AttendanceDate == DateTime.Today.Date.ToShortDateString());

                            if (attdance != null)
                            {
                                MessageBox.Show("Attendance already taken for the day.");
                            }
                            else
                            {
                                //keep a spot for attendance
                                Attendance attd = new Attendance();
                                attd.AdminName = dt.FirstName + " " + dt.LastName;
                                attd.AdminId = tempstorage.TempStaffs.IndexOf(dt).ToString();
                                attd.AttendanceDate = DateTime.Today.Date.ToShortDateString();
                                attd.TimeIn = DateTime.Now.TimeOfDay.ToString();
                                tempstorage.TempAttendance.Add(attd);
                                ListEvents.Items.Insert(0, String.Format("Attendance taken for staff: {0}, Time In: {1}, Date: {2}", attd.AdminName,attd.TimeIn,attd.AttendanceDate));
                            }
                            
                            break; // success
                        }
                            
                    }
                }
                if (res.Verified)
                    break; // success
            }

            

            if (!res.Verified)
                Status = DPFP.Gui.EventHandlerStatus.Failure;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //search for the staff attendance that day
            Attendance attdance = tempstorage.TempAttendance.Find(x => x.AdminId == "simulate 1" && x.AttendanceDate == DateTime.Today.Date.ToShortDateString());

            if (attdance != null)
            {
                MessageBox.Show("Attendance already taken for the day.");
            }
            else
            {
                Attendance attd = new Attendance();
                attd.AdminName = "simulate name";
                attd.AdminId = "simulate 1";
                attd.AttendanceDate = DateTime.Today.Date.ToShortDateString();
                attd.TimeIn = DateTime.Now.TimeOfDay.ToString();
                tempstorage.TempAttendance.Add(attd);
            }
            
        }

        private void Start_Attendance_Load(object sender, EventArgs e)
        {

        }
    }
}
