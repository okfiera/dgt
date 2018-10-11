namespace Presentation.Windows.UI.SecondaryForms
{
    partial class FrmAddNewInfraction
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label infractionTypeIdLabel;
            System.Windows.Forms.Label pointsLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVehicleFullName = new System.Windows.Forms.Label();
            this.lblDriverIdentifier = new System.Windows.Forms.Label();
            this.infractionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDriverFullName = new System.Windows.Forms.Label();
            this.panePoints = new System.Windows.Forms.Panel();
            this.pointsLabel1 = new System.Windows.Forms.Label();
            this.infractionTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.infractionTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleDriverDTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDriverDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLicenseFilter = new System.Windows.Forms.TextBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            infractionTypeIdLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionDTOBindingSource)).BeginInit();
            this.panePoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionTypeDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDriverDTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDriverDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(23, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 19);
            label1.TabIndex = 4;
            label1.Text = "Matrícula del vehículo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(23, 169);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(468, 19);
            label2.TabIndex = 6;
            label2.Text = "Seleccionar conductor asociado al vehículo al que se le aplicará la infracción:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            dateLabel.Location = new System.Drawing.Point(23, 40);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(140, 19);
            dateLabel.TabIndex = 10;
            dateLabel.Text = "Fecha de la infración: ";
            // 
            // infractionTypeIdLabel
            // 
            infractionTypeIdLabel.AutoSize = true;
            infractionTypeIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            infractionTypeIdLabel.Location = new System.Drawing.Point(23, 130);
            infractionTypeIdLabel.Name = "infractionTypeIdLabel";
            infractionTypeIdLabel.Size = new System.Drawing.Size(135, 19);
            infractionTypeIdLabel.TabIndex = 8;
            infractionTypeIdLabel.Text = "Infracción cometida :";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            pointsLabel.Location = new System.Drawing.Point(3, 1);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(63, 19);
            pointsLabel.TabIndex = 11;
            pointsLabel.Text = "Puntos : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(378, 67);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(201, 19);
            label4.TabIndex = 15;
            label4.Text = "ENTER = buscar, ESC = limpiar";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            label5.Location = new System.Drawing.Point(214, 383);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 19);
            label5.TabIndex = 17;
            label5.Text = "Nombre :";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(23, 354);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(282, 19);
            label6.TabIndex = 18;
            label6.Text = "Conductor que ha cometido la infracción";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(23, 383);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 19);
            label8.TabIndex = 20;
            label8.Text = "NIF / NIE :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lblVehicleFullName);
            this.groupBox1.Controls.Add(this.lblDriverIdentifier);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(this.lblDriverFullName);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.panePoints);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(infractionTypeIdLabel);
            this.groupBox1.Controls.Add(this.infractionTypeIdComboBox);
            this.groupBox1.Controls.Add(this.vehicleDriverDTODataGridView);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.txtLicenseFilter);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblVehicleFullName
            // 
            this.lblVehicleFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblVehicleFullName.Location = new System.Drawing.Point(182, 96);
            this.lblVehicleFullName.Name = "lblVehicleFullName";
            this.lblVehicleFullName.Size = new System.Drawing.Size(407, 25);
            this.lblVehicleFullName.TabIndex = 22;
            this.lblVehicleFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDriverIdentifier
            // 
            this.lblDriverIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDriverIdentifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDriverIdentifier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionDTOBindingSource, "DriverIdentifier", true));
            this.lblDriverIdentifier.Location = new System.Drawing.Point(95, 380);
            this.lblDriverIdentifier.Name = "lblDriverIdentifier";
            this.lblDriverIdentifier.Size = new System.Drawing.Size(94, 25);
            this.lblDriverIdentifier.TabIndex = 21;
            this.lblDriverIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infractionDTOBindingSource
            // 
            this.infractionDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Infractions.InfractionDTO);
            // 
            // lblDriverFullName
            // 
            this.lblDriverFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDriverFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDriverFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionDTOBindingSource, "DriverFullName", true));
            this.lblDriverFullName.Location = new System.Drawing.Point(286, 380);
            this.lblDriverFullName.Name = "lblDriverFullName";
            this.lblDriverFullName.Size = new System.Drawing.Size(342, 25);
            this.lblDriverFullName.TabIndex = 19;
            this.lblDriverFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panePoints
            // 
            this.panePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panePoints.Controls.Add(pointsLabel);
            this.panePoints.Controls.Add(this.pointsLabel1);
            this.panePoints.Location = new System.Drawing.Point(483, 127);
            this.panePoints.Name = "panePoints";
            this.panePoints.Size = new System.Drawing.Size(101, 25);
            this.panePoints.TabIndex = 14;
            // 
            // pointsLabel1
            // 
            this.pointsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionTypeDTOBindingSource, "Points", true));
            this.pointsLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pointsLabel1.Location = new System.Drawing.Point(63, 1);
            this.pointsLabel1.Name = "pointsLabel1";
            this.pointsLabel1.Size = new System.Drawing.Size(35, 23);
            this.pointsLabel1.TabIndex = 12;
            this.pointsLabel1.Text = "0";
            // 
            // infractionTypeDTOBindingSource
            // 
            this.infractionTypeDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.InfractionTypes.InfractionTypeDTO);
            this.infractionTypeDTOBindingSource.CurrentChanged += new System.EventHandler(this.infractionTypeDTOBindingSource_CurrentChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nueva infracción";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.infractionDTOBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(183, 34);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(173, 25);
            this.dateDateTimePicker.TabIndex = 11;
            // 
            // infractionTypeIdComboBox
            // 
            this.infractionTypeIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infractionTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionDTOBindingSource, "InfractionTypeId", true));
            this.infractionTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.infractionDTOBindingSource, "InfractionTypeId", true));
            this.infractionTypeIdComboBox.DataSource = this.infractionTypeDTOBindingSource;
            this.infractionTypeIdComboBox.DisplayMember = "Name";
            this.infractionTypeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.infractionTypeIdComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.infractionTypeIdComboBox.FormattingEnabled = true;
            this.infractionTypeIdComboBox.Location = new System.Drawing.Point(183, 127);
            this.infractionTypeIdComboBox.Name = "infractionTypeIdComboBox";
            this.infractionTypeIdComboBox.Size = new System.Drawing.Size(298, 25);
            this.infractionTypeIdComboBox.TabIndex = 9;
            this.infractionTypeIdComboBox.ValueMember = "Id";
            // 
            // vehicleDriverDTODataGridView
            // 
            this.vehicleDriverDTODataGridView.AllowUserToAddRows = false;
            this.vehicleDriverDTODataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vehicleDriverDTODataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vehicleDriverDTODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleDriverDTODataGridView.AutoGenerateColumns = false;
            this.vehicleDriverDTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDriverDTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vehicleDriverDTODataGridView.DataSource = this.vehicleDriverDTOBindingSource;
            this.vehicleDriverDTODataGridView.Location = new System.Drawing.Point(27, 191);
            this.vehicleDriverDTODataGridView.Name = "vehicleDriverDTODataGridView";
            this.vehicleDriverDTODataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDriverDTODataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.vehicleDriverDTODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleDriverDTODataGridView.Size = new System.Drawing.Size(603, 154);
            this.vehicleDriverDTODataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VehicleId";
            this.dataGridViewTextBoxColumn2.HeaderText = "VehicleId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VehicleLicense";
            this.dataGridViewTextBoxColumn4.HeaderText = "Matrícula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VehicleName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehículo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DriverId";
            this.dataGridViewTextBoxColumn5.HeaderText = "DriverId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DriverFullName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Conductor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DriverIdentifier";
            this.dataGridViewTextBoxColumn7.HeaderText = "NIF / NIE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DriverPoints";
            this.dataGridViewTextBoxColumn8.HeaderText = "Puntos";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // vehicleDriverDTOBindingSource
            // 
            this.vehicleDriverDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers.VehicleDriverDTO);
            this.vehicleDriverDTOBindingSource.CurrentChanged += new System.EventHandler(this.vehicleDriverDTOBindingSource_CurrentChanged);
            // 
            // txtLicenseFilter
            // 
            this.txtLicenseFilter.Location = new System.Drawing.Point(183, 65);
            this.txtLicenseFilter.Name = "txtLicenseFilter";
            this.txtLicenseFilter.Size = new System.Drawing.Size(173, 25);
            this.txtLicenseFilter.TabIndex = 5;
            this.txtLicenseFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseFilter_KeyPress);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(344, 447);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(156, 38);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "&Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAccept
            // 
            this.cmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAccept.BackColor = System.Drawing.Color.Honeydew;
            this.cmdAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccept.Location = new System.Drawing.Point(506, 447);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(156, 38);
            this.cmdAccept.TabIndex = 7;
            this.cmdAccept.Text = "&Aceptar";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // FrmAddNewInfraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 499);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddNewInfraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva infracción";
            this.Load += new System.EventHandler(this.FrmAddNewInfraction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionDTOBindingSource)).EndInit();
            this.panePoints.ResumeLayout(false);
            this.panePoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionTypeDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDriverDTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDriverDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.BindingSource infractionDTOBindingSource;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.BindingSource infractionTypeDTOBindingSource;
        private System.Windows.Forms.TextBox txtLicenseFilter;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox infractionTypeIdComboBox;
        private System.Windows.Forms.BindingSource vehicleDriverDTOBindingSource;
        private System.Windows.Forms.Label pointsLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panePoints;
        private System.Windows.Forms.DataGridView vehicleDriverDTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblDriverIdentifier;
        private System.Windows.Forms.Label lblDriverFullName;
        private System.Windows.Forms.Label lblVehicleFullName;
    }
}