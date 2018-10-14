using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.Brands;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.UcControls
{
    public partial class UcBrands : UserControl
    {
        #region Members

        private List<BrandDTO> brands = new List<BrandDTO>();

        #endregion



        #region Constructor

        public UcBrands()
        {
            InitializeComponent();
        }

        #endregion



        #region Control events

        private async void UcBrands_Load(object sender, EventArgs e)
        {
            await this.SearchBrands();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.txtFilter.Text = "";
                this.brandDTOBindingSource.DataSource = this.brands.OrderBy(m => m.Name);

                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                var filter = this.txtFilter.Text;
                this.brandDTOBindingSource.DataSource = this.brands.Where(m => m.Name.ToLower().Contains(filter.ToLower())).OrderBy(m => m.Name);

                e.Handled = true;
            }

        }

        private void cmdClearLocalFilter_Click(object sender, EventArgs e)
        {
            this.txtFilter.Text = "";
            this.brandDTOBindingSource.DataSource = this.brands.OrderBy(m => m.Name);
        }


        #endregion


        #region Private methods

        public async Task SearchBrands()
        {
            this.brands = await ApiManagerBrands.GetAllBrands();
            this.brandDTOBindingSource.DataSource = this.brands.OrderBy(m => m.Name);
        }

        #endregion


    }
}
