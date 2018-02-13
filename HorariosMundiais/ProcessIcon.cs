using HorariosMundiais.models;
using HorariosMundiais.Properties;
using HorariosMundiais.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorariosMundiais
{
    class ProcessIcon : IDisposable
    {
        private bool formVisiveis = false;

        /// <summary>
        /// The NotifyIcon object.
        /// </summary>
        NotifyIcon ni;

        Timer timer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessIcon"/> class.
        /// </summary>
        public ProcessIcon()
        {
            // Instantiate the NotifyIcon object.
            ni = new NotifyIcon();
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {            
            ni.Text = "GMT+0 : " + DateTime.Now.ToUniversalTime().ToString("HH:mm:ss");            
        }


        /// <summary>
        /// Displays the icon in the system tray.
        /// </summary>
        public void Display()
        {
            // Put the icon in the system tray and allow it react to mouse clicks.			
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            ni.Icon = Resources.clock1;
            ni.Text = "GMT+0 : " + DateTime.Now.ToUniversalTime().ToString("HH:mm:ss");
            ni.Visible = true;


            ni.BalloonTipIcon = ToolTipIcon.Info;
            ni.BalloonTipTitle = ConfigHelper.RetornaVersao();
            ni.BalloonTipText = "Aplicativo de relógios iniciado";
            ni.ShowBalloonTip(1500);

            // Attach a context menu.
            ni.ContextMenuStrip = new ContextMenus().Create();

            ConfigXML configXML = ConfigHelper.CarregarConfig();

            foreach (RelogioXML relogio in configXML.Relogios)
            {
                formRelogio form = new formRelogio();
                form.relogioXML = relogio;
                form.Show();
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
        {
            // When the application closes, this will remove the icon from the system tray immediately.
            ni.Dispose();
        }

        /// <summary>
        /// Handles the MouseClick event of the ni control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            // Handle mouse button clicks.
            if (e.Button == MouseButtons.Left)
            {                
                foreach (Form item in Application.OpenForms)
                {
                    if (this.formVisiveis)
                    {
                        item.Hide();
                    }
                    else
                    {                       
                        item.Show();                        
                        item.BringToFront();
                        item.Activate();

                    }
                }

                this.formVisiveis = !this.formVisiveis;
                // Start Windows Explorer.
                //Process.Start("explorer", null);
            }
        }
    }
}
