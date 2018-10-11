using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Application.MainBoundedContext.DTO.DgtModule.Drivers;
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.SecondaryForms
{
    public partial class FrmAddNewVehicle : Form
    {

        #region Members

        private VehicleDTO _vehicle;
        private List<BrandDTO> _brands;
        private DriverDTO _driver;
        private bool _showDriver = false;

        #endregion



        #region Constructor

        public FrmAddNewVehicle()
        {
            InitializeComponent();
            SetResources();
        }

        #endregion




        #region Control events

        private void FrmAddNewVehicle_Load(object sender, EventArgs e)
        {
            LoadBrands();
            ShowDriver(false);
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
                    this._vehicle = await ApiManagerVehicles.AddNew(this._vehicle);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error:" + Environment.NewLine + Environment.NewLine + ex.GetBaseException().Message, "DGT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtIdentifier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.txtIdentifier.Text = "";

                var current = this.vehicleDTOBindingSource.Current as VehicleDTO;
                if (current != null)
                    current.DriverId = Guid.Empty;

                ShowDriver(false);


                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = this.txtIdentifier.Text.Trim();
                if (!String.IsNullOrEmpty(filter))
                {
                    e.Handled = true;
                    this.GetDriverByIdentifier(filter);
                }

            }
        }

        #endregion



        #region Public methods

        public VehicleDTO AddNewVehicle()
        {
            ClearErrors();

            this._vehicle = new VehicleDTO();
            this.vehicleDTOBindingSource.DataSource = this._vehicle;
            this.vehicleDTOBindingSource.MoveFirst();

            var dialogResult = this.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return this._vehicle;
            else
                return null;
        }

        #endregion




        #region Private methods

        private bool ValidateData()
        {
            this.ClearErrors();

            var result = true;

            var v = this.vehicleDTOBindingSource.Current as VehicleDTO;


            // Check brand
            if (v.BrandId == Guid.Empty)
            {
                errP.SetError(this.brandIdComboBox, "Campo obligatorio");
                result = false;
            }

            // Check model
            if (String.IsNullOrEmpty(v.Model))
            {
                errP.SetError(this.modelTextBox, "Campo obligatorio");
                result = false;
            }
            
            // Check license
            if (String.IsNullOrEmpty(v.License))
            {
                errP.SetError(this.licenseTextBox, "Campo obligatorio");
                result = false;
            }

            // Check driverId
            if (v.DriverId == Guid.Empty)
            {
                errP.SetError(this.txtIdentifier, "Campo obligatorio");
                this.ShowDriver(false);
                result = false;
            }

            // Check habitual driver
            return result;
        }

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

        private async void LoadBrands()
        {
            this._brands = new List<BrandDTO>();
            this._brands.Add(new BrandDTO() {Id = Guid.Empty, Name = "Seleccionar marca"});

            var b = await ApiManagerBrands.GetAllBrands();
            this._brands.AddRange(b);

            this.brandDTOBindingSource.DataSource = this._brands;
        }

        private async void GetDriverByIdentifier(string identifier)
        {
            var driver = await ApiManagerDrivers.GetByNifNie(identifier);
            if (driver != null)
            {
                var current = this.vehicleDTOBindingSource.Current as VehicleDTO;
                if (current != null)
                {
                    current.DriverId = driver.Id;
                    this.driverDTOBindingSource.DataSource = driver;
                    ShowDriver(true);
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningún resultado", "Búsqueda de conductor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ShowDriver(false);
            }
        }


        private void ShowDriver(bool value)
        {
            this.paneDriverNOTSetted.Visible = !value;
            this.paneDriverSetted.Visible = value;
        }
        #endregion


    }
}
