using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Presentation.Windows.UI
{
    static class Program
    {
        public static FrmSplash frmSplash = null;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);


            //show splash
            Thread splashThread = new Thread(new ThreadStart(
                delegate
                {
                    frmSplash = new FrmSplash();
                    System.Windows.Forms.Application.Run(frmSplash);
                }
            ));

            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();


            //run form - time taking operation
            FrmContainer mainForm = new FrmContainer();
            mainForm.Load += new EventHandler(mainForm_Load);
            try
            {
                System.Windows.Forms.Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicación", "DGT", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        static void mainForm_Load(object sender, EventArgs e)
        {
            //close splash
            if (frmSplash == null)
            {
                return;
            }

            frmSplash.Invoke(new Action(frmSplash.Close));
            frmSplash.Dispose();
            frmSplash = null;
        }
    }
}
