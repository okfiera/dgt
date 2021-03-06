﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Windows.UI
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();

            // DGT Logo
            this.imgDgtLogo.Image = Properties.Resources.DGT_logo;
            this.imgDgtLogo.SizeMode = PictureBoxSizeMode.Zoom;

            // Loading image
            this.imgLoading.Image = Properties.Resources.loading160x24;
            this.imgDgtLogo.SizeMode = PictureBoxSizeMode.Zoom;

            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
