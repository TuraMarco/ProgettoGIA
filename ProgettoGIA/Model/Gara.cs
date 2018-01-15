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
            Console.Write("Chiamato OnChange!!!\n");
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
            OnChanged();
        }

        public void RemoveSpecialitàGara(Disciplina disciplina)
        {
            for (int i = 0 ; i<_specialitàGara.Count ; i++)
            {
                SpecialitàGara sg = _specialitàGara[i];

                if (sg.Disciplina.Equals(disciplina))
                {
                    _specialitàGara.Remove(sg);
                }
            }
            OnChanged();
        }

        public void AddAtletaToGara(Atleta atleta, List<Disciplina> discipline)
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
            OnChanged();
        }

        

        public void RemoveAtletaToGara(Atleta atleta)
        {
            foreach (SpecialitàGara sg in _specialitàGara)
            {
                sg.RemoveAtleta(atleta);
            }
            OnChanged();
        }

        public void AddAtleta(Atleta atleta)
        {
            if (ExistAtleta(atleta))
            {
                throw new ArgumentException("Atleta gia esisitenete, non puoi aggiungerlo");
            }
            else
            {
                _atleti.Add(atleta);
            }
            OnChanged();
        }

        public void AddSocietà(Società società)
        {
            if (ExistSocietà(società))
            {
                throw new ArgumentException("Società gia esisitenete, non puoi aggiungerla");
            }
            else
            {
                _società.Add(società);
            }
            OnChanged();
        }

        public void RemoveSocietà(Società società)
        {
            if (SocietàPossiedeAtleti(società))
            {
                throw new ArgumentException("Società associata ad atleti, non puoi cancellarla");
            }
            else
            {
                _società.Remove(società);
            }
            OnChanged();
        }

        public void RemoveAtleta(Atleta atleta)
        {
            _atleti.Remove(atleta);

            foreach (SpecialitàGara sg in _specialitàGara)
            {
                sg.RemoveAtleta(atleta);
            }
            OnChanged();
        }

        #endregion
        #region Metodi di Utlità

        public bool ExistAtleta(Atleta atleta)
        {
            bool exist = false;
            foreach (Atleta a in _atleti)
            {
                if (a.Guid.Equals(atleta.Guid))
                {
                    exist = true;
                }
            }

            return exist;
        }


        public bool ExistSocietà(Società società)
        {
            bool exist = false;
            foreach (Società a in _società)
            {
                if (a.Guid.Equals(società.Guid))
                {
                    exist = true;
                }
            }

            return exist;
        }

        public bool SocietàPossiedeAtleti(Società societa)
        {
            bool possiede = false;

            foreach (Atleta a in _atleti)
            {
                if (a.SocietàDiAppeartenenza.Guid.Equals(societa.Guid))
                {
                    possiede = true;
                }
            }

            return possiede;
        }

        public void printAtleti()
        {
            foreach (Atleta a in _atleti)
            {
                Console.Write("ATLETA: " + a.Nome + " " + a.Cognome + "\n");
            }
        }

        public void printSocietà()
        {
            foreach (Società a in _società)
            {
                Console.Write("SOCIETA' :" + a.Nome + " " + a.Sede + "\n");
            }
        }

        public void printGara()
        {
            foreach (SpecialitàGara a in _specialitàGara)
            {
                Console.Write("DISCIPLINA :" + a.Disciplina + "\n");
            }
        }

        #endregion
    }
}
