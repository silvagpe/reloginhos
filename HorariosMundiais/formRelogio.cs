using HorariosMundiais.flags;
using HorariosMundiais.models;
using HorariosMundiais.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorariosMundiais
{
    public partial class formRelogio : Form
    {
        #region Ajustes janela

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0xC00000; //WS_CAPTION;  
                return cp;
            }
        }

        #endregion

        public const int ALTURA_COMPACTO = 115;
        public const int ALTURA_NORMAL = 180;

        public const int LAGURA_NORMAL = 140;



        /// <summary>
        /// Carregar as propriedades da tela 
        /// </summary>
        public RelogioXML relogioXML{ get; set; }

        private TimeSpan abertura = new TimeSpan(9, 0, 0);
        private TimeSpan fechamento= new TimeSpan(18, 0, 0);

        private bool ocultarSegundos = false;
        private bool horarioVersao = false;
        private bool formCompacto = false;

        public formRelogio()
        {
            InitializeComponent();
            
            timer1.Enabled = true;
            timer1.Start();


            new ToolTip().SetToolTip(this.btnHorarioVersao, "Ativar / desativar horário de versão");
            new ToolTip().SetToolTip(this.lblProximoAbertura, "Dias : Horas : Minutos : Segundos");

            tsMenuHorarioVersao.Click += TsMenuHorarioVersao_Click;
            tsOcultarSegundos.Click += TsOcultarSegundos_Click;
            tsAjusteTamanhoJanela.Click += TsAjusteTamanhoJanela_Click;

        }

        private void TsAjusteTamanhoJanela_Click(object sender, EventArgs e)
        {
            AlterarTamanhoForm(!formCompacto);

            SalvarRelogio();
        }

        private void TsOcultarSegundos_Click(object sender, EventArgs e)
        {
            ocultarSegundos = !ocultarSegundos;
            SalvarRelogio();
        }

        private void TsMenuHorarioVersao_Click(object sender, EventArgs e)
        {
            this.horarioVersao = !this.horarioVersao;
            DefinirHorarioVersao();

            SalvarRelogio();
        }

        private void formRelogio_Shown(object sender, EventArgs e)
        {            
            if (relogioXML == null)
            {
                AlterarTamanhoForm(false);
                return;
            }


            picBandeira.Image = (Bitmap)Resource_Flags.ResourceManager.GetObject(relogioXML.Bandeira);
            lblNomeBolsa.Text = relogioXML.Sigla;

            AlterarTamanhoForm(relogioXML.FormCompacto);
            
            this.horarioVersao = relogioXML.HorarioVerao;
            DefinirHorarioVersao();

            this.abertura = TimeSpan.Parse(relogioXML.Abertura);
            this.fechamento = TimeSpan.Parse(relogioXML.Fechamento);

            btnAbertura.Text = this.abertura.ToString();
            btnFechamento.Text = this.fechamento.ToString();

            this.Top = relogioXML.Top;
            this.Left = relogioXML.Left;
            this.Height = relogioXML.Height;
            this.Width = relogioXML.Width;
            this.ocultarSegundos = relogioXML.OcultarSegundos;

            new ToolTip().SetToolTip(this.lblNomeBolsa, relogioXML.NomeBolsa);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataGMT = DateTime.Now.ToUniversalTime();

            int gmt = relogioXML.GMT;

            if(relogioXML.HorarioVerao)
            {
                gmt++;
            }

            dataGMT = dataGMT.AddHours(gmt);

            if (ocultarSegundos)
                lblHoraAtual.Text = dataGMT.ToString("HH:mm");
            else
                lblHoraAtual.Text = dataGMT.ToString("HH:mm:ss");

            calcularSaldoHoras(dataGMT);
           
        }

        private void calcularSaldoHoras(DateTime dataGMT)
        {
            DateTime dtAbertura = new DateTime(dataGMT.Year, dataGMT.Month, dataGMT.Day, abertura.Hours, abertura.Minutes, abertura.Seconds);
            DateTime dtFechamento = new DateTime(dataGMT.Year, dataGMT.Month, dataGMT.Day, fechamento.Hours, fechamento.Minutes, fechamento.Seconds);

            IList<DayOfWeek> finalDeSemana = new List<DayOfWeek>();
            finalDeSemana.Add(DayOfWeek.Saturday);
            finalDeSemana.Add(DayOfWeek.Sunday);

            if (finalDeSemana.Contains(dataGMT.DayOfWeek))
            {
                calcularProximoDiaUtil(dataGMT, dtFechamento);
            }
            else
            {
                TimeSpan timeSaldo = TimeSpan.MinValue;

                

                if (dataGMT < dtAbertura)
                {
                    MercadoFechado();
                    timeSaldo = dtAbertura.Subtract(dataGMT);

                    lblProximoAbertura.Text = string.Format("{0} : {1} : {2} : {3}", timeSaldo.Days, timeSaldo.Hours, timeSaldo.Minutes, timeSaldo.Seconds);
                }
                else if (dataGMT > dtAbertura && dataGMT < dtFechamento)
                {
                    MercadoAberto();
                    timeSaldo = dtFechamento.Subtract(dataGMT);

                    lblProximoAbertura.Text = string.Format("{0} : {1} : {2} : {3}", timeSaldo.Days, timeSaldo.Hours, timeSaldo.Minutes, timeSaldo.Seconds);
                }
                else
                {
                    MercadoFechado();
                    calcularProximoDiaUtil(dataGMT, dtFechamento);
                }

                                
            }            
        }

        private void MercadoFechado()
        {
            lblStatus.Text = "FECHADO";
            lblStatus.ForeColor = Color.Red;
        }

        private void MercadoAberto()
        {
            lblStatus.Text = "ABERTO";
            lblStatus.ForeColor = Color.Green;
        }


        private void calcularProximoDiaUtil(DateTime dataGMT, DateTime dtFechamento)
        {
            IList<DayOfWeek> finalDeSemana = new List<DayOfWeek>();
            finalDeSemana.Add(DayOfWeek.Saturday);
            finalDeSemana.Add(DayOfWeek.Sunday);

            DateTime dtProxAbertura = new DateTime(dataGMT.Year, dataGMT.Month, dataGMT.Day, abertura.Hours, abertura.Minutes, abertura.Seconds);

            for (int i = 1; i <= 7; i++)
            {                
                if (finalDeSemana.Contains(dtProxAbertura.DayOfWeek))
                {
                    dtProxAbertura = dtProxAbertura.AddDays(1);                    
                }
                if (dtProxAbertura < dtFechamento)
                {
                    dtProxAbertura = dtProxAbertura.AddDays(1);
                }


                if (dtProxAbertura > dtFechamento && dtProxAbertura < dtFechamento.AddDays(1))
                {
                    break;
                }
                
            }

            dtProxAbertura = new DateTime(dtProxAbertura.Year, dtProxAbertura.Month, dtProxAbertura.Day, abertura.Hours, abertura.Minutes, abertura.Seconds);

            TimeSpan timeSaldo = dtProxAbertura.Subtract(dataGMT);

            lblProximoAbertura.Text = string.Format("{0} : {1} : {2} : {3}", timeSaldo.Days, timeSaldo.Hours, timeSaldo.Minutes, timeSaldo.Seconds);
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHorarioVersao_Click(object sender, EventArgs e)
        {
            this.horarioVersao = !this.horarioVersao;
            DefinirHorarioVersao();

            SalvarRelogio();
        }

        private void DefinirHorarioVersao()
        {
            string onOff = this.horarioVersao ? "ON" : "OFF";

            tsMenuHorarioVersao.Text = string.Format("Horário de versão ({0})", onOff);

            this.btnHorarioVersao.Text = this.horarioVersao ? "ON" : "OFF";
        }

        private void formRelogio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }            
        }

        private void btnFormSize_Click(object sender, EventArgs e)
        {
            AlterarTamanhoForm(!formCompacto);

            SalvarRelogio();
        }

        private void AlterarTamanhoForm(bool tipoSimples)
        {
            if (tipoSimples)
            {
                this.Height = ALTURA_COMPACTO;
                this.btnFormSize.Image = Properties.Resources.maximizar;
                tsAjusteTamanhoJanela.Image = Properties.Resources.maximizar;
                formCompacto = tipoSimples;
            }
            else
            {
                this.Height = ALTURA_NORMAL;
                this.Width = LAGURA_NORMAL;
                this.btnFormSize.Image = Properties.Resources.minimizar;
                tsAjusteTamanhoJanela.Image = Properties.Resources.minimizar;
                formCompacto = tipoSimples;
            }            
        }


        private void SalvarRelogio()
        {
            relogioXML.HorarioVerao = horarioVersao;
            relogioXML.FormCompacto = formCompacto;
            relogioXML.Top = this.Top;
            relogioXML.Left = this.Left;
            relogioXML.Height = this.Height;
            relogioXML.Width = this.Width;
            relogioXML.OcultarSegundos = ocultarSegundos;

            ConfigHelper.SalvarRelogio(relogioXML);
        }

        private void formRelogio_ResizeEnd(object sender, EventArgs e)
        {
            SalvarRelogio();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            ConfigHelper.ExcluirRelogio(relogioXML);
            this.Close();
        }
    }
}
