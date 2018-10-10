namespace Presentation.Windows.UI.SecondaryForms
{
    partial class FrmAddNewInfractionType
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pointsLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.infractionTypeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            nameLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionTypeDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(pointsLabel);
            this.groupBox1.Controls.Add(this.pointsNumericUpDown);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de infracción";
            // 
            // cmdAccept
            // 
            this.cmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAccept.BackColor = System.Drawing.Color.Honeydew;
            this.cmdAccept.Image = global::Presentation.Windows.UI.Properties.Resources.ok;
            this.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccept.Location = new System.Drawing.Point(356, 251);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(156, 38);
            this.cmdAccept.TabIndex = 1;
            this.cmdAccept.Text = "&Aceptar";
            this.cmdAccept.UseVisualStyleBackColor = false;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmdCancel.Image = global::Presentation.Windows.UI.Properties.Resources.cancel;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(194, 251);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(156, 38);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "&Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // infractionTypeDTOBindingSource
            // 
            this.infractionTypeDTOBindingSource.DataSource = typeof(Application.MainBoundedContext.DTO.DgtModule.InfractionTypes.InfractionTypeDTO);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            nameLabel.Location = new System.Drawing.Point(24, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 19);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionTypeDTOBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(83, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(370, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            pointsLabel.Location = new System.Drawing.Point(23, 74);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(49, 19);
            pointsLabel.TabIndex = 2;
            pointsLabel.Text = "Points:";
            // 
            // pointsNumericUpDown
            // 
            this.pointsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.infractionTypeDTOBindingSource, "Points", true));
            this.pointsNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pointsNumericUpDown.Location = new System.Drawing.Point(83, 71);
            this.pointsNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.pointsNumericUpDown.Name = "pointsNumericUpDown";
            this.pointsNumericUpDown.Size = new System.Drawing.Size(70, 25);
            this.pointsNumericUpDown.TabIndex = 3;
            this.pointsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            descriptionLabel.Location = new System.Drawing.Point(24, 111);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(81, 19);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infractionTypeDTOBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriptionTextBox.Location = new System.Drawing.Point(28, 133);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(425, 83);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // FrmAddNewInfractionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 301);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmAddNewInfractionType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo tipo de infracción";
            this.Load += new System.EventHandler(this.FrmAddNewInfractionType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infractionTypeDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource infractionTypeDTOBindingSource;
        private System.Windows.Forms.NumericUpDown pointsNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ErrorProvider errP;
    }
}