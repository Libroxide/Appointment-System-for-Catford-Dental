
namespace WindowsFormsApp1
{
    partial class DeletePatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patfNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patlNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patphoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patemailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medAidcompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medAidpolicyNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medAiddependantNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst5DataSet = new WindowsFormsApp1.GroupWst5DataSet();
            this.patientTableAdapter = new WindowsFormsApp1.GroupWst5DataSetTableAdapters.PatientTableAdapter();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delete Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catford Dental";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.LoginPicture2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name Of Patient";
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.PatientNameTextBox.Location = new System.Drawing.Point(283, 167);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Size = new System.Drawing.Size(286, 33);
            this.PatientNameTextBox.TabIndex = 3;
            this.PatientNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientNameTextBox_KeyDown);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Coral;
            this.DeleteButton.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(637, 340);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(190, 38);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Coral;
            this.BackButton.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.BackButton.Location = new System.Drawing.Point(32, 555);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(137, 47);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.patemailAddressDataGridViewTextBoxColumn,
            this.medAidcompanyDataGridViewTextBoxColumn,
            this.medAidpolicyNoDataGridViewTextBoxColumn,
            this.medAiddependantNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.groupWst5DataSetBindingSource;
            // 
            // groupWst5DataSetBindingSource
            // 
            this.groupWst5DataSetBindingSource.DataSource = this.groupWst5DataSet;
            this.groupWst5DataSetBindingSource.Position = 0;
            // 
            // groupWst5DataSet
            // 
            this.groupWst5DataSet.DataSetName = "GroupWst5DataSet";
            this.groupWst5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Coral;
            this.SearchButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(67, 340);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(182, 38);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(283, 220);
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(286, 33);
            this.PatientLastNameTextBox.TabIndex = 11;
            this.PatientLastNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientLastNameTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name Of Patient";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(283, 282);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(286, 33);
            this.PhoneNumberTextBox.TabIndex = 13;
            this.PhoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhoneNumberTextBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone Number Of Patient";
            // 
            // IDtxt
            // 
            this.IDtxt.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.IDtxt.Location = new System.Drawing.Point(283, 115);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(286, 33);
            this.IDtxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID Number";
            // 
            // DeletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1116, 728);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatientLastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "DeletePatient";
            this.Text = "Delete Patient";
            this.Load += new System.EventHandler(this.DeletePatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource groupWst5DataSetBindingSource;
        private GroupWst5DataSet groupWst5DataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private GroupWst5DataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patfNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patlNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patphoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_line1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_line2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patemailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medAidcompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medAidpolicyNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medAiddependantNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox PatientLastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label6;
    }
}