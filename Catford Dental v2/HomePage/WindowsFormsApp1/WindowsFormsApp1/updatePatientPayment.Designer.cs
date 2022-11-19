
namespace WindowsFormsApp1
{
    partial class updatePatientPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updatePatientPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.phoneNumTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientLNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patientFNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupWst5DataSet = new WindowsFormsApp1.GroupWst5DataSet();
            this.groupWst5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst5DataSet1 = new WindowsFormsApp1.GroupWst5DataSet1();
            this.groupWst5DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payrecepitNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new WindowsFormsApp1.GroupWst5DataSetTableAdapters.PaymentsTableAdapter();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.patientIDTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 107);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(140, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Update Patient Payment";
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
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Coral;
            this.cancelBtn.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.cancelBtn.Location = new System.Drawing.Point(713, 390);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(184, 41);
            this.cancelBtn.TabIndex = 34;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Coral;
            this.searchBtn.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.searchBtn.Location = new System.Drawing.Point(179, 390);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(223, 41);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.Text = "SEARCH PATIENT";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // phoneNumTB
            // 
            this.phoneNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumTB.Location = new System.Drawing.Point(448, 334);
            this.phoneNumTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumTB.Name = "phoneNumTB";
            this.phoneNumTB.Size = new System.Drawing.Size(327, 30);
            this.phoneNumTB.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phone Number Of Patient";
            // 
            // patientLNameTB
            // 
            this.patientLNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLNameTB.Location = new System.Drawing.Point(448, 263);
            this.patientLNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientLNameTB.Name = "patientLNameTB";
            this.patientLNameTB.Size = new System.Drawing.Size(327, 30);
            this.patientLNameTB.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Last Name Of Patient";
            // 
            // patientFNameTB
            // 
            this.patientFNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFNameTB.Location = new System.Drawing.Point(448, 198);
            this.patientFNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientFNameTB.Name = "patientFNameTB";
            this.patientFNameTB.Size = new System.Drawing.Size(327, 30);
            this.patientFNameTB.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name Of Patient";
            // 
            // groupWst5DataSet
            // 
            this.groupWst5DataSet.DataSetName = "GroupWst5DataSet";
            this.groupWst5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupWst5DataSetBindingSource
            // 
            this.groupWst5DataSetBindingSource.DataSource = this.groupWst5DataSet;
            this.groupWst5DataSetBindingSource.Position = 0;
            // 
            // groupWst5DataSet1
            // 
            this.groupWst5DataSet1.DataSetName = "GroupWst5DataSet1";
            this.groupWst5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupWst5DataSet1BindingSource
            // 
            this.groupWst5DataSet1BindingSource.DataSource = this.groupWst5DataSet1;
            this.groupWst5DataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payrecepitNoDataGridViewTextBoxColumn,
            this.patIDDataGridViewTextBoxColumn,
            this.payamountDataGridViewTextBoxColumn,
            this.paydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(145, 485);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 196);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // payrecepitNoDataGridViewTextBoxColumn
            // 
            this.payrecepitNoDataGridViewTextBoxColumn.DataPropertyName = "pay_recepitNo";
            this.payrecepitNoDataGridViewTextBoxColumn.HeaderText = "pay_recepitNo";
            this.payrecepitNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payrecepitNoDataGridViewTextBoxColumn.Name = "payrecepitNoDataGridViewTextBoxColumn";
            this.payrecepitNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // patIDDataGridViewTextBoxColumn
            // 
            this.patIDDataGridViewTextBoxColumn.DataPropertyName = "pat_ID";
            this.patIDDataGridViewTextBoxColumn.HeaderText = "pat_ID";
            this.patIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patIDDataGridViewTextBoxColumn.Name = "patIDDataGridViewTextBoxColumn";
            this.patIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // payamountDataGridViewTextBoxColumn
            // 
            this.payamountDataGridViewTextBoxColumn.DataPropertyName = "pay_amount";
            this.payamountDataGridViewTextBoxColumn.HeaderText = "pay_amount";
            this.payamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payamountDataGridViewTextBoxColumn.Name = "payamountDataGridViewTextBoxColumn";
            this.payamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // paydateDataGridViewTextBoxColumn
            // 
            this.paydateDataGridViewTextBoxColumn.DataPropertyName = "pay_date";
            this.paydateDataGridViewTextBoxColumn.HeaderText = "pay_date";
            this.paydateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paydateDataGridViewTextBoxColumn.Name = "paydateDataGridViewTextBoxColumn";
            this.paydateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentsBindingSource1
            // 
            this.paymentsBindingSource1.DataMember = "Payments";
            this.paymentsBindingSource1.DataSource = this.groupWst5DataSetBindingSource;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.groupWst5DataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Coral;
            this.backBtn.Font = new System.Drawing.Font("Sitka Text", 10.8F);
            this.backBtn.Location = new System.Drawing.Point(13, 1001);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(184, 41);
            this.backBtn.TabIndex = 39;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Payment Amount";
            // 
            // amountTb
            // 
            this.amountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTb.Location = new System.Drawing.Point(301, 101);
            this.amountTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(319, 30);
            this.amountTb.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Update Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientIDTb
            // 
            this.patientIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTb.Location = new System.Drawing.Point(304, 32);
            this.patientIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientIDTb.Name = "patientIDTb";
            this.patientIDTb.ReadOnly = true;
            this.patientIDTb.Size = new System.Drawing.Size(327, 30);
            this.patientIDTb.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Patient ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.patientIDTb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.amountTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(179, 722);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(699, 230);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // IDtxt
            // 
            this.IDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtxt.Location = new System.Drawing.Point(448, 141);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(327, 30);
            this.IDtxt.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "ID Number";
            // 
            // updatePatientPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1028, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.phoneNumTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientLNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patientFNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updatePatientPayment";
            this.Text = "updatePatientPayment";
            this.Load += new System.EventHandler(this.updatePatientPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox phoneNumTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientLNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientFNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource groupWst5DataSetBindingSource;
        private GroupWst5DataSet groupWst5DataSet;
        private GroupWst5DataSet1 groupWst5DataSet1;
        private System.Windows.Forms.BindingSource groupWst5DataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private GroupWst5DataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox patientIDTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrecepitNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentsBindingSource1;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label2;
    }
}