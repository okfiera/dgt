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
using Presentation.Windows.Seedwork.Api;
using Presentation.Windows.UI.SecondaryForms;

namespace Presentation.Windows.UI.UcControls
{
    public partial class UcDrivers : UserControl
    {
        #region Members

        private List<DriverDTO> drivers = new List<DriverDTO>();

        #endregion



        #region Constructor

        public UcDrivers()
        {
            InitializeComponent();
        }

        #endregion



        #region Control events

        private void UcDrivers_Load(object sender, EventArgs e)
        {
            SetResources();
        }

        private async void cmdAddNewDriver_Click(object sender, EventArgs e)
        {
            var frmAddNewDriver = new FrmAddNewDriver();
            var driverAdded = frmAddNewDriver.AddNewDriver();
            if (frmAddNewDriver.DialogResult == DialogResult.OK && driverAdded != null)
            {
                this.txtFilter.Text = driverAdded.Identifier;
                await this.SearchDrivers(driverAdded.Identifier);
            }
        }

        private async void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.txtFilter.Text = "";
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = this.txtFilter.Text;

                e.Handled = true;

                await this.SearchDrivers(filter);
            }
        }



        private void cmdClearLocalFilter_Click(object sender, EventArgs e)
        {
            this.txtFilter.Text = "";
            this.driverDTOBindingSource.DataSource = this.drivers.OrderBy(m => m.FullName);
        }

        private async void driverDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            await GetDriverVehicles();
            await GetDriverInfractions();
        }

        #endregion



        #region Private methods

        public async Task SearchDrivers(string filter = null)
        {
            if (filter == null)
                filter = this.txtFilter.Text;

            if (!String.IsNullOrEmpty(filter))
            {
                this.drivers = await ApiManagerDrivers.Search(filter);
                if (drivers == null || !drivers.Any())
                    MessageBox.Show("No se ha encontrado ningún resultado", "Búsqueda de conductores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    this.driverDTOBindingSource.DataSource = drivers;
            }
        }

        private async Task GetDriverVehicles()
        {
            var currentDriver = this.driverDTOBindingSource.Current as DriverDTO;
            if (currentDriver != null)
            {
                var vehicles = await ApiManagerVehicles.ByDriverIdentifier(currentDriver.Identifier);
                this.vehicleDriverDTOBindingSource.DataSource = vehicles;
            }
            
        }

        private async Task GetDriverInfractions()
        {
            var currentDriver = this.driverDTOBindingSource.Current as DriverDTO;
            if (currentDriver != null)
            {
                var infractions = await ApiManagerInfractions.ByDriverIdentifier(currentDriver.Identifier);
                this.infractionDTOBindingSource.DataSource = infractions;
            }
        }

        private void SetResources()
        {
            this.cmdAddNewDriver.Image = Properties.Resources.addnew;
        }



        #endregion

        
    }
}
