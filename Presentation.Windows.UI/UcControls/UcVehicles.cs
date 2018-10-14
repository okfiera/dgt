using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Presentation.Windows.Seedwork.Api;
using Presentation.Windows.UI.SecondaryForms;

namespace Presentation.Windows.UI.UcControls
{
    public partial class UcVehicles : UserControl
    {
        #region Members

        private List<VehicleDTO> vehicles = new List<VehicleDTO>();
        private VehicleDTO currentVehicle;

        #endregion

        

        #region Constructor

        public UcVehicles()
        {
            InitializeComponent();
        }

        #endregion




        #region Control events

        private void UcVehicles_Load(object sender, EventArgs e)
        {
            SetResources();
        }

        private void UcVehicles_Enter(object sender, EventArgs e)
        {
            SetResources();
        }

        private async void cmdAddNewVehicle_Click(object sender, EventArgs e)
        {
            var frmAddNewVehicle = new FrmAddNewVehicle();
            var driverAdded = frmAddNewVehicle.AddNewVehicle();
            if (frmAddNewVehicle.DialogResult == DialogResult.OK && driverAdded != null)
            {
                this.txtFilter.Text = driverAdded.License;
                await this.SearchVehicles(driverAdded.License);
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

                await this.SearchVehicles(filter);
            }
        }

        private void vehicleDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.currentVehicle = this.vehicleDTOBindingSource.Current as VehicleDTO;
            if (currentVehicle != null)
            {
                GetInfractions(currentVehicle.License);
                GetDrivers(currentVehicle.License);
            }
        }

        #endregion




        #region Private methods

        public async Task SearchVehicles(string filter = null)
        {
            if (filter == null)
                filter = this.txtFilter.Text;

            this.vehicles = await ApiManagerVehicles.Search(filter);
            if (vehicles == null || !vehicles.Any())
                MessageBox.Show("No se ha encontrado ningún resultado", "Búsqueda de vehículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                this.vehicleDTOBindingSource.DataSource = vehicles;
                this.vehicleDriverDTOBindingSource.MoveFirst();
            }
        }

        private void SetResources()
        {
            this.cmdAddNewVehicle.Image = Properties.Resources.addnew;
            this.lnkAddDriver.Image = Properties.Resources.create16x16;
        }

        private async void GetInfractions(string license)
        {
            var results = await ApiManagerInfractions.ByVehicleLicense(license);
            this.infractionDTOBindingSource.DataSource = results;
        }

        private async void GetDrivers(string license)
        {
            var results = await ApiManagerDrivers.GetDriversByVehicleLicense(license);
            this.vehicleDriverDTOBindingSource.DataSource = results;
        }
        
        #endregion

        private void lnkAddDriver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentVehicle != null)
            {
                var frmAttachDriver = new FrmAttachDriver();
                frmAttachDriver.AttachDriver(currentVehicle);
                if (frmAttachDriver.DialogResult == DialogResult.OK)
                {
                    this.GetDrivers(this.currentVehicle.License);
                }
            }
            else
                MessageBox.Show("No hay ningún vehículo seleccionado", "Añadir conductor habitual",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

       
    }
}
