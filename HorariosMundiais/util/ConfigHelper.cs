using HorariosMundiais.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosMundiais.util
{
    public class ConfigHelper
    {
        /// <summary>
        /// Arquivo local onde é salva as informações
        /// </summary>
        public static string ArquivoConfig
        {
            get
            {
                //string caminho = AppDomain.CurrentDomain.BaseDirectory + "bin";
                string caminho = AppDomain.CurrentDomain.BaseDirectory;

                if (Environment.OSVersion.Platform != PlatformID.Unix)
                {
                    int tamanho = caminho.Length - 1;
                    if (caminho[tamanho] != '\\')
                    {
                        caminho = caminho + "\\";
                    }
                }

                //caminho = Path.GetDirectoryName(caminho);
                caminho = caminho + "config.xml";
                return caminho;
            }
        }

        public static void SalvarConfig(ConfigXML configXML)
        {
            configXML.Versao = RetornaVersao();


            XmlParseHelper<ConfigXML> xmlParse = new XmlParseHelper<ConfigXML>();

            xmlParse.SaveData(ArquivoConfig, configXML);
        }

        public static ConfigXML CarregarConfig()
        {
            XmlParseHelper<ConfigXML> xmlParse = new XmlParseHelper<ConfigXML>();

            ConfigXML configXml = xmlParse.LoadData(ArquivoConfig);

            return configXml;
        }

        public static string RetornaVersao()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        public static void SalvarRelogio(RelogioXML relogioXML)
        {

            ConfigXML configXML = CarregarConfig();
            if (configXML == null)
            {
                configXML = new ConfigXML();                
            }

            RelogioXML relogioExiste = configXML.Relogios.Where(x => x.Sigla == relogioXML.Sigla).FirstOrDefault();
            if (relogioExiste != null)
                configXML.Relogios.Remove(relogioExiste);

            configXML.Relogios.Add(relogioXML);

            SalvarConfig(configXML);

        }

        public static void ExcluirRelogio(RelogioXML relogioXML)
        {
            ConfigXML configXML = CarregarConfig();
            if (configXML == null)
                return;


            RelogioXML relogioExiste = configXML.Relogios.Where(x => x.Sigla == relogioXML.Sigla).FirstOrDefault();
            if (relogioExiste != null)
                configXML.Relogios.Remove(relogioExiste);


            SalvarConfig(configXML);
        }
    }
}
