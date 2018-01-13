using System.Collections.Generic;

namespace ProgettoGIA.Model
{
    class SpecialitàGara
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
    }
}