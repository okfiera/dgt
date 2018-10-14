using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Presentation.Windows.Seedwork.Api;
using Presentation.Windows.UI.SecondaryForms;

namespace Presentation.Windows.UI.UcControls
{
    public partial class UcInfractions : UserControl
    {
        #region Members

        private List<InfractionDTO> infractions = new List<InfractionDTO>();
        private List<InfractionTypeDTO> infractionTypes = new List<InfractionTypeDTO>();

        #endregion

        
        #region Constructor

        public UcInfractions()
        {
            InitializeComponent();
        }


        #endregion


        #region Control events

        private void UcInfractions_Load(object sender, EventArgs e)
        {
            SetResources();

            this.dtpFilterFrom.Checked = false;
            this.dtpFilterTo.Checked = false;
        }

        private async void cmdAddInfraction_Click(object sender, EventArgs e)
        {
            var frmAddNewInfraction = new FrmAddNewInfraction();
            var infractionAdded = frmAddNewInfraction.AddNewInfraction();
            if (frmAddNewInfraction.DialogResult == DialogResult.OK && infractionAdded != null)
            {
                this.txtFilterDriverIdentifier.Text = infractionAdded.DriverIdentifier;
                this.txtFilterVehicleLicense.Text = infractionAdded.VehicleLicense;

                await this.SearchInfractions();
            }
        }
        private async void cmdSearch_Click(object sender, EventArgs e)
        {
            await this.SearchInfractions();
        }

        #endregion


        #region Private methods

        public async Task SearchInfractions()
        {
            if (this.infractionTypes == null || !this.infractionTypes.Any())
                await this.LoadInfractionTypes();

            DateTime? from = null;
            if (this.dtpFilterFrom.Checked)
                from = this.dtpFilterFrom.Value;

            DateTime? to = null;
            if (this.dtpFilterTo.Checked)
                to = this.dtpFilterTo.Value;

            var infractionTypeId = "";
            if (this.cmbFilterInfractionType.SelectedValue.ToString() != Guid.Empty.ToString())
                infractionTypeId = this.cmbFilterInfractionType.SelectedValue.ToString();

            this.infractions = await ApiManagerInfractions.Search(this.txtFilterVehicleLicense.Text, this.txtFilterDriverIdentifier.Text, infractionTypeId, from, to );
            if (infractions == null || !infractions.Any())
                MessageBox.Show("No se ha encontrado ningún resultado", "Búsqueda de infracciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                this.infractionDTOBindingSource.DataSource = infractions;
        }

        private void SetResources()
        {
            this.cmdAddInfraction.Image = Properties.Resources.addnew;
            this.cmdSearch.Image = Properties.Resources.zoom;
        }

        private async Task LoadInfractionTypes()
        {
            this.infractionTypes = new List<InfractionTypeDTO>()
            {
                new InfractionTypeDTO() {Name = "TODAS"}
            };

            var it = await ApiManagerInfractionTypes.GetAllInfractionTypes();
            this.infractionTypes.AddRange(it);

            this.infractionTypeDTOBindingSource.DataSource = this.infractionTypes;
        }


        #endregion
    }
}
