using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.SecondaryForms
{
    public partial class FrmAddNewDriver : Form
    {
        #region Members

        private DriverDTO _driver;

        #endregion




        #region Constructor 

        public FrmAddNewDriver()
        {
            InitializeComponent();
        }

        #endregion




        #region Control events

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void cmdAccept_Click(object sender, EventArgs e)
        {
            if (this.ValidateData())
            {
                try
                {
                    this._driver = await ApiManagerDrivers.AddNew(this._driver);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error:" + Environment.NewLine + Environment.NewLine + ex.GetBaseException().Message, "DGT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion




        #region Public methods

        public DriverDTO AddNewDriver()
        {
            ClearErrors();

            this._driver = new DriverDTO();
            this.driverDTOBindingSource.DataSource = this._driver;
            this.driverDTOBindingSource.MoveFirst();

            var dialogResult = this.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return this._driver;
            else
                return null;
        }

        #endregion



        #region Private methods

        private bool ValidateData()
        {
            this.ClearErrors();

            var result = true;

            // Check identification
            if (String.IsNullOrEmpty(this.identifierTextBox.Text.Trim()))
            {
                errP.SetError(this.identifierTextBox, "Campo obligatorio");
                result = false;
            }

            // Check first name
            if (String.IsNullOrEmpty(this.firstNameTextBox.Text.Trim()))
            {
                errP.SetError(this.firstNameTextBox, "Campo obligatorio");
                result = false;
            }



            // Check last name
            if (String.IsNullOrEmpty(this.lastNameTextBox.Text.Trim()))
            {
                errP.SetError(this.lastNameTextBox, "Campo obligatorio");
                result = false;
            }
            
            return result;
        }

        private void ClearErrors()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                errP.SetError(ctr, "");
            }
        }



        #endregion


    }
}
