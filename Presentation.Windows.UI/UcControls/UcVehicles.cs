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

        private void cmdAddNewVehicle_Click(object sender, EventArgs e)
        {
            var frmAddNewVehicle = new FrmAddNewVehicle();
            var driverAdded = frmAddNewVehicle.AddNewVehicle();
            if (frmAddNewVehicle.DialogResult == DialogResult.OK && driverAdded != null)
            {
                this.txtFilter.Text = driverAdded.License;
                this.SearchVehicles(driverAdded.License);
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
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

                this.SearchVehicles(filter);
            }
        }

        #endregion




        #region Private methods

        private async void SearchVehicles(string filter)
        {
            if (!String.IsNullOrEmpty(filter))
            {
                this.vehicles = await ApiManagerVehicles.Search(filter);
                if (vehicles == null || !vehicles.Any())
                    MessageBox.Show("No se ha encontrado ningún resultado", "Búsqueda de vehículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    this.vehicleDTOBindingSource.DataSource = vehicles;
            }
        }

        private void SetResources()
        {
            this.cmdAddNewVehicle.Image = Properties.Resources.addnew;
        }


        #endregion

       
    }
}
