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
            System.Windows.Forms.Label infractionTypeIdLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infractionDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.infractionTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.infractionTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            infractionTypeIdLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infractionTypeDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(infractionTypeIdLabel);
            this.groupBox1.Controls.Add(this.infractionTypeIdComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva infracción";
            // 
            // infractionDTOBindingSource
            // 
            this.infractionDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.Infractions.InfractionDTO);
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
            this.cmdCancel.Location = new System.Drawing.Point(249, 284);
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
            this.cmdAccept.Location = new System.Drawing.Point(411, 284);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(156, 38);
            this.cmdAccept.TabIndex = 7;
            this.cmdAccept.Text = "&Aceptar";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // infractionTypeIdLabel
            // 
            infractionTypeIdLabel.AutoSize = true;
            infractionTypeIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            infractionTypeIdLabel.Location = new System.Drawing.Point(21, 185);
            infractionTypeIdLabel.Name = "infractionTypeIdLabel";
            infractionTypeIdLabel.Size = new System.Drawing.Size(75, 19);
            infractionTypeIdLabel.TabIndex = 0;
            infractionTypeIdLabel.Text = "Infracción :";
            // 
            // infractionTypeIdComboBox
            // 
            this.infractionTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionDTOBindingSource, "InfractionTypeId", true));
            this.infractionTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.infractionDTOBindingSource, "InfractionTypeId", true));
            this.infractionTypeIdComboBox.DataSource = this.infractionTypeDTOBindingSource;
            this.infractionTypeIdComboBox.DisplayMember = "Name";
            this.infractionTypeIdComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.infractionTypeIdComboBox.FormattingEnabled = true;
            this.infractionTypeIdComboBox.Location = new System.Drawing.Point(113, 182);
            this.infractionTypeIdComboBox.Name = "infractionTypeIdComboBox";
            this.infractionTypeIdComboBox.Size = new System.Drawing.Size(169, 25);
            this.infractionTypeIdComboBox.TabIndex = 1;
            this.infractionTypeIdComboBox.ValueMember = "Id";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            dateLabel.Location = new System.Drawing.Point(21, 213);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(55, 19);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Fecha : ";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.infractionDTOBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(113, 213);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(145, 25);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // infractionTypeDTOBindingSource
            // 
            this.infractionTypeDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.InfractionTypes.InfractionTypeDTO);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            label1.Location = new System.Drawing.Point(21, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 19);
            label1.TabIndex = 4;
            label1.Text = "Matrícula :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 25);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new System.Drawing.Point(21, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 19);
            label2.TabIndex = 6;
            label2.Text = "Conductor habitual :";
            // 
            // FrmAddNewInfraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 328);
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
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infractionTypeDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.BindingSource infractionDTOBindingSource;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox infractionTypeIdComboBox;
        private System.Windows.Forms.BindingSource infractionTypeDTOBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}