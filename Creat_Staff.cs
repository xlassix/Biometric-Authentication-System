using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class Creat_Staff : Form
    {
        private AppData Data;					// keeps application-wide data
        private EnrollmentForm Enroller;
        TempStorage tempstorage = TempStorage.Instance;

        public Creat_Staff()
        {
            InitializeComponent();
            Data = new AppData();								// Create the application data object
            Data.OnChange += delegate { ExchangeData(false); };	// Track data changes to keep the form synchronized
            Enroller = new EnrollmentForm(Data);
            
            ExchangeData(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            //check that the form is filled
            if (staffno_tb.Text != string.Empty || firstname_tb.Text != string.Empty || lastname_tb.Text != string.Empty || phone_tb.Text != string.Empty || gender_cmb.SelectedText != string.Empty || faculty_tb.Text != string.Empty || department_tb.Text != string.Empty)
            {
                ExchangeData(true);
                Enroller.ShowDialog();
            }
            else
            {
                MessageBox.Show("Fill the form completely before you can proceed");
            }
            
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        // Simple dialog data exchange (DDX) implementation.
        private void ExchangeData(bool read)
        {
            if (read)
            {	// read values from the form's controls to the data object
                Data.staff.StaffNO = staffno_tb.Text;
                Data.staff.FirstName =firstname_tb.Text;
                Data.staff.LastName =lastname_tb.Text;
                Data.staff.Phone=phone_tb.Text;
                Data.staff.Gender=gender_cmb.Text;
                //MessageBox.Show(gender_cmb.Text);
                Data.staff.Faculty=faculty_tb.Text;
                Data.staff.Department=department_tb.Text;

                //save to the db
                //const string filename = "sample_db.sqlite";
                //const string sql = "select * from staff;";
                //var conn = new SQLiteConnection("Data Source=" + filename + ";");
                
                //try
                //{
                //    conn.Open();
                //    using (var command = new SQLiteCommand("INSERT INTO staff(staff_no,first_name,last_name,phone,gender,faculty,department,template)VALUES('sch25','ola','ade','08052634152','male','csc','csc',@photo)",conn))
                //    {
                //        byte[] photo = ImageToByte(Data.staff.StaffImage);
                //        command.Parameters.Add("@photo", DbType.Binary, 20).Value = photo;
                //        command.ExecuteNonQuery();
                //        MessageBox.Show("successfully added to db");
                //    }
                    
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            

            //check if the inputs are filled and the fingerprint is too
            if (staffno_tb.Text != string.Empty || firstname_tb.Text != string.Empty || lastname_tb.Text != string.Empty || phone_tb.Text != string.Empty || gender_cmb.SelectedText != string.Empty || faculty_tb.Text != string.Empty || department_tb.Text != string.Empty || Data.staff.Templates.Length == 0)
            {
                ExchangeData(true);
                tempstorage.TempStaffs.Add(Data.staff);
                MessageBox.Show("saved successfully");
            }
            else
            {
                MessageBox.Show("Fill the form completely and register at least a fingerprint before you can save");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadedimage_tb.Text = openFileDialog1.FileName;
                Bitmap image = new Bitmap(uploadedimage_tb.Text);
                uploadstaffimg.Image = (Image)image;
                Data.staff.StaffImage = image;
            }
        }
    }
}
