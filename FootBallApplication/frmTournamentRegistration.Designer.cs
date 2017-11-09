namespace FootBallApplication
{
    partial class frmTournamentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTournamentRegistration));
            this.btnView = new System.Windows.Forms.Button();
            this.btnDateBrowse = new System.Windows.Forms.Button();
            this.btnVideoBrowse = new System.Windows.Forms.Button();
            this.btnDBBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.txtDBPath = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnEndDateBrowseClick = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToTeamRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToPlayerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToNavigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.gvTour = new System.Windows.Forms.DataGridView();
            this.lblchoose1 = new System.Windows.Forms.Label();
            this.lblchoose2 = new System.Windows.Forms.Label();
            this.lblchoose4 = new System.Windows.Forms.Label();
            this.lblchoose3 = new System.Windows.Forms.Label();
            this.lblcontinue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Khaki;
            this.btnView.Location = new System.Drawing.Point(623, 157);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 33;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDateBrowse
            // 
            this.btnDateBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateBrowse.Location = new System.Drawing.Point(774, 27);
            this.btnDateBrowse.Name = "btnDateBrowse";
            this.btnDateBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnDateBrowse.TabIndex = 32;
            this.btnDateBrowse.Text = "Choose";
            this.btnDateBrowse.UseVisualStyleBackColor = true;
            this.btnDateBrowse.Visible = false;
            this.btnDateBrowse.Click += new System.EventHandler(this.btnDateBrowse_Click);
            // 
            // btnVideoBrowse
            // 
            this.btnVideoBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoBrowse.Location = new System.Drawing.Point(630, 27);
            this.btnVideoBrowse.Name = "btnVideoBrowse";
            this.btnVideoBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnVideoBrowse.TabIndex = 30;
            this.btnVideoBrowse.Text = "Choose";
            this.btnVideoBrowse.UseVisualStyleBackColor = true;
            this.btnVideoBrowse.Visible = false;
            this.btnVideoBrowse.Click += new System.EventHandler(this.btnVideoBrowse_Click);
            // 
            // btnDBBrowse
            // 
            this.btnDBBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBBrowse.Location = new System.Drawing.Point(774, 56);
            this.btnDBBrowse.Name = "btnDBBrowse";
            this.btnDBBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnDBBrowse.TabIndex = 29;
            this.btnDBBrowse.Text = "Choose";
            this.btnDBBrowse.UseVisualStyleBackColor = true;
            this.btnDBBrowse.Visible = false;
            this.btnDBBrowse.Click += new System.EventHandler(this.btnDBBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Khaki;
            this.btnSave.Location = new System.Drawing.Point(625, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Create";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(44, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Video Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(56, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "DB Path";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(44, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(48, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "StartDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(44, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tournament Name";
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(199, 356);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(180, 20);
            this.txtVideoPath.TabIndex = 22;
            // 
            // txtDBPath
            // 
            this.txtDBPath.Location = new System.Drawing.Point(205, 403);
            this.txtDBPath.Name = "txtDBPath";
            this.txtDBPath.Size = new System.Drawing.Size(180, 20);
            this.txtDBPath.TabIndex = 21;
            this.txtDBPath.Visible = false;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(199, 297);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(180, 20);
            this.txtCountry.TabIndex = 20;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(199, 185);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 20);
            this.txtDate.TabIndex = 19;
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(199, 89);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(180, 20);
            this.txtTourName.TabIndex = 18;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(199, 239);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(180, 20);
            this.txtEnd.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(44, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "EndDate";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(389, 182);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 34;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(389, 182);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected_1);
            // 
            // btnEndDateBrowseClick
            // 
            this.btnEndDateBrowseClick.Location = new System.Drawing.Point(774, 12);
            this.btnEndDateBrowseClick.Name = "btnEndDateBrowseClick";
            this.btnEndDateBrowseClick.Size = new System.Drawing.Size(56, 23);
            this.btnEndDateBrowseClick.TabIndex = 36;
            this.btnEndDateBrowseClick.Text = "Choose";
            this.btnEndDateBrowseClick.UseVisualStyleBackColor = true;
            this.btnEndDateBrowseClick.Visible = false;
            this.btnEndDateBrowseClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToTeamRegistrationToolStripMenuItem,
            this.goToPlayerRegistrationToolStripMenuItem,
            this.goToNavigationToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // goToTeamRegistrationToolStripMenuItem
            // 
            this.goToTeamRegistrationToolStripMenuItem.Name = "goToTeamRegistrationToolStripMenuItem";
            this.goToTeamRegistrationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.goToTeamRegistrationToolStripMenuItem.Text = "Go to Team Registration";
            this.goToTeamRegistrationToolStripMenuItem.Click += new System.EventHandler(this.goToTeamRegistrationToolStripMenuItem_Click);
            // 
            // goToPlayerRegistrationToolStripMenuItem
            // 
            this.goToPlayerRegistrationToolStripMenuItem.Name = "goToPlayerRegistrationToolStripMenuItem";
            this.goToPlayerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.goToPlayerRegistrationToolStripMenuItem.Text = "Go to player Registration";
            // 
            // goToNavigationToolStripMenuItem
            // 
            this.goToNavigationToolStripMenuItem.Name = "goToNavigationToolStripMenuItem";
            this.goToNavigationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.goToNavigationToolStripMenuItem.Text = "Go to Navigation";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(44, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "DOMESTIC",
            "INTERNATIONAL"});
            this.cmbCategory.Location = new System.Drawing.Point(199, 138);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 21);
            this.cmbCategory.TabIndex = 38;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(611, 56);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 123;
            this.btnNext.Text = "Next Step";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gvTour
            // 
            this.gvTour.AllowUserToAddRows = false;
            this.gvTour.AllowUserToDeleteRows = false;
            this.gvTour.AllowUserToResizeRows = false;
            this.gvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvTour.BackgroundColor = System.Drawing.Color.Khaki;
            this.gvTour.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTour.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvTour.Location = new System.Drawing.Point(54, 444);
            this.gvTour.Name = "gvTour";
            this.gvTour.RowHeadersVisible = false;
            this.gvTour.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTour.Size = new System.Drawing.Size(562, 150);
            this.gvTour.TabIndex = 124;
            this.gvTour.Visible = false;
            // 
            // lblchoose1
            // 
            this.lblchoose1.AutoSize = true;
            this.lblchoose1.BackColor = System.Drawing.Color.Transparent;
            this.lblchoose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoose1.ForeColor = System.Drawing.Color.Khaki;
            this.lblchoose1.Location = new System.Drawing.Point(391, 190);
            this.lblchoose1.Name = "lblchoose1";
            this.lblchoose1.Size = new System.Drawing.Size(49, 13);
            this.lblchoose1.TabIndex = 125;
            this.lblchoose1.Text = "Choose";
            this.lblchoose1.Click += new System.EventHandler(this.lblchoose1_Click);
            // 
            // lblchoose2
            // 
            this.lblchoose2.AutoSize = true;
            this.lblchoose2.BackColor = System.Drawing.Color.Transparent;
            this.lblchoose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoose2.ForeColor = System.Drawing.Color.Khaki;
            this.lblchoose2.Location = new System.Drawing.Point(386, 241);
            this.lblchoose2.Name = "lblchoose2";
            this.lblchoose2.Size = new System.Drawing.Size(49, 13);
            this.lblchoose2.TabIndex = 125;
            this.lblchoose2.Text = "Choose";
            this.lblchoose2.Click += new System.EventHandler(this.lblchoose2_Click);
            // 
            // lblchoose4
            // 
            this.lblchoose4.AutoSize = true;
            this.lblchoose4.BackColor = System.Drawing.Color.Transparent;
            this.lblchoose4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoose4.ForeColor = System.Drawing.Color.Khaki;
            this.lblchoose4.Location = new System.Drawing.Point(386, 361);
            this.lblchoose4.Name = "lblchoose4";
            this.lblchoose4.Size = new System.Drawing.Size(49, 13);
            this.lblchoose4.TabIndex = 125;
            this.lblchoose4.Text = "Choose";
            this.lblchoose4.Click += new System.EventHandler(this.lblchoose4_Click);
            // 
            // lblchoose3
            // 
            this.lblchoose3.AutoSize = true;
            this.lblchoose3.BackColor = System.Drawing.Color.Transparent;
            this.lblchoose3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoose3.ForeColor = System.Drawing.Color.Khaki;
            this.lblchoose3.Location = new System.Drawing.Point(391, 405);
            this.lblchoose3.Name = "lblchoose3";
            this.lblchoose3.Size = new System.Drawing.Size(49, 13);
            this.lblchoose3.TabIndex = 125;
            this.lblchoose3.Text = "Choose";
            this.lblchoose3.Visible = false;
            this.lblchoose3.Click += new System.EventHandler(this.lblchoose3_Click);
            // 
            // lblcontinue
            // 
            this.lblcontinue.AutoSize = true;
            this.lblcontinue.BackColor = System.Drawing.Color.Transparent;
            this.lblcontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontinue.ForeColor = System.Drawing.Color.Khaki;
            this.lblcontinue.Location = new System.Drawing.Point(627, 600);
            this.lblcontinue.Name = "lblcontinue";
            this.lblcontinue.Size = new System.Drawing.Size(95, 15);
            this.lblcontinue.TabIndex = 126;
            this.lblcontinue.Text = "Continue Kick";
            this.lblcontinue.Visible = false;
            this.lblcontinue.Click += new System.EventHandler(this.lblcontinue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(696, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 41);
            this.panel1.TabIndex = 127;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(697, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 37);
            this.panel2.TabIndex = 127;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(695, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 37);
            this.panel3.TabIndex = 221;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(694, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 41);
            this.panel4.TabIndex = 222;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Khaki;
            this.button4.Location = new System.Drawing.Point(628, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 220;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Khaki;
            this.button5.Location = new System.Drawing.Point(628, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 218;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Khaki;
            this.button3.Location = new System.Drawing.Point(628, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 219;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(697, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(42, 41);
            this.panel5.TabIndex = 223;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(697, 382);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(42, 41);
            this.panel6.TabIndex = 225;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(626, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 224;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmTournamentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FootBallApplication.Properties.Resources.hfjdg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 621);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcontinue);
            this.Controls.Add(this.lblchoose3);
            this.Controls.Add(this.lblchoose4);
            this.Controls.Add(this.lblchoose2);
            this.Controls.Add(this.lblchoose1);
            this.Controls.Add(this.gvTour);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnEndDateBrowseClick);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDateBrowse);
            this.Controls.Add(this.btnVideoBrowse);
            this.Controls.Add(this.btnDBBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVideoPath);
            this.Controls.Add(this.txtDBPath);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTournamentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTournamentRegistration";
            this.Load += new System.EventHandler(this.frmTournamentRegistration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDateBrowse;
        private System.Windows.Forms.Button btnVideoBrowse;
        private System.Windows.Forms.Button btnDBBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.TextBox txtDBPath;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnEndDateBrowseClick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToTeamRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToPlayerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToNavigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView gvTour;
        private System.Windows.Forms.Label lblchoose1;
        private System.Windows.Forms.Label lblchoose2;
        private System.Windows.Forms.Label lblchoose4;
        private System.Windows.Forms.Label lblchoose3;
        private System.Windows.Forms.Label lblcontinue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}