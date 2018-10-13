namespace Presentation.Windows.UI
{
    partial class FrmContainer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInfractionTypes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInfractions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDrivers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVehicles = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBrands = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 46);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "DGT - Gestión de infracciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInicio,
            this.toolStripSeparator7,
            this.tsbInfractionTypes,
            this.toolStripSeparator4,
            this.tsbInfractions,
            this.toolStripSeparator1,
            this.tsbDrivers,
            this.toolStripSeparator3,
            this.tsbVehicles,
            this.toolStripSeparator2,
            this.tsbBrands,
            this.toolStripSeparator5,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 26);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInicio
            // 
            this.tsbInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInicio.Name = "tsbInicio";
            this.tsbInicio.Size = new System.Drawing.Size(45, 23);
            this.tsbInicio.Text = "Inicio";
            this.tsbInicio.Click += new System.EventHandler(this.tsbInicio_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 26);
            this.toolStripSeparator7.Visible = false;
            // 
            // tsbInfractionTypes
            // 
            this.tsbInfractionTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfractionTypes.Name = "tsbInfractionTypes";
            this.tsbInfractionTypes.Size = new System.Drawing.Size(126, 23);
            this.tsbInfractionTypes.Text = "Tipos de infracción";
            this.tsbInfractionTypes.Click += new System.EventHandler(this.tsbInfractionTypes_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbInfractions
            // 
            this.tsbInfractions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfractions.Name = "tsbInfractions";
            this.tsbInfractions.Size = new System.Drawing.Size(85, 23);
            this.tsbInfractions.Text = "Infracciones";
            this.tsbInfractions.Click += new System.EventHandler(this.tsbInfractions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbDrivers
            // 
            this.tsbDrivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDrivers.Name = "tsbDrivers";
            this.tsbDrivers.Size = new System.Drawing.Size(91, 23);
            this.tsbDrivers.Text = "Conductores";
            this.tsbDrivers.Click += new System.EventHandler(this.tsbDrivers_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbVehicles
            // 
            this.tsbVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVehicles.Name = "tsbVehicles";
            this.tsbVehicles.Size = new System.Drawing.Size(70, 23);
            this.tsbVehicles.Text = "Vehículos";
            this.tsbVehicles.Click += new System.EventHandler(this.tsbVehicles_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbBrands
            // 
            this.tsbBrands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrands.Name = "tsbBrands";
            this.tsbBrands.Size = new System.Drawing.Size(57, 23);
            this.tsbBrands.Text = "Marcas";
            this.tsbBrands.Click += new System.EventHandler(this.tsbBrands_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbExit
            // 
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(134, 23);
            this.tsbExit.Text = "Salir de la aplicación";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.panelContainer.Location = new System.Drawing.Point(0, 72);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1141, 664);
            this.panelContainer.TabIndex = 13;
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 736);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DGT - Gestión de infracciones";
            this.Load += new System.EventHandler(this.FrmContainer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbInfractions;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripButton tsbInfractionTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDrivers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbVehicles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBrands;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}