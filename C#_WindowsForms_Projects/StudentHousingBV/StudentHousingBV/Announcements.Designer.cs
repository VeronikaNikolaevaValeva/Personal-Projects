
namespace StudentHousingBV
{
    partial class Announcements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAnnouncements = new System.Windows.Forms.Panel();
            this.gbAddAnouncements = new System.Windows.Forms.GroupBox();
            this.gbSubmitResults = new System.Windows.Forms.GroupBox();
            this.lbTimeToSubmitResult = new System.Windows.Forms.Label();
            this.rbNegative = new System.Windows.Forms.RadioButton();
            this.rbPositive = new System.Windows.Forms.RadioButton();
            this.btnSubmitResults = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnRestrictions = new System.Windows.Forms.Button();
            this.btnDeleteAnnouncement = new System.Windows.Forms.Button();
            this.lbRestrictions = new System.Windows.Forms.ListBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.btnAddAnnouncement = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.tbAnnouncementTitle = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.rbFormal = new System.Windows.Forms.RadioButton();
            this.rbParty = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tbcAnnouncements = new System.Windows.Forms.TabControl();
            this.tPPartyAnnouncements = new System.Windows.Forms.TabPage();
            this.lbPartyAnnouncements = new System.Windows.Forms.ListBox();
            this.tPFormalAnnouncements = new System.Windows.Forms.TabPage();
            this.lbFormalAnnouncements = new System.Windows.Forms.ListBox();
            this.tPCovidAnnouncements = new System.Windows.Forms.TabPage();
            this.lbRequestTest = new System.Windows.Forms.Label();
            this.lbPeopleWithCovid = new System.Windows.Forms.ListBox();
            this.btnRequestTest = new System.Windows.Forms.Button();
            this.pnlAnnouncements.SuspendLayout();
            this.gbAddAnouncements.SuspendLayout();
            this.gbSubmitResults.SuspendLayout();
            this.tbcAnnouncements.SuspendLayout();
            this.tPPartyAnnouncements.SuspendLayout();
            this.tPFormalAnnouncements.SuspendLayout();
            this.tPCovidAnnouncements.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnnouncements
            // 
            this.pnlAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.pnlAnnouncements.Controls.Add(this.gbAddAnouncements);
            this.pnlAnnouncements.Controls.Add(this.tbcAnnouncements);
            this.pnlAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlAnnouncements.Location = new System.Drawing.Point(21, 22);
            this.pnlAnnouncements.Name = "pnlAnnouncements";
            this.pnlAnnouncements.Size = new System.Drawing.Size(783, 607);
            this.pnlAnnouncements.TabIndex = 1;
            // 
            // gbAddAnouncements
            // 
            this.gbAddAnouncements.Controls.Add(this.gbSubmitResults);
            this.gbAddAnouncements.Controls.Add(this.btnRestrictions);
            this.gbAddAnouncements.Controls.Add(this.btnDeleteAnnouncement);
            this.gbAddAnouncements.Controls.Add(this.lbRestrictions);
            this.gbAddAnouncements.Controls.Add(this.lbRoom);
            this.gbAddAnouncements.Controls.Add(this.tbRoom);
            this.gbAddAnouncements.Controls.Add(this.time);
            this.gbAddAnouncements.Controls.Add(this.btnAddAnnouncement);
            this.gbAddAnouncements.Controls.Add(this.date);
            this.gbAddAnouncements.Controls.Add(this.tbAnnouncementTitle);
            this.gbAddAnouncements.Controls.Add(this.lbDate);
            this.gbAddAnouncements.Controls.Add(this.rbFormal);
            this.gbAddAnouncements.Controls.Add(this.rbParty);
            this.gbAddAnouncements.Controls.Add(this.lbTitle);
            this.gbAddAnouncements.Controls.Add(this.lbType);
            this.gbAddAnouncements.Location = new System.Drawing.Point(36, 349);
            this.gbAddAnouncements.Name = "gbAddAnouncements";
            this.gbAddAnouncements.Size = new System.Drawing.Size(708, 239);
            this.gbAddAnouncements.TabIndex = 1;
            this.gbAddAnouncements.TabStop = false;
            this.gbAddAnouncements.Text = "Add your announcement";
            // 
            // gbSubmitResults
            // 
            this.gbSubmitResults.Controls.Add(this.lbTimeToSubmitResult);
            this.gbSubmitResults.Controls.Add(this.rbNegative);
            this.gbSubmitResults.Controls.Add(this.rbPositive);
            this.gbSubmitResults.Controls.Add(this.btnSubmitResults);
            this.gbSubmitResults.Controls.Add(this.lbResult);
            this.gbSubmitResults.Location = new System.Drawing.Point(1, 0);
            this.gbSubmitResults.Name = "gbSubmitResults";
            this.gbSubmitResults.Size = new System.Drawing.Size(708, 239);
            this.gbSubmitResults.TabIndex = 13;
            this.gbSubmitResults.TabStop = false;
            this.gbSubmitResults.Text = "Submit test results";
            this.gbSubmitResults.Visible = false;
            // 
            // lbTimeToSubmitResult
            // 
            this.lbTimeToSubmitResult.AutoSize = true;
            this.lbTimeToSubmitResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeToSubmitResult.Location = new System.Drawing.Point(20, 169);
            this.lbTimeToSubmitResult.Name = "lbTimeToSubmitResult";
            this.lbTimeToSubmitResult.Size = new System.Drawing.Size(0, 29);
            this.lbTimeToSubmitResult.TabIndex = 11;
            // 
            // rbNegative
            // 
            this.rbNegative.AutoSize = true;
            this.rbNegative.Location = new System.Drawing.Point(381, 90);
            this.rbNegative.Name = "rbNegative";
            this.rbNegative.Size = new System.Drawing.Size(130, 33);
            this.rbNegative.TabIndex = 10;
            this.rbNegative.TabStop = true;
            this.rbNegative.Text = "Negative";
            this.rbNegative.UseVisualStyleBackColor = true;
            // 
            // rbPositive
            // 
            this.rbPositive.AutoSize = true;
            this.rbPositive.Location = new System.Drawing.Point(164, 90);
            this.rbPositive.Name = "rbPositive";
            this.rbPositive.Size = new System.Drawing.Size(119, 33);
            this.rbPositive.TabIndex = 9;
            this.rbPositive.TabStop = true;
            this.rbPositive.Text = "Positive";
            this.rbPositive.UseVisualStyleBackColor = true;
            // 
            // btnSubmitResults
            // 
            this.btnSubmitResults.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSubmitResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmitResults.Location = new System.Drawing.Point(538, 158);
            this.btnSubmitResults.Name = "btnSubmitResults";
            this.btnSubmitResults.Size = new System.Drawing.Size(153, 53);
            this.btnSubmitResults.TabIndex = 8;
            this.btnSubmitResults.Text = "Submit";
            this.btnSubmitResults.UseVisualStyleBackColor = false;
            this.btnSubmitResults.Click += new System.EventHandler(this.btnSubmitResults_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.Location = new System.Drawing.Point(89, 45);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(87, 29);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Result:";
            // 
            // btnRestrictions
            // 
            this.btnRestrictions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestrictions.Location = new System.Drawing.Point(6, 171);
            this.btnRestrictions.Name = "btnRestrictions";
            this.btnRestrictions.Size = new System.Drawing.Size(158, 45);
            this.btnRestrictions.TabIndex = 9;
            this.btnRestrictions.Text = "Restrictions";
            this.btnRestrictions.UseVisualStyleBackColor = false;
            this.btnRestrictions.MouseLeave += new System.EventHandler(this.btnRestrictions_MouseLeave);
            this.btnRestrictions.MouseHover += new System.EventHandler(this.btnRestrictions_MouseHover);
            // 
            // btnDeleteAnnouncement
            // 
            this.btnDeleteAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAnnouncement.Location = new System.Drawing.Point(504, 158);
            this.btnDeleteAnnouncement.Name = "btnDeleteAnnouncement";
            this.btnDeleteAnnouncement.Size = new System.Drawing.Size(199, 70);
            this.btnDeleteAnnouncement.TabIndex = 12;
            this.btnDeleteAnnouncement.Text = "Delete Announcement";
            this.btnDeleteAnnouncement.UseVisualStyleBackColor = false;
            this.btnDeleteAnnouncement.Click += new System.EventHandler(this.btnDeleteAnnouncement_Click);
            // 
            // lbRestrictions
            // 
            this.lbRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRestrictions.FormattingEnabled = true;
            this.lbRestrictions.ItemHeight = 22;
            this.lbRestrictions.Items.AddRange(new object[] {
            "* Maximum allowed people in one room is 5",
            "* Wear your masks while being in a room with more people",
            "* Keep distance of 1.5m "});
            this.lbRestrictions.Location = new System.Drawing.Point(165, 158);
            this.lbRestrictions.Name = "lbRestrictions";
            this.lbRestrictions.Size = new System.Drawing.Size(544, 70);
            this.lbRestrictions.TabIndex = 2;
            this.lbRestrictions.Visible = false;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoom.Location = new System.Drawing.Point(475, 42);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(69, 25);
            this.lbRoom.TabIndex = 11;
            this.lbRoom.Text = "Room:";
            // 
            // tbRoom
            // 
            this.tbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRoom.Location = new System.Drawing.Point(550, 40);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(109, 30);
            this.tbRoom.TabIndex = 10;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(414, 113);
            this.time.Name = "time";
            this.time.ShowUpDown = true;
            this.time.Size = new System.Drawing.Size(130, 30);
            this.time.TabIndex = 9;
            this.time.Value = new System.DateTime(2021, 1, 5, 12, 27, 36, 0);
            // 
            // btnAddAnnouncement
            // 
            this.btnAddAnnouncement.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAnnouncement.Location = new System.Drawing.Point(597, 90);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.Size = new System.Drawing.Size(105, 53);
            this.btnAddAnnouncement.TabIndex = 8;
            this.btnAddAnnouncement.Text = "Add";
            this.btnAddAnnouncement.UseVisualStyleBackColor = false;
            this.btnAddAnnouncement.Click += new System.EventHandler(this.btnAddAnnouncement_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(165, 113);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(243, 30);
            this.date.TabIndex = 7;
            this.date.Value = new System.DateTime(2021, 1, 4, 23, 25, 40, 0);
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(82, 77);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(387, 30);
            this.tbAnnouncementTitle.TabIndex = 6;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(21, 118);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(138, 25);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date and time:";
            // 
            // rbFormal
            // 
            this.rbFormal.AutoSize = true;
            this.rbFormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbFormal.Location = new System.Drawing.Point(281, 40);
            this.rbFormal.Name = "rbFormal";
            this.rbFormal.Size = new System.Drawing.Size(93, 29);
            this.rbFormal.TabIndex = 5;
            this.rbFormal.TabStop = true;
            this.rbFormal.Text = "Formal";
            this.rbFormal.UseVisualStyleBackColor = true;
            // 
            // rbParty
            // 
            this.rbParty.AutoSize = true;
            this.rbParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbParty.Location = new System.Drawing.Point(114, 40);
            this.rbParty.Name = "rbParty";
            this.rbParty.Size = new System.Drawing.Size(78, 29);
            this.rbParty.TabIndex = 4;
            this.rbParty.TabStop = true;
            this.rbParty.Text = "Party";
            this.rbParty.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(21, 79);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(55, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbType.Location = new System.Drawing.Point(21, 42);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(63, 25);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Type:";
            // 
            // tbcAnnouncements
            // 
            this.tbcAnnouncements.Controls.Add(this.tPPartyAnnouncements);
            this.tbcAnnouncements.Controls.Add(this.tPFormalAnnouncements);
            this.tbcAnnouncements.Controls.Add(this.tPCovidAnnouncements);
            this.tbcAnnouncements.Location = new System.Drawing.Point(18, 35);
            this.tbcAnnouncements.Name = "tbcAnnouncements";
            this.tbcAnnouncements.SelectedIndex = 0;
            this.tbcAnnouncements.Size = new System.Drawing.Size(748, 308);
            this.tbcAnnouncements.TabIndex = 1;
            this.tbcAnnouncements.SelectedIndexChanged += new System.EventHandler(this.tbcAnnouncements_SelectedIndexChanged);
            // 
            // tPPartyAnnouncements
            // 
            this.tPPartyAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.tPPartyAnnouncements.Controls.Add(this.lbPartyAnnouncements);
            this.tPPartyAnnouncements.Location = new System.Drawing.Point(4, 38);
            this.tPPartyAnnouncements.Name = "tPPartyAnnouncements";
            this.tPPartyAnnouncements.Size = new System.Drawing.Size(740, 266);
            this.tPPartyAnnouncements.TabIndex = 0;
            this.tPPartyAnnouncements.Text = "Party";
            // 
            // lbPartyAnnouncements
            // 
            this.lbPartyAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPartyAnnouncements.FormattingEnabled = true;
            this.lbPartyAnnouncements.HorizontalScrollbar = true;
            this.lbPartyAnnouncements.ItemHeight = 25;
            this.lbPartyAnnouncements.Items.AddRange(new object[] {
            "--> Birthday Party - Date: 20.01.2021 - Room: 21 - Time: 20:00h - Alex Smith"});
            this.lbPartyAnnouncements.Location = new System.Drawing.Point(5, 39);
            this.lbPartyAnnouncements.Name = "lbPartyAnnouncements";
            this.lbPartyAnnouncements.Size = new System.Drawing.Size(730, 179);
            this.lbPartyAnnouncements.TabIndex = 1;
            // 
            // tPFormalAnnouncements
            // 
            this.tPFormalAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.tPFormalAnnouncements.Controls.Add(this.lbFormalAnnouncements);
            this.tPFormalAnnouncements.Location = new System.Drawing.Point(4, 38);
            this.tPFormalAnnouncements.Name = "tPFormalAnnouncements";
            this.tPFormalAnnouncements.Size = new System.Drawing.Size(740, 266);
            this.tPFormalAnnouncements.TabIndex = 1;
            this.tPFormalAnnouncements.Text = "Formal";
            // 
            // lbFormalAnnouncements
            // 
            this.lbFormalAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFormalAnnouncements.FormattingEnabled = true;
            this.lbFormalAnnouncements.HorizontalScrollbar = true;
            this.lbFormalAnnouncements.ItemHeight = 25;
            this.lbFormalAnnouncements.Items.AddRange(new object[] {
            "--> House meeting - Date: 23.01.2021 - Room: 0 - Time: 13:00h - Carter Johnson"});
            this.lbFormalAnnouncements.Location = new System.Drawing.Point(3, 36);
            this.lbFormalAnnouncements.Name = "lbFormalAnnouncements";
            this.lbFormalAnnouncements.Size = new System.Drawing.Size(730, 179);
            this.lbFormalAnnouncements.TabIndex = 2;
            // 
            // tPCovidAnnouncements
            // 
            this.tPCovidAnnouncements.BackColor = System.Drawing.Color.Lavender;
            this.tPCovidAnnouncements.Controls.Add(this.lbRequestTest);
            this.tPCovidAnnouncements.Controls.Add(this.lbPeopleWithCovid);
            this.tPCovidAnnouncements.Controls.Add(this.btnRequestTest);
            this.tPCovidAnnouncements.Location = new System.Drawing.Point(4, 38);
            this.tPCovidAnnouncements.Name = "tPCovidAnnouncements";
            this.tPCovidAnnouncements.Size = new System.Drawing.Size(740, 266);
            this.tPCovidAnnouncements.TabIndex = 2;
            this.tPCovidAnnouncements.Text = "COVID-19";
            // 
            // lbRequestTest
            // 
            this.lbRequestTest.AutoSize = true;
            this.lbRequestTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRequestTest.Location = new System.Drawing.Point(63, 209);
            this.lbRequestTest.Name = "lbRequestTest";
            this.lbRequestTest.Size = new System.Drawing.Size(335, 25);
            this.lbRequestTest.TabIndex = 12;
            this.lbRequestTest.Text = "You have symptoms? Request a test!";
            // 
            // lbPeopleWithCovid
            // 
            this.lbPeopleWithCovid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPeopleWithCovid.FormattingEnabled = true;
            this.lbPeopleWithCovid.HorizontalScrollbar = true;
            this.lbPeopleWithCovid.ItemHeight = 25;
            this.lbPeopleWithCovid.Items.AddRange(new object[] {
            "--> Carter Johnson - Student - 13 days left of quarantine"});
            this.lbPeopleWithCovid.Location = new System.Drawing.Point(14, 21);
            this.lbPeopleWithCovid.Name = "lbPeopleWithCovid";
            this.lbPeopleWithCovid.Size = new System.Drawing.Size(713, 154);
            this.lbPeopleWithCovid.TabIndex = 10;
            // 
            // btnRequestTest
            // 
            this.btnRequestTest.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRequestTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequestTest.Location = new System.Drawing.Point(448, 190);
            this.btnRequestTest.Name = "btnRequestTest";
            this.btnRequestTest.Size = new System.Drawing.Size(225, 57);
            this.btnRequestTest.TabIndex = 9;
            this.btnRequestTest.Text = "Request a free test";
            this.btnRequestTest.UseVisualStyleBackColor = false;
            this.btnRequestTest.Click += new System.EventHandler(this.btnRequestTest_Click);
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAnnouncements);
            this.Name = "Announcements";
            this.Size = new System.Drawing.Size(824, 650);
            this.pnlAnnouncements.ResumeLayout(false);
            this.gbAddAnouncements.ResumeLayout(false);
            this.gbAddAnouncements.PerformLayout();
            this.gbSubmitResults.ResumeLayout(false);
            this.gbSubmitResults.PerformLayout();
            this.tbcAnnouncements.ResumeLayout(false);
            this.tPPartyAnnouncements.ResumeLayout(false);
            this.tPFormalAnnouncements.ResumeLayout(false);
            this.tPCovidAnnouncements.ResumeLayout(false);
            this.tPCovidAnnouncements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnnouncements;
        private System.Windows.Forms.TabControl tbcAnnouncements;
        private System.Windows.Forms.TabPage tPPartyAnnouncements;
        private System.Windows.Forms.TabPage tPFormalAnnouncements;
        private System.Windows.Forms.TabPage tPCovidAnnouncements;
        private System.Windows.Forms.ListBox lbPartyAnnouncements;
        private System.Windows.Forms.GroupBox gbAddAnouncements;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox tbAnnouncementTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.RadioButton rbFormal;
        private System.Windows.Forms.RadioButton rbParty;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnRestrictions;
        private System.Windows.Forms.ListBox lbRestrictions;
        private System.Windows.Forms.Button btnAddAnnouncement;
        private System.Windows.Forms.ListBox lbFormalAnnouncements;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Button btnDeleteAnnouncement;
        private System.Windows.Forms.Label lbRequestTest;
        private System.Windows.Forms.ListBox lbPeopleWithCovid;
        private System.Windows.Forms.Button btnRequestTest;
        private System.Windows.Forms.GroupBox gbSubmitResults;
        private System.Windows.Forms.Button btnSubmitResults;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.RadioButton rbNegative;
        private System.Windows.Forms.RadioButton rbPositive;
        private System.Windows.Forms.Label lbTimeToSubmitResult;
    }
}
