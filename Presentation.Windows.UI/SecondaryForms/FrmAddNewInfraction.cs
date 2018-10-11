using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.SecondaryForms
{
    public partial class FrmAddNewInfraction : Form
    {

        #region Members

        private InfractionDTO _infraction;

        #endregion



        #region Constructor

        public FrmAddNewInfraction()
        {
            InitializeComponent();
        }

        #endregion



        #region Control events

        private void FrmAddNewInfraction_Load(object sender, EventArgs e)
        {
            SetResources();
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
                    this._infraction = await ApiManagerInfractions.AddNew(this._infraction);
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

        public InfractionDTO AddNewInfraction()
        {
            ClearErrors();

            this._infraction = new InfractionDTO();
            this.infractionDTOBindingSource.DataSource = this._infraction;
            this.infractionDTOBindingSource.MoveFirst();

            var dialogResult = this.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return this._infraction;
            else
                return null;
        }

        #endregion



        #region Private methods

        private void ClearErrors()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                errP.SetError(ctr, "");
            }
        }

        private void SetResources()
        {
            this.cmdCancel.Image = Properties.Resources.cancel;
            this.cmdAccept.Image = Properties.Resources.ok;
        }


        #endregion

        

        private bool ValidateData()
        {
            this.ClearErrors();

            var result = true;

            var v = this.infractionDTOBindingSource.Current as InfractionDTO;

            
            // Check habitual driver
            return result;
        }
    }
}
