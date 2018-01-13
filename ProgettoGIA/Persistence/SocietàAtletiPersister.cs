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
            saver.SaveSocietà(s);
            saver.SaveAtleti(a);
        }

        public ISocietàAtletiLoader getLoader()
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

            internal void SaveAtleti(List<Atleta> a)
            {
                throw new NotImplementedException();
            }

            internal void SaveSocietà(List<Società> s)
            {
                throw new NotImplementedException();
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
