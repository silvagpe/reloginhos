namespace HorariosMundiais
{
    partial class formRelogio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelogio));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusGMT0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnFormSize = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnHorarioVersao = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuHorarioVersao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOcultarSegundos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblProximoAbertura = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeBolsa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.picBandeira = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusGMT0
            // 
            this.statusGMT0.Name = "statusGMT0";
            resources.ApplyResources(this.statusGMT0, "statusGMT0");
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnTrash);
            this.pnlMenu.Controls.Add(this.btnFormSize);
            this.pnlMenu.Controls.Add(this.btnFechar);
            this.pnlMenu.Controls.Add(this.btnHorarioVersao);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // btnTrash
            // 
            resources.ApplyResources(this.btnTrash, "btnTrash");
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.Image = global::HorariosMundiais.Properties.Resources.trash;
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.TabStop = false;
            this.btnTrash.UseVisualStyleBackColor = true;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnFormSize
            // 
            resources.ApplyResources(this.btnFormSize, "btnFormSize");
            this.btnFormSize.FlatAppearance.BorderSize = 0;
            this.btnFormSize.Image = global::HorariosMundiais.Properties.Resources.minimizar;
            this.btnFormSize.Name = "btnFormSize";
            this.btnFormSize.TabStop = false;
            this.btnFormSize.UseVisualStyleBackColor = true;
            this.btnFormSize.Click += new System.EventHandler(this.btnFormSize_Click);
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Image = global::HorariosMundiais.Properties.Resources.close;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.TabStop = false;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnHorarioVersao
            // 
            resources.ApplyResources(this.btnHorarioVersao, "btnHorarioVersao");
            this.btnHorarioVersao.FlatAppearance.BorderSize = 0;
            this.btnHorarioVersao.Image = global::HorariosMundiais.Properties.Resources.sun;
            this.btnHorarioVersao.Name = "btnHorarioVersao";
            this.btnHorarioVersao.TabStop = false;
            this.btnHorarioVersao.UseVisualStyleBackColor = true;
            this.btnHorarioVersao.Click += new System.EventHandler(this.btnHorarioVersao_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuHorarioVersao,
            this.tsOcultarSegundos});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // tsMenuHorarioVersao
            // 
            this.tsMenuHorarioVersao.Image = global::HorariosMundiais.Properties.Resources.sun;
            this.tsMenuHorarioVersao.Name = "tsMenuHorarioVersao";
            resources.ApplyResources(this.tsMenuHorarioVersao, "tsMenuHorarioVersao");
            // 
            // tsOcultarSegundos
            // 
            this.tsOcultarSegundos.Image = global::HorariosMundiais.Properties.Resources.segundos;
            this.tsOcultarSegundos.Name = "tsOcultarSegundos";
            resources.ApplyResources(this.tsOcultarSegundos, "tsOcultarSegundos");
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.lblHoraAtual, "lblHoraAtual");
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formRelogio_MouseDown);
            // 
            // lblProximoAbertura
            // 
            this.lblProximoAbertura.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.lblProximoAbertura, "lblProximoAbertura");
            this.lblProximoAbertura.Name = "lblProximoAbertura";
            this.lblProximoAbertura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formRelogio_MouseDown);
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNomeBolsa);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblNomeBolsa
            // 
            this.lblNomeBolsa.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.lblNomeBolsa, "lblNomeBolsa");
            this.lblNomeBolsa.Name = "lblNomeBolsa";
            this.lblNomeBolsa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formRelogio_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picBandeira);
            this.panel2.Controls.Add(this.lblStatus);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblStatus
            // 
            this.lblStatus.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Name = "lblStatus";
            // 
            // picBandeira
            // 
            resources.ApplyResources(this.picBandeira, "picBandeira");
            this.picBandeira.Name = "picBandeira";
            this.picBandeira.TabStop = false;
            // 
            // formRelogio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblProximoAbertura);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formRelogio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.formRelogio_Shown);
            this.ResizeEnd += new System.EventHandler(this.formRelogio_ResizeEnd);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formRelogio_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formRelogio_MouseDown);
            this.pnlMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBandeira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statusGMT0;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHorarioVersao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFormSize;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Label lblProximoAbertura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuHorarioVersao;
        private System.Windows.Forms.ToolStripMenuItem tsOcultarSegundos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeBolsa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBandeira;
        private System.Windows.Forms.Label lblStatus;
    }
}

