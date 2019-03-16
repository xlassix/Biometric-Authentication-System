namespace UI_Support
{
    partial class Show_Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.show_attendance_gridview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_attendance_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // show_attendance_gridview
            // 
            this.show_attendance_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_attendance_gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_attendance_gridview.Location = new System.Drawing.Point(0, 0);
            this.show_attendance_gridview.Name = "show_attendance_gridview";
            this.show_attendance_gridview.Size = new System.Drawing.Size(704, 458);
            this.show_attendance_gridview.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // Show_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show_attendance_gridview);
            this.Name = "Show_Attendance";
            this.Text = "SHOW ATTENDANCE";
            ((System.ComponentModel.ISupportInitialize)(this.show_attendance_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView show_attendance_gridview;
        private System.Windows.Forms.Button button1;
    }
}