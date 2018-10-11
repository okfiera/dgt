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
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.SecondaryForms
{
    public partial class FrmAddNewInfraction : Form
    {

        #region Members

        private InfractionDTO _infraction;
        private List<InfractionTypeDTO> _infractionTypes;

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
            LoadInfractionTypes();
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

        private void txtLicenseFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.txtLicenseFilter.Text = "";

                var current = this.infractionDTOBindingSource.Current as InfractionDTO;
                if (current != null)
                {
                    current.VehicleId = Guid.Empty;
                }

                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = this.txtLicenseFilter.Text.Trim();
                if (!String.IsNullOrEmpty(filter))
                {
                    e.Handled = true;
                    this.GetVehicleByLicense(filter);
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

        private async void LoadInfractionTypes()
        {
            this._infractionTypes = new List<InfractionTypeDTO>()
            {
                new InfractionTypeDTO() {Name = " Seleccionar infracción", Points = 0}
            };
           var i = await ApiManagerInfractionTypes.GetAllInfractionTypes();
            this._infractionTypes.AddRange(i);
            this.infractionTypeDTOBindingSource.DataSource = this._infractionTypes;
        }


        private void ShowVehicle(bool value)
        {

        }

        private async void GetVehicleByLicense(string license)
        {
            var infraction = this.infractionDTOBindingSource.Current as InfractionDTO;
            if (infraction != null)
            {
                var v = await ApiManagerVehicles.GetByLicense(license);
                if (v != null)
                {
                    infraction.VehicleId = v.Id;
                    infraction.VehicleFullName = v.VehicleFullName;
                    infraction.VehicleLicense = v.License;

                    this.lblVehicleFullName.Text = v.VehicleFullName;

                    GetDriversByVehicleLicense(license);
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningún resultado", "Buscar vehículo", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    infraction.VehicleId = Guid.Empty;
                    infraction.VehicleFullName = "";
                    infraction.VehicleLicense = "";

                    this.lblVehicleFullName.Text = "";

                    this.vehicleDriverDTOBindingSource.DataSource = null;
                }
            }
          
        }

        private async void GetDriversByVehicleLicense(string license)
        {
            var infraction = this.infractionDTOBindingSource.Current as InfractionDTO;
            if (infraction != null)
            {
                var drivers = await ApiManagerDrivers.GetDriversByVehicleLicense(license);
                if (drivers != null && drivers.Any())
                {
                    this.vehicleDriverDTOBindingSource.DataSource = drivers;

                    if (drivers.Count == 1)
                    {

                        infraction.DriverId = drivers.First().DriverId;
                        infraction.DriverFullName = drivers.First().DriverFullName;
                        infraction.DriverIdentifier = drivers.First().DriverIdentifier;

                        this.lblDriverIdentifier.Text = drivers.First().DriverIdentifier;
                        this.lblDriverFullName.Text = drivers.First().DriverFullName;
                    }
                    else
                    {
                        infraction.DriverId = drivers.First().DriverId;
                        infraction.DriverFullName = drivers.First().DriverFullName;
                        infraction.DriverIdentifier = drivers.First().DriverIdentifier;

                        this.lblDriverIdentifier.Text = drivers.First().DriverIdentifier;
                        this.lblDriverFullName.Text = drivers.First().DriverFullName;
                    }
                }
                else
                {
                    infraction.DriverId = Guid.Empty;
                    infraction.DriverFullName = "";
                    infraction.DriverIdentifier = "";

                    this.lblDriverIdentifier.Text = "";
                    this.lblDriverFullName.Text = "";

                    this.vehicleDriverDTOBindingSource.DataSource = null;
                }
            }
        }

        private void GetDriverByIdentifier(string identifier)
        {

        }

        #endregion



        private bool ValidateData()
        {
            this.ClearErrors();

            var result = true;

            var v = this.infractionDTOBindingSource.Current as InfractionDTO;

            v.Date = this.dateDateTimePicker.Value;

            if (v.Date > DateTime.Now)
            {
                this.errP.SetError(this.dateDateTimePicker, "La fecha no puede ser posterior al momento actual");
                result = false;
            }

            if (v.DriverId == Guid.Empty)
            {
                this.errP.SetError(this.lblDriverIdentifier, "Campo obligatorio");
                this.errP.SetError(this.lblDriverFullName, "Campo obligatorio");
                result = false;
            }

            if (v.VehicleId == Guid.Empty)
            {
                this.errP.SetError(this.txtLicenseFilter, "Campo obligatorio");
                result = false;
            }

            if (v.InfractionTypeId == Guid.Empty)
            {
                this.errP.SetError(this.infractionTypeIdComboBox, "Campo obligatorio");
                result = false;
            }


            // Check habitual driver
            return result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void infractionTypeDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var current = this.infractionTypeDTOBindingSource.Current as InfractionTypeDTO;
            if (current.Id == Guid.Empty)
                this.panePoints.Visible = false;
            else
                this.panePoints.Visible = true;
        }

        private void vehicleDriverDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var vehicleDriver= this.vehicleDriverDTOBindingSource.Current as VehicleDriverDTO;
            var infraction = this.infractionDTOBindingSource.Current as InfractionDTO;

            if (vehicleDriver != null & infraction != null)
            {
                infraction.DriverId = vehicleDriver.DriverId;
                infraction.DriverFullName = vehicleDriver.DriverFullName;
                infraction.DriverIdentifier = vehicleDriver.DriverIdentifier;

                this.lblDriverIdentifier.Text = vehicleDriver.DriverIdentifier;
                this.lblDriverFullName.Text = vehicleDriver.DriverFullName;
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
