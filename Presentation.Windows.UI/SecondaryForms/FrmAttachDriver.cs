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
using Application.MainBoundedContext.DTO.DgtModule.Vehicles;
using Application.MainBoundedContext.DTO.DgtModule.VehiclesDrivers;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.SecondaryForms
{
    public partial class FrmAttachDriver : Form
    {
        #region Members

        private VehicleDTO vehicleDTO;
        private DriverDTO driverDTO;
        private VehicleDriverDTO vehicleDriverDTO;

        #endregion



        #region Constructor

        public FrmAttachDriver()
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
            if (this.driverDTO != null)
            {
                try
                {
                    this.vehicleDriverDTO = await ApiManagerVehicles.AttachDriver(this.vehicleDTO.License, this.driverDTO.Identifier);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error:" + Environment.NewLine + Environment.NewLine + ex.GetBaseException().Message, "DGT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("No hay conductor seleccionado", "Añadir conductor habitual",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmAttachDriver_Load(object sender, EventArgs e)
        {
            this.cmdAccept.Image = Properties.Resources.ok;
            this.cmdCancel.Image = Properties.Resources.cancel;
        }
        private void txtIdentifierFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.txtIdentifierFilter.Text = "";
                this.driverDTO = null;
                this.driverDTOBindingSource.Clear();
                this.cmdAccept.Enabled = false;
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = this.txtIdentifierFilter.Text.Trim();
                if (!String.IsNullOrEmpty(filter))
                {
                    e.Handled = true;
                    this.GetDriverByIdentifier(filter);
                }

            }
        }

        #endregion



        #region Public methods

        public void AttachDriver(VehicleDTO _vehicleDTO)
        {
            if (_vehicleDTO == null)
                throw new ArgumentNullException("_vehicleDTO");

            this.vehicleDTO = _vehicleDTO;

            ClearErrors();

            this.vehicleDTOBindingSource.DataSource = vehicleDTO;
            this.ShowDialog();
        }

        #endregion



        #region private methods

        private void ClearErrors()
        {
            this.errP.SetError(this.txtIdentifierFilter, "");
        }

        private async void GetDriverByIdentifier(string identifier)
        {
            if (!String.IsNullOrEmpty(identifier))
            {
                var result = await ApiManagerDrivers.GetByNifNie(identifier);

                if (result != null)
                {
                    this.driverDTOBindingSource.DataSource = result;
                    this.driverDTO = result;
                    this.cmdAccept.Enabled = true;
                    this.cmdAccept.Focus();
                }
                else
                {
                    this.driverDTO = null;
                    this.driverDTOBindingSource.Clear();
                    this.cmdAccept.Enabled = false;
                    MessageBox.Show("No se ha encontrado ningún Conductor con el NIF/NIE " + identifier,
                        "Añadir conductor habitual",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                                this.cmdAccept.Enabled = false;
                MessageBox.Show("Debes introducir el NIF/NIE del conductor", "Añadir conductor habitual",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }




        #endregion


    }