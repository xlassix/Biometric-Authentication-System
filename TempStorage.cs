using System;
using System.Collections.Generic;
using System.Text;

namespace UI_Support
{
    class TempStorage
    {
        private static TempStorage instance;

        private TempStorage() { }

        public static TempStorage Instance
        {
            get
            {
                if (instance == null)
                    instance = new TempStorage();
                return instance;
            }
        }

        public List<Staff> TempStaffs = new List<Staff>();
        public List<Attendance> TempAttendance = new List<Attendance>();
    }
}
