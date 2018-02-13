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
    class ContextMenus
    {
        /// <summary>
        /// Is the About box displayed?
        /// </summary>
        bool isAboutLoaded = false;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Windows Explorer.
            item = new ToolStripMenuItem();
            item.Text = "Versão:" + ConfigHelper.RetornaVersao();            
            //item.Image = Resources.novo;
            menu.Items.Add(item);

            // Windows Explorer.
            item = new ToolStripMenuItem();
            item.Text = "Novo";
            item.Click += new EventHandler(NovoCadastro_Click);
            item.Image = Resources.novo;
            menu.Items.Add(item);

            // About.
            item = new ToolStripMenuItem();
            item.Text = "Centralizar janelas";
            item.Click += new EventHandler(CentralizarJanelas_Click);
            item.Image = Resources.config;
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Sair";
            item.Click += new System.EventHandler(Exit_Click);
            item.Image = Resources.close;
            menu.Items.Add(item);

            return menu;
        }

        /// <summary>
        /// Handles the Click event of the Explorer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void NovoCadastro_Click(object sender, EventArgs e)
        {
            formCadastro frm = new formCadastro();
            frm.Icon = Resources.clock1;
            frm.Show();
        }

        /// <summary>
        /// Handles the Click event of the About control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void CentralizarJanelas_Click(object sender, EventArgs e)
        {
            int posicaoIndex = 0;
            foreach (Form item in Application.OpenForms)
            {
                item.Top = posicaoIndex;
                item.Left = posicaoIndex;
             
                item.Show();
                item.BringToFront();
                item.Activate();

                posicaoIndex = posicaoIndex + 10;
                
            }
        }

        /// <summary>
        /// Processes a menu item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }
    }
}
