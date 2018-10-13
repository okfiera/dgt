namespace Presentation.Windows.UI
{
    partial class FrmSplash
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
            this.label1 = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.imgDgtLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDgtLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de infraciones";
            // 
            // imgLoading
            // 
            this.imgLoading.Location = new System.Drawing.Point(14, 173);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(160, 24);
            this.imgLoading.TabIndex = 3;
            this.imgLoading.TabStop = false;
            // 
            // imgDgtLogo
            // 
            this.imgDgtLogo.Location = new System.Drawing.Point(14, 31);
            this.imgDgtLogo.Name = "imgDgtLogo";
            this.imgDgtLogo.Size = new System.Drawing.Size(160, 136);
            this.imgDgtLogo.TabIndex = 0;
            this.imgDgtLogo.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(188, 208);
            this.ControlBox = false;
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgDgtLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.Text = "FrmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDgtLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDgtLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgLoading;
    }
}