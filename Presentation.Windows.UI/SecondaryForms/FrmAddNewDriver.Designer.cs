namespace Presentation.Windows.UI.SecondaryForms
{
    partial class FrmAddNewDriver
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
            System.Windows.Forms.Label identifierLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.identifierTextBox = new System.Windows.Forms.TextBox();
            this.driverDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            identifierLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(identifierLabel);
            this.groupBox1.Controls.Add(this.identifierTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del conductor";
            // 
            // identifierLabel
            // 
            identifierLabel.AutoSize = true;
            identifierLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            identifierLabel.Location = new System.Drawing.Point(21, 39);
            identifierLabel.Name = "identifierLabel";
            identifierLabel.Size = new System.Drawing.Size(97, 19);
            identifierLabel.TabIndex = 0;
            identifierLabel.Text = "NIF / NIE / ... : ";
            // 
            // identifierTextBox
            // 
            this.identifierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "Identifier", true));
            this.identifierTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.identifierTextBox.Location = new System.Drawing.Point(128, 36);
            this.identifierTextBox.Name = "identifierTextBox";
            this.identifierTextBox.Size = new System.Drawing.Size(100, 25);
            this.identifierTextBox.TabIndex = 1;
            // 
            // driverDTOBindingSource
            // 
            this.driverDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Drivers.DriverDTO);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            firstNameLabel.Location = new System.Drawing.Point(21, 70);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(70, 19);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Nombre : ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstNameTextBox.Location = new System.Drawing.Point(128, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(366, 25);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            lastNameLabel.Location = new System.Drawing.Point(21, 101);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 19);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Apellidos : ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverDTOBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastNameTextBox.Location = new System.Drawing.Point(128, 98);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(366, 25);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(221, 200);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(156, 38);
            this.cmdCancel.TabIndex = 4;
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
            this.cmdAccept.Location = new System.Drawing.Point(383, 200);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(156, 38);
            this.cmdAccept.TabIndex = 3;
            this.cmdAccept.Text = "&Aceptar";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(21, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 19);
            label1.TabIndex = 6;
            label1.Text = "Puntos : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(124, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(329, 19);
            label2.TabIndex = 7;
            label2.Text = "Los conductores nuevos comenzarán con 12 puntos";
            // 
            // FrmAddNewDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 250);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 289);
            this.Name = "FrmAddNewDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo conductor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox identifierTextBox;
        private System.Windows.Forms.BindingSource driverDTOBindingSource;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.ErrorProvider errP;
    }
}