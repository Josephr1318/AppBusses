namespace BusControlApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.dataGridViewBuses = new System.Windows.Forms.DataGridView();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.dataGridViewRoutes = new System.Windows.Forms.DataGridView();
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.cmbBuses = new System.Windows.Forms.ComboBox();
            this.cmbRoutes = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dataGridViewAssignments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(224, 12);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(430, 12);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(536, 10);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(75, 23);
            this.btnAddDriver.TabIndex = 4;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrivers.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.Size = new System.Drawing.Size(599, 150);
            this.dataGridViewDrivers.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(12, 194);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(118, 194);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 7;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(224, 194);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 20);
            this.txtLicensePlate.TabIndex = 8;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(330, 194);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 9;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(436, 194);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 10;
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(542, 192);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(75, 23);
            this.btnAddBus.TabIndex = 11;
            this.btnAddBus.Text = "Add Bus";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // dataGridViewBuses
            // 
            this.dataGridViewBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuses.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewBuses.Name = "dataGridViewBuses";
            this.dataGridViewBuses.Size = new System.Drawing.Size(599, 150);
            this.dataGridViewBuses.TabIndex = 12;
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(12, 376);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(100, 20);
            this.txtRouteName.TabIndex = 13;
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(118, 374);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoute.TabIndex = 14;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // dataGridViewRoutes
            // 
            this.dataGridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoutes.Location = new System.Drawing.Point(12, 402);
            this.dataGridViewRoutes.Name = "dataGridViewRoutes";
            this.dataGridViewRoutes.Size = new System.Drawing.Size(599, 150);
            this.dataGridViewRoutes.TabIndex = 15;
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(12, 558);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(121, 21);
            this.cmbDrivers.TabIndex = 16;
            // 
            // cmbBuses
            // 
            this.cmbBuses.FormattingEnabled = true;
            this.cmbBuses.Location = new System.Drawing.Point(139, 558);
            this.cmbBuses.Name = "cmbBuses";
            this.cmbBuses.Size = new System.Drawing.Size(121, 21);
            this.cmbBuses.TabIndex = 17;
            // 
            // cmbRoutes
            // 
            this.cmbRoutes.FormattingEnabled = true;
            this.cmbRoutes.Location = new System.Drawing.Point(266, 558);
            this.cmbRoutes.Name = "cmbRoutes";
            this.cmbRoutes.Size = new System.Drawing.Size(121, 21);
            this.cmbRoutes.TabIndex = 18;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(393, 556);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 19;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dataGridViewAssignments
            // 
            this.dataGridViewAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignments.Location = new System.Drawing.Point(12, 585);
            this.dataGridViewAssignments.Name = "dataGridViewAssignments";
            this.dataGridViewAssignments.Size = new System.Drawing.Size(599, 150);
            this.dataGridViewAssignments.TabIndex = 20;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(623, 747);
            this.Controls.Add(this.dataGridViewAssignments);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbRoutes);
            this.Controls.Add(this.cmbBuses);
            this.Controls.Add(this.cmbDrivers);
            this.Controls.Add(this.dataGridViewRoutes);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.txtRouteName);
            this.Controls.Add(this.dataGridViewBuses);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.dataGridViewDrivers);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.DataGridView dataGridViewDrivers;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.DataGridView dataGridViewBuses;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.DataGridView dataGridViewRoutes;
        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.ComboBox cmbBuses;
        private System.Windows.Forms.ComboBox cmbRoutes;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dataGridViewAssignments;
    }
}



