using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UI_Support
{
    public class Staff
    {
        //staff
        public string StaffNO { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }

        public Bitmap StaffImage { get; set; }
        public DPFP.Template[] Templates = new DPFP.Template[10];
    }
}
