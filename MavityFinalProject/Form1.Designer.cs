﻿namespace MavityFinalProject
{
    partial class MainForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCleanliness = new System.Windows.Forms.Label();
            this.lblQuietness = new System.Windows.Forms.Label();
            this.lblStudiousness = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblWake = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radM = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtClean = new System.Windows.Forms.TextBox();
            this.txtQuiet = new System.Windows.Forms.TextBox();
            this.txtStudy = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.grpWake = new System.Windows.Forms.GroupBox();
            this.radAfter9 = new System.Windows.Forms.RadioButton();
            this.rad8to9 = new System.Windows.Forms.RadioButton();
            this.rad7to8 = new System.Windows.Forms.RadioButton();
            this.rad6to7 = new System.Windows.Forms.RadioButton();
            this.radBefore6 = new System.Windows.Forms.RadioButton();
            this.grpBed = new System.Windows.Forms.GroupBox();
            this.radAfter1 = new System.Windows.Forms.RadioButton();
            this.rad12to1 = new System.Windows.Forms.RadioButton();
            this.rad11to12 = new System.Windows.Forms.RadioButton();
            this.rad10to11 = new System.Windows.Forms.RadioButton();
            this.radBefore10 = new System.Windows.Forms.RadioButton();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnChangeRecord = new System.Windows.Forms.Button();
            this.btnRemoveRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.strpStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbDescribe = new System.Windows.Forms.RichTextBox();
            this.lblDescibe = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.dgvPersonViewer = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanlinessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quietnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studiousnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wakeup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDataSet2 = new MavityFinalProject.PeopleDataSet2();
            this.peopleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDataSet = new MavityFinalProject.PeopleDataSet();
            this.btnDescription = new System.Windows.Forms.Button();
            this.informationTableAdapter1 = new MavityFinalProject.PeopleDataSet2TableAdapters.InformationTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDataSet1 = new MavityFinalProject.PeopleDataSet1();
            this.informationTableAdapter = new MavityFinalProject.PeopleDataSet1TableAdapters.InformationTableAdapter();
            this.informationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpGender.SuspendLayout();
            this.grpWake.SuspendLayout();
            this.grpBed.SuspendLayout();
            this.strpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(10, 37);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(105, 13);
            this.lblSSN.TabIndex = 3;
            this.lblSSN.Text = "Last 4 Digits of SSN:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 86);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblCleanliness
            // 
            this.lblCleanliness.AutoSize = true;
            this.lblCleanliness.Location = new System.Drawing.Point(10, 109);
            this.lblCleanliness.Name = "lblCleanliness";
            this.lblCleanliness.Size = new System.Drawing.Size(93, 13);
            this.lblCleanliness.TabIndex = 6;
            this.lblCleanliness.Text = "Cleanliness (1-10):";
            // 
            // lblQuietness
            // 
            this.lblQuietness.AutoSize = true;
            this.lblQuietness.Location = new System.Drawing.Point(10, 133);
            this.lblQuietness.Name = "lblQuietness";
            this.lblQuietness.Size = new System.Drawing.Size(90, 13);
            this.lblQuietness.TabIndex = 7;
            this.lblQuietness.Text = "Quietness  (1-10):";
            // 
            // lblStudiousness
            // 
            this.lblStudiousness.AutoSize = true;
            this.lblStudiousness.Location = new System.Drawing.Point(10, 157);
            this.lblStudiousness.Name = "lblStudiousness";
            this.lblStudiousness.Size = new System.Drawing.Size(103, 13);
            this.lblStudiousness.TabIndex = 8;
            this.lblStudiousness.Text = "Studiousness (1-10):";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(11, 238);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(36, 13);
            this.lblMajor.TabIndex = 11;
            this.lblMajor.Text = "Major:";
            // 
            // lblWake
            // 
            this.lblWake.AutoSize = true;
            this.lblWake.Location = new System.Drawing.Point(11, 265);
            this.lblWake.Name = "lblWake";
            this.lblWake.Size = new System.Drawing.Size(80, 13);
            this.lblWake.TabIndex = 12;
            this.lblWake.Text = "Wake-up Time:";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(9, 323);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(48, 13);
            this.lblBed.TabIndex = 13;
            this.lblBed.Text = "Bedtime:";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radM);
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radF);
            this.grpGender.Location = new System.Drawing.Point(60, 53);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(81, 26);
            this.grpGender.TabIndex = 2;
            this.grpGender.TabStop = false;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(41, 6);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(34, 17);
            this.radM.TabIndex = 1;
            this.radM.TabStop = true;
            this.radM.Text = "M";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(-28, 8);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(34, 17);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "M";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(6, 6);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(31, 17);
            this.radF.TabIndex = 0;
            this.radF.TabStop = true;
            this.radF.Text = "F";
            this.radF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Average Number of Guests/Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grade in coming school  year:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 59);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender:";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(121, 30);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(51, 20);
            this.txtSSN.TabIndex = 1;
            this.txtSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSSN_KeyPress);
            // 
            // txtClean
            // 
            this.txtClean.Location = new System.Drawing.Point(101, 100);
            this.txtClean.Name = "txtClean";
            this.txtClean.Size = new System.Drawing.Size(25, 20);
            this.txtClean.TabIndex = 4;
            this.txtClean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClean_KeyPress);
            // 
            // txtQuiet
            // 
            this.txtQuiet.Location = new System.Drawing.Point(101, 126);
            this.txtQuiet.Name = "txtQuiet";
            this.txtQuiet.Size = new System.Drawing.Size(25, 20);
            this.txtQuiet.TabIndex = 5;
            this.txtQuiet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuiet_KeyPress);
            // 
            // txtStudy
            // 
            this.txtStudy.Location = new System.Drawing.Point(119, 150);
            this.txtStudy.Name = "txtStudy";
            this.txtStudy.Size = new System.Drawing.Size(25, 20);
            this.txtStudy.TabIndex = 6;
            this.txtStudy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudy_KeyPress);
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(186, 176);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(25, 20);
            this.txtGuests.TabIndex = 7;
            this.txtGuests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuests_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(164, 202);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(97, 20);
            this.txtYear.TabIndex = 8;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(51, 229);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 20);
            this.txtMajor.TabIndex = 9;
            // 
            // grpWake
            // 
            this.grpWake.Controls.Add(this.radAfter9);
            this.grpWake.Controls.Add(this.rad8to9);
            this.grpWake.Controls.Add(this.rad7to8);
            this.grpWake.Controls.Add(this.rad6to7);
            this.grpWake.Controls.Add(this.radBefore6);
            this.grpWake.Location = new System.Drawing.Point(97, 255);
            this.grpWake.Name = "grpWake";
            this.grpWake.Size = new System.Drawing.Size(185, 55);
            this.grpWake.TabIndex = 10;
            this.grpWake.TabStop = false;
            // 
            // radAfter9
            // 
            this.radAfter9.AutoSize = true;
            this.radAfter9.Location = new System.Drawing.Point(51, 30);
            this.radAfter9.Name = "radAfter9";
            this.radAfter9.Size = new System.Drawing.Size(72, 17);
            this.radAfter9.TabIndex = 4;
            this.radAfter9.TabStop = true;
            this.radAfter9.Text = "After 9AM";
            this.radAfter9.UseVisualStyleBackColor = true;
            // 
            // rad8to9
            // 
            this.rad8to9.AutoSize = true;
            this.rad8to9.Location = new System.Drawing.Point(4, 30);
            this.rad8to9.Name = "rad8to9";
            this.rad8to9.Size = new System.Drawing.Size(40, 17);
            this.rad8to9.TabIndex = 3;
            this.rad8to9.TabStop = true;
            this.rad8to9.Text = "8-9";
            this.rad8to9.UseVisualStyleBackColor = true;
            // 
            // rad7to8
            // 
            this.rad7to8.AutoSize = true;
            this.rad7to8.Location = new System.Drawing.Point(136, 8);
            this.rad7to8.Name = "rad7to8";
            this.rad7to8.Size = new System.Drawing.Size(40, 17);
            this.rad7to8.TabIndex = 2;
            this.rad7to8.TabStop = true;
            this.rad7to8.Text = "7-8";
            this.rad7to8.UseVisualStyleBackColor = true;
            // 
            // rad6to7
            // 
            this.rad6to7.AutoSize = true;
            this.rad6to7.Location = new System.Drawing.Point(89, 6);
            this.rad6to7.Name = "rad6to7";
            this.rad6to7.Size = new System.Drawing.Size(40, 17);
            this.rad6to7.TabIndex = 1;
            this.rad6to7.TabStop = true;
            this.rad6to7.Text = "6-7";
            this.rad6to7.UseVisualStyleBackColor = true;
            // 
            // radBefore6
            // 
            this.radBefore6.AutoSize = true;
            this.radBefore6.Location = new System.Drawing.Point(4, 6);
            this.radBefore6.Name = "radBefore6";
            this.radBefore6.Size = new System.Drawing.Size(81, 17);
            this.radBefore6.TabIndex = 0;
            this.radBefore6.TabStop = true;
            this.radBefore6.Text = "Before 6AM";
            this.radBefore6.UseVisualStyleBackColor = true;
            // 
            // grpBed
            // 
            this.grpBed.Controls.Add(this.radAfter1);
            this.grpBed.Controls.Add(this.rad12to1);
            this.grpBed.Controls.Add(this.rad11to12);
            this.grpBed.Controls.Add(this.rad10to11);
            this.grpBed.Controls.Add(this.radBefore10);
            this.grpBed.Location = new System.Drawing.Point(60, 323);
            this.grpBed.Name = "grpBed";
            this.grpBed.Size = new System.Drawing.Size(213, 55);
            this.grpBed.TabIndex = 11;
            this.grpBed.TabStop = false;
            // 
            // radAfter1
            // 
            this.radAfter1.AutoSize = true;
            this.radAfter1.Location = new System.Drawing.Point(131, 32);
            this.radAfter1.Name = "radAfter1";
            this.radAfter1.Size = new System.Drawing.Size(72, 17);
            this.radAfter1.TabIndex = 0;
            this.radAfter1.TabStop = true;
            this.radAfter1.Text = "After 1AM";
            this.radAfter1.UseVisualStyleBackColor = true;
            // 
            // rad12to1
            // 
            this.rad12to1.AutoSize = true;
            this.rad12to1.Location = new System.Drawing.Point(63, 32);
            this.rad12to1.Name = "rad12to1";
            this.rad12to1.Size = new System.Drawing.Size(62, 17);
            this.rad12to1.TabIndex = 4;
            this.rad12to1.TabStop = true;
            this.rad12to1.Text = "12-1AM";
            this.rad12to1.UseVisualStyleBackColor = true;
            // 
            // rad11to12
            // 
            this.rad11to12.AutoSize = true;
            this.rad11to12.Location = new System.Drawing.Point(4, 32);
            this.rad11to12.Name = "rad11to12";
            this.rad11to12.Size = new System.Drawing.Size(52, 17);
            this.rad11to12.TabIndex = 3;
            this.rad11to12.TabStop = true;
            this.rad11to12.Text = "11-12";
            this.rad11to12.UseVisualStyleBackColor = true;
            // 
            // rad10to11
            // 
            this.rad10to11.AutoSize = true;
            this.rad10to11.Location = new System.Drawing.Point(97, 5);
            this.rad10to11.Name = "rad10to11";
            this.rad10to11.Size = new System.Drawing.Size(52, 17);
            this.rad10to11.TabIndex = 2;
            this.rad10to11.TabStop = true;
            this.rad10to11.Text = "10-11";
            this.rad10to11.UseVisualStyleBackColor = true;
            // 
            // radBefore10
            // 
            this.radBefore10.AutoSize = true;
            this.radBefore10.Location = new System.Drawing.Point(4, 5);
            this.radBefore10.Name = "radBefore10";
            this.radBefore10.Size = new System.Drawing.Size(87, 17);
            this.radBefore10.TabIndex = 1;
            this.radBefore10.TabStop = true;
            this.radBefore10.Text = "Before 10PM";
            this.radBefore10.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(15, 378);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(60, 60);
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnChangeRecord
            // 
            this.btnChangeRecord.Location = new System.Drawing.Point(81, 378);
            this.btnChangeRecord.Name = "btnChangeRecord";
            this.btnChangeRecord.Size = new System.Drawing.Size(60, 60);
            this.btnChangeRecord.TabIndex = 14;
            this.btnChangeRecord.Text = "Change Record";
            this.btnChangeRecord.UseVisualStyleBackColor = true;
            this.btnChangeRecord.Click += new System.EventHandler(this.btnChangeRecord_Click);
            // 
            // btnRemoveRecord
            // 
            this.btnRemoveRecord.Location = new System.Drawing.Point(213, 378);
            this.btnRemoveRecord.Name = "btnRemoveRecord";
            this.btnRemoveRecord.Size = new System.Drawing.Size(60, 60);
            this.btnRemoveRecord.TabIndex = 15;
            this.btnRemoveRecord.Text = "Remove Record";
            this.btnRemoveRecord.UseVisualStyleBackColor = true;
            this.btnRemoveRecord.Click += new System.EventHandler(this.btnRemoveRecord_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(438, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // strpStatus
            // 
            this.strpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.strpStatus.Location = new System.Drawing.Point(0, 445);
            this.strpStatus.Name = "strpStatus";
            this.strpStatus.Size = new System.Drawing.Size(1414, 22);
            this.strpStatus.TabIndex = 32;
            this.strpStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // rtbDescribe
            // 
            this.rtbDescribe.Location = new System.Drawing.Point(260, 37);
            this.rtbDescribe.Name = "rtbDescribe";
            this.rtbDescribe.Size = new System.Drawing.Size(238, 159);
            this.rtbDescribe.TabIndex = 12;
            this.rtbDescribe.Text = "";
            // 
            // lblDescibe
            // 
            this.lblDescibe.AutoSize = true;
            this.lblDescibe.Location = new System.Drawing.Point(257, 21);
            this.lblDescibe.Name = "lblDescibe";
            this.lblDescibe.Size = new System.Drawing.Size(90, 13);
            this.lblDescibe.TabIndex = 34;
            this.lblDescibe.Text = "Descibe Yourself:";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(306, 378);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(60, 60);
            this.btnAssign.TabIndex = 16;
            this.btnAssign.Text = "Choose For Me";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 79);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(87, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(372, 378);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 60);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // dgvPersonViewer
            // 
            this.dgvPersonViewer.AllowUserToAddRows = false;
            this.dgvPersonViewer.AllowUserToDeleteRows = false;
            this.dgvPersonViewer.AutoGenerateColumns = false;
            this.dgvPersonViewer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPersonViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.sSNDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.cleanlinessDataGridViewTextBoxColumn,
            this.quietnessDataGridViewTextBoxColumn,
            this.studiousnessDataGridViewTextBoxColumn,
            this.guestsDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.Wakeup,
            this.bedtimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvPersonViewer.DataSource = this.informationBindingSource2;
            this.dgvPersonViewer.Location = new System.Drawing.Point(508, 12);
            this.dgvPersonViewer.Name = "dgvPersonViewer";
            this.dgvPersonViewer.ReadOnly = true;
            this.dgvPersonViewer.Size = new System.Drawing.Size(796, 396);
            this.dgvPersonViewer.TabIndex = 35;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            this.sSNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSNDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 65;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // cleanlinessDataGridViewTextBoxColumn
            // 
            this.cleanlinessDataGridViewTextBoxColumn.DataPropertyName = "Cleanliness";
            this.cleanlinessDataGridViewTextBoxColumn.HeaderText = "Cleanliness";
            this.cleanlinessDataGridViewTextBoxColumn.Name = "cleanlinessDataGridViewTextBoxColumn";
            this.cleanlinessDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleanlinessDataGridViewTextBoxColumn.Width = 75;
            // 
            // quietnessDataGridViewTextBoxColumn
            // 
            this.quietnessDataGridViewTextBoxColumn.DataPropertyName = "Quietness";
            this.quietnessDataGridViewTextBoxColumn.HeaderText = "Quietness";
            this.quietnessDataGridViewTextBoxColumn.Name = "quietnessDataGridViewTextBoxColumn";
            this.quietnessDataGridViewTextBoxColumn.ReadOnly = true;
            this.quietnessDataGridViewTextBoxColumn.Width = 75;
            // 
            // studiousnessDataGridViewTextBoxColumn
            // 
            this.studiousnessDataGridViewTextBoxColumn.DataPropertyName = "Studiousness";
            this.studiousnessDataGridViewTextBoxColumn.HeaderText = "Studiousness";
            this.studiousnessDataGridViewTextBoxColumn.Name = "studiousnessDataGridViewTextBoxColumn";
            this.studiousnessDataGridViewTextBoxColumn.ReadOnly = true;
            this.studiousnessDataGridViewTextBoxColumn.Width = 80;
            // 
            // guestsDataGridViewTextBoxColumn
            // 
            this.guestsDataGridViewTextBoxColumn.DataPropertyName = "Guests";
            this.guestsDataGridViewTextBoxColumn.HeaderText = "Guests";
            this.guestsDataGridViewTextBoxColumn.Name = "guestsDataGridViewTextBoxColumn";
            this.guestsDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestsDataGridViewTextBoxColumn.Width = 60;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Width = 60;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Wakeup
            // 
            this.Wakeup.DataPropertyName = "Wakeup";
            this.Wakeup.HeaderText = "Wakeup";
            this.Wakeup.Name = "Wakeup";
            this.Wakeup.ReadOnly = true;
            this.Wakeup.Width = 65;
            // 
            // bedtimeDataGridViewTextBoxColumn
            // 
            this.bedtimeDataGridViewTextBoxColumn.DataPropertyName = "Bedtime";
            this.bedtimeDataGridViewTextBoxColumn.HeaderText = "Bedtime";
            this.bedtimeDataGridViewTextBoxColumn.Name = "bedtimeDataGridViewTextBoxColumn";
            this.bedtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bedtimeDataGridViewTextBoxColumn.Width = 65;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // informationBindingSource2
            // 
            this.informationBindingSource2.DataMember = "Information";
            this.informationBindingSource2.DataSource = this.peopleDataSet2;
            // 
            // peopleDataSet2
            // 
            this.peopleDataSet2.DataSetName = "PeopleDataSet2";
            this.peopleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleDataSetBindingSource
            // 
            this.peopleDataSetBindingSource.DataSource = this.peopleDataSet;
            this.peopleDataSetBindingSource.Position = 0;
            // 
            // peopleDataSet
            // 
            this.peopleDataSet.DataSetName = "PeopleDataSet";
            this.peopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDescription
            // 
            this.btnDescription.Location = new System.Drawing.Point(1310, 157);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(75, 60);
            this.btnDescription.TabIndex = 36;
            this.btnDescription.Text = "Get Description";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // informationTableAdapter1
            // 
            this.informationTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.peopleDataSet1;
            // 
            // peopleDataSet1
            // 
            this.peopleDataSet1.DataSetName = "PeopleDataSet1";
            this.peopleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // informationBindingSource1
            // 
            this.informationBindingSource1.DataMember = "Information";
            this.informationBindingSource1.DataSource = this.peopleDataSet1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 467);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.dgvPersonViewer);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblDescibe);
            this.Controls.Add(this.rtbDescribe);
            this.Controls.Add(this.strpStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveRecord);
            this.Controls.Add(this.btnChangeRecord);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.grpBed);
            this.Controls.Add(this.grpWake);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.txtStudy);
            this.Controls.Add(this.txtQuiet);
            this.Controls.Add(this.txtClean);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblWake);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblStudiousness);
            this.Controls.Add(this.lblQuietness);
            this.Controls.Add(this.lblCleanliness);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "Roommate Selection";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpWake.ResumeLayout(false);
            this.grpWake.PerformLayout();
            this.grpBed.ResumeLayout(false);
            this.grpBed.PerformLayout();
            this.strpStatus.ResumeLayout(false);
            this.strpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCleanliness;
        private System.Windows.Forms.Label lblQuietness;
        private System.Windows.Forms.Label lblStudiousness;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblWake;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtClean;
        private System.Windows.Forms.TextBox txtQuiet;
        private System.Windows.Forms.TextBox txtStudy;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.GroupBox grpWake;
        private System.Windows.Forms.RadioButton radAfter9;
        private System.Windows.Forms.RadioButton rad8to9;
        private System.Windows.Forms.RadioButton rad7to8;
        private System.Windows.Forms.RadioButton rad6to7;
        private System.Windows.Forms.RadioButton radBefore6;
        private System.Windows.Forms.GroupBox grpBed;
        private System.Windows.Forms.RadioButton radAfter1;
        private System.Windows.Forms.RadioButton rad12to1;
        private System.Windows.Forms.RadioButton rad11to12;
        private System.Windows.Forms.RadioButton rad10to11;
        private System.Windows.Forms.RadioButton radBefore10;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnChangeRecord;
        private System.Windows.Forms.Button btnRemoveRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip strpStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.RichTextBox rtbDescribe;
        private System.Windows.Forms.Label lblDescibe;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView dgvPersonViewer;
        private System.Windows.Forms.BindingSource peopleDataSetBindingSource;
        private PeopleDataSet peopleDataSet;
        private PeopleDataSet1 peopleDataSet1;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private PeopleDataSet1TableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.BindingSource informationBindingSource1;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn wakeupDataGridViewTextBoxColumn;
        private PeopleDataSet2 peopleDataSet2;
        private System.Windows.Forms.BindingSource informationBindingSource2;
        private PeopleDataSet2TableAdapters.InformationTableAdapter informationTableAdapter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanlinessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quietnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studiousnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wakeup;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}

