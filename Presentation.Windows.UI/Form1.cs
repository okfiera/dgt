using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation.Windows.Seedwork.Api;

namespace Presentation.Windows.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var brands = await ApiManagerBrands.GetAllBrands();
            MessageBox.Show(brands.Count.ToString());
        }
    }
}
