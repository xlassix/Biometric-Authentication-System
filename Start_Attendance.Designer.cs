namespace UI_Support
{
    partial class Start_Attendance
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
            System.Windows.Forms.Label lblPrompt;
            this.ListEvents = new System.Windows.Forms.ListBox();
            this.GroupEvents = new System.Windows.Forms.GroupBox();
            this.VerificationControl = new DPFP.Gui.Verification.VerificationControl();
            lblPrompt = new System.Windows.Forms.Label();
            this.GroupEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPrompt.Location = new System.Drawing.Point(102, 41);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new System.Drawing.Size(606, 37);
            lblPrompt.TabIndex = 6;
            lblPrompt.Text = "TO VERIFY YOUR IDENTITY AND TAKE ATTENDANCE IN, TOUCH THE FINGERPRINT READER WITH" +
    " ANY ENROLLED FINGER.";
            // 
            // ListEvents
            // 
            this.ListEvents.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.ItemHeight = 16;
            this.ListEvents.Location = new System.Drawing.Point(16, 19);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(680, 308);
            this.ListEvents.TabIndex = 0;
            // 
            // GroupEvents
            // 
            this.GroupEvents.Controls.Add(this.ListEvents);
            this.GroupEvents.Location = new System.Drawing.Point(12, 114);
            this.GroupEvents.Name = "GroupEvents";
            this.GroupEvents.Size = new System.Drawing.Size(702, 341);
            this.GroupEvents.TabIndex = 4;
            this.GroupEvents.TabStop = false;
            this.GroupEvents.Text = "Events";
            // 
            // VerificationControl
            // 
            this.VerificationControl.Active = true;
            this.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerificationControl.Location = new System.Drawing.Point(28, 32);
            this.VerificationControl.Name = "VerificationControl";
            this.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.VerificationControl.Size = new System.Drawing.Size(52, 52);
            this.VerificationControl.TabIndex = 5;
            this.VerificationControl.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.OnComplete);
            // 
            // Start_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 526);
            this.Controls.Add(lblPrompt);
            this.Controls.Add(this.VerificationControl);
            this.Controls.Add(this.GroupEvents);
            this.Name = "Start_Attendance";
            this.Text = "ATTENDANCE IN";
            this.Load += new System.EventHandler(this.Start_Attendance_Load);
            this.GroupEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListEvents;
        private System.Windows.Forms.GroupBox GroupEvents;
        private DPFP.Gui.Verification.VerificationControl VerificationControl;
    }
}