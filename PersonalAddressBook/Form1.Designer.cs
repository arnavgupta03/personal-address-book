namespace PersonalAddressBook
{
    partial class FormPABook
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
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtAddNum = new System.Windows.Forms.TextBox();
            this.lblAddNum = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.tabBirthday = new System.Windows.Forms.TabPage();
            this.btnBdaySearch = new System.Windows.Forms.Button();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.lblBday = new System.Windows.Forms.Label();
            this.txtBdayCellNum = new System.Windows.Forms.TextBox();
            this.lblBdayCellNum = new System.Windows.Forms.Label();
            this.txtBdayEmail = new System.Windows.Forms.TextBox();
            this.lblBdayEmail = new System.Windows.Forms.Label();
            this.lblBdayInstructions = new System.Windows.Forms.Label();
            this.txtBdayLastName = new System.Windows.Forms.TextBox();
            this.lblBdayLastName = new System.Windows.Forms.Label();
            this.txtBdayFirstName = new System.Windows.Forms.TextBox();
            this.lblBdayFirstName = new System.Windows.Forms.Label();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.txtContactCellNum = new System.Windows.Forms.TextBox();
            this.lblContactCellNum = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.btnContactSearch = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContactLastName = new System.Windows.Forms.TextBox();
            this.lblContactLastName = new System.Windows.Forms.Label();
            this.txtContactFirstName = new System.Windows.Forms.TextBox();
            this.lblContactFirstName = new System.Windows.Forms.Label();
            this.tabToday = new System.Windows.Forms.TabPage();
            this.lbToday = new System.Windows.Forms.ListBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.tabChange = new System.Windows.Forms.TabPage();
            this.txtEditCellNum = new System.Windows.Forms.TextBox();
            this.lblEditCellNum = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.dtpEditBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblEditBirthday = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcMain.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabBirthday.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.tabToday.SuspendLayout();
            this.tabChange.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tabAdd);
            this.tabcMain.Controls.Add(this.tabBirthday);
            this.tabcMain.Controls.Add(this.tabContact);
            this.tabcMain.Controls.Add(this.tabToday);
            this.tabcMain.Controls.Add(this.tabChange);
            this.tabcMain.Location = new System.Drawing.Point(12, 27);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(642, 310);
            this.tabcMain.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.txtAddNum);
            this.tabAdd.Controls.Add(this.lblAddNum);
            this.tabAdd.Controls.Add(this.txtAddEmail);
            this.tabAdd.Controls.Add(this.lblAddEmail);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.dtpAdd);
            this.tabAdd.Controls.Add(this.lblAddDate);
            this.tabAdd.Controls.Add(this.txtAddLastName);
            this.tabAdd.Controls.Add(this.lblAddLastName);
            this.tabAdd.Controls.Add(this.txtAddFirstName);
            this.tabAdd.Controls.Add(this.lblAddFirstName);
            this.tabAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(634, 284);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddNum
            // 
            this.txtAddNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNum.Location = new System.Drawing.Point(226, 168);
            this.txtAddNum.Name = "txtAddNum";
            this.txtAddNum.Size = new System.Drawing.Size(384, 26);
            this.txtAddNum.TabIndex = 5;
            // 
            // lblAddNum
            // 
            this.lblAddNum.AutoSize = true;
            this.lblAddNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNum.Location = new System.Drawing.Point(17, 167);
            this.lblAddNum.Name = "lblAddNum";
            this.lblAddNum.Size = new System.Drawing.Size(203, 26);
            this.lblAddNum.TabIndex = 9;
            this.lblAddNum.Text = "Cell Phone Number";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmail.Location = new System.Drawing.Point(177, 120);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(433, 26);
            this.txtAddEmail.TabIndex = 4;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmail.Location = new System.Drawing.Point(17, 119);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(154, 26);
            this.lblAddEmail.TabIndex = 7;
            this.lblAddEmail.Text = "Email Address";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(25, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(585, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpAdd
            // 
            this.dtpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdd.Location = new System.Drawing.Point(349, 54);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.Size = new System.Drawing.Size(261, 26);
            this.dtpAdd.TabIndex = 3;
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDate.Location = new System.Drawing.Point(442, 25);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(92, 26);
            this.lblAddDate.TabIndex = 4;
            this.lblAddDate.Text = "Birthday";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLastName.Location = new System.Drawing.Point(144, 72);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(181, 26);
            this.txtAddLastName.TabIndex = 2;
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLastName.Location = new System.Drawing.Point(20, 71);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(118, 26);
            this.lblAddLastName.TabIndex = 2;
            this.lblAddLastName.Text = "Last Name";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFirstName.Location = new System.Drawing.Point(145, 25);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFirstName.Location = new System.Drawing.Point(20, 24);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(119, 26);
            this.lblAddFirstName.TabIndex = 0;
            this.lblAddFirstName.Text = "First Name";
            // 
            // tabBirthday
            // 
            this.tabBirthday.Controls.Add(this.btnBdaySearch);
            this.tabBirthday.Controls.Add(this.dtpBday);
            this.tabBirthday.Controls.Add(this.lblBday);
            this.tabBirthday.Controls.Add(this.txtBdayCellNum);
            this.tabBirthday.Controls.Add(this.lblBdayCellNum);
            this.tabBirthday.Controls.Add(this.txtBdayEmail);
            this.tabBirthday.Controls.Add(this.lblBdayEmail);
            this.tabBirthday.Controls.Add(this.lblBdayInstructions);
            this.tabBirthday.Controls.Add(this.txtBdayLastName);
            this.tabBirthday.Controls.Add(this.lblBdayLastName);
            this.tabBirthday.Controls.Add(this.txtBdayFirstName);
            this.tabBirthday.Controls.Add(this.lblBdayFirstName);
            this.tabBirthday.Location = new System.Drawing.Point(4, 22);
            this.tabBirthday.Name = "tabBirthday";
            this.tabBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthday.Size = new System.Drawing.Size(634, 284);
            this.tabBirthday.TabIndex = 1;
            this.tabBirthday.Text = "Show Birthday";
            this.tabBirthday.UseVisualStyleBackColor = true;
            // 
            // btnBdaySearch
            // 
            this.btnBdaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBdaySearch.Location = new System.Drawing.Point(12, 180);
            this.btnBdaySearch.Name = "btnBdaySearch";
            this.btnBdaySearch.Size = new System.Drawing.Size(313, 65);
            this.btnBdaySearch.TabIndex = 5;
            this.btnBdaySearch.Text = "Search";
            this.btnBdaySearch.UseVisualStyleBackColor = true;
            this.btnBdaySearch.Click += new System.EventHandler(this.btnBdaySearch_Click);
            // 
            // dtpBday
            // 
            this.dtpBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBday.Location = new System.Drawing.Point(343, 209);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(277, 26);
            this.dtpBday.TabIndex = 14;
            this.dtpBday.TabStop = false;
            this.dtpBday.Visible = false;
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBday.Location = new System.Drawing.Point(434, 180);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(92, 26);
            this.lblBday.TabIndex = 15;
            this.lblBday.Text = "Birthday";
            this.lblBday.Visible = false;
            // 
            // txtBdayCellNum
            // 
            this.txtBdayCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBdayCellNum.Location = new System.Drawing.Point(216, 89);
            this.txtBdayCellNum.Name = "txtBdayCellNum";
            this.txtBdayCellNum.Size = new System.Drawing.Size(404, 26);
            this.txtBdayCellNum.TabIndex = 3;
            // 
            // lblBdayCellNum
            // 
            this.lblBdayCellNum.AutoSize = true;
            this.lblBdayCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdayCellNum.Location = new System.Drawing.Point(7, 88);
            this.lblBdayCellNum.Name = "lblBdayCellNum";
            this.lblBdayCellNum.Size = new System.Drawing.Size(203, 26);
            this.lblBdayCellNum.TabIndex = 13;
            this.lblBdayCellNum.Text = "Cell Phone Number";
            // 
            // txtBdayEmail
            // 
            this.txtBdayEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBdayEmail.Location = new System.Drawing.Point(167, 132);
            this.txtBdayEmail.Name = "txtBdayEmail";
            this.txtBdayEmail.Size = new System.Drawing.Size(453, 26);
            this.txtBdayEmail.TabIndex = 4;
            // 
            // lblBdayEmail
            // 
            this.lblBdayEmail.AutoSize = true;
            this.lblBdayEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdayEmail.Location = new System.Drawing.Point(7, 131);
            this.lblBdayEmail.Name = "lblBdayEmail";
            this.lblBdayEmail.Size = new System.Drawing.Size(154, 26);
            this.lblBdayEmail.TabIndex = 12;
            this.lblBdayEmail.Text = "Email Address";
            // 
            // lblBdayInstructions
            // 
            this.lblBdayInstructions.AutoSize = true;
            this.lblBdayInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdayInstructions.Location = new System.Drawing.Point(44, 15);
            this.lblBdayInstructions.Name = "lblBdayInstructions";
            this.lblBdayInstructions.Size = new System.Drawing.Size(547, 20);
            this.lblBdayInstructions.TabIndex = 7;
            this.lblBdayInstructions.Text = "Please input either the full name, cell number, or email address. (not multiple)";
            // 
            // txtBdayLastName
            // 
            this.txtBdayLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBdayLastName.Location = new System.Drawing.Point(439, 48);
            this.txtBdayLastName.Name = "txtBdayLastName";
            this.txtBdayLastName.Size = new System.Drawing.Size(181, 26);
            this.txtBdayLastName.TabIndex = 2;
            // 
            // lblBdayLastName
            // 
            this.lblBdayLastName.AutoSize = true;
            this.lblBdayLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdayLastName.Location = new System.Drawing.Point(319, 47);
            this.lblBdayLastName.Name = "lblBdayLastName";
            this.lblBdayLastName.Size = new System.Drawing.Size(118, 26);
            this.lblBdayLastName.TabIndex = 6;
            this.lblBdayLastName.Text = "Last Name";
            // 
            // txtBdayFirstName
            // 
            this.txtBdayFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBdayFirstName.Location = new System.Drawing.Point(132, 48);
            this.txtBdayFirstName.Name = "txtBdayFirstName";
            this.txtBdayFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtBdayFirstName.TabIndex = 1;
            // 
            // lblBdayFirstName
            // 
            this.lblBdayFirstName.AutoSize = true;
            this.lblBdayFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdayFirstName.Location = new System.Drawing.Point(7, 48);
            this.lblBdayFirstName.Name = "lblBdayFirstName";
            this.lblBdayFirstName.Size = new System.Drawing.Size(119, 26);
            this.lblBdayFirstName.TabIndex = 3;
            this.lblBdayFirstName.Text = "First Name";
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.txtContactCellNum);
            this.tabContact.Controls.Add(this.lblContactCellNum);
            this.tabContact.Controls.Add(this.txtContactEmail);
            this.tabContact.Controls.Add(this.lblContactEmail);
            this.tabContact.Controls.Add(this.btnContactSearch);
            this.tabContact.Controls.Add(this.lblContact);
            this.tabContact.Controls.Add(this.txtContactLastName);
            this.tabContact.Controls.Add(this.lblContactLastName);
            this.tabContact.Controls.Add(this.txtContactFirstName);
            this.tabContact.Controls.Add(this.lblContactFirstName);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(634, 284);
            this.tabContact.TabIndex = 4;
            this.tabContact.Text = "Show Contact Info";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // txtContactCellNum
            // 
            this.txtContactCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactCellNum.Location = new System.Drawing.Point(220, 186);
            this.txtContactCellNum.Name = "txtContactCellNum";
            this.txtContactCellNum.ReadOnly = true;
            this.txtContactCellNum.Size = new System.Drawing.Size(404, 26);
            this.txtContactCellNum.TabIndex = 14;
            this.txtContactCellNum.TabStop = false;
            this.txtContactCellNum.Visible = false;
            // 
            // lblContactCellNum
            // 
            this.lblContactCellNum.AutoSize = true;
            this.lblContactCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactCellNum.Location = new System.Drawing.Point(11, 185);
            this.lblContactCellNum.Name = "lblContactCellNum";
            this.lblContactCellNum.Size = new System.Drawing.Size(203, 26);
            this.lblContactCellNum.TabIndex = 17;
            this.lblContactCellNum.Text = "Cell Phone Number";
            this.lblContactCellNum.Visible = false;
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactEmail.Location = new System.Drawing.Point(171, 229);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.ReadOnly = true;
            this.txtContactEmail.Size = new System.Drawing.Size(453, 26);
            this.txtContactEmail.TabIndex = 15;
            this.txtContactEmail.TabStop = false;
            this.txtContactEmail.Visible = false;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactEmail.Location = new System.Drawing.Point(11, 228);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(154, 26);
            this.lblContactEmail.TabIndex = 16;
            this.lblContactEmail.Text = "Email Address";
            this.lblContactEmail.Visible = false;
            // 
            // btnContactSearch
            // 
            this.btnContactSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactSearch.Location = new System.Drawing.Point(159, 103);
            this.btnContactSearch.Name = "btnContactSearch";
            this.btnContactSearch.Size = new System.Drawing.Size(313, 65);
            this.btnContactSearch.TabIndex = 3;
            this.btnContactSearch.Text = "Search";
            this.btnContactSearch.UseVisualStyleBackColor = true;
            this.btnContactSearch.Click += new System.EventHandler(this.btnContactSearch_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(142, 22);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(357, 20);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Please input the full name to find the contact info.";
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactLastName.Location = new System.Drawing.Point(443, 60);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(181, 26);
            this.txtContactLastName.TabIndex = 2;
            // 
            // lblContactLastName
            // 
            this.lblContactLastName.AutoSize = true;
            this.lblContactLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactLastName.Location = new System.Drawing.Point(323, 59);
            this.lblContactLastName.Name = "lblContactLastName";
            this.lblContactLastName.Size = new System.Drawing.Size(118, 26);
            this.lblContactLastName.TabIndex = 12;
            this.lblContactLastName.Text = "Last Name";
            // 
            // txtContactFirstName
            // 
            this.txtContactFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactFirstName.Location = new System.Drawing.Point(136, 60);
            this.txtContactFirstName.Name = "txtContactFirstName";
            this.txtContactFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtContactFirstName.TabIndex = 1;
            // 
            // lblContactFirstName
            // 
            this.lblContactFirstName.AutoSize = true;
            this.lblContactFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactFirstName.Location = new System.Drawing.Point(11, 60);
            this.lblContactFirstName.Name = "lblContactFirstName";
            this.lblContactFirstName.Size = new System.Drawing.Size(119, 26);
            this.lblContactFirstName.TabIndex = 10;
            this.lblContactFirstName.Text = "First Name";
            // 
            // tabToday
            // 
            this.tabToday.Controls.Add(this.lbToday);
            this.tabToday.Controls.Add(this.btnToday);
            this.tabToday.Location = new System.Drawing.Point(4, 22);
            this.tabToday.Name = "tabToday";
            this.tabToday.Padding = new System.Windows.Forms.Padding(3);
            this.tabToday.Size = new System.Drawing.Size(634, 284);
            this.tabToday.TabIndex = 2;
            this.tabToday.Text = "Today\'s Birthdays";
            this.tabToday.UseVisualStyleBackColor = true;
            // 
            // lbToday
            // 
            this.lbToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToday.FormattingEnabled = true;
            this.lbToday.ItemHeight = 20;
            this.lbToday.Location = new System.Drawing.Point(7, 79);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(621, 184);
            this.lbToday.TabIndex = 1;
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(7, 7);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(621, 65);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Show Today\'s Birthdays";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // tabChange
            // 
            this.tabChange.Controls.Add(this.txtEditCellNum);
            this.tabChange.Controls.Add(this.lblEditCellNum);
            this.tabChange.Controls.Add(this.txtEditEmail);
            this.tabChange.Controls.Add(this.lblEditEmail);
            this.tabChange.Controls.Add(this.dtpEditBirthday);
            this.tabChange.Controls.Add(this.lblEditBirthday);
            this.tabChange.Controls.Add(this.btnDelete);
            this.tabChange.Controls.Add(this.btnCancel);
            this.tabChange.Controls.Add(this.btnSave);
            this.tabChange.Controls.Add(this.btnEdit);
            this.tabChange.Controls.Add(this.txtEditLastName);
            this.tabChange.Controls.Add(this.lblEditLastName);
            this.tabChange.Controls.Add(this.txtEditFirstName);
            this.tabChange.Controls.Add(this.lblEditFirstName);
            this.tabChange.Location = new System.Drawing.Point(4, 22);
            this.tabChange.Name = "tabChange";
            this.tabChange.Padding = new System.Windows.Forms.Padding(3);
            this.tabChange.Size = new System.Drawing.Size(634, 284);
            this.tabChange.TabIndex = 3;
            this.tabChange.Text = "Edit/Delete";
            this.tabChange.UseVisualStyleBackColor = true;
            // 
            // txtEditCellNum
            // 
            this.txtEditCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditCellNum.Location = new System.Drawing.Point(220, 152);
            this.txtEditCellNum.Name = "txtEditCellNum";
            this.txtEditCellNum.Size = new System.Drawing.Size(404, 26);
            this.txtEditCellNum.TabIndex = 6;
            this.txtEditCellNum.Visible = false;
            // 
            // lblEditCellNum
            // 
            this.lblEditCellNum.AutoSize = true;
            this.lblEditCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCellNum.Location = new System.Drawing.Point(11, 151);
            this.lblEditCellNum.Name = "lblEditCellNum";
            this.lblEditCellNum.Size = new System.Drawing.Size(203, 26);
            this.lblEditCellNum.TabIndex = 26;
            this.lblEditCellNum.Text = "Cell Phone Number";
            this.lblEditCellNum.Visible = false;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditEmail.Location = new System.Drawing.Point(171, 102);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(453, 26);
            this.txtEditEmail.TabIndex = 5;
            this.txtEditEmail.Visible = false;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmail.Location = new System.Drawing.Point(11, 101);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(154, 26);
            this.lblEditEmail.TabIndex = 25;
            this.lblEditEmail.Text = "Email Address";
            this.lblEditEmail.Visible = false;
            // 
            // dtpEditBirthday
            // 
            this.dtpEditBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditBirthday.Location = new System.Drawing.Point(16, 222);
            this.dtpEditBirthday.Name = "dtpEditBirthday";
            this.dtpEditBirthday.Size = new System.Drawing.Size(261, 26);
            this.dtpEditBirthday.TabIndex = 7;
            this.dtpEditBirthday.Visible = false;
            // 
            // lblEditBirthday
            // 
            this.lblEditBirthday.AutoSize = true;
            this.lblEditBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBirthday.Location = new System.Drawing.Point(109, 193);
            this.lblEditBirthday.Name = "lblEditBirthday";
            this.lblEditBirthday.Size = new System.Drawing.Size(92, 26);
            this.lblEditBirthday.TabIndex = 23;
            this.lblEditBirthday.Text = "Birthday";
            this.lblEditBirthday.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(447, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(481, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(303, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 55);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(16, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(425, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLastName.Location = new System.Drawing.Point(443, 9);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(181, 26);
            this.txtEditLastName.TabIndex = 2;
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditLastName.Location = new System.Drawing.Point(323, 8);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(118, 26);
            this.lblEditLastName.TabIndex = 17;
            this.lblEditLastName.Text = "Last Name";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFirstName.Location = new System.Drawing.Point(136, 9);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(181, 26);
            this.txtEditFirstName.TabIndex = 1;
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFirstName.Location = new System.Drawing.Point(11, 9);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(119, 26);
            this.lblEditFirstName.TabIndex = 16;
            this.lblEditFirstName.Text = "First Name";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(666, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTextToolStripMenuItem,
            this.openFromTextToolStripMenuItem,
            this.saveToBinaryToolStripMenuItem,
            this.openFromBinaryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToTextToolStripMenuItem
            // 
            this.saveToTextToolStripMenuItem.Name = "saveToTextToolStripMenuItem";
            this.saveToTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToTextToolStripMenuItem.Text = "Save to Text";
            this.saveToTextToolStripMenuItem.Click += new System.EventHandler(this.saveToTextToolStripMenuItem_Click);
            // 
            // openFromTextToolStripMenuItem
            // 
            this.openFromTextToolStripMenuItem.Name = "openFromTextToolStripMenuItem";
            this.openFromTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFromTextToolStripMenuItem.Text = "Open from Text";
            this.openFromTextToolStripMenuItem.Click += new System.EventHandler(this.openFromTextToolStripMenuItem_Click);
            // 
            // saveToBinaryToolStripMenuItem
            // 
            this.saveToBinaryToolStripMenuItem.Name = "saveToBinaryToolStripMenuItem";
            this.saveToBinaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToBinaryToolStripMenuItem.Text = "Save to Binary";
            this.saveToBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveToBinaryToolStripMenuItem_Click);
            // 
            // openFromBinaryToolStripMenuItem
            // 
            this.openFromBinaryToolStripMenuItem.Name = "openFromBinaryToolStripMenuItem";
            this.openFromBinaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFromBinaryToolStripMenuItem.Text = "Open from Binary";
            this.openFromBinaryToolStripMenuItem.Click += new System.EventHandler(this.openFromBinaryToolStripMenuItem_Click);
            // 
            // FormPABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 340);
            this.Controls.Add(this.tabcMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPABook";
            this.Text = "Personal Address Book";
            this.tabcMain.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabBirthday.ResumeLayout(false);
            this.tabBirthday.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.tabContact.PerformLayout();
            this.tabToday.ResumeLayout(false);
            this.tabChange.ResumeLayout(false);
            this.tabChange.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabBirthday;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpAdd;
        private System.Windows.Forms.Label lblAddDate;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.TabPage tabToday;
        private System.Windows.Forms.TabPage tabChange;
        private System.Windows.Forms.TextBox txtAddNum;
        private System.Windows.Forms.Label lblAddNum;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblBdayInstructions;
        private System.Windows.Forms.TextBox txtBdayLastName;
        private System.Windows.Forms.Label lblBdayLastName;
        private System.Windows.Forms.TextBox txtBdayFirstName;
        private System.Windows.Forms.Label lblBdayFirstName;
        private System.Windows.Forms.TextBox txtBdayCellNum;
        private System.Windows.Forms.Label lblBdayCellNum;
        private System.Windows.Forms.TextBox txtBdayEmail;
        private System.Windows.Forms.Label lblBdayEmail;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.Button btnBdaySearch;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.TextBox txtContactCellNum;
        private System.Windows.Forms.Label lblContactCellNum;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.Button btnContactSearch;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContactLastName;
        private System.Windows.Forms.Label lblContactLastName;
        private System.Windows.Forms.TextBox txtContactFirstName;
        private System.Windows.Forms.Label lblContactFirstName;
        private System.Windows.Forms.ListBox lbToday;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.TextBox txtEditCellNum;
        private System.Windows.Forms.Label lblEditCellNum;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.DateTimePicker dtpEditBirthday;
        private System.Windows.Forms.Label lblEditBirthday;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromBinaryToolStripMenuItem;
    }
}

