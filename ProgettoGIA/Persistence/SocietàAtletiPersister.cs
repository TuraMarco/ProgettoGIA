using System;
using System.Collections.Generic;
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
                    _writer.WriteStartElement("Società");

                    foreach (Società s in societàList)
                    {
                        SaveSocietà(s);
                    }
         
                    _writer.WriteEndElement();
                    _writer.WriteStartElement("Atleti");

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

            public List<Atleta> LoadAtleti()
            {
                throw new NotImplementedException();
            }

            public List<Società> LoadSocietà()
            {
                throw new NotImplementedException();
            }
        }
    }
}
