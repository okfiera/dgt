using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.InfractionTypes;
using Presentation.Windows.Seedwork.Api;
using Presentation.Windows.UI.SecondaryForms;

namespace Presentation.Windows.UI.UcControls
{
    public partial class UcInfractionTypes : UserControl
    {
        #region Members

        private List<InfractionTypeDTO>infractionTypes = new List<InfractionTypeDTO>();

        #endregion


        #region Constructor

        public UcInfractionTypes()
        {
            InitializeComponent();
        }

        #endregion



        #region Control events


        private async void UcInfractionTypes_Load(object sender, EventArgs e)
        {
            this.infractionTypes = await ApiManagerInfractionTypes.GetAllInfractionTypes();
            this.infractionTypeDTOBindingSource.DataSource = this.infractionTypes.OrderBy(m => m.Name);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.txtFilter.Text = "";
                this.infractionTypeDTOBindingSource.DataSource = this.infractionTypes.OrderBy(m => m.Name);

                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = this.txtFilter.Text;
                this.infractionTypeDTOBindingSource.DataSource = this.infractionTypes.Where(m => m.Name.ToLower().Contains(filter.ToLower())).OrderBy(m => m.Name);

                e.Handled = true;
            }

        }

        private void cmdClearLocalFilter_Click(object sender, EventArgs e)
        {
            this.txtFilter.Text = "";
            this.infractionTypeDTOBindingSource.DataSource = this.infractionTypes.OrderBy(m => m.Name);
        }

        private void cmdAddNewInfractionType_Click(object sender, EventArgs e)
        {
            var frmAddNewInfractionType = new FrmAddNewInfractionType();
            var infractionTypeAdded = frmAddNewInfractionType.AddNewInfractionType();
            if (frmAddNewInfractionType.DialogResult == DialogResult.OK && infractionTypeAdded != null)
            {
                this.infractionTypes.Add(infractionTypeAdded);
                this.infractionTypeDTOBindingSource.Add(infractionTypeAdded);
            }
        }

        #endregion


    }
}
