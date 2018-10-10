using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Windows.UI.UcControls;

namespace Presentation.Windows.UI
{
    public partial class FrmContainer : Form
    {

        #region Members

        private enum Option
        {
            Home = 0,
            InfractionTypes = 1,
            Infractions = 2,
            Drivers = 3,
            Vehicles = 4,
            Brands = 5
        }

        protected UcHome UcHome;
        protected UcBrands UcBrands;
        protected UcDrivers UcDrivers;
        protected UcInfractions UcInfractions;
        protected UcInfractionTypes UcInfractionTypes;
        protected UcVehicles UcVehicles;

        #endregion



        #region Control events


        #region Menu options

        private void tsbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la Aplicación?", "Salir de la Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void tsbInfractionTypes_Click(object sender, EventArgs e)
        {
            ShowControl(Option.InfractionTypes);
        }
        private void FrmContainer_Load(object sender, EventArgs e)
        {
            ShowControl(Option.Home);
        }

        private void tsbInicio_Click(object sender, EventArgs e)
        {
            ShowControl(Option.Home);
        }

        private void tsbInfractions_Click(object sender, EventArgs e)
        {
            ShowControl(Option.Infractions);
        }

        private void tsbDrivers_Click(object sender, EventArgs e)
        {
            ShowControl(Option.Drivers);
        }

        private void tsbVehicles_Click(object sender, EventArgs e)
        {
            ShowControl(Option.Vehicles);
        }

        private void tsbBrands_Click(object sender, EventArgs e)
        {
            ShowControl(Option.Brands);
        }
        private void ShowControl(Option option)
        {
            Control currentControl = null;

            switch (option)
            {
                case Option.Home:
                    if (UcHome == null) UcHome = new UcHome();
                    currentControl = UcHome;
                    break;

                case Option.Brands:
                    if (UcBrands == null) UcBrands = new UcBrands();
                    currentControl = UcBrands;
                    break;


                case Option.Drivers:
                    if (UcDrivers == null) UcDrivers = new UcDrivers();
                    currentControl = UcDrivers;
                    break;

                case Option.Infractions:
                    if (UcInfractions == null) UcInfractions = new UcInfractions();
                    currentControl = UcInfractions;
                    break;

                case Option.InfractionTypes:
                    if (UcInfractionTypes == null) UcInfractionTypes = new UcInfractionTypes();
                    currentControl = UcInfractionTypes;
                    break;

                case Option.Vehicles:
                    if (UcVehicles == null) UcVehicles = new UcVehicles();
                    currentControl = UcVehicles;
                    break;
            }

            if (currentControl != null)
            {
                currentControl.Dock = DockStyle.Fill;
                this.panelContainer.Controls.Clear();
                this.panelContainer.Controls.Add(currentControl);
            }
        }

        #endregion


        public FrmContainer()
        {
            InitializeComponent();
        }




        #endregion

       
        
    }
}
