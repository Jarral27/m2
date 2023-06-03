namespace Box360_M2
{
    partial class Appointment
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.makePage = new System.Windows.Forms.TabPage();
            this.pnlAddBooking = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.pnlClass = new System.Windows.Forms.Panel();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.classIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classPublicDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBox360 = new Box360_M2.dsBox360();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.lblClassType = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.pnlSelectDate = new System.Windows.Forms.Panel();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cancelPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.dgvBooking2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClient2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchClient2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingTableAdapter = new Box360_M2.dsBox360TableAdapters.BookingTableAdapter();
            this.clientTableAdapter = new Box360_M2.dsBox360TableAdapters.ClientTableAdapter();
            this.classTableAdapter = new Box360_M2.dsBox360TableAdapters.ClassTableAdapter();
            this.tabControl1.SuspendLayout();
            this.makePage.SuspendLayout();
            this.pnlAddBooking.SuspendLayout();
            this.pnlClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBox360)).BeginInit();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.pnlSelectDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.cancelPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.makePage);
            this.tabControl1.Controls.Add(this.cancelPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1363, 608);
            this.tabControl1.TabIndex = 0;
            // 
            // makePage
            // 
            this.makePage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.makePage.Controls.Add(this.pnlAddBooking);
            this.makePage.Controls.Add(this.pnlClass);
            this.makePage.Controls.Add(this.pnlClient);
            this.makePage.Controls.Add(this.pnlSelectDate);
            this.makePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePage.ForeColor = System.Drawing.Color.White;
            this.makePage.Location = new System.Drawing.Point(4, 25);
            this.makePage.Name = "makePage";
            this.makePage.Padding = new System.Windows.Forms.Padding(3);
            this.makePage.Size = new System.Drawing.Size(1355, 579);
            this.makePage.TabIndex = 0;
            this.makePage.Text = "Make Booking";
            // 
            // pnlAddBooking
            // 
            this.pnlAddBooking.BackColor = System.Drawing.Color.Teal;
            this.pnlAddBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddBooking.Controls.Add(this.label2);
            this.pnlAddBooking.Controls.Add(this.label1);
            this.pnlAddBooking.Controls.Add(this.cmbStatus);
            this.pnlAddBooking.Controls.Add(this.txtVenue);
            this.pnlAddBooking.Controls.Add(this.btnAddBooking);
            this.pnlAddBooking.ForeColor = System.Drawing.Color.Black;
            this.pnlAddBooking.Location = new System.Drawing.Point(1080, 192);
            this.pnlAddBooking.Name = "pnlAddBooking";
            this.pnlAddBooking.Size = new System.Drawing.Size(269, 384);
            this.pnlAddBooking.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter venue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ongoing",
            "Pending",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(31, 43);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(214, 24);
            this.cmbStatus.TabIndex = 2;
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(31, 114);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(214, 22);
            this.txtVenue.TabIndex = 1;
            this.txtVenue.Text = "Room";
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.ForeColor = System.Drawing.Color.Black;
            this.btnAddBooking.Location = new System.Drawing.Point(70, 274);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(134, 59);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "Confirm Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // pnlClass
            // 
            this.pnlClass.BackColor = System.Drawing.Color.Teal;
            this.pnlClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClass.Controls.Add(this.dgvClass);
            this.pnlClass.Controls.Add(this.txtSearchClass);
            this.pnlClass.Controls.Add(this.lblClassType);
            this.pnlClass.ForeColor = System.Drawing.Color.Black;
            this.pnlClass.Location = new System.Drawing.Point(3, 382);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(969, 194);
            this.pnlClass.TabIndex = 2;
            // 
            // dgvClass
            // 
            this.dgvClass.AutoGenerateColumns = false;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classIDDataGridViewTextBoxColumn1,
            this.coachIDDataGridViewTextBoxColumn,
            this.groupTypeDataGridViewTextBoxColumn,
            this.classTypeDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.maxCapacityDataGridViewTextBoxColumn,
            this.currentCapacityDataGridViewTextBoxColumn,
            this.classPublicDataGridViewCheckBoxColumn});
            this.dgvClass.DataSource = this.classBindingSource;
            this.dgvClass.Location = new System.Drawing.Point(12, 27);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Size = new System.Drawing.Size(946, 159);
            this.dgvClass.TabIndex = 8;
            this.dgvClass.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClass_RowHeaderMouseClick);
            // 
            // classIDDataGridViewTextBoxColumn1
            // 
            this.classIDDataGridViewTextBoxColumn1.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn1.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn1.Name = "classIDDataGridViewTextBoxColumn1";
            // 
            // coachIDDataGridViewTextBoxColumn
            // 
            this.coachIDDataGridViewTextBoxColumn.DataPropertyName = "CoachID";
            this.coachIDDataGridViewTextBoxColumn.HeaderText = "CoachID";
            this.coachIDDataGridViewTextBoxColumn.Name = "coachIDDataGridViewTextBoxColumn";
            // 
            // groupTypeDataGridViewTextBoxColumn
            // 
            this.groupTypeDataGridViewTextBoxColumn.DataPropertyName = "GroupType";
            this.groupTypeDataGridViewTextBoxColumn.HeaderText = "GroupType";
            this.groupTypeDataGridViewTextBoxColumn.Name = "groupTypeDataGridViewTextBoxColumn";
            // 
            // classTypeDataGridViewTextBoxColumn
            // 
            this.classTypeDataGridViewTextBoxColumn.DataPropertyName = "ClassType";
            this.classTypeDataGridViewTextBoxColumn.HeaderText = "ClassType";
            this.classTypeDataGridViewTextBoxColumn.Name = "classTypeDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // maxCapacityDataGridViewTextBoxColumn
            // 
            this.maxCapacityDataGridViewTextBoxColumn.DataPropertyName = "MaxCapacity";
            this.maxCapacityDataGridViewTextBoxColumn.HeaderText = "MaxCapacity";
            this.maxCapacityDataGridViewTextBoxColumn.Name = "maxCapacityDataGridViewTextBoxColumn";
            // 
            // currentCapacityDataGridViewTextBoxColumn
            // 
            this.currentCapacityDataGridViewTextBoxColumn.DataPropertyName = "CurrentCapacity";
            this.currentCapacityDataGridViewTextBoxColumn.HeaderText = "CurrentCapacity";
            this.currentCapacityDataGridViewTextBoxColumn.Name = "currentCapacityDataGridViewTextBoxColumn";
            // 
            // classPublicDataGridViewCheckBoxColumn
            // 
            this.classPublicDataGridViewCheckBoxColumn.DataPropertyName = "ClassPublic";
            this.classPublicDataGridViewCheckBoxColumn.HeaderText = "ClassPublic";
            this.classPublicDataGridViewCheckBoxColumn.Name = "classPublicDataGridViewCheckBoxColumn";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dsBox360;
            // 
            // dsBox360
            // 
            this.dsBox360.DataSetName = "dsBox360";
            this.dsBox360.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.Location = new System.Drawing.Point(128, 2);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(145, 22);
            this.txtSearchClass.TabIndex = 7;
            this.txtSearchClass.TextChanged += new System.EventHandler(this.txtSearchClass_TextChanged);
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassType.ForeColor = System.Drawing.Color.White;
            this.lblClassType.Location = new System.Drawing.Point(12, 2);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(113, 16);
            this.lblClassType.TabIndex = 6;
            this.lblClassType.Text = "Enter a class type";
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.Color.Teal;
            this.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClient.Controls.Add(this.dgvClient);
            this.pnlClient.Controls.Add(this.txtSearchClient);
            this.pnlClient.Controls.Add(this.lblSearchClient);
            this.pnlClient.ForeColor = System.Drawing.Color.Black;
            this.pnlClient.Location = new System.Drawing.Point(3, 192);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(1071, 188);
            this.pnlClient.TabIndex = 1;
            // 
            // dgvClient
            // 
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.membershipPlanDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvClient.DataSource = this.clientBindingSource;
            this.dgvClient.Location = new System.Drawing.Point(11, 30);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 30;
            this.dgvClient.Size = new System.Drawing.Size(1047, 150);
            this.dgvClient.TabIndex = 2;
            this.dgvClient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClient_RowHeaderMouseClick);
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // membershipPlanDataGridViewTextBoxColumn
            // 
            this.membershipPlanDataGridViewTextBoxColumn.DataPropertyName = "MembershipPlan";
            this.membershipPlanDataGridViewTextBoxColumn.HeaderText = "MembershipPlan";
            this.membershipPlanDataGridViewTextBoxColumn.Name = "membershipPlanDataGridViewTextBoxColumn";
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "AmountDue";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "AmountDue";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dsBox360;
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(155, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(145, 22);
            this.txtSearchClient.TabIndex = 1;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchClient.ForeColor = System.Drawing.Color.White;
            this.lblSearchClient.Location = new System.Drawing.Point(11, 4);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(138, 16);
            this.lblSearchClient.TabIndex = 0;
            this.lblSearchClient.Text = "Enter a client surname";
            // 
            // pnlSelectDate
            // 
            this.pnlSelectDate.BackColor = System.Drawing.Color.Teal;
            this.pnlSelectDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelectDate.Controls.Add(this.dgvBooking);
            this.pnlSelectDate.Controls.Add(this.monthCalendar1);
            this.pnlSelectDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectDate.ForeColor = System.Drawing.Color.Black;
            this.pnlSelectDate.Location = new System.Drawing.Point(3, 3);
            this.pnlSelectDate.Name = "pnlSelectDate";
            this.pnlSelectDate.Size = new System.Drawing.Size(1349, 183);
            this.pnlSelectDate.TabIndex = 0;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AutoGenerateColumns = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.venueDataGridViewTextBoxColumn});
            this.dgvBooking.DataSource = this.bookingBindingSource;
            this.dgvBooking.Location = new System.Drawing.Point(248, 9);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.Size = new System.Drawing.Size(745, 162);
            this.dgvBooking.TabIndex = 1;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // venueDataGridViewTextBoxColumn
            // 
            this.venueDataGridViewTextBoxColumn.DataPropertyName = "Venue";
            this.venueDataGridViewTextBoxColumn.HeaderText = "Venue";
            this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.dsBox360;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // cancelPage
            // 
            this.cancelPage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cancelPage.Controls.Add(this.panel2);
            this.cancelPage.Controls.Add(this.panel1);
            this.cancelPage.Location = new System.Drawing.Point(4, 25);
            this.cancelPage.Name = "cancelPage";
            this.cancelPage.Padding = new System.Windows.Forms.Padding(3);
            this.cancelPage.Size = new System.Drawing.Size(1355, 579);
            this.cancelPage.TabIndex = 1;
            this.cancelPage.Text = "Cancel Booking";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnCancelBooking);
            this.panel2.Controls.Add(this.dgvBooking2);
            this.panel2.Location = new System.Drawing.Point(117, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 252);
            this.panel2.TabIndex = 3;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(415, 20);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(201, 45);
            this.btnCancelBooking.TabIndex = 3;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // dgvBooking2
            // 
            this.dgvBooking2.AutoGenerateColumns = false;
            this.dgvBooking2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dgvBooking2.DataSource = this.bookingBindingSource;
            this.dgvBooking2.Location = new System.Drawing.Point(174, 71);
            this.dgvBooking2.Name = "dgvBooking2";
            this.dgvBooking2.Size = new System.Drawing.Size(747, 162);
            this.dgvBooking2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BookingID";
            this.dataGridViewTextBoxColumn11.HeaderText = "BookingID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn13.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "BookingDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "BookingDate";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn15.HeaderText = "Status";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn16.HeaderText = "Type";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn17.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvClient2);
            this.panel1.Controls.Add(this.txtSearchClient2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(117, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 188);
            this.panel1.TabIndex = 2;
            // 
            // dgvClient2
            // 
            this.dgvClient2.AutoGenerateColumns = false;
            this.dgvClient2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvClient2.DataSource = this.clientBindingSource;
            this.dgvClient2.Location = new System.Drawing.Point(11, 30);
            this.dgvClient2.Name = "dgvClient2";
            this.dgvClient2.RowHeadersWidth = 30;
            this.dgvClient2.Size = new System.Drawing.Size(1038, 150);
            this.dgvClient2.TabIndex = 2;
            this.dgvClient2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "ContactNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmailAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "EmailAddress";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MembershipPlan";
            this.dataGridViewTextBoxColumn6.HeaderText = "MembershipPlan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AmountDue";
            this.dataGridViewTextBoxColumn7.HeaderText = "AmountDue";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn8.HeaderText = "Age";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn9.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn10.HeaderText = "Password";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // txtSearchClient2
            // 
            this.txtSearchClient2.Location = new System.Drawing.Point(155, 4);
            this.txtSearchClient2.Name = "txtSearchClient2";
            this.txtSearchClient2.Size = new System.Drawing.Size(145, 22);
            this.txtSearchClient2.TabIndex = 1;
            this.txtSearchClient2.TextChanged += new System.EventHandler(this.txtSearchClient2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter a client surname";
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1363, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.tabControl1.ResumeLayout(false);
            this.makePage.ResumeLayout(false);
            this.pnlAddBooking.ResumeLayout(false);
            this.pnlAddBooking.PerformLayout();
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBox360)).EndInit();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.pnlSelectDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.cancelPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage makePage;
        private System.Windows.Forms.TabPage cancelPage;
        private System.Windows.Forms.Panel pnlSelectDate;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private dsBox360 dsBox360;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private dsBox360TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dsBox360TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlClass;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.BindingSource classBindingSource;
        private dsBox360TableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn classPublicDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel pnlAddBooking;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClient2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox txtSearchClient2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DataGridView dgvBooking2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}