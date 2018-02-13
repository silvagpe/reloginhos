namespace HorariosMundiais
{
    partial class formCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastro));
            this.cmbBolsas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBandeira = new System.Windows.Forms.PictureBox();
            this.txtAbertura = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGMTs = new System.Windows.Forms.ComboBox();
            this.txtFechamento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHorarioVerao = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeira)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBolsas
            // 
            this.cmbBolsas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolsas.FormattingEnabled = true;
            this.cmbBolsas.Location = new System.Drawing.Point(84, 14);
            this.cmbBolsas.Name = "cmbBolsas";
            this.cmbBolsas.Size = new System.Drawing.Size(206, 21);
            this.cmbBolsas.TabIndex = 0;
            this.cmbBolsas.SelectedIndexChanged += new System.EventHandler(this.cmbBolsas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bolsa";
            // 
            // picBandeira
            // 
            this.picBandeira.Image = ((System.Drawing.Image)(resources.GetObject("picBandeira.Image")));
            this.picBandeira.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBandeira.Location = new System.Drawing.Point(296, 15);
            this.picBandeira.Name = "picBandeira";
            this.picBandeira.Size = new System.Drawing.Size(28, 20);
            this.picBandeira.TabIndex = 2;
            this.picBandeira.TabStop = false;
            // 
            // txtAbertura
            // 
            this.txtAbertura.Location = new System.Drawing.Point(84, 68);
            this.txtAbertura.Mask = "90:00";
            this.txtAbertura.Name = "txtAbertura";
            this.txtAbertura.Size = new System.Drawing.Size(100, 20);
            this.txtAbertura.TabIndex = 30;
            this.txtAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GMT";
            // 
            // cmbGMTs
            // 
            this.cmbGMTs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGMTs.FormattingEnabled = true;
            this.cmbGMTs.Location = new System.Drawing.Point(84, 41);
            this.cmbGMTs.Name = "cmbGMTs";
            this.cmbGMTs.Size = new System.Drawing.Size(206, 21);
            this.cmbGMTs.TabIndex = 20;
            // 
            // txtFechamento
            // 
            this.txtFechamento.Location = new System.Drawing.Point(84, 94);
            this.txtFechamento.Mask = "90:00";
            this.txtFechamento.Name = "txtFechamento";
            this.txtFechamento.Size = new System.Drawing.Size(100, 20);
            this.txtFechamento.TabIndex = 40;
            this.txtFechamento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Abertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fechamento";
            // 
            // chkHorarioVerao
            // 
            this.chkHorarioVerao.AutoSize = true;
            this.chkHorarioVerao.Location = new System.Drawing.Point(84, 120);
            this.chkHorarioVerao.Name = "chkHorarioVerao";
            this.chkHorarioVerao.Size = new System.Drawing.Size(106, 17);
            this.chkHorarioVerao.TabIndex = 50;
            this.chkHorarioVerao.Text = "Horário de Verão";
            this.chkHorarioVerao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 34);
            this.panel1.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(171, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 100;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(252, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 110;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkHorarioVerao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechamento);
            this.Controls.Add(this.cmbGMTs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAbertura);
            this.Controls.Add(this.picBandeira);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBolsas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo relógio";
            this.Shown += new System.EventHandler(this.formCadastro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picBandeira)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBolsas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBandeira;
        private System.Windows.Forms.MaskedTextBox txtAbertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGMTs;
        private System.Windows.Forms.MaskedTextBox txtFechamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHorarioVerao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}