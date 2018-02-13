using HorariosMundiais.flags;
using HorariosMundiais.models;
using HorariosMundiais.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorariosMundiais
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void formCadastro_Shown(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            var bolsasMundiais = BolsasModel.CarregarDados();

            cmbBolsas.Items.AddRange(bolsasMundiais.ToArray());
            cmbBolsas.SelectedIndex = 0;
            BolsasModel bolsa = (BolsasModel)cmbBolsas.SelectedItem;

            picBandeira.Image = (Bitmap)Resource_Flags.ResourceManager.GetObject(bolsa.Bandeira);

            var gmts = GMTModel.CarregarDados();
            GMTModel gmtSelecionado = gmts.Where(x => x.Chave == bolsa.GMT).FirstOrDefault();
            cmbGMTs.Items.AddRange(gmts.ToArray());
            cmbGMTs.SelectedItem = gmtSelecionado;



        }

        private void cmbBolsas_SelectedIndexChanged(object sender, EventArgs e)
        {
            BolsasModel bolsa = (BolsasModel)cmbBolsas.SelectedItem;

            picBandeira.Image = (Bitmap)Resource_Flags.ResourceManager.GetObject(bolsa.Bandeira);

            var gmts = GMTModel.CarregarDados();
            GMTModel gmtSelecionado = gmts.Where(x => x.Chave == bolsa.GMT).FirstOrDefault();


            cmbGMTs.SelectedIndex = cmbGMTs.FindStringExact(gmtSelecionado.ToString());

            txtAbertura.Text = bolsa.Abertura.ToString();
            txtFechamento.Text = bolsa.Fechamento.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            RelogioXML relogioXML = new RelogioXML();

            BolsasModel bolsa = (BolsasModel)cmbBolsas.SelectedItem;
            GMTModel gmt = (GMTModel)cmbGMTs.SelectedItem;

            relogioXML.Abertura = txtAbertura.Text;
            relogioXML.Bandeira = bolsa.Bandeira;
            relogioXML.Fechamento = txtFechamento.Text;
            relogioXML.FormCompacto = false;
            relogioXML.GMT = gmt.Chave;
            relogioXML.Height = formRelogio.ALTURA_NORMAL;
            relogioXML.Width = formRelogio.LAGURA_NORMAL;
            relogioXML.HorarioVerao = chkHorarioVerao.Checked;
            relogioXML.NomeBolsa = bolsa.NomeBolsa;
            relogioXML.Sigla = bolsa.Sigla;
                        
            ConfigHelper.SalvarRelogio(relogioXML);

            formRelogio form =  new formRelogio();
            form.relogioXML = relogioXML;
            form.Show();

            this.Close();

        }
    }
}
