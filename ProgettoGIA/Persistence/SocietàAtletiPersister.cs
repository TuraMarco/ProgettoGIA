using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProgettoGIA.Model;

namespace ProgettoGIA.Persistence
{
    class SocietàAtletiPersister : ISocietàAtletiPersisiter
    {
        //campo
        private readonly string _fileName;

        //costruttore
        public SocietàAtletiPersister(string fileName)
        {
            _fileName = fileName;
        }

        public void SaveSocietàAtleti(List<Società> s, List<Atleta> a)
        {
            SocietàAtletiSaver saver = new SocietàAtletiSaver(_fileName);
            saver.SaveSocietàAtleti(s, a);
        }

        public ISocietàAtletiLoader GetLoader()
        {
            return new SocietàAtletiLoader(_fileName);
        }

        private class SocietàAtletiSaver
        {
            //campo
            private readonly XmlWriter _writer;

            //costruttore
            public SocietàAtletiSaver(string fileName)
            {
                _writer = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true });
            }

            internal void SaveSocietàAtleti(List<Società> societàList, List<Atleta> atletiList)
            {
                try
                {
                    _writer.WriteStartDocument();
                    _writer.WriteStartElement("SocietàAtleti");
                    _writer.WriteStartElement("SocietàList");

                    foreach (Società s in societàList)
                    {
                        SaveSocietà(s);
                    }
         
                    _writer.WriteEndElement();
                    _writer.WriteStartElement("AtletiList");

                    foreach (Atleta a in atletiList)
                    {
                        SaveAtleta(a);
                    }

                    _writer.WriteEndElement();
                    _writer.WriteEndElement();
                    _writer.WriteEndDocument();
                }
                finally
                {
                    if (_writer != null)
                    {
                        _writer.Close();
                    }
                }
            }

            internal void SaveAtleta(Atleta a)
            {
                _writer.WriteStartElement("Atleta");
                _writer.WriteAttributeString("idAtleta", "urn:samples", a.Guid.ToString());
                _writer.WriteAttributeString("nomeAtleta", "urn:samples", a.Nome);
                _writer.WriteAttributeString("cognomeAtleta", "urn:samples", a.Cognome);
                _writer.WriteAttributeString("cfAtleta", "urn:samples", a.CodiceFiscale);
                _writer.WriteAttributeString("dataDiNascita", "urn:samples", a.DataDiNascita.ToString());
                _writer.WriteAttributeString("istruttore", "urn:samples", a.Istruttore.ToString());
                _writer.WriteAttributeString("societàDiAppartenenza", "urn:samples", a.Società.Guid.ToString());
                _writer.WriteAttributeString("sesso", "urn:samples", a.Sesso.ToString());
                _writer.WriteAttributeString("scadenzaCertificato", "urn:samples", a.ScadenzaCertificato.ToString());
                _writer.WriteEndElement();
            }

            internal void SaveSocietà(Società s)
            {
                _writer.WriteStartElement("Società");
                _writer.WriteAttributeString("idSocietà", "urn:samples", s.Guid.ToString());
                _writer.WriteAttributeString("nomeSocietà", "urn:samples", s.Nome);
                _writer.WriteAttributeString("sedeSocietà", "urn:samples", s.Sede);
                _writer.WriteEndElement();
            }
        }

        private class SocietàAtletiLoader : ISocietàAtletiLoader
        {
            //campo
            private readonly XmlDocument _xmlDocument;

            //costruttore
            public SocietàAtletiLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public void LoadSocietàAtleti()
            {
                Gara g = Gara.GetInstance();

                XmlElement societàElement = (XmlElement)_xmlDocument.SelectSingleNode("SocietàAtleti/SocietàList");
                foreach (XmlNode societàNode in societàElement.ChildNodes)
                {
                    XmlAttributeCollection ac = societàNode.Attributes;
                    g.AddSocietà(new Società(societàNode.Attributes["p3:nomeSocietà"].Value, societàNode.Attributes["p3:sedeSocietà"].Value, new Guid(societàNode.Attributes["p3:idSocietà"].Value)));
                }

                XmlElement atletiElement = (XmlElement)_xmlDocument.SelectSingleNode("SocietàAtleti/AtletiList");
                foreach (XmlNode atletaNode in atletiElement.ChildNodes)
                {
                    Sesso sesso = Sesso.MASCHIO;
                    if (atletaNode.Attributes["p3:sesso"].Value.Equals("FEMMINA"))
                        sesso = Sesso.FEMMINA;

                    g.AddAtleta(new Atleta(
                            atletaNode.Attributes["p3:nomeAtleta"].Value,
                            atletaNode.Attributes["p3:cognomeAtleta"].Value,
                            atletaNode.Attributes["p3:cfAtleta"].Value,
                            sesso,
                            Convert.ToDateTime(atletaNode.Attributes["p3:dataDiNascita"].Value),
                            Convert.ToBoolean(atletaNode.Attributes["p3:istruttore"].Value),
                            g.GetSocietàForID(new Guid(atletaNode.Attributes["p3:societàDiAppartenenza"].Value)),
                            Convert.ToDateTime(atletaNode.Attributes["p3:scadenzaCertificato"].Value),
                            new Guid(atletaNode.Attributes["p3:idAtleta"].Value
                        )
                    ));
                }
            }
        }
    }
}
