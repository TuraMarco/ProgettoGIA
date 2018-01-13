using ProgettoGIA.Persistence;
using System;
using System.Collections.Generic;

namespace ProgettoGIA.Model
{
    public class Gara
    {
        //campi
        private List<SpecialitàGara> _specialitàGara;
        private List<Atleta> _atleti;
        private List<Società> _società;

        private static Gara _instance;

        //evento
        public event EventHandler Changed;

        //costruttore
        private Gara()
        {
            New();
        }

        public static Gara GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Gara();
            }

            return _instance;
        }

        private void New()
        {
            _società = new List<Società>();
            _atleti = new List<Atleta>();
            _specialitàGara = new List<SpecialitàGara>();
            OnChanged();
        }

        private void OnChanged()
        {
            if (Changed != null)
            {
                Changed(this, EventArgs.Empty);
            }
        }

        #region Metodi di Persistenza

        public void SaveGara(IGaraPersisiter gp)
        {
            if(gp == null)
            {
                throw new ArgumentNullException("Gara Persisiter");
            }
            gp.SaveGara(_specialitàGara);
        }

        public void SaveSocietàAtleti(ISocietàAtletiPersisiter sap)
        {
            if (sap == null)
            {
                throw new ArgumentNullException("Società-Atleti Persisiter");
            }
            sap.SaveSocietàAtleti(_società, _atleti);
        }

        public void LoadSocietà(ISocietàAtletiPersisiter sap)
        {
            if (sap == null)
            {
                throw new ArgumentNullException("persister");
            }
            ISocietàAtletiLoader loader = sap.GetLoader();
            _società = loader.LoadSocietà();
            OnChanged();
        }

        public void LoadAtleti(ISocietàAtletiPersisiter sap)
        {
            if (sap == null)
            {
                throw new ArgumentNullException("persister");
            }
            ISocietàAtletiLoader loader = sap.GetLoader();
            _atleti = loader.LoadAtleti();
            OnChanged();
        }

        #endregion
        #region Metodi di Amministrazione

        public void AddSpecialitàGara(Disciplina disciplina)
        {
            _specialitàGara.Add(new SpecialitàGara(disciplina));
        }

        public void RemoveSpecialitàGara(Disciplina disciplina)
        {
            foreach (SpecialitàGara sg in _specialitàGara)
            {
                if (sg.Disciplina.Equals(disciplina))
                {
                    _specialitàGara.Remove(sg);
                }
            }

        }

        public void AddAtleta(Atleta atleta)
        {
            //non sicuro che funzioni
            if (!_atleti.Contains(atleta))
            {
                _atleti.Add(atleta);
            }
        }

        public void AddAtleta(Atleta atleta, List<Disciplina> discipline)
        {
            foreach (Disciplina d in discipline)
            {
                foreach (SpecialitàGara sg in _specialitàGara)
                {
                    if (d.Equals(sg.Disciplina))
                    {
                        sg.AddAtleta(atleta);
                    }
                }
            }
        }

        public void RemoveAtleta(Atleta atleta)
        {
            _atleti.Remove(atleta);

            foreach (SpecialitàGara sg in _specialitàGara)
            {
                sg.RemoveAtleta(atleta);
            }
        }

        public void AddSocietà(Società società)
        {
            //non sicuro che funzioni
            if (!_società.Contains(società))
            {
                _società.Add(società);
            }
        }

        public void RemoveSocietà(Società società)
        {
            //non sicuro che funzioni
            if (_società.Contains(società))
            {
                /*foreach (Atleta a in _atleti)
                {
                    if (a.SocietàDiAppeartenenza.Equals(società))
                    {
                        throw new ArgumentException("La società ha degli iscritti.");
                    }
                }*/

                _società.Remove(società);
            }
        }

        #endregion

        public void printAtleti()
        {
            foreach (Atleta a in _atleti)
            {
                Console.Write(a.Nome + a.Cognome + "\n");
            }
        }

        public void printSocietà()
        {
            foreach (Società a in _società)
            {
                Console.Write(a.Nome + a.Sede + "\n");
            }
        }

        public void printGara()
        {
            foreach (SpecialitàGara a in _specialitàGara)
            {
                Console.Write(a.Disciplina +"\n");
            }
        }

    }
}
