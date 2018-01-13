using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ProgettoGIA.Model;

namespace ProgettoGIA.Persistence
{
    class GaraPersisiter : IGaraPersisiter
    {
        //campo
        private readonly string _fileName;

        //costruttore
        public GaraPersisiter(string fileName)
        {
            _fileName = fileName;
        }

        public void SaveGara(List<SpecialitàGara> sg)
        {
            GaraSaver saver = new GaraSaver(_fileName);
            saver.SaveGara(sg);
        }

        private class GaraSaver
        {
            //campo
            private readonly XmlWriter _writer;

            //costruttore
            public GaraSaver(string fileName)
            {
                _writer = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true });
            }

            public void SaveGara(List<SpecialitàGara> list)
            {
                throw new NotImplementedException();
            }

            private void Save(SpecialitàGara sg)
            {
                throw new NotImplementedException();
            }

            private void Save(Prestazione p)
            {
                throw new NotImplementedException();
            }
        }
    }
}
