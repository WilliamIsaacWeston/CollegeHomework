namespace Employee
{
    partial class FormEmployee
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
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxMI = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelEIN = new System.Windows.Forms.Label();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.textBoxEIN = new System.Windows.Forms.TextBox();
            this.groupBoxPhone = new System.Windows.Forms.GroupBox();
            this.textBoxCell = new System.Windows.Forms.TextBox();
            this.textBoxWork = new System.Windows.Forms.TextBox();
            this.labelCell = new System.Windows.Forms.Label();
            this.textBoxHomePhone = new System.Windows.Forms.TextBox();
            this.labelWork = new System.Windows.Forms.Label();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.groupBoxCoInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.textBoxSuperEIN = new System.Windows.Forms.TextBox();
            this.labelSupervisor = new System.Windows.Forms.Label();
            this.textBoxOfficeLocation = new System.Windows.Forms.TextBox();
            this.labelOfficeLocation = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dateTimePickerHired = new System.Windows.Forms.DateTimePicker();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelDateHired = new System.Windows.Forms.Label();
            this.groupBoxPersonal = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBoxTaxInfo = new System.Windows.Forms.GroupBox();
            this.numericUpDownExemptions = new System.Windows.Forms.NumericUpDown();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.labelExtra = new System.Windows.Forms.Label();
            this.labelNumExemptions = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.dateTimePickerRaise = new System.Windows.Forms.DateTimePicker();
            this.labelDateLastRaise = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelPayType = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonSalary = new System.Windows.Forms.RadioButton();
            this.radioButtonWage = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBoxName.SuspendLayout();
            this.groupBoxPhone.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.groupBoxCoInfo.SuspendLayout();
            this.groupBoxPersonal.SuspendLayout();
            this.groupBoxTaxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExemptions)).BeginInit();
            this.groupBoxPaymentInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxLastName);
            this.groupBoxName.Controls.Add(this.textBoxFirstName);
            this.groupBoxName.Controls.Add(this.labelLastName);
            this.groupBoxName.Controls.Add(this.textBoxMI);
            this.groupBoxName.Controls.Add(this.labelFirstName);
            this.groupBoxName.Location = new System.Drawing.Point(14, 15);
            this.groupBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxName.Size = new System.Drawing.Size(255, 105);
            this.groupBoxName.TabIndex = 1;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(95, 64);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.MaxLength = 24;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(153, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(95, 28);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.MaxLength = 24;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 26);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(8, 68);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(40, 20);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last";
            // 
            // textBoxMI
            // 
            this.textBoxMI.Location = new System.Drawing.Point(224, 28);
            this.textBoxMI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMI.MaxLength = 2;
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(24, 26);
            this.textBoxMI.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 31);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(70, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First / MI";
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Location = new System.Drawing.Point(8, 102);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(42, 20);
            this.labelSSN.TabIndex = 0;
            this.labelSSN.Text = "SSN";
            // 
            // labelEIN
            // 
            this.labelEIN.AutoSize = true;
            this.labelEIN.Location = new System.Drawing.Point(8, 31);
            this.labelEIN.Name = "labelEIN";
            this.labelEIN.Size = new System.Drawing.Size(36, 20);
            this.labelEIN.TabIndex = 1;
            this.labelEIN.Text = "EIN";
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(95, 99);
            this.textBoxSSN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSSN.MaxLength = 11;
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(153, 26);
            this.textBoxSSN.TabIndex = 11;
            // 
            // textBoxEIN
            // 
            this.textBoxEIN.Location = new System.Drawing.Point(129, 25);
            this.textBoxEIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEIN.MaxLength = 6;
            this.textBoxEIN.Name = "textBoxEIN";
            this.textBoxEIN.ReadOnly = true;
            this.textBoxEIN.Size = new System.Drawing.Size(162, 26);
            this.textBoxEIN.TabIndex = 0;
            this.textBoxEIN.TabStop = false;
            // 
            // groupBoxPhone
            // 
            this.groupBoxPhone.Controls.Add(this.textBoxCell);
            this.groupBoxPhone.Controls.Add(this.textBoxWork);
            this.groupBoxPhone.Controls.Add(this.labelCell);
            this.groupBoxPhone.Controls.Add(this.textBoxHomePhone);
            this.groupBoxPhone.Controls.Add(this.labelWork);
            this.groupBoxPhone.Controls.Add(this.labelHomePhone);
            this.groupBoxPhone.Location = new System.Drawing.Point(14, 422);
            this.groupBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPhone.Name = "groupBoxPhone";
            this.groupBoxPhone.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPhone.Size = new System.Drawing.Size(255, 140);
            this.groupBoxPhone.TabIndex = 4;
            this.groupBoxPhone.TabStop = false;
            this.groupBoxPhone.Text = "Phone";
            // 
            // textBoxCell
            // 
            this.textBoxCell.Location = new System.Drawing.Point(95, 100);
            this.textBoxCell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCell.MaxLength = 14;
            this.textBoxCell.Name = "textBoxCell";
            this.textBoxCell.Size = new System.Drawing.Size(153, 26);
            this.textBoxCell.TabIndex = 13;
            // 
            // textBoxWork
            // 
            this.textBoxWork.Location = new System.Drawing.Point(95, 64);
            this.textBoxWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxWork.MaxLength = 14;
            this.textBoxWork.Name = "textBoxWork";
            this.textBoxWork.Size = new System.Drawing.Size(153, 26);
            this.textBoxWork.TabIndex = 12;
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Location = new System.Drawing.Point(7, 104);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(35, 20);
            this.labelCell.TabIndex = 3;
            this.labelCell.Text = "Cell";
            // 
            // textBoxHomePhone
            // 
            this.textBoxHomePhone.Location = new System.Drawing.Point(95, 28);
            this.textBoxHomePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHomePhone.MaxLength = 14;
            this.textBoxHomePhone.Name = "textBoxHomePhone";
            this.textBoxHomePhone.Size = new System.Drawing.Size(153, 26);
            this.textBoxHomePhone.TabIndex = 11;
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.Location = new System.Drawing.Point(7, 68);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(46, 20);
            this.labelWork.TabIndex = 1;
            this.labelWork.Text = "Work";
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(7, 31);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(52, 20);
            this.labelHomePhone.TabIndex = 0;
            this.labelHomePhone.Text = "Home";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.comboBoxState);
            this.groupBoxAddress.Controls.Add(this.textBoxZip);
            this.groupBoxAddress.Controls.Add(this.textBoxCity);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.labelState);
            this.groupBoxAddress.Controls.Add(this.labelCity);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Location = new System.Drawing.Point(14, 128);
            this.groupBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAddress.Size = new System.Drawing.Size(255, 139);
            this.groupBoxAddress.TabIndex = 2;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(95, 101);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxState.MaxLength = 2;
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(51, 28);
            this.comboBoxState.TabIndex = 6;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(152, 101);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxZip.MaxLength = 10;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(96, 26);
            this.textBoxZip.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(95, 64);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCity.MaxLength = 22;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(153, 26);
            this.textBoxCity.TabIndex = 5;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(95, 28);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStreet.MaxLength = 30;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(153, 26);
            this.textBoxStreet.TabIndex = 4;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(7, 104);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(82, 20);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State / Zip";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(8, 68);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 20);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(7, 34);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(53, 20);
            this.labelStreet.TabIndex = 0;
            this.labelStreet.Text = "Street";
            // 
            // groupBoxCoInfo
            // 
            this.groupBoxCoInfo.Controls.Add(this.comboBoxDept);
            this.groupBoxCoInfo.Controls.Add(this.textBoxSuperEIN);
            this.groupBoxCoInfo.Controls.Add(this.labelSupervisor);
            this.groupBoxCoInfo.Controls.Add(this.textBoxOfficeLocation);
            this.groupBoxCoInfo.Controls.Add(this.textBoxEIN);
            this.groupBoxCoInfo.Controls.Add(this.labelEIN);
            this.groupBoxCoInfo.Controls.Add(this.labelOfficeLocation);
            this.groupBoxCoInfo.Controls.Add(this.textBoxTitle);
            this.groupBoxCoInfo.Controls.Add(this.labelTitle);
            this.groupBoxCoInfo.Controls.Add(this.dateTimePickerHired);
            this.groupBoxCoInfo.Controls.Add(this.labelDepartment);
            this.groupBoxCoInfo.Controls.Add(this.labelDateHired);
            this.groupBoxCoInfo.Location = new System.Drawing.Point(276, 15);
            this.groupBoxCoInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCoInfo.Name = "groupBoxCoInfo";
            this.groupBoxCoInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCoInfo.Size = new System.Drawing.Size(297, 252);
            this.groupBoxCoInfo.TabIndex = 5;
            this.groupBoxCoInfo.TabStop = false;
            this.groupBoxCoInfo.Text = "Company Info";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(129, 101);
            this.comboBoxDept.MaxLength = 4;
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(162, 28);
            this.comboBoxDept.TabIndex = 16;
            // 
            // textBoxSuperEIN
            // 
            this.textBoxSuperEIN.Location = new System.Drawing.Point(129, 209);
            this.textBoxSuperEIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSuperEIN.MaxLength = 6;
            this.textBoxSuperEIN.Name = "textBoxSuperEIN";
            this.textBoxSuperEIN.Size = new System.Drawing.Size(162, 26);
            this.textBoxSuperEIN.TabIndex = 19;
            // 
            // labelSupervisor
            // 
            this.labelSupervisor.AutoSize = true;
            this.labelSupervisor.Location = new System.Drawing.Point(8, 212);
            this.labelSupervisor.Name = "labelSupervisor";
            this.labelSupervisor.Size = new System.Drawing.Size(115, 20);
            this.labelSupervisor.TabIndex = 8;
            this.labelSupervisor.Text = "Supervisor EIN";
            // 
            // textBoxOfficeLocation
            // 
            this.textBoxOfficeLocation.Location = new System.Drawing.Point(129, 136);
            this.textBoxOfficeLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOfficeLocation.MaxLength = 14;
            this.textBoxOfficeLocation.Name = "textBoxOfficeLocation";
            this.textBoxOfficeLocation.Size = new System.Drawing.Size(162, 26);
            this.textBoxOfficeLocation.TabIndex = 17;
            // 
            // labelOfficeLocation
            // 
            this.labelOfficeLocation.AutoSize = true;
            this.labelOfficeLocation.Location = new System.Drawing.Point(7, 140);
            this.labelOfficeLocation.Name = "labelOfficeLocation";
            this.labelOfficeLocation.Size = new System.Drawing.Size(116, 20);
            this.labelOfficeLocation.TabIndex = 0;
            this.labelOfficeLocation.Text = "Office Location";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(129, 64);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.MaxLength = 30;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(162, 26);
            this.textBoxTitle.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(8, 68);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            // 
            // dateTimePickerHired
            // 
            this.dateTimePickerHired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHired.Location = new System.Drawing.Point(129, 172);
            this.dateTimePickerHired.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerHired.Name = "dateTimePickerHired";
            this.dateTimePickerHired.Size = new System.Drawing.Size(162, 26);
            this.dateTimePickerHired.TabIndex = 18;
            this.dateTimePickerHired.Value = new System.DateTime(2015, 2, 25, 0, 0, 0, 0);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(8, 104);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(94, 20);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Department";
            // 
            // labelDateHired
            // 
            this.labelDateHired.AutoSize = true;
            this.labelDateHired.Location = new System.Drawing.Point(8, 179);
            this.labelDateHired.Name = "labelDateHired";
            this.labelDateHired.Size = new System.Drawing.Size(86, 20);
            this.labelDateHired.TabIndex = 2;
            this.labelDateHired.Text = "Date Hired";
            // 
            // groupBoxPersonal
            // 
            this.groupBoxPersonal.Controls.Add(this.panel1);
            this.groupBoxPersonal.Controls.Add(this.dateTimePickerBirth);
            this.groupBoxPersonal.Controls.Add(this.textBoxSSN);
            this.groupBoxPersonal.Controls.Add(this.labelDOB);
            this.groupBoxPersonal.Controls.Add(this.labelSSN);
            this.groupBoxPersonal.Controls.Add(this.labelGender);
            this.groupBoxPersonal.Location = new System.Drawing.Point(14, 275);
            this.groupBoxPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPersonal.Name = "groupBoxPersonal";
            this.groupBoxPersonal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPersonal.Size = new System.Drawing.Size(255, 140);
            this.groupBoxPersonal.TabIndex = 3;
            this.groupBoxPersonal.TabStop = false;
            this.groupBoxPersonal.Text = "Personal Info";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(95, 62);
            this.dateTimePickerBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBirth.MinDate = new System.DateTime(1900, 12, 28, 0, 0, 0, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(153, 26);
            this.dateTimePickerBirth.TabIndex = 10;
            this.dateTimePickerBirth.Value = new System.DateTime(2015, 2, 25, 0, 0, 0, 0);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(8, 65);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(67, 20);
            this.labelDOB.TabIndex = 0;
            this.labelDOB.Text = "Birthday";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(8, 29);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 20);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender";
            // 
            // groupBoxTaxInfo
            // 
            this.groupBoxTaxInfo.Controls.Add(this.panel3);
            this.groupBoxTaxInfo.Controls.Add(this.numericUpDownExemptions);
            this.groupBoxTaxInfo.Controls.Add(this.textBoxExtra);
            this.groupBoxTaxInfo.Controls.Add(this.labelExtra);
            this.groupBoxTaxInfo.Controls.Add(this.labelNumExemptions);
            this.groupBoxTaxInfo.Controls.Add(this.labelStatus);
            this.groupBoxTaxInfo.Location = new System.Drawing.Point(276, 422);
            this.groupBoxTaxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTaxInfo.Name = "groupBoxTaxInfo";
            this.groupBoxTaxInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxTaxInfo.Size = new System.Drawing.Size(297, 140);
            this.groupBoxTaxInfo.TabIndex = 7;
            this.groupBoxTaxInfo.TabStop = false;
            this.groupBoxTaxInfo.Text = "Tax Info";
            // 
            // numericUpDownExemptions
            // 
            this.numericUpDownExemptions.Location = new System.Drawing.Point(129, 29);
            this.numericUpDownExemptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownExemptions.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownExemptions.Name = "numericUpDownExemptions";
            this.numericUpDownExemptions.Size = new System.Drawing.Size(58, 26);
            this.numericUpDownExemptions.TabIndex = 1;
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Location = new System.Drawing.Point(129, 101);
            this.textBoxExtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExtra.MaxLength = 8;
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxExtra.Size = new System.Drawing.Size(162, 26);
            this.textBoxExtra.TabIndex = 25;
            this.textBoxExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelExtra
            // 
            this.labelExtra.AutoSize = true;
            this.labelExtra.Location = new System.Drawing.Point(7, 105);
            this.labelExtra.Name = "labelExtra";
            this.labelExtra.Size = new System.Drawing.Size(69, 20);
            this.labelExtra.TabIndex = 2;
            this.labelExtra.Text = "Extra ($)";
            // 
            // labelNumExemptions
            // 
            this.labelNumExemptions.AutoSize = true;
            this.labelNumExemptions.Location = new System.Drawing.Point(7, 31);
            this.labelNumExemptions.Name = "labelNumExemptions";
            this.labelNumExemptions.Size = new System.Drawing.Size(92, 20);
            this.labelNumExemptions.TabIndex = 1;
            this.labelNumExemptions.Text = "Exemptions";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 68);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status";
            // 
            // groupBoxPaymentInfo
            // 
            this.groupBoxPaymentInfo.Controls.Add(this.panel2);
            this.groupBoxPaymentInfo.Controls.Add(this.textBoxSalary);
            this.groupBoxPaymentInfo.Controls.Add(this.dateTimePickerRaise);
            this.groupBoxPaymentInfo.Controls.Add(this.labelDateLastRaise);
            this.groupBoxPaymentInfo.Controls.Add(this.labelSalary);
            this.groupBoxPaymentInfo.Controls.Add(this.labelPayType);
            this.groupBoxPaymentInfo.Location = new System.Drawing.Point(276, 275);
            this.groupBoxPaymentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPaymentInfo.Name = "groupBoxPaymentInfo";
            this.groupBoxPaymentInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPaymentInfo.Size = new System.Drawing.Size(297, 140);
            this.groupBoxPaymentInfo.TabIndex = 6;
            this.groupBoxPaymentInfo.TabStop = false;
            this.groupBoxPaymentInfo.Text = "Payment Info";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(129, 59);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSalary.MaxLength = 12;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSalary.Size = new System.Drawing.Size(162, 26);
            this.textBoxSalary.TabIndex = 21;
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePickerRaise
            // 
            this.dateTimePickerRaise.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRaise.Location = new System.Drawing.Point(129, 94);
            this.dateTimePickerRaise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerRaise.Name = "dateTimePickerRaise";
            this.dateTimePickerRaise.Size = new System.Drawing.Size(162, 26);
            this.dateTimePickerRaise.TabIndex = 22;
            this.dateTimePickerRaise.Value = new System.DateTime(2015, 2, 25, 0, 0, 0, 0);
            // 
            // labelDateLastRaise
            // 
            this.labelDateLastRaise.AutoSize = true;
            this.labelDateLastRaise.Location = new System.Drawing.Point(7, 100);
            this.labelDateLastRaise.Name = "labelDateLastRaise";
            this.labelDateLastRaise.Size = new System.Drawing.Size(85, 20);
            this.labelDateLastRaise.TabIndex = 2;
            this.labelDateLastRaise.Text = "Last Raise";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(7, 66);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(88, 20);
            this.labelSalary.TabIndex = 1;
            this.labelSalary.Text = "Amount ($)";
            // 
            // labelPayType
            // 
            this.labelPayType.AutoSize = true;
            this.labelPayType.Location = new System.Drawing.Point(8, 29);
            this.labelPayType.Name = "labelPayType";
            this.labelPayType.Size = new System.Drawing.Size(43, 20);
            this.labelPayType.TabIndex = 0;
            this.labelPayType.Text = "Type";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(399, 570);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 29);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(489, 570);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 29);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 570);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonFemale);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Location = new System.Drawing.Point(95, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 33);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(0, 5);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(61, 24);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(67, 5);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(80, 24);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonWage);
            this.panel2.Controls.Add(this.radioButtonSalary);
            this.panel2.Location = new System.Drawing.Point(124, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 41);
            this.panel2.TabIndex = 1;
            // 
            // radioButtonSalary
            // 
            this.radioButtonSalary.AutoSize = true;
            this.radioButtonSalary.Location = new System.Drawing.Point(7, 11);
            this.radioButtonSalary.Name = "radioButtonSalary";
            this.radioButtonSalary.Size = new System.Drawing.Size(71, 24);
            this.radioButtonSalary.TabIndex = 2;
            this.radioButtonSalary.TabStop = true;
            this.radioButtonSalary.Text = "Salary";
            this.radioButtonSalary.UseVisualStyleBackColor = true;
            // 
            // radioButtonWage
            // 
            this.radioButtonWage.AutoSize = true;
            this.radioButtonWage.Location = new System.Drawing.Point(93, 11);
            this.radioButtonWage.Name = "radioButtonWage";
            this.radioButtonWage.Size = new System.Drawing.Size(69, 24);
            this.radioButtonWage.TabIndex = 3;
            this.radioButtonWage.TabStop = true;
            this.radioButtonWage.Text = "Wage";
            this.radioButtonWage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonSingle);
            this.panel3.Controls.Add(this.radioButtonMarried);
            this.panel3.Location = new System.Drawing.Point(129, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 31);
            this.panel3.TabIndex = 2;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(2, 3);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(80, 24);
            this.radioButtonMarried.TabIndex = 3;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.Text = "Married";
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(88, 3);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(71, 24);
            this.radioButtonSingle.TabIndex = 4;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(585, 612);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxPaymentInfo);
            this.Controls.Add(this.groupBoxTaxInfo);
            this.Controls.Add(this.groupBoxPersonal);
            this.Controls.Add(this.groupBoxCoInfo);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxPhone);
            this.Controls.Add(this.groupBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Corp Employee Maintenance Form";
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxPhone.ResumeLayout(false);
            this.groupBoxPhone.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.groupBoxCoInfo.ResumeLayout(false);
            this.groupBoxCoInfo.PerformLayout();
            this.groupBoxPersonal.ResumeLayout(false);
            this.groupBoxPersonal.PerformLayout();
            this.groupBoxTaxInfo.ResumeLayout(false);
            this.groupBoxTaxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExemptions)).EndInit();
            this.groupBoxPaymentInfo.ResumeLayout(false);
            this.groupBoxPaymentInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxMI;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxEIN;
        private System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.Label labelEIN;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.GroupBox groupBoxPhone;
        private System.Windows.Forms.TextBox textBoxCell;
        private System.Windows.Forms.TextBox textBoxWork;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.TextBox textBoxHomePhone;
        private System.Windows.Forms.Label labelWork;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.GroupBox groupBoxCoInfo;
        private System.Windows.Forms.TextBox textBoxOfficeLocation;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelDateHired;
        private System.Windows.Forms.DateTimePicker dateTimePickerHired;
        private System.Windows.Forms.Label labelOfficeLocation;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxSuperEIN;
        private System.Windows.Forms.Label labelSupervisor;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBoxTaxInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownExemptions;
        private System.Windows.Forms.TextBox textBoxExtra;
        private System.Windows.Forms.Label labelExtra;
        private System.Windows.Forms.Label labelNumExemptions;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxPaymentInfo;
        private System.Windows.Forms.Label labelDateLastRaise;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelPayType;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.DateTimePicker dateTimePickerRaise;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.RadioButton radioButtonMarried;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonWage;
        private System.Windows.Forms.RadioButton radioButtonSalary;
    }
}

