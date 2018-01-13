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
            //TODO
        }

        public void SaveSocietàAtleti(ISocietàAtletiPersisiter ap)
        {
            //TODO
        }

        public void LoadAtleti(ISocietàAtletiPersisiter ap)
        {
            //TODO
        }

        public void LoadSocietà(ISocietàAtletiPersisiter ap)
        {
            //TODO
        }

        #endregion
        #region Metodi di Amministrazione

        public void AddSpecialitàGara(Disciplina disciplina)
        {
            //TODO
        }

        public void RemoveSpecialitàGara(Disciplina disciplina)
        {
            //TODO
        }

        public void AddAtleta(Atleta atleta)
        {
            //TODO
        }

        public void AddAtleta(Atleta atleta, List<Disciplina> discipline)
        {
            //TODO
        }

        public void RemoveAtleta(Atleta atleta)
        {
            //TODO
        }

        public void AddSocietà(Società società)
        {
            //TODO
        }

        public void RemoveSocietà(Società società)
        {
            //TODO
        }

        #endregion

    }
}
