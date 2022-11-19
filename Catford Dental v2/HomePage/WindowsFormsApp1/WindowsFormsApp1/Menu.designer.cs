
namespace WindowsFormsApp1
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.paymentsPanelSubMenu = new System.Windows.Forms.Panel();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.updatePayment = new System.Windows.Forms.Button();
            this.paymentsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.appointmentsPanelSubMenu = new System.Windows.Forms.Panel();
            this.delAppButton = new System.Windows.Forms.Button();
            this.editAppButton = new System.Windows.Forms.Button();
            this.addAppButton = new System.Windows.Forms.Button();
            this.appButton = new System.Windows.Forms.Button();
            this.patientPanelSubMenu = new System.Windows.Forms.Panel();
            this.delPatButton = new System.Windows.Forms.Button();
            this.editPatButton = new System.Windows.Forms.Button();
            this.addPatButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupWst5DataSet1 = new WindowsFormsApp1.GroupWst5DataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.paymentsPanelSubMenu.SuspendLayout();
            this.appointmentsPanelSubMenu.SuspendLayout();
            this.patientPanelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelSideMenu.Controls.Add(this.paymentsPanelSubMenu);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.logoutButton);
            this.panelSideMenu.Controls.Add(this.exitButton);
            this.panelSideMenu.Controls.Add(this.appointmentsPanelSubMenu);
            this.panelSideMenu.Controls.Add(this.appButton);
            this.panelSideMenu.Controls.Add(this.patientPanelSubMenu);
            this.panelSideMenu.Controls.Add(this.patientButton);
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(251, 819);
            this.panelSideMenu.TabIndex = 9;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // paymentsPanelSubMenu
            // 
            this.paymentsPanelSubMenu.BackColor = System.Drawing.Color.MistyRose;
            this.paymentsPanelSubMenu.Controls.Add(this.ReportBtn);
            this.paymentsPanelSubMenu.Controls.Add(this.updatePayment);
            this.paymentsPanelSubMenu.Controls.Add(this.paymentsButton);
            this.paymentsPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentsPanelSubMenu.Location = new System.Drawing.Point(0, 630);
            this.paymentsPanelSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentsPanelSubMenu.Name = "paymentsPanelSubMenu";
            this.paymentsPanelSubMenu.Size = new System.Drawing.Size(230, 146);
            this.paymentsPanelSubMenu.TabIndex = 18;
            this.paymentsPanelSubMenu.Visible = false;
            // 
            // ReportBtn
            // 
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.ReportBtn.Location = new System.Drawing.Point(0, 78);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.ReportBtn.Size = new System.Drawing.Size(230, 39);
            this.ReportBtn.TabIndex = 6;
            this.ReportBtn.Text = "Payments Report";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // updatePayment
            // 
            this.updatePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.updatePayment.FlatAppearance.BorderSize = 0;
            this.updatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePayment.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.updatePayment.Location = new System.Drawing.Point(0, 39);
            this.updatePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatePayment.Name = "updatePayment";
            this.updatePayment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.updatePayment.Size = new System.Drawing.Size(230, 39);
            this.updatePayment.TabIndex = 5;
            this.updatePayment.Text = "Update Payments";
            this.updatePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatePayment.UseVisualStyleBackColor = true;
            this.updatePayment.Click += new System.EventHandler(this.updatePayment_Click);
            // 
            // paymentsButton
            // 
            this.paymentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentsButton.FlatAppearance.BorderSize = 0;
            this.paymentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentsButton.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.paymentsButton.Location = new System.Drawing.Point(0, 0);
            this.paymentsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentsButton.Name = "paymentsButton";
            this.paymentsButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.paymentsButton.Size = new System.Drawing.Size(230, 39);
            this.paymentsButton.TabIndex = 4;
            this.paymentsButton.Text = "Payments";
            this.paymentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentsButton.UseVisualStyleBackColor = true;
            this.paymentsButton.Click += new System.EventHandler(this.paymentsButton_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 578);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(230, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = " Payments";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Coral;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(0, 776);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(230, 45);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Coral;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(0, 821);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(230, 43);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // appointmentsPanelSubMenu
            // 
            this.appointmentsPanelSubMenu.BackColor = System.Drawing.Color.MistyRose;
            this.appointmentsPanelSubMenu.Controls.Add(this.delAppButton);
            this.appointmentsPanelSubMenu.Controls.Add(this.editAppButton);
            this.appointmentsPanelSubMenu.Controls.Add(this.addAppButton);
            this.appointmentsPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.appointmentsPanelSubMenu.Location = new System.Drawing.Point(0, 440);
            this.appointmentsPanelSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsPanelSubMenu.Name = "appointmentsPanelSubMenu";
            this.appointmentsPanelSubMenu.Size = new System.Drawing.Size(230, 138);
            this.appointmentsPanelSubMenu.TabIndex = 12;
            // 
            // delAppButton
            // 
            this.delAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.delAppButton.FlatAppearance.BorderSize = 0;
            this.delAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delAppButton.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.delAppButton.Location = new System.Drawing.Point(0, 78);
            this.delAppButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delAppButton.Name = "delAppButton";
            this.delAppButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.delAppButton.Size = new System.Drawing.Size(230, 37);
            this.delAppButton.TabIndex = 2;
            this.delAppButton.Text = "Delete Appointment";
            this.delAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delAppButton.UseVisualStyleBackColor = true;
            this.delAppButton.Click += new System.EventHandler(this.delAppButton_Click);
            // 
            // editAppButton
            // 
            this.editAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editAppButton.FlatAppearance.BorderSize = 0;
            this.editAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAppButton.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.editAppButton.Location = new System.Drawing.Point(0, 39);
            this.editAppButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editAppButton.Name = "editAppButton";
            this.editAppButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.editAppButton.Size = new System.Drawing.Size(230, 39);
            this.editAppButton.TabIndex = 1;
            this.editAppButton.Text = "Edit Appointment";
            this.editAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editAppButton.UseVisualStyleBackColor = true;
            this.editAppButton.Click += new System.EventHandler(this.editAppButton_Click);
            // 
            // addAppButton
            // 
            this.addAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addAppButton.FlatAppearance.BorderSize = 0;
            this.addAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppButton.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.addAppButton.Location = new System.Drawing.Point(0, 0);
            this.addAppButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addAppButton.Size = new System.Drawing.Size(230, 39);
            this.addAppButton.TabIndex = 0;
            this.addAppButton.Text = "Add Appointment";
            this.addAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addAppButton_Click);
            // 
            // appButton
            // 
            this.appButton.BackColor = System.Drawing.Color.Coral;
            this.appButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.appButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appButton.Location = new System.Drawing.Point(0, 388);
            this.appButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appButton.Name = "appButton";
            this.appButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.appButton.Size = new System.Drawing.Size(230, 52);
            this.appButton.TabIndex = 11;
            this.appButton.Text = "Appointments";
            this.appButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appButton.UseVisualStyleBackColor = false;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // patientPanelSubMenu
            // 
            this.patientPanelSubMenu.BackColor = System.Drawing.Color.MistyRose;
            this.patientPanelSubMenu.Controls.Add(this.delPatButton);
            this.patientPanelSubMenu.Controls.Add(this.editPatButton);
            this.patientPanelSubMenu.Controls.Add(this.addPatButton);
            this.patientPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientPanelSubMenu.Location = new System.Drawing.Point(0, 239);
            this.patientPanelSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientPanelSubMenu.Name = "patientPanelSubMenu";
            this.patientPanelSubMenu.Size = new System.Drawing.Size(230, 149);
            this.patientPanelSubMenu.TabIndex = 10;
            this.patientPanelSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.patientPanelSubMenu_Paint);
            // 
            // delPatButton
            // 
            this.delPatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.delPatButton.FlatAppearance.BorderSize = 0;
            this.delPatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delPatButton.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.delPatButton.Location = new System.Drawing.Point(0, 78);
            this.delPatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delPatButton.Name = "delPatButton";
            this.delPatButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.delPatButton.Size = new System.Drawing.Size(230, 39);
            this.delPatButton.TabIndex = 2;
            this.delPatButton.Text = "Delete Patient";
            this.delPatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delPatButton.UseVisualStyleBackColor = true;
            this.delPatButton.Click += new System.EventHandler(this.delPatButton_Click);
            // 
            // editPatButton
            // 
            this.editPatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPatButton.FlatAppearance.BorderSize = 0;
            this.editPatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPatButton.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.editPatButton.Location = new System.Drawing.Point(0, 39);
            this.editPatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPatButton.Name = "editPatButton";
            this.editPatButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.editPatButton.Size = new System.Drawing.Size(230, 39);
            this.editPatButton.TabIndex = 1;
            this.editPatButton.Text = "Edit Patient";
            this.editPatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editPatButton.UseVisualStyleBackColor = true;
            this.editPatButton.Click += new System.EventHandler(this.editPatButton_Click);
            // 
            // addPatButton
            // 
            this.addPatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPatButton.FlatAppearance.BorderSize = 0;
            this.addPatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatButton.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.addPatButton.Location = new System.Drawing.Point(0, 0);
            this.addPatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatButton.Name = "addPatButton";
            this.addPatButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addPatButton.Size = new System.Drawing.Size(230, 39);
            this.addPatButton.TabIndex = 0;
            this.addPatButton.Text = "Add Patient";
            this.addPatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPatButton.UseVisualStyleBackColor = true;
            this.addPatButton.Click += new System.EventHandler(this.addPatButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.BackColor = System.Drawing.Color.Coral;
            this.patientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.Location = new System.Drawing.Point(0, 187);
            this.patientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientButton.Name = "patientButton";
            this.patientButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.patientButton.Size = new System.Drawing.Size(230, 52);
            this.patientButton.TabIndex = 9;
            this.patientButton.Text = "Patient";
            this.patientButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._4c7605be4392e71182c7008da6063e52;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupWst5DataSet1
            // 
            this.groupWst5DataSet1.DataSetName = "GroupWst5DataSet";
            this.groupWst5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(594, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(387, 33);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 247);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 273);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 819);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(999, 698);
            this.Name = "MenuForm";
            this.Text = "Log Out";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.paymentsPanelSubMenu.ResumeLayout(false);
            this.appointmentsPanelSubMenu.ResumeLayout(false);
            this.patientPanelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel appointmentsPanelSubMenu;
        private System.Windows.Forms.Button delAppButton;
        private System.Windows.Forms.Button editAppButton;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Panel patientPanelSubMenu;
        private System.Windows.Forms.Button delPatButton;
        private System.Windows.Forms.Button editPatButton;
        private System.Windows.Forms.Button addPatButton;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private GroupWst5DataSet groupWst5DataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel paymentsPanelSubMenu;
        private System.Windows.Forms.Button paymentsButton;
        private System.Windows.Forms.Button updatePayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ReportBtn;
    }
}

