using System.Collections.Generic;

namespace ProgettoGIA.Model
{
    public class SpecialitàGara
    {
        //campi
        private readonly Disciplina _disciplina;
        private readonly Dictionary<Atleta, Prestazione> _prestazioneMaschile;
        private readonly Dictionary<Atleta, Prestazione> _prestazioneFemminile;

        //property
        public Disciplina Disciplina => _disciplina;

        //costruttore
        public SpecialitàGara(Disciplina disciplina)
        {
            _disciplina = disciplina;
        }

        #region Metodi di Amministrazione

        public void AddAtleta(Atleta atleta)
        {
            //TODO
        }

        public void RemoveAtleta(Atleta atleta)
        {
            //TODO
        }

        public Prestazione GetPrestazione(Atleta atleta)
        {
            //TODO
            return null;
        }

        public List<Atleta> GetAllAtleti()
        {
            //TODO
            return null;
        }

        #endregion
    }
}