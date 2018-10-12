namespace Presentation.Windows.UI.SecondaryForms
{
    partial class FrmAttachDriver
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
            System.Windows.Forms.Label licenseLabel;
            System.Windows.Forms.Label vehicleFullNameLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label pointsLabel;
            System.Windows.Forms.Label label4;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.licenseLabel1 = new System.Windows.Forms.Label();
            this.vehicleDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleFullNameLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pointsLabel1 = new System.Windows.Forms.Label();
            this.driverDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.txtIdentifierFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            licenseLabel = new System.Windows.Forms.Label();
            vehicleFullNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDTOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Location = new System.Drawing.Point(17, 29);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new System.Drawing.Size(69, 17);
            licenseLabel.TabIndex = 9;
            licenseLabel.Text = "Matrícula :";
            // 
            // vehicleFullNameLabel
            // 
            vehicleFullNameLabel.AutoSize = true;
            vehicleFullNameLabel.Location = new System.Drawing.Point(17, 59);
            vehicleFullNameLabel.Name = "vehicleFullNameLabel";
            vehicleFullNameLabel.Size = new System.Drawing.Size(63, 17);
            vehicleFullNameLabel.TabIndex = 13;
            vehicleFullNameLabel.Text = "Vehículo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 17);
            label3.TabIndex = 10;
            label3.Text = "NIF / NIE / ... :";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(17, 64);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(76, 17);
            fullNameLabel.TabIndex = 11;
            fullNameLabel.Text = "Conductor :";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(17, 95);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(54, 17);
            pointsLabel.TabIndex = 12;
            pointsLabel.Text = "Puntos :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Italic);
            label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label4.Location = new System.Drawing.Point(246, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(182, 17);
            label4.TabIndex = 14;
            label4.Text = "ENTER = buscar, ESC = limpiar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(licenseLabel);
            this.groupBox1.Controls.Add(this.licenseLabel1);
            this.groupBox1.Controls.Add(vehicleFullNameLabel);
            this.groupBox1.Controls.Add(this.vehicleFullNameLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // licenseLabel1
            // 
            this.licenseLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.licenseLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDTOBindingSource, "License", true));
            this.licenseLabel1.Location = new System.Drawing.Point(136, 28);
            this.licenseLabel1.Name = "licenseLabel1";
            this.licenseLabel1.Size = new System.Drawing.Size(104, 24);
            this.licenseLabel1.TabIndex = 10;
            this.licenseLabel1.Text = "label2";
            // 
            // vehicleDTOBindingSource
            // 
            this.vehicleDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Vehicles.VehicleDTO);
            // 
            // vehicleFullNameLabel1
            // 
            this.vehicleFullNameLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.vehicleFullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleFullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleDTOBindingSource, "VehicleFullName", true));
            this.vehicleFullNameLabel1.Location = new System.Drawing.Point(136, 58);
            this.vehicleFullNameLabel1.Name = "vehicleFullNameLabel1";
            this.vehicleFullNameLabel1.Size = new System.Drawing.Size(350, 24);
            this.vehicleFullNameLabel1.TabIndex = 14;
            this.vehicleFullNameLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del vehículo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(pointsLabel);
            this.groupBox2.Controls.Add(this.pointsLabel1);
            this.groupBox2.Controls.Add(fullNameLabel);
            this.groupBox2.Controls.Add(this.fullNameLabel1);
            this.groupBox2.Controls.Add(this.txtIdentifierFilter);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pointsLabel1
            // 
            this.pointsLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.pointsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "Points", true));
            this.pointsLabel1.Location = new System.Drawing.Point(136, 94);
            this.pointsLabel1.Name = "pointsLabel1";
            this.pointsLabel1.Size = new System.Drawing.Size(100, 24);
            this.pointsLabel1.TabIndex = 13;
            // 
            // driverDTOBindingSource
            // 
            this.driverDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Drivers.DriverDTO);
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.fullNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "FullName", true));
            this.fullNameLabel1.Location = new System.Drawing.Point(136, 63);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(350, 24);
            this.fullNameLabel1.TabIndex = 12;
            // 
            // txtIdentifierFilter
            // 
            this.txtIdentifierFilter.Location = new System.Drawing.Point(136, 32);
            this.txtIdentifierFilter.Name = "txtIdentifierFilter";
            this.txtIdentifierFilter.Size = new System.Drawing.Size(104, 24);
            this.txtIdentifierFilter.TabIndex = 11;
            this.txtIdentifierFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentifierFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conductor que desea asignar como habitual";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(206, 261);
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
            this.cmdAccept.Enabled = false;
            this.cmdAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccept.Location = new System.Drawing.Point(368, 261);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(156, 38);
            this.cmdAccept.TabIndex = 7;
            this.cmdAccept.Text = "&Aceptar";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // FrmAttachDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 311);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAttachDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir conductor habitual";
            this.Load += new System.EventHandler(this.FrmAttachDriver_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDTOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label licenseLabel1;
        private System.Windows.Forms.BindingSource vehicleDTOBindingSource;
        private System.Windows.Forms.Label vehicleFullNameLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pointsLabel1;
        private System.Windows.Forms.BindingSource driverDTOBindingSource;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.TextBox txtIdentifierFilter;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.ErrorProvider errP;
    }
}