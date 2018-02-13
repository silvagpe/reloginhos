using HorariosMundiais.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HorariosMundiais.models
{
    [XmlRoot("Config")]
    public class ConfigXML : ISerializavel
    {
        public ConfigXML()
        {
            this.Relogios = new List<RelogioXML>();
        }

        [XmlElement]
        public string Versao { get; set; }

        [XmlElement]
        public List<RelogioXML> Relogios { get; set; }
    }


    [XmlRoot("Relogio")]
    public class RelogioXML
    {
        [XmlAttribute("Sigla")]
        public string Sigla { get; set; }

        [XmlAttribute("Bandeira")]
        public string Bandeira { get; set; }

        [XmlAttribute("NomeBolsa")]
        public string NomeBolsa { get; set; }

        [XmlAttribute("GMT")]
        public int GMT { get; set; }

        [XmlAttribute("Abertura")]
        public string Abertura { get; set; }

        [XmlAttribute("Fechamento")]
        public string Fechamento { get; set; }

        [XmlAttribute("Avisame")]
        public string Avisame { get; set; }

        [XmlAttribute("HorarioVerao")]
        public Boolean HorarioVerao { get; set; }

        [XmlAttribute("FormCompacto")]
        public bool FormCompacto { get; set; }

        [XmlAttribute("Top")]
        public int Top { get; set; }

        [XmlAttribute("Left")]
        public int Left { get; set; }

        [XmlAttribute("Height")]
        public int Height { get; set; }

        [XmlAttribute("Width")]
        public int Width { get; set; }

        [XmlAttribute("OcultarSegundos")]
        public bool OcultarSegundos { get; set; }
    }
}
