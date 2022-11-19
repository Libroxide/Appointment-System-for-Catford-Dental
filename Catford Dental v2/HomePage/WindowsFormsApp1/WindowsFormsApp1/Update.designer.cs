namespace WindowsFormsApp1
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.DependentsComboBox = new System.Windows.Forms.ComboBox();
            this.PolicyTextbox = new System.Windows.Forms.TextBox();
            this.CompanyTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.PhoneTextbox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnPatID = new System.Windows.Forms.Button();
            this.tbPatID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.addressL2TB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.zipTB = new System.Windows.Forms.TextBox();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst5DataSet = new WindowsFormsApp1.GroupWst5DataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new WindowsFormsApp1.GroupWst5DataSetTableAdapters.PatientTableAdapter();
            this.groupWst5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patfNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patlNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patphoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressline1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressline2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patemailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medAidcompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medAidpolicyNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medAiddependantNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 103);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(140, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Update Patient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(124, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 49);
            this.label7.TabIndex = 0;
            this.label7.Text = "Catford Dental";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Coral;
            this.BackButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(10, 1019);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 36);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DependentsComboBox
            // 
            this.DependentsComboBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DependentsComboBox.FormattingEnabled = true;
            this.DependentsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.DependentsComboBox.Location = new System.Drawing.Point(286, 759);
            this.DependentsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DependentsComboBox.Name = "DependentsComboBox";
            this.DependentsComboBox.Size = new System.Drawing.Size(160, 37);
            this.DependentsComboBox.TabIndex = 38;
            // 
            // PolicyTextbox
            // 
            this.PolicyTextbox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolicyTextbox.Location = new System.Drawing.Point(286, 689);
            this.PolicyTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PolicyTextbox.Name = "PolicyTextbox";
            this.PolicyTextbox.Size = new System.Drawing.Size(331, 33);
            this.PolicyTextbox.TabIndex = 37;
            // 
            // CompanyTextbox
            // 
            this.CompanyTextbox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTextbox.Location = new System.Drawing.Point(286, 615);
            this.CompanyTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyTextbox.Name = "CompanyTextbox";
            this.CompanyTextbox.Size = new System.Drawing.Size(331, 33);
            this.CompanyTextbox.TabIndex = 36;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(639, 438);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(328, 33);
            this.EmailTextbox.TabIndex = 35;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextbox.Location = new System.Drawing.Point(639, 367);
            this.LastNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(328, 33);
            this.LastNameTextbox.TabIndex = 34;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextbox.Location = new System.Drawing.Point(191, 508);
            this.AddressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(388, 33);
            this.AddressTextbox.TabIndex = 33;
            // 
            // PhoneTextbox
            // 
            this.PhoneTextbox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextbox.Location = new System.Drawing.Point(165, 434);
            this.PhoneTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextbox.Name = "PhoneTextbox";
            this.PhoneTextbox.Size = new System.Drawing.Size(243, 33);
            this.PhoneTextbox.TabIndex = 32;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(165, 367);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(300, 33);
            this.NameTextBox.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 767);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "Number of dependents: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 692);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 29);
            this.label10.TabIndex = 29;
            this.label10.Text = "Medical Aid Policy Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 619);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Medical Aid Company: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-mail Address: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phone Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name: ";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Coral;
            this.UpdateButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(201, 821);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(247, 38);
            this.UpdateButton.TabIndex = 39;
            this.UpdateButton.Text = "Update Patient Details";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Coral;
            this.CancelButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(696, 821);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 38);
            this.CancelButton.TabIndex = 40;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.Location = new System.Drawing.Point(277, 233);
            this.PhoneText.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(416, 33);
            this.PhoneText.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Patient Phone Number: ";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Coral;
            this.CancelBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(556, 297);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(185, 42);
            this.CancelBtn.TabIndex = 46;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Coral;
            this.SearchButton.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(257, 297);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(185, 42);
            this.SearchButton.TabIndex = 45;
            this.SearchButton.Text = "Search Patient";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SurnameText
            // 
            this.SurnameText.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameText.Location = new System.Drawing.Point(277, 172);
            this.SurnameText.Margin = new System.Windows.Forms.Padding(4);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(416, 33);
            this.SurnameText.TabIndex = 44;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(277, 118);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(416, 33);
            this.NameText.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Patient Surname:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(16, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 29);
            this.label12.TabIndex = 41;
            this.label12.Text = "Patient Name: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 508);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 29);
            this.label13.TabIndex = 49;
            this.label13.Text = "Address Line 1: ";
            // 
            // BtnPatID
            // 
            this.BtnPatID.BackColor = System.Drawing.Color.Coral;
            this.BtnPatID.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatID.Location = new System.Drawing.Point(826, 258);
            this.BtnPatID.Name = "BtnPatID";
            this.BtnPatID.Size = new System.Drawing.Size(141, 73);
            this.BtnPatID.TabIndex = 50;
            this.BtnPatID.Text = "Search By Pat ID";
            this.BtnPatID.UseVisualStyleBackColor = false;
            this.BtnPatID.Click += new System.EventHandler(this.BtnPatID_Click);
            // 
            // tbPatID
            // 
            this.tbPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatID.Location = new System.Drawing.Point(737, 214);
            this.tbPatID.Name = "tbPatID";
            this.tbPatID.Size = new System.Drawing.Size(287, 30);
            this.tbPatID.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 568);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 29);
            this.label14.TabIndex = 53;
            this.label14.Text = "Address Line 2: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(605, 508);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 29);
            this.label15.TabIndex = 54;
            this.label15.Text = "City:";
            // 
            // addressL2TB
            // 
            this.addressL2TB.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressL2TB.Location = new System.Drawing.Point(191, 568);
            this.addressL2TB.Margin = new System.Windows.Forms.Padding(4);
            this.addressL2TB.Name = "addressL2TB";
            this.addressL2TB.Size = new System.Drawing.Size(317, 33);
            this.addressL2TB.TabIndex = 55;
            // 
            // cityTB
            // 
            this.cityTB.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTB.Location = new System.Drawing.Point(671, 508);
            this.cityTB.Margin = new System.Windows.Forms.Padding(4);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(296, 33);
            this.cityTB.TabIndex = 56;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(605, 565);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 29);
            this.label16.TabIndex = 57;
            this.label16.Text = "ZipCode:";
            // 
            // zipTB
            // 
            this.zipTB.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTB.Location = new System.Drawing.Point(696, 562);
            this.zipTB.Margin = new System.Windows.Forms.Padding(4);
            this.zipTB.Name = "zipTB";
            this.zipTB.Size = new System.Drawing.Size(144, 33);
            this.zipTB.TabIndex = 58;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.groupWst5DataSet;
            // 
            // groupWst5DataSet
            // 
            this.groupWst5DataSet.DataSetName = "GroupWst5DataSet";
            this.groupWst5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.groupWst5DataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // groupWst5DataSetBindingSource
            // 
            this.groupWst5DataSetBindingSource.DataSource = this.groupWst5DataSet;
            this.groupWst5DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patIDDataGridViewTextBoxColumn,
            this.patfNameDataGridViewTextBoxColumn,
            this.patlNameDataGridViewTextBoxColumn,
            this.patphoneNoDataGridViewTextBoxColumn,
            this.addressline1DataGridViewTextBoxColumn,
            this.addressline2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn,
            this.patemailAddressDataGridViewTextBoxColumn,
            this.medAidcompanyDataGridViewTextBoxColumn,
            this.medAidpolicyNoDataGridViewTextBoxColumn,
            this.medAiddependantNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 862);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 150);
            this.dataGridView1.TabIndex = 59;
            // 
            // patIDDataGridViewTextBoxColumn
            // 
            this.patIDDataGridViewTextBoxColumn.DataPropertyName = "pat_ID";
            this.patIDDataGridViewTextBoxColumn.HeaderText = "pat_ID";
            this.patIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patIDDataGridViewTextBoxColumn.Name = "patIDDataGridViewTextBoxColumn";
            this.patIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // patfNameDataGridViewTextBoxColumn
            // 
            this.patfNameDataGridViewTextBoxColumn.DataPropertyName = "pat_fName";
            this.patfNameDataGridViewTextBoxColumn.HeaderText = "pat_fName";
            this.patfNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patfNameDataGridViewTextBoxColumn.Name = "patfNameDataGridViewTextBoxColumn";
            this.patfNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patlNameDataGridViewTextBoxColumn
            // 
            this.patlNameDataGridViewTextBoxColumn.DataPropertyName = "pat_lName";
            this.patlNameDataGridViewTextBoxColumn.HeaderText = "pat_lName";
            this.patlNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patlNameDataGridViewTextBoxColumn.Name = "patlNameDataGridViewTextBoxColumn";
            this.patlNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patphoneNoDataGridViewTextBoxColumn
            // 
            this.patphoneNoDataGridViewTextBoxColumn.DataPropertyName = "pat_phoneNo";
            this.patphoneNoDataGridViewTextBoxColumn.HeaderText = "pat_phoneNo";
            this.patphoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patphoneNoDataGridViewTextBoxColumn.Name = "patphoneNoDataGridViewTextBoxColumn";
            this.patphoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressline1DataGridViewTextBoxColumn
            // 
            this.addressline1DataGridViewTextBoxColumn.DataPropertyName = "address_line1";
            this.addressline1DataGridViewTextBoxColumn.HeaderText = "address_line1";
            this.addressline1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressline1DataGridViewTextBoxColumn.Name = "addressline1DataGridViewTextBoxColumn";
            this.addressline1DataGridViewTextBoxColumn.Width = 125;
            // 
            // addressline2DataGridViewTextBoxColumn
            // 
            this.addressline2DataGridViewTextBoxColumn.DataPropertyName = "address_line2";
            this.addressline2DataGridViewTextBoxColumn.HeaderText = "address_line2";
            this.addressline2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressline2DataGridViewTextBoxColumn.Name = "addressline2DataGridViewTextBoxColumn";
            this.addressline2DataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zipcode";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zipcode";
            this.zipcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            this.zipcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // patemailAddressDataGridViewTextBoxColumn
            // 
            this.patemailAddressDataGridViewTextBoxColumn.DataPropertyName = "pat_emailAddress";
            this.patemailAddressDataGridViewTextBoxColumn.HeaderText = "pat_emailAddress";
            this.patemailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patemailAddressDataGridViewTextBoxColumn.Name = "patemailAddressDataGridViewTextBoxColumn";
            this.patemailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // medAidcompanyDataGridViewTextBoxColumn
            // 
            this.medAidcompanyDataGridViewTextBoxColumn.DataPropertyName = "medAid_company";
            this.medAidcompanyDataGridViewTextBoxColumn.HeaderText = "medAid_company";
            this.medAidcompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medAidcompanyDataGridViewTextBoxColumn.Name = "medAidcompanyDataGridViewTextBoxColumn";
            this.medAidcompanyDataGridViewTextBoxColumn.Width = 125;
            // 
            // medAidpolicyNoDataGridViewTextBoxColumn
            // 
            this.medAidpolicyNoDataGridViewTextBoxColumn.DataPropertyName = "medAid_policyNo";
            this.medAidpolicyNoDataGridViewTextBoxColumn.HeaderText = "medAid_policyNo";
            this.medAidpolicyNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medAidpolicyNoDataGridViewTextBoxColumn.Name = "medAidpolicyNoDataGridViewTextBoxColumn";
            this.medAidpolicyNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // medAiddependantNoDataGridViewTextBoxColumn
            // 
            this.medAiddependantNoDataGridViewTextBoxColumn.DataPropertyName = "medAid_dependantNo";
            this.medAiddependantNoDataGridViewTextBoxColumn.HeaderText = "medAid_dependantNo";
            this.medAiddependantNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medAiddependantNoDataGridViewTextBoxColumn.Name = "medAiddependantNoDataGridViewTextBoxColumn";
            this.medAiddependantNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1052, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zipTB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.addressL2TB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbPatID);
            this.Controls.Add(this.BtnPatID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DependentsComboBox);
            this.Controls.Add(this.PolicyTextbox);
            this.Controls.Add(this.CompanyTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.PhoneTextbox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox DependentsComboBox;
        private System.Windows.Forms.TextBox PolicyTextbox;
        private System.Windows.Forms.TextBox CompanyTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.TextBox PhoneTextbox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnPatID;
        private System.Windows.Forms.TextBox tbPatID;
        private GroupWst5DataSet groupWst5DataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private GroupWst5DataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox addressL2TB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox zipTB;
        private System.Windows.Forms.BindingSource groupWst5DataSetBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patfNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patlNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patphoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressline1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressline2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patemailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medAidcompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medAidpolicyNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medAiddependantNoDataGridViewTextBoxColumn;
    }
}