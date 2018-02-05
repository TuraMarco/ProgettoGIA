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
            private Gara g = Gara.GetInstance();

            //costruttore
            public GaraSaver(string fileName)
            {
                _writer = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true });
            }

            public void SaveGara(List<SpecialitàGara> specialitàGaraList)
            {
                try
                {
                    _writer.WriteStartDocument();
                    _writer.WriteStartElement("Gara");
                    _writer.WriteStartElement("Discipline");

                    foreach (SpecialitàGara sg in specialitàGaraList)
                    {
                        Save(sg);
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

            private void Save(SpecialitàGara specialitàGara)
            {
                _writer.WriteStartElement("Disciplina");
                _writer.WriteAttributeString("tipoDisciplina", "urn:samples", specialitàGara.Disciplina.ToString());
                _writer.WriteStartElement("PrestazioniMaschili");

                foreach (KeyValuePair<Atleta, Prestazione> kvp in specialitàGara.PrestazioneMaschile)
                {
                    _writer.WriteStartElement("Prestazione");
                    _writer.WriteAttributeString("idAtleta", "urn:samples", kvp.Key.Guid.ToString());
                    _writer.WriteAttributeString("nomeAtleta", "urn:samples", kvp.Key.Nome);
                    _writer.WriteAttributeString("cognomeAtleta", "urn:samples", kvp.Key.Cognome);
                    _writer.WriteAttributeString("CodiceFiscaleAtleta", "urn:samples", kvp.Key.CodiceFiscale);

                    Save(kvp.Value);

                    _writer.WriteEndElement();
                }

                _writer.WriteEndElement();
                _writer.WriteStartElement("PrestazioniFemminili");

                foreach (KeyValuePair<Atleta, Prestazione> kvp in specialitàGara.PrestazioneFemminile)
                {
                    _writer.WriteStartElement("Prestazione");
                    _writer.WriteAttributeString("idAtleta", "urn:samples", kvp.Key.Guid.ToString());
                    _writer.WriteAttributeString("nomeAtleta", "urn:samples", kvp.Key.Nome);
                    _writer.WriteAttributeString("cognomeAtleta", "urn:samples", kvp.Key.Cognome);
                    _writer.WriteAttributeString("CodiceFiscaleAtleta", "urn:samples", kvp.Key.CodiceFiscale);

                    Save(kvp.Value);

                    _writer.WriteEndElement();
                }

                _writer.WriteEndElement();
                _writer.WriteEndElement();
            }

            private void Save(Prestazione p)
            {
                //misurazione
                _writer.WriteStartElement("Misurazione");
                _writer.WriteString(p.Misurazione.ToString());
                _writer.WriteEndElement();

                //valutazione tecnica
                _writer.WriteStartElement("ValutazioniTecniche");
                _writer.WriteAttributeString("assetto", "urn:samples", p.ValutazioneTecnica_assetto.ToString());
                _writer.WriteAttributeString("virata", "urn:samples", p.ValutazioneTecnica_virata.ToString());
                _writer.WriteAttributeString("avanzamento", "urn:samples", p.ValutazioneTecnica_avanzamento.ToString());
                _writer.WriteAttributeString("acquaticità", "urn:samples", p.ValutazioneTecnica_acquaticità.ToString());
                _writer.WriteEndElement();

                //atrezzature
                _writer.WriteStartElement("Atrezzature");
                _writer.WriteAttributeString("muta", "urn:samples", p.Atrezzatura_muta.ToString());
                _writer.WriteAttributeString("maschera", "urn:samples", p.Atrezzatura_maschera.ToString());
                _writer.WriteAttributeString("tappanaso", "urn:samples", p.Atrezzatura_tappanaso.ToString());
                _writer.WriteAttributeString("zavorra", "urn:samples", p.Atrezzatura_zavorra.ToString());
                _writer.WriteEndElement();

                //cartellino
                _writer.WriteStartElement("Cartellino");
                _writer.WriteAttributeString("colore", "urn:samples", p.Cartellino.ToString());
                _writer.WriteAttributeString("penalità", "urn:samples", p.Penalità.ToString());
                _writer.WriteEndElement();

                //punteggio
                _writer.WriteStartElement("Punteggio");
                if (p.IsCompletata)
                {
                    _writer.WriteString(p.Punteggio.ToString());
                }
                else
                {
                    p.CalcolaPunteggio();
                    if (!float.IsNaN(p.Punteggio))
                    {
                        _writer.WriteString("PUNTEGGIO NON CALCOLABILE");
                    }
                    else
                    {
                        _writer.WriteString(p.Punteggio.ToString());
                    }
                }
                _writer.WriteEndElement();
            }
        }
    }
}
