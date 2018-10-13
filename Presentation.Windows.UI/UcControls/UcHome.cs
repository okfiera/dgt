using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.MainBoundedContext.DTO.DgtModule.Infractions;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI.UcControls
{
    public partial class UcHome : UserControl
    {
        #region Members

        private List<InfractionDTO> _lastInfractions = new List<InfractionDTO>();
        private List<InfractionStatsDTO> _infractionStats = new List<InfractionStatsDTO>();

        #endregion





        #region Constructor

        public UcHome()
        {
            InitializeComponent();
            this.cmbItems.SelectedIndex = 0;
        }

        #endregion




        #region Control events
        
        private void chart1_Enter(object sender, EventArgs e)
        {
            
        }

        private void UcHome_Enter(object sender, EventArgs e)
        {
            
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            //this.GetLastInfractions();
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetLastInfractions();
        }

        #endregion



        #region Private methods

        private async void GetLastInfractions()
        {
            var count = int.Parse(this.cmbItems.SelectedItem.ToString());
            this._lastInfractions = await ApiManagerInfractions.GetLast(count);
            this.infractionDTOBindingSource.DataSource = _lastInfractions;
        }

        private async void GetInfractionStats()
        {
            this.chart1.Series[0].Points.Clear();
            var stats = await ApiManagerInfractions.GetStats();
            if (stats != null && stats.Any())
            {
                this._infractionStats = stats;
                this.infractionDTOBindingSource.DataSource = this._infractionStats;

                foreach(var s in _infractionStats)
                    this.chart1.Series[0].Points.AddXY(s.Name, s.Count);

            }

            else
                _infractionStats = new List<InfractionStatsDTO>();
        }

        #endregion



        #region Public methods

        public void RefreshControl()
        {
            this.GetInfractionStats();
            this.GetLastInfractions();
        }

        #endregion


    }
}
