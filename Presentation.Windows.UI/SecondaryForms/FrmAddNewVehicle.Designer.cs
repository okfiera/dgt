namespace Presentation.Windows.UI.SecondaryForms
{
    partial class FrmAddNewVehicle
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
            System.Windows.Forms.Label brandIdLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label licenseLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label label7;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.vehicleDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandIdComboBox = new System.Windows.Forms.ComboBox();
            this.brandDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paneDriverNOTSetted = new System.Windows.Forms.Panel();
            this.paneDriverSetted = new System.Windows.Forms.Panel();
            this.lblHabitualDriverPoints = new System.Windows.Forms.Label();
            this.driverDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHabitualDriverName = new System.Windows.Forms.Label();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            brandIdLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            licenseLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDTOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.paneDriverNOTSetted.SuspendLayout();
            this.paneDriverSetted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // brandIdLabel
            // 
            brandIdLabel.AutoSize = true;
            brandIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            brandIdLabel.Location = new System.Drawing.Point(19, 39);
            brandIdLabel.Name = "brandIdLabel";
            brandIdLabel.Size = new System.Drawing.Size(58, 19);
            brandIdLabel.TabIndex = 0;
            brandIdLabel.Text = "Marca : ";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            modelLabel.Location = new System.Drawing.Point(19, 70);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(67, 19);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Modelo : ";
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            licenseLabel.Location = new System.Drawing.Point(19, 101);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new System.Drawing.Size(77, 19);
            licenseLabel.TabIndex = 4;
            licenseLabel.Text = "Matrícula : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(19, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 19);
            label1.TabIndex = 5;
            label1.Text = "NIF, NIE, ... :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(214, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(170, 19);
            label2.TabIndex = 8;
            label2.Text = "Pulsar ENTER para buscar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(15, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 19);
            label3.TabIndex = 11;
            label3.Text = "Puntos : ";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            firstNameLabel.Location = new System.Drawing.Point(13, 10);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(70, 19);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "Nombre : ";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(3, 25);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(472, 19);
            label7.TabIndex = 10;
            label7.Text = "No se ha definido ningún conductor";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(licenseLabel);
            this.groupBox1.Controls.Add(this.licenseTextBox);
            this.groupBox1.Controls.Add(modelLabel);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(brandIdLabel);
            this.groupBox1.Controls.Add(this.brandIdComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehículo";
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDTOBindingSource, "License", true));
            this.licenseTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.licenseTextBox.Location = new System.Drawing.Point(108, 98);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.Size = new System.Drawing.Size(100, 25);
            this.licenseTextBox.TabIndex = 5;
            // 
            // vehicleDTOBindingSource
            // 
            this.vehicleDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Vehicles.VehicleDTO);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDTOBindingSource, "Model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modelTextBox.Location = new System.Drawing.Point(108, 67);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(330, 25);
            this.modelTextBox.TabIndex = 3;
            // 
            // brandIdComboBox
            // 
            this.brandIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDTOBindingSource, "BrandId", true));
            this.brandIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehicleDTOBindingSource, "BrandId", true));
            this.brandIdComboBox.DataSource = this.brandDTOBindingSource;
            this.brandIdComboBox.DisplayMember = "Name";
            this.brandIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandIdComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.brandIdComboBox.FormattingEnabled = true;
            this.brandIdComboBox.Location = new System.Drawing.Point(108, 36);
            this.brandIdComboBox.Name = "brandIdComboBox";
            this.brandIdComboBox.Size = new System.Drawing.Size(330, 25);
            this.brandIdComboBox.TabIndex = 1;
            this.brandIdComboBox.ValueMember = "Id";
            // 
            // brandDTOBindingSource
            // 
            this.brandDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Brands.BrandDTO);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.paneDriverNOTSetted);
            this.groupBox2.Controls.Add(this.paneDriverSetted);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.txtIdentifier);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conductor habitual";
            // 
            // paneDriverNOTSetted
            // 
            this.paneDriverNOTSetted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneDriverNOTSetted.Controls.Add(label7);
            this.paneDriverNOTSetted.Location = new System.Drawing.Point(6, 140);
            this.paneDriverNOTSetted.Name = "paneDriverNOTSetted";
            this.paneDriverNOTSetted.Size = new System.Drawing.Size(478, 70);
            this.paneDriverNOTSetted.TabIndex = 10;
            // 
            // paneDriverSetted
            // 
            this.paneDriverSetted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneDriverSetted.Controls.Add(this.lblHabitualDriverPoints);
            this.paneDriverSetted.Controls.Add(this.lblHabitualDriverName);
            this.paneDriverSetted.Controls.Add(label3);
            this.paneDriverSetted.Controls.Add(firstNameLabel);
            this.paneDriverSetted.Location = new System.Drawing.Point(6, 64);
            this.paneDriverSetted.Name = "paneDriverSetted";
            this.paneDriverSetted.Size = new System.Drawing.Size(478, 70);
            this.paneDriverSetted.TabIndex = 9;
            // 
            // lblHabitualDriverPoints
            // 
            this.lblHabitualDriverPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHabitualDriverPoints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "Points", true));
            this.lblHabitualDriverPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHabitualDriverPoints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHabitualDriverPoints.Location = new System.Drawing.Point(98, 39);
            this.lblHabitualDriverPoints.Name = "lblHabitualDriverPoints";
            this.lblHabitualDriverPoints.Size = new System.Drawing.Size(102, 25);
            this.lblHabitualDriverPoints.TabIndex = 14;
            this.lblHabitualDriverPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driverDTOBindingSource
            // 
            this.driverDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Drivers.DriverDTO);
            // 
            // lblHabitualDriverName
            // 
            this.lblHabitualDriverName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHabitualDriverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHabitualDriverName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "FullName", true));
            this.lblHabitualDriverName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHabitualDriverName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHabitualDriverName.Location = new System.Drawing.Point(98, 6);
            this.lblHabitualDriverName.Name = "lblHabitualDriverName";
            this.lblHabitualDriverName.Size = new System.Drawing.Size(363, 25);
            this.lblHabitualDriverName.TabIndex = 12;
            this.lblHabitualDriverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(106, 33);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(102, 25);
            this.txtIdentifier.TabIndex = 6;
            this.txtIdentifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentifier_KeyPress);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(192, 394);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(156, 38);
            this.cmdCancel.TabIndex = 6;
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
            this.cmdAccept.Location = new System.Drawing.Point(354, 394);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(156, 38);
            this.cmdAccept.TabIndex = 5;
            this.cmdAccept.Text = "&Aceptar";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // FrmAddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 444);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(600, 483);
            this.Name = "FrmAddNewVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo vehículo";
            this.Load += new System.EventHandler(this.FrmAddNewVehicle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDTOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.paneDriverNOTSetted.ResumeLayout(false);
            this.paneDriverSetted.ResumeLayout(false);
            this.paneDriverSetted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.BindingSource vehicleDTOBindingSource;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ComboBox brandIdComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.Panel paneDriverSetted;
        private System.Windows.Forms.Panel paneDriverNOTSetted;
        private System.Windows.Forms.Label lblHabitualDriverPoints;
        private System.Windows.Forms.Label lblHabitualDriverName;
        private System.Windows.Forms.BindingSource driverDTOBindingSource;
        private System.Windows.Forms.BindingSource brandDTOBindingSource;
        private System.Windows.Forms.ErrorProvider errP;
    }
}