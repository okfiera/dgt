using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.SecondaryForms
{
    public partial class FrmAddNewInfractionType : Form
    {
        #region Members

        private InfractionTypeDTO _infractionType;

        #endregion



        #region Constructor 

        public FrmAddNewInfractionType()
        {
            InitializeComponent();
        }

        #endregion



        #region Control events

        private void FrmAddNewInfractionType_Load(object sender, EventArgs e)
        {
            
        }

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
                    this._infractionType = await ApiManagerInfractionTypes.AddNew(this._infractionType);
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

        public InfractionTypeDTO AddNewInfractionType()
        {
            ClearErrors();

            this._infractionType = new InfractionTypeDTO();
            this.infractionTypeDTOBindingSource.DataSource = this._infractionType;
            this.infractionTypeDTOBindingSource.MoveFirst();

            var dialogResult = this.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return this._infractionType;
            else
                return null;
        }

        #endregion



        #region Private methods

        private bool ValidateData()
        {
            var result = true;

            if (String.IsNullOrEmpty(this.nameTextBox.Text.Trim()))
            {
                errP.SetError(this.nameTextBox, "Campo obligatorio");
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
