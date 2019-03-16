using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class Stop_Attendance : Form
    {
        TempStorage tempstorage = TempStorage.Instance;
        public Stop_Attendance()
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
                            Attendance attd=tempstorage.TempAttendance.Find(x => x.AdminId == tempstorage.TempStaffs.IndexOf(dt).ToString() && x.AttendanceDate == DateTime.Today.Date.ToShortDateString());

                            if (attd!=null)
                            {
                                attd.TimeOut = DateTime.Now.TimeOfDay.ToString();
                                ListEvents.Items.Insert(0, String.Format("Attendance taken for staff: {0}, Time Out: {1}, Date: {2}", attd.AdminName, attd.TimeOut, attd.AttendanceDate));

                            }
                            else
                            {
                                MessageBox.Show("Cannot sign out, No attendance in yet.");
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
            Attendance attd = tempstorage.TempAttendance.Find(x => x.AdminId == "simulate 1" && x.AttendanceDate == DateTime.Today.Date.ToShortDateString());

            if (attd != null)
            {
                attd.TimeOut = DateTime.Now.TimeOfDay.ToString();
            }
            else
            {
                MessageBox.Show("Cannot sign out, No attendance in yet.");
            }

        }

        
    }
}
